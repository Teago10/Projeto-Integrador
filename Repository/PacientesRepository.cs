using GestaoCuidadores.DataBase;
using GestaoCuidadores.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Repositorys
{
    public class PacientesRepository
    {
        public List<Pacientes> Listar() //string termo = ""
        {
            var paciente = new List<Pacientes>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Paciente";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (var linhas = comando.ExecuteReader())
                    {
                        while(linhas.Read())
                        {
                            paciente.Add(new Pacientes()
                            {
                                Id = Convert.ToInt32(linhas["id_paciente"]),
                                IdResponsavel = Convert.ToInt32(linhas["id_responsavel"]),
                                DataNascimento = Convert.ToDateTime(linhas["data_nascimento"]),
                                CondicaoFisica = linhas["condicao_fisica"].ToString(),
                                UsaFralda = Convert.ToBoolean(linhas["usa_fraldas"]),
                                HorarioMedicacao = linhas["horario_medicacao"].ToString(),
                                Medicacao = linhas["medicacao"].ToString(),
                                Nome = linhas["nome"].ToString(),
                                Comorbidade = linhas["comorbidade"].ToString(),
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
            return paciente;
        }

        public void Adicionar(Pacientes paciente)
        {
            // Implementação para adicionar um paciente ao banco de dados
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "INSERT INTO Paciente (id_responsavel, data_nascimento, condicao_fisica, usa_fraldas, horario_medicacao, medicacao, nome, comorbidade, rua, numero, complemento, bairro, cidade, estado, cep, email) " +
                             "VALUES (@id_responsavel, @data_nascimento, @condicao_fisica, @usa_fralda, @horario_medicacao, @medicacao, @nome, @comorbidade, @rua, @numero, @complemento, @bairro, @cidade, @estado, @cep, @email)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_responsavel", paciente.IdResponsavel);
                    comando.Parameters.AddWithValue("@data_nascimento", paciente.DataNascimento);
                    comando.Parameters.AddWithValue("@condicao_fisica", paciente.CondicaoFisica);
                    comando.Parameters.AddWithValue("@usa_fralda", paciente.UsaFralda);
                    comando.Parameters.AddWithValue("@horario_medicacao", paciente.HorarioMedicacao);
                    comando.Parameters.AddWithValue("@medicacao", paciente.Medicacao);
                    comando.Parameters.AddWithValue("@nome", paciente.Nome);
                    comando.Parameters.AddWithValue("@comorbidade", paciente.Comorbidade);
                    comando.Parameters.AddWithValue("@rua", paciente.Rua);
                    comando.Parameters.AddWithValue("@numero", paciente.Numero);
                    comando.Parameters.AddWithValue("@complemento", paciente.Complemento);
                    comando.Parameters.AddWithValue("@bairro", paciente.Bairro);
                    comando.Parameters.AddWithValue("@cidade", paciente.Cidade);
                    comando.Parameters.AddWithValue("@estado", paciente.Estado);
                    comando.Parameters.AddWithValue("@cep", paciente.CEP);
                    comando.Parameters.AddWithValue("@email", paciente.Email);

                    conexao.Open();
                    comando.ExecuteNonQuery(); 
                }
            }
        }

        public void Atualizar(Pacientes paciente)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "UPDATE Paciente SET id_responsavel = @id_responsavel,  nome = @nome, data_nascimento = @data_nascimento, comorbidade = @comorbidade, condicao_fisica = @condicao_fisica,  usa_fraldas = @usa_fraldas, medicacao = @medicacao, horario_medicacao = @horario_medicacao, rua = @rua, numero = @numero, complemento = @complemento,  bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep, email = @email  " +
                    "WHERE id_paciente = @id_paciente";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_responsavel", paciente.IdResponsavel);
                    comando.Parameters.AddWithValue("@data_nascimento", paciente.DataNascimento);
                    comando.Parameters.AddWithValue("@condicao_fisica", paciente.CondicaoFisica);
                    comando.Parameters.AddWithValue("@usa_fraldas", paciente.UsaFralda);
                    comando.Parameters.AddWithValue("@horario_medicacao", paciente.HorarioMedicacao);
                    comando.Parameters.AddWithValue("@medicacao", paciente.Medicacao);
                    comando.Parameters.AddWithValue("@nome", paciente.Nome);
                    comando.Parameters.AddWithValue("@comorbidade", paciente.Comorbidade);
                    comando.Parameters.AddWithValue("@rua", paciente.Rua);
                    comando.Parameters.AddWithValue("@numero", paciente.Numero);
                    comando.Parameters.AddWithValue("@complemento", paciente.Complemento);
                    comando.Parameters.AddWithValue("@bairro", paciente.Bairro);
                    comando.Parameters.AddWithValue("@cidade", paciente.Cidade);
                    comando.Parameters.AddWithValue("@estado", paciente.Estado);
                    comando.Parameters.AddWithValue("@cep", paciente.CEP);
                    comando.Parameters.AddWithValue("@email", paciente.Email);
                    comando.Parameters.AddWithValue("@id_paciente", paciente.Id);
                    
                    conexao.Open();
                    comando.ExecuteNonQuery();

                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "DELETE FROM Paciente " +
                    "WHERE id_paciente = @id_paciente";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_paciente", id);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
