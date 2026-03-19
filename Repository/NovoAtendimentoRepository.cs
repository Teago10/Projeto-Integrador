using GestaoCuidadores.DataBase;
using GestaoCuidadores.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Repository
{
    public class NovoAtendimentoRepository
    {
        public void Inserir(NovoAtendimento atendimento)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO Plantao (Id_Cuidador, Id_Paciente, Tipo, Valor) VALUES" +
                    " (@Id_Cuidador, @Id_Paciente, @Tipo, @Valor)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id_Cuidador", atendimento.Id_Cuidador);
                    comando.Parameters.AddWithValue("@Id_Paciente", atendimento.Id_Paciente);
                    comando.Parameters.AddWithValue("@Tipo", atendimento.Tipo);
                    comando.Parameters.AddWithValue("@Valor", atendimento.Valor);
                    
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<CuidadorSimples> ListarCuidadores()
        {
            List<CuidadorSimples> cuidador = new List<CuidadorSimples>();
            string sql = "SELECT id_cuidador, nome FROM Cuidador;";
            using (var conexao = ConexaoDB.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cuidador.Add(new CuidadorSimples
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return cuidador;
        }
        public List<PacienteSimples> ListarPacientes()
        {
            List<PacienteSimples> pacientes = new List<PacienteSimples>();

            string sql = "SELECT id_paciente, nome FROM Paciente;";

            using (var conexao = ConexaoDB.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pacientes.Add(new PacienteSimples
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return pacientes;
        }
    }
}
