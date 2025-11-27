using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCuidadores.Repositories;
using GestaoCuidadores.View;


namespace GestaoCuidadores.Controller
{
    public class CuidadorController
    {
        private FrmCadastroCuidador _frmCadastroCuidador;
        private CuidadorRepository _cuidadorRepository;

        public CuidadorController(FrmCadastroCuidador view)
        {
            _frmCadastroCuidador = view;
            _cuidadorRepository = new CuidadorRepository();
        }
        public void ListarCuidadores()
        {
            try
            {
                var listaCuidadores = _cuidadorRepository.Listar();
                _frmCadastroCuidador.ExibirCuidadores(listaCuidadores);
            }
            catch (Exception ex)
            {
                _frmCadastroCuidador.ExibirMensagem("Erro ao listar cuidadores: " + ex.Message);

            }
        }
    }
}
