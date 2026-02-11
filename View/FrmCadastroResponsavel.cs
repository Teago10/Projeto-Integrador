using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoCuidadores.Controller;
using GestaoCuidadores.Model;
using Newtonsoft.Json;

namespace GestaoCuidadores.View
{
    public partial class FrmCadastroResponsavel : Form
    {
        private ResponsaveisController _responsaveisController;
        public FrmCadastroResponsavel()
        {
            InitializeComponent();
            _responsaveisController = new ResponsaveisController(this);
        }

        private void FrmCadastroResponsavel_Load(object sender, EventArgs e)
        {
            _responsaveisController.ListarResponsaveis();
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        public void ExibirResponsaveis(List<Responsaveis> responsaveis)
        {
            dgvListaResponsavel.DataSource = responsaveis;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var responsavel = new Responsaveis()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                CPF = txtCPF.Text,
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                CEP = txtCEP.Text,
                Email = txtEmail.Text

            };
            if (!ValidarCampos(responsavel))
                return;
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                _responsaveisController.Salvar(responsavel);
            }
            else
            {
                responsavel.Id = Convert.ToInt32(txtCodigo.Text);
                _responsaveisController.Atualizar(responsavel);
            }
        }
        public bool ValidarCampos(Responsaveis responsavel)
        {

            if (string.IsNullOrWhiteSpace(responsavel.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Email))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Telefone))
            {
                ExibirMensagem("O campo Telefone é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Rua))
            {
                ExibirMensagem("O campo Rua é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Numero))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Bairro))
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Cidade))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(responsavel.Estado))
            {
                ExibirMensagem("O campo Estado é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                string cpf = txtCPF.Text;
                if (cpf.Length != 11)
                {
                    ExibirMensagem("O campo CPF é obrigatório.");
                    txtCPF.Focus();
                    return false;
                }
            }

            return true;
        }
        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCPF.ReadOnly = false;
            txtRua.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = true;
            txtCEP.ReadOnly = false;
            txtEmail.ReadOnly = false;

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCPF.ReadOnly = true;
            txtRua.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            cbxEstado.Enabled = false;
            txtCEP.ReadOnly = true;
            txtEmail.ReadOnly = true;

            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnNovo.Enabled = true;

        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbxEstado.SelectedIndex = -1;
            txtCEP.Clear();
            txtEmail.Clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnPesquisar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um responsável para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este responsável?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _responsaveisController.Excluir(id);
                LimparCampos();
            }
        }

        private async Task BuscarEnderecoPorCep(string cep)
        {
            try
            {
                cep = cep.Replace("-", "").Trim(); // remove qualquer traço do CEP

                using (HttpClient client = new HttpClient()) // cria uma instância do HttpClient para fazer requisições HTTP
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/"; // URL da API do ViaCEP

                    var response = await client.GetAsync(url); // aguarda a resposta da requisição


                    if (response.IsSuccessStatusCode) // se a resposta for bem-sucedida
                    {
                        string json = await response.Content.ReadAsStringAsync(); // lê o conteúdo da resposta como uma string

                        dynamic? dadosEndereco = JsonConvert.DeserializeObject(json);

                        if (dadosEndereco?.erro == true)
                        {
                            ExibirMensagem("CEP não encontrado.");
                            return;
                        }

                        txtRua.Text = dadosEndereco?.logradouro;
                        txtBairro.Text = dadosEndereco?.bairro;
                        txtCidade.Text = dadosEndereco?.localidade;
                        cbxEstado.Text = dadosEndereco?.uf;

                    }
                    else
                    {
                        ExibirMensagem("CEP não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                ExibirMensagem($"Erro ao buscar o endereço: {ex.Message}");
            }
        }

        private async Task txtCEP_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _responsaveisController.ListarResponsaveis(termo);
        }

        private void dgvListaResponsavel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvListaResponsavel.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtTelefone.Text = linhaSelecionada.Cells["Telefone"].Value.ToString();
                txtCPF.Text = linhaSelecionada.Cells["CPF"].Value.ToString();
                txtRua.Text = linhaSelecionada.Cells["Rua"].Value.ToString();
                txtNumero.Text = linhaSelecionada.Cells["Numero"].Value.ToString();
                txtComplemento.Text = linhaSelecionada.Cells["Complemento"].Value.ToString();
                txtBairro.Text = linhaSelecionada.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linhaSelecionada.Cells["Cidade"].Value.ToString();
                cbxEstado.Text = linhaSelecionada.Cells["Estado"].Value.ToString();
                txtCEP.Text = linhaSelecionada.Cells["CEP"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();

                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = false;
            }
        }

        private async void txtCEP_Leave_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCEP.Text))
            {
                await BuscarEnderecoPorCep(txtCEP.Text);
            }
        }
    }
}
