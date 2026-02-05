using GestaoCuidadores.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCuidadores
{
    public partial class FrmCadastroPaciente : Form
    {
        private PacientesController _pacientesController;
        public FrmCadastroPaciente()
        {
            InitializeComponent();
            _pacientesController = new PacientesController(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_de_Paciente_Load(object sender, EventArgs e)
        {
            _pacientesController.ListarPacientes();
        }

        public void ExibirPacientes(object pacientes)
        {
            dgvListaPacientes.DataSource = pacientes;
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
    }
}
