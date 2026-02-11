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
    public class ResponsaveisController
    {
        private FrmCadastroResponsavel _frmCadastroResponsavel;
        private ResponsaveisRepository _responsaveisRepository;

        public ResponsaveisController(FrmCadastroResponsavel view)
        {
            _frmCadastroResponsavel = view;
            _responsaveisRepository = new ResponsaveisRepository();
        }

        public void ListarResponsaveis(string termo = "")
        {
            try
            {
                var listaResponsaveis = _responsaveisRepository.Listar(termo); // aqui tem que passar o termo para o método listar do repositório, para fazer a busca
                _frmCadastroResponsavel.ExibirResponsaveis(listaResponsaveis);
            }
            catch (Exception ex)
            {
                _frmCadastroResponsavel.ExibirMensagem("Erro ao listar responsáveis: " + ex.Message);
            }
        }
        public void Salvar(Responsaveis responsavel)
        {
            try
            {
                _responsaveisRepository.Inserir(responsavel);
                _frmCadastroResponsavel.ExibirMensagem("Responsável salvo com sucesso!");

                ListarResponsaveis();

                _frmCadastroResponsavel.DesabilitarCampos();

            }
            catch (Exception ex)
            {
                _frmCadastroResponsavel.ExibirMensagem("Erro ao salvar responsável: " + ex.Message);
            }
        }

        public void Atualizar(Responsaveis responsavel)
        {
            try
            {
                _responsaveisRepository.Atualizar(responsavel);
                _frmCadastroResponsavel.ExibirMensagem("Responsável atualizado com sucesso!");

                ListarResponsaveis();
            }
            catch (Exception ex)
            {
                _frmCadastroResponsavel.ExibirMensagem("Erro ao atualizar responsável: " + ex.Message);
            }
        }

        public void Excluir(int idResponsavel)
        {
            try
            {
                _responsaveisRepository.Excluir(idResponsavel);
                //_frmCadastroResponsavel.ExibirMensagem("Responsável excluído com sucesso!");
                ListarResponsaveis();
            }
            catch (Exception ex)
            {
                //_frmCadastroResponsavel.ExibirMensagem("Erro ao excluir responsável: " + ex.Message);
            }
        }
    }
}
