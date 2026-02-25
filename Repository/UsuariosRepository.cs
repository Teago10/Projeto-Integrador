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
    class UsuariosRepository
    {
        public List<Usuarios> Listar()
        {
            var usuarios = new List<Usuarios>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "select * from Usuario"; 

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            usuarios.Add(new Usuarios()
                            {
                                Id = Convert.ToInt32(linhas["id_usuario"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Senha = linhas["senha"].ToString(),
                                TipoUsuario = linhas["tipoUsuario"].ToString() 
                            });
                        }
                    }
                }
            }

            return usuarios;
        }

        public void Inserir(Usuarios usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "insert into Usuario (nome, email, senha, tipousuario) values (@nome, @email, @senha, @tipousuario)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@tipoUsuario", usuario.TipoUsuario);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Usuarios usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "update Usuario set nome = @nome, email = @email, senha = @senha, tipousuario = @tipousuario where id_usuario = @id_usuario";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_usuario", usuario.Id);
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@tipoUsuario", usuario.TipoUsuario);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from Usuario where id_usuario = @id_usuario";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_usuario", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public Usuarios Login(string email, string senha)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "select * from Usuario " +
                             "where email = @email and" +
                             " senha = @senha";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);

                    conexao.Open();

                    using (var linha = comando.ExecuteReader())
                    {
                        if (linha.Read())
                        {
                            return new Usuarios()
                            {
                                Id = Convert.ToInt32(linha["id_usuario"]),
                                Nome = linha["nome"].ToString(),
                                Email = linha["email"].ToString(),
                                Senha = linha["senha"].ToString(),
                                TipoUsuario = linha["tipoUsuario"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
