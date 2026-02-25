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

        public UsuariosController(FrmCadastroUsuario view)
        {
            _usuarioRepository = new UsuariosRepository();
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
