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
using GestaoCuidadores.Repositorys;

namespace GestaoCuidadores.View
{
    public partial class FrmCadastroCuidador : Form
    {
        private CuidadorController _cuidadorController;
        public FrmCadastroCuidador()
        {
            InitializeComponent();
            _cuidadorController = new CuidadorController(this);
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
            if(!ValidarCampos(cuidador))
            {
               return;
            }
        }

        public bool ValidarCampos(Cuidadores cuidador)
        {
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                string cpf = txtCPF.Text;
                if (cpf.Length != 11)
                {
                    ExibirMensagem("O campo CPF é obrigatório.");
                    return false;
                }
            }
            if(string.IsNullOrWhiteSpace(txtCEP.Text))
            {
                ExibirMensagem("O campo CEP é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                ExibirMensagem("O campo Número é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                ExibirMensagem("O campo Bairro é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                ExibirMensagem("O campo Cidade é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(cbxEstado.Text))
            {
                ExibirMensagem("O campo Estado é obrigatório.");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtRua.Text))
            {
                ExibirMensagem("O campo Rua é obrigatório.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbxQualificacao.Text))
            {
                ExibirMensagem("O campo Qualificação é obrigatório.");
                return false;
            }
            
            return true;
        }
    }
}
