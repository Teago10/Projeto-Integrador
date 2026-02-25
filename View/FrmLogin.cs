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
    public partial class FrmLogin : Form
    {
        private UsuariosController _usuariosController;
        public FrmLogin()
        {
            InitializeComponent();
            _usuariosController = new UsuariosController(null);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = _usuariosController.Autenticacao(
                txtEmail.Text.Trim(),
                txtSenha.Text.Trim()
                );
            if (usuario != null)
            {
                MessageBox.Show($"Bem-vindo, {usuario.Nome}!");
                // implementar a lógica para abrir a janela correspondente do usuário
                FrmSistemaCadastro telaPrincipal = new FrmSistemaCadastro();
                telaPrincipal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastroUsuario cadastroUsuario = new FrmCadastroUsuario();
            cadastroUsuario.Show();

            this.Hide();
        }
    }
}
