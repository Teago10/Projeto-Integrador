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
            _cuidadorController .ListarCuidadores();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirCuidadores(List<Cuidador> cuidadores)
        {
            dgvListaCuidador.DataSource = null;
            dgvListaCuidador.DataSource = cuidadores;
        }
    }
}
