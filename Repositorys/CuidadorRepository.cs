using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCuidadores.DataBase;
using GestaoCuidadores.Model;
using Microsoft.Data.SqlClient;

namespace GestaoCuidadores.Repositorys
{
    public class CuidadorRepository
    {
        public List<Cuidadores> Listar()
        {
            var cuidadores = new List<Cuidadores>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Cuidadores";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            cuidadores.Add(new Cuidadores()
                            {
                                Id = Convert.ToInt32(linhas["id_cuidador"]),
                                Nome = linhas["nome"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                CPF = linhas["cpf"].ToString(),
                                Qualificacao = linhas["qualificacao"].ToString(),
                                Rua = linhas["rua"].ToString(),
                                Numero = linhas["numero"].ToString(),
                                Complemento = linhas["complemento"].ToString(),
                                Bairro = linhas["bairro"].ToString(),
                                Cidade = linhas["cidade"].ToString(),
                                Estado = linhas["estado"].ToString(),
                                CEP = linhas["cep"].ToString(),
                                Email = linhas["email"].ToString()

                            });
                        }
                    }
                }
            }
            return cuidadores;
        }

        public void Inserir(Cuidadores cuidador)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO Cuidadores (nome, telefone, cpf, qualificacao, avaliacao_media, rua, numero, complemento, bairro, cidade, estado, cep, email) " +
                             "VALUES (@Nome, @Telefone, @CPF, @Qualificacao,@AvaliacaoMedia, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @CEP, @Email)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", cuidador.Nome);
                    comando.Parameters.AddWithValue("@Telefone", cuidador.Telefone);
                    comando.Parameters.AddWithValue("@CPF", cuidador.CPF);
                    comando.Parameters.AddWithValue("@Qualificacao", cuidador.Qualificacao);
                    comando.Parameters.AddWithValue("@Rua", cuidador.Rua);
                    comando.Parameters.AddWithValue("@Numero", cuidador.Numero);
                    comando.Parameters.AddWithValue("@Complemento", cuidador.Complemento);
                    comando.Parameters.AddWithValue("@Bairro", cuidador.Bairro);
                    comando.Parameters.AddWithValue("@Cidade", cuidador.Cidade);
                    comando.Parameters.AddWithValue("@Estado", cuidador.Estado);
                    comando.Parameters.AddWithValue("@CEP", cuidador.CEP);
                    comando.Parameters.AddWithValue("@Email", cuidador.Email);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
