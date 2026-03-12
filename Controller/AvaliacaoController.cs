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
    public class AvaliacaoController
    {
        private FrmAvalicao _frmAvalicao;
        private AvaliacaoRepository _avaliacaoRepository;

        public AvaliacaoController(FrmAvalicao view)
        {
            _frmAvalicao = view;
            _avaliacaoRepository = new AvaliacaoRepository();
        }

        public void SalvarAvaliacao(Avaliacao avaliacao)
        {
            try
            {
                _avaliacaoRepository.Inserir(avaliacao);
                //_frmAvalicao.ExibirMensagem("Avaliação salva com sucesso!");
            }
            catch (Exception ex)
            {
                //_frmAvalicao.ExibirMensagem($"Erro ao salvar avaliação: {ex.Message}" );
            }
        }
    }
}
