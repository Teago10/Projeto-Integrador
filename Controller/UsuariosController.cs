using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCuidadores.Model;
using GestaoCuidadores.Repository;
using GestaoCuidadores.View;

namespace GestaoCuidadores.Controller
{
    public class UsuariosController
    {
        private UsuariosRepository _usuarioRepository;
        private FrmCadastroUsuario _frmCadastroUsuario;

        public UsuariosController(FrmCadastroUsuario view)
        {
            _usuarioRepository = new UsuariosRepository();
        }

        public void Salvar(Usuarios usuarios)
        {
            try
            {
                _usuarioRepository.Inserir(usuarios);
                //_frmCadastroUsuario.Mensagem("Usuário cadastrado com sucesso!");
            }
            catch (Exception ex) 
            {
                //_frmCadastroUsuario.Mensagem("Erro ao cadastrar usuário: " + ex.Message);
            }
        }

        public void Atualizar(Usuarios usuarios)
        {
            try
            {
                _usuarioRepository.Atualizar(usuarios);
                //_frmCadastroUsuario.Mensagem("Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                //_frmCadastroUsuario.Mensagem("Erro ao atualizar usuário: " + ex.Message);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                //_frmCadastroUsuario.Mensagem("Usuário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                //_frmCadastroUsuario.Mensagem("Erro ao excluir usuário: " + ex.Message);
            }
        }

        public Usuarios Autenticacao(string email, string senha)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                return null;
            }
            return _usuarioRepository.Login(email, senha);
        }
    }
}
