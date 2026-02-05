using GestaoCuidadores.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Controller
{
    public class PacientesController
    {
        private FrmCadastroPaciente _frmCadastroPaciente;
        private PacientesRepository _pacientesRepository;

        public PacientesController(FrmCadastroPaciente view)
        {
            _frmCadastroPaciente = view;
            _pacientesRepository = new PacientesRepository();
        }

        public void ListarPacientes()
        {
            try
            {
                var pacientes = _pacientesRepository.Listar();
                _frmCadastroPaciente.ExibirPacientes(pacientes);
            }
            catch (Exception ex)
            {
                _frmCadastroPaciente.ExibirMensagem("Erro ao listar pacientes: " + ex.Message);
            }
        }
    }
}
