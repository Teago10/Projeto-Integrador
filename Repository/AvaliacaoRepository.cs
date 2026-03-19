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
    public class AvaliacaoRepository
    {
        public void Inserir(Avaliacao avaliacao)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO Avaliacao (id_Responsavel, id_Cuidador, nota, comentario) " +
                    "VALUES (@id_Responsavel, @id_Cuidador, @nota, @comentario);";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_Responsavel", avaliacao.Id_Responsavel);
                    comando.Parameters.AddWithValue("@id_Cuidador", avaliacao.Id_Cuidador);
                    comando.Parameters.AddWithValue("@nota", avaliacao.Nota);
                    comando.Parameters.AddWithValue("@comentario", avaliacao.Comentario);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Método para listar os responsáveis disponíveis para avaliação
        public List<ResponsavelSimples> ListarResponsaveis()
        {
            List<ResponsavelSimples> Aval_responsaveis = new List<ResponsavelSimples>();
            string sql = "SELECT id_Responsavel, nome FROM Responsavel;";
            using (var conexao = ConexaoDB.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aval_responsaveis.Add(new ResponsavelSimples
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1)
                            });
                        }
                    }
                }
            }

            return Aval_responsaveis;
        }

        public List<CuidadorSimples> ListarCuidadores()
        {
            List<CuidadorSimples> Aval_cuidadores = new List<CuidadorSimples>();
            string sql = "SELECT id_Cuidador, nome FROM Cuidador;";
            using (var conexao = ConexaoDB.GetConexao())
            {
                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var reader = comando.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            Aval_cuidadores.Add(new CuidadorSimples
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1)
                            });
                        }
                    }
                }
            }
            return Aval_cuidadores;

        }
    }
}
