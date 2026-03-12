using GestaoCuidadores.Controller;
using GestaoCuidadores.Model;
using GestaoCuidadores.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCuidadores.View
{
    public partial class FrmAvalicao : Form
    {
        private AvaliacaoController _avaliacaoController;
        public FrmAvalicao()
        {
            InitializeComponent();
            _avaliacaoController = new AvaliacaoController(this);
        }

        private void FrmAvalicao_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Avaliacao avaliacao = new Avaliacao();

                //pega o Id do cuidador e do responsável selecionados nos combo boxes
                avaliacao.Id_Cuidador = Convert.ToInt32(cbxNomeCuidador.SelectedValue);
                avaliacao.Id_Responsavel = Convert.ToInt32(cbxNomeResponsavel.SelectedValue);

                avaliacao.Nota = Convert.ToInt32(cbxNota.Text);
                avaliacao.Comentario = txtComentario.Text;

                _avaliacaoController.SalvarAvaliacao(avaliacao);

                MessageBox.Show("Avaliação salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar a avaliação:{ex.Message} ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
    }
}
