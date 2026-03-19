using GestaoCuidadores.Controller;
using GestaoCuidadores.DataBase;
using GestaoCuidadores.Model;
using Microsoft.Data.SqlClient;
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
    public partial class FrmNovoAtendimento : Form
    {
        private NovoAtendimentoController _novoAtendimentoController;
        public FrmNovoAtendimento()
        {
            InitializeComponent();
            _novoAtendimentoController = new NovoAtendimentoController(this);
        }

        private void FrmNovoAtendimento_Load(object sender, EventArgs e)
        {
            cbxCuidador.DataSource = _novoAtendimentoController.ObterCuidadores();
            cbxCuidador.DisplayMember = "Nome"; // Exibe o nome do cuidador no combo box
            cbxCuidador.ValueMember = "Id"; // Usa o Id do cuidador como valor selecionado

            cbxPaciente.DataSource = _novoAtendimentoController.ObterPacientes();
            cbxPaciente.DisplayMember = "Nome"; // Exibe o nome do paciente no combo box
            cbxPaciente.ValueMember = "Id"; // Usa o Id do paciente como valor selecionado

            cbxPaciente.SelectedIndex = -1;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                NovoAtendimento atendimento = new NovoAtendimento();

                atendimento.Id_Cuidador = Convert.ToInt32(cbxCuidador.SelectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar o atendimento:{ex.Message} ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void cbxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResponsavel.Text = "Buscando...";
            txtResponsavel.Enabled = false;


            if (cbxPaciente.SelectedValue is int id_paciente)
            {
                string sql = "SELECT r.nome FROM Paciente p " +
                    "JOIN Responsavel r ON p.id_responsavel = r.id_responsavel " +
                    "WHERE p.id_paciente = @id_paciente;";

                try
                {
                    using (var conexao = ConexaoDB.GetConexao())
                    {
                        using (var comando = new SqlCommand(sql, conexao))
                        {
                            comando.Parameters.AddWithValue("@id_paciente", id_paciente);
                            
                            conexao.Open();
                            
                            var resultado = comando.ExecuteScalar();
                            
                            if (resultado != null)
                            {
                                txtResponsavel.Text = resultado.ToString();
                            }
                            else
                            {
                                txtResponsavel.Text = "Responsável não encontrado";
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao buscar responsável: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
