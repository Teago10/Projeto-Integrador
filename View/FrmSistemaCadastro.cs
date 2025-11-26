using GestaoCuidadores.DataBase;
using Microsoft.Data.SqlClient;

namespace GestaoCuidadores
{
    public partial class FrmSistemaCadastro : Form
    {
        public FrmSistemaCadastro()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
           try
           {
               using (SqlConnection conexao = ConexaoDB.GetConexao())
               {
                   conexao.Open();
                   MessageBox.Show("Conexão Realizada com Sucesso!");
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show("Erro ao conectar:" + ex.Message);
           }
        
        }
    }
}
