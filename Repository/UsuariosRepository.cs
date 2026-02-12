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
                string sql = "select * from usuario"; // corrigido 'slect' para 'select' e nome da tabela em minúsculo

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
                                TipoUsuario = linhas["tipousuario"].ToString() // campo em minúsculo
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
                string sql = "insert into usuario (nome, email, senha, tipousuario) values (@nome, @email, @senha, @tipousuario)";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@tipousuario", usuario.TipoUsuario);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Usuarios usuario)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "update usuario set nome = @nome, email = @email, senha = @senha, tipousuario = @tipousuario where id_usuario = @id_usuario";
                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id_usuario", usuario.Id);
                    comando.Parameters.AddWithValue("@nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@email", usuario.Email);
                    comando.Parameters.AddWithValue("@senha", usuario.Senha);
                    comando.Parameters.AddWithValue("@tipousuario", usuario.TipoUsuario);

                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "delete from usuario where id_usuario = @id_usuario";
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
                string sql = "select * from usuario where email = @email and senha = @senha";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);
                    conexao.Open();
                    using (var leitor = comando.ExecuteReader())
                    {
                        if (leitor.Read())
                        {
                            return new Usuarios()
                            {
                                Id = Convert.ToInt32(leitor["id_usuario"]),
                                Nome = leitor["nome"].ToString(),
                                Email = leitor["email"].ToString(),
                                Senha = leitor["senha"].ToString(),
                                TipoUsuario = leitor["tipousuario"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
