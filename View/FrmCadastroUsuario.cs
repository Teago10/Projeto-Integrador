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
    public partial class FrmCadastroUsuario : Form
    {
        private UsuariosController _usuariosController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuariosController = new UsuariosController(this);
        }

        private void FrmCadastroGeral_Load(object sender, EventArgs e)
        {

        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        // Evento do link para voltar a tela de login
        private void lnkEntrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();

            this.Hide();
        }

        public bool ValidarDados(Usuarios usuarios)
        {
            if (string.IsNullOrWhiteSpace(usuarios.Nome) ||
                string.IsNullOrWhiteSpace(usuarios.Email) ||
                string.IsNullOrWhiteSpace(usuarios.Senha) ||
                string.IsNullOrWhiteSpace(usuarios.TipoUsuario))
            {
                ExibirMensagem("Todos os campos são obrigatórios.");
                return false;
            }

            return true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuarios = new Usuarios
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Senha = txtSenha.Text.Trim(),
                TipoUsuario = cbxTipoUsuario.SelectedItem?.ToString()
            };
            if(!ValidarDados(usuarios))
                return;
            
        }
    }
}
