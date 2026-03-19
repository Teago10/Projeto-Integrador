using GestaoCuidadores.Model;
using GestaoCuidadores.Repository;
using GestaoCuidadores.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Controller
{
    public class NovoAtendimentoController
    {
        private FrmNovoAtendimento _frmNovoAtendimento;
        private NovoAtendimentoRepository _novoAtendimentoRepository;

        public NovoAtendimentoController(FrmNovoAtendimento view)
        {
            _frmNovoAtendimento = view;
            _novoAtendimentoRepository = new NovoAtendimentoRepository();
        }

        public void SalvarAtendimento(NovoAtendimento atendimento)
        {
            try
            {
                _novoAtendimentoRepository.Inserir(atendimento);
                _frmNovoAtendimento.ExibirMensagem("Atendimento salvo com sucesso!");
            }
            catch (Exception ex)
            {
                _frmNovoAtendimento.ExibirMensagem("Erro ao salvar atendimento: " + ex.Message);
            }
        }

        public List<CuidadorSimples> ObterCuidadores()
        {
            return _novoAtendimentoRepository.ListarCuidadores();
        }
        public List<PacienteSimples> ObterPacientes()
        {
            return _novoAtendimentoRepository.ListarPacientes();
        }

    }
}
