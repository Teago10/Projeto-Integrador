using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCuidadores.DataBase;
using GestaoCuidadores.Model;
using Microsoft.Data.SqlClient;

namespace GestaoCuidadores.Repositories
{
    public class CuidadorRepository
    {
        public List<Cuidador> Listar()
        {
            var cuidadores = new List<Cuidador>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Cuidador";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            cuidadores.Add(new Cuidador()
                            {
                                Id = Convert.ToInt32(linhas["id_cuidador"]),
                                Nome = linhas["nome"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                CPF = linhas["cpf"].ToString(),
                                Qualificacao = linhas["qualificacao"].ToString(),
                                Endereco = linhas["endereco"].ToString(),
                                AvaliacaoMedia = Convert.ToSingle(linhas["avaliacao_media"]),
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
    }
}
