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
using GestaoCuidadores.Repositorys;

namespace GestaoCuidadores.View
{
    public partial class FrmCadastroCuidador : Form
    {
        private CuidadoresController _cuidadorController;
        public FrmCadastroCuidador()
        {
            InitializeComponent();
            _cuidadorController = new CuidadoresController(this);
        }

        private void dgvListaCuidador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCadastroCuidador_Load(object sender, EventArgs e)
        {
            _cuidadorController.ListarCuidadores();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirCuidadores(List<Cuidadores> cuidador)
        {
            dgvListaCuidador.DataSource = cuidador;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cuidador = new Cuidadores()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text,
                CPF = txtCPF.Text,
                Qualificacao = cbxQualificacao.Text,
                Rua = txtRua.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = cbxEstado.Text,
                CEP = txtCEP.Text,
                Email = txtEmail.Text

            };
            if (!ValidarCampos(cuidador))
                return;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                _cuidadorController.Salvar(cuidador);
            }
            else
            {
                cuidador.Id = Convert.ToInt32(txtCodigo.Text);

                _cuidadorController.Atualizar(cuidador);
            }
        }

        public bool ValidarCampos(Cuidadores cuidador)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
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
            if (string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                ExibirMensagem("O campo CEP é obrigatório.");
                txtCEP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                txtNumero.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                txtBairro.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo Estado é obrigatório.");
                txtCidade.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRua.Text))
            {
                ExibirMensagem("O campo Rua é obrigatório.");
                txtRua.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxQualificacao.Text))
            {
                ExibirMensagem("O campo Qualificação é obrigatório.");
                cbxQualificacao.Focus();
                return false;
            }

            return true;
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCPF.ReadOnly = false;
            cbxQualificacao.Enabled = false;
            txtRua.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            cbxEstado.Enabled = false;
            txtCEP.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cbxEstado.Enabled = true;
            cbxQualificacao.Enabled = true;

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
            cbxQualificacao.Enabled = false;
            txtRua.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            cbxEstado.Enabled = false;
            txtCEP.ReadOnly = true;
            txtEmail.ReadOnly = true;

            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            cbxQualificacao.SelectedIndex = -1;
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

        private void dgvListaCuidador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvListaCuidador.Rows[e.RowIndex];

                txtCodigo.Text = linhaSelecionada.Cells["Id"].Value.ToString();
                txtNome.Text = linhaSelecionada.Cells["Nome"].Value.ToString();
                txtTelefone.Text = linhaSelecionada.Cells["Telefone"].Value.ToString();
                txtCPF.Text = linhaSelecionada.Cells["CPF"].Value.ToString();
                cbxQualificacao.Text = linhaSelecionada.Cells["Qualificacao"].Value.ToString();
                txtRua.Text = linhaSelecionada.Cells["Rua"].Value.ToString();
                txtNumero.Text = linhaSelecionada.Cells["Numero"].Value.ToString();
                txtComplemento.Text = linhaSelecionada.Cells["Complemento"].Value.ToString();
                txtBairro.Text = linhaSelecionada.Cells["Bairro"].Value.ToString();
                txtCidade.Text = linhaSelecionada.Cells["Cidade"].Value.ToString();
                cbxEstado.Text = linhaSelecionada.Cells["Estado"].Value.ToString();
                txtCEP.Text = linhaSelecionada.Cells["CEP"].Value.ToString();
                txtEmail.Text = linhaSelecionada.Cells["Email"].Value.ToString();

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = false;
                btnCancelar.Enabled = true;

            }
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
                ExibirMensagem("Selecione um cuidador para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este cuidador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int idCuidador = Convert.ToInt32(txtCodigo.Text);
                _cuidadorController.Excluir(idCuidador);
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

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtPesquisar.Text.Trim();
            _cuidadorController.ListarCuidadores(termo);
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
