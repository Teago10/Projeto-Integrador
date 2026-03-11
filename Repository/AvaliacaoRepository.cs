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

    }
}
