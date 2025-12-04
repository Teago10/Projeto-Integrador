using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoCuidadores.Model;
using GestaoCuidadores.Repositorys;
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
        public void ListarCuidadores(string termo = "") 
        {
            try
            {
                var listaCuidadores = _cuidadorRepository.Listar(termo); 
                _frmCadastroCuidador.ExibirCuidadores(listaCuidadores);
            }
            catch (Exception ex)
            {
                _frmCadastroCuidador.ExibirMensagem("Erro ao listar cuidador: " + ex.Message);
            }
        }
        public void Salvar(Cuidadores cuidador)
        {
            try
            {
                _cuidadorRepository.Inserir(cuidador);
                _frmCadastroCuidador.ExibirMensagem("Cuidador salvo com sucesso!");

                ListarCuidadores();

                _frmCadastroCuidador.DesabilitarCampos();

            }
            catch (Exception ex)
            {
                _frmCadastroCuidador.ExibirMensagem("Erro ao salvar cuidador: " + ex.Message);
            }
        }

        public void Atualizar(Cuidadores cuidador)
        {
            try
            {
                _cuidadorRepository.Atualizar(cuidador);
                _frmCadastroCuidador.ExibirMensagem("Cuidador atualizado com sucesso!");
                
                ListarCuidadores();

                _frmCadastroCuidador.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroCuidador.ExibirMensagem("Erro ao atualizar cuidador: " + ex.Message);
            }

        }
        public void Excluir(int idCuidador)
        {
            try
            {
                _cuidadorRepository.Excluir(idCuidador);
                _frmCadastroCuidador.ExibirMensagem("Cuidador excluído com sucesso!");
                
                ListarCuidadores();

                _frmCadastroCuidador.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroCuidador.ExibirMensagem("Erro ao excluir cuidador: " + ex.Message);
            }
        }
    }
}
