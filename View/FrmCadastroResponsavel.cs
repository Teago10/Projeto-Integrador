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
        public void ExibirResponsaveis(List<Model.Responsaveis> responsaveis)
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
            /*if (!ValidarCampos(responsavel))
                return;*/
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

            if(string.IsNullOrWhiteSpace(responsavel.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Email))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.CPF))
            {
                ExibirMensagem("O campo CPF é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Telefone))
            {
                ExibirMensagem("O campo Telefone é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Rua))
            {
                ExibirMensagem("O campo Rua é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Numero))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Bairro))
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Cidade))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(responsavel.Estado))
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
    }
}
