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
    public class CuidadoresRepository
    {
        public List<Cuidadores> Listar(string termo = "") 
        {
            var cuidador = new List<Cuidadores>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Cuidador";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "SELECT * FROM Cuidador WHERE nome LIKE @termo or email LIKE @termo";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo)) // se o termo não for vazio, então adiciona o parâmetro @termo ao comando sql. Para o campo de busca
                    {
                        comando.Parameters.AddWithValue("@termo", "%"+termo+"%");
                    }
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            cuidador.Add(new Cuidadores()
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
            return cuidador;
        }

        public void Inserir(Cuidadores cuidador)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO Cuidador (nome, telefone, cpf, qualificacao, rua, numero, complemento, bairro, cidade, estado, cep, email) " +
                             "VALUES (@nome, @telefone, @cpf, @qualificacao, @rua, @numero, @complemento, @bairro, @cidade, @estado, @cep, @email)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", cuidador.Nome);
                    comando.Parameters.AddWithValue("@telefone", cuidador.Telefone);
                    comando.Parameters.AddWithValue("@cpf", cuidador.CPF);
                    comando.Parameters.AddWithValue("@qualificacao", cuidador.Qualificacao);
                    comando.Parameters.AddWithValue("@rua", cuidador.Rua);
                    comando.Parameters.AddWithValue("@numero", cuidador.Numero);
                    comando.Parameters.AddWithValue("@complemento", cuidador.Complemento);
                    comando.Parameters.AddWithValue("@bairro", cuidador.Bairro);
                    comando.Parameters.AddWithValue("@cidade", cuidador.Cidade);
                    comando.Parameters.AddWithValue("@estado", cuidador.Estado);
                    comando.Parameters.AddWithValue("@cep", cuidador.CEP);
                    comando.Parameters.AddWithValue("@email", cuidador.Email);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Cuidadores cuidador)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE Cuidador SET nome = @nome, telefone = @telefone, cpf = @cpf, qualificacao = @qualificacao, rua = @rua, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, email = @email " +
                             "WHERE id_cuidador = @Id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", cuidador.Id);
                    comando.Parameters.AddWithValue("@nome", cuidador.Nome);
                    comando.Parameters.AddWithValue("@telefone", cuidador.Telefone);
                    comando.Parameters.AddWithValue("@cpf", cuidador.CPF);
                    comando.Parameters.AddWithValue("@qualificacao", cuidador.Qualificacao);
                    comando.Parameters.AddWithValue("@rua", cuidador.Rua);
                    comando.Parameters.AddWithValue("@numero", cuidador.Numero);
                    comando.Parameters.AddWithValue("@complemento", cuidador.Complemento);
                    comando.Parameters.AddWithValue("@bairro", cuidador.Bairro);
                    comando.Parameters.AddWithValue("@cidade", cuidador.Cidade);
                    comando.Parameters.AddWithValue("@estado", cuidador.Estado);
                    comando.Parameters.AddWithValue("@cep", cuidador.CEP);
                    comando.Parameters.AddWithValue("@email", cuidador.Email);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM Cuidador WHERE id_cuidador = @Id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
