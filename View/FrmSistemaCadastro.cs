using GestaoCuidadores.DataBase;
using GestaoCuidadores.View;
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

        private void cuidadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCuidador frmCadastroCuidador = new FrmCadastroCuidador();
            frmCadastroCuidador.ShowDialog();
        }

        private void consultarPlantãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmSistemaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPaciente frmCadastroPaciente = new FrmCadastroPaciente();
            frmCadastroPaciente.ShowDialog();
        }

        private void responsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroResponsavel frmCadastroResponsavel = new FrmCadastroResponsavel();
            frmCadastroResponsavel.ShowDialog();
        }
    }
}
