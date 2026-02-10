using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCuidadores.DataBase;
using GestaoCuidadores.Model;
using Microsoft.Data.SqlClient;

namespace GestaoCuidadores.Repository
{
    public class ResponsaveisRepository
    {
        public List<Responsaveis> Listar(string termo = "")
        {
            var responsaveis = new List<Responsaveis>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "select * from Responsaveis";

                if (!string.IsNullOrEmpty(termo))
                {
                    sql = "select * from Responsaveis where nome like @termo or email like @termo";
                }

                using (var comando = new SqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(termo)) // se o termo não for vazio, então adiciona o parâmetro @termo ao comando sql. Para o campo de busca
                    {
                        comando.Parameters.AddWithValue("@termo", "%" + termo + "%");
                    }
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            responsaveis.Add(new Responsaveis()
                            {
                                Id = Convert.ToInt32(linhas["id_responsavel"]),
                                Nome = linhas["nome"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                CPF = linhas["cpf"].ToString(),
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

            return responsaveis;
        }

        public void Inserir(Responsaveis responsavel)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "insert into Responsaveis (nome, telefone, cpf, rua, numero, complemento, bairro, cidade, estado, cep, email) values (@nome, @telefone, @cpf, @rua, @numero, @complemento, @bairro, @cidade, @estado, @cep, @email)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", responsavel.Nome);
                    comando.Parameters.AddWithValue("@telefone", responsavel.Telefone);
                    comando.Parameters.AddWithValue("@cpf", responsavel.CPF);
                    comando.Parameters.AddWithValue("@rua", responsavel.Rua);
                    comando.Parameters.AddWithValue("@numero", responsavel.Numero);
                    comando.Parameters.AddWithValue("@complemento", responsavel.Complemento);
                    comando.Parameters.AddWithValue("@bairro", responsavel.Bairro);
                    comando.Parameters.AddWithValue("@cidade", responsavel.Cidade);
                    comando.Parameters.AddWithValue("@estado", responsavel.Estado);
                    comando.Parameters.AddWithValue("@cep", responsavel.CEP);
                    comando.Parameters.AddWithValue("@email", responsavel.Email);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Responsaveis responsavel)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "update Responsaveis set nome = @nome, telefone = @telefone, cpf = @cpf, rua = @rua, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, email = @email where id_responsavel = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", responsavel.Id);
                    comando.Parameters.AddWithValue("@nome", responsavel.Nome);
                    comando.Parameters.AddWithValue("@telefone", responsavel.Telefone);
                    comando.Parameters.AddWithValue("@cpf", responsavel.CPF);
                    comando.Parameters.AddWithValue("@rua", responsavel.Rua);
                    comando.Parameters.AddWithValue("@numero", responsavel.Numero);
                    comando.Parameters.AddWithValue("@complemento", responsavel.Complemento);
                    comando.Parameters.AddWithValue("@bairro", responsavel.Bairro);
                    comando.Parameters.AddWithValue("@cidade", responsavel.Cidade);
                    comando.Parameters.AddWithValue("@estado", responsavel.Estado);
                    comando.Parameters.AddWithValue("@cep", responsavel.CEP);
                    comando.Parameters.AddWithValue("@email", responsavel.Email);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from Responsaveis where id_responsavel = @id";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
