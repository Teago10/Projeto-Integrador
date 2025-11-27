using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Model
{
    public class Cuidador
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? CPF { get; set; }
        public string? Qualificacao { get; set; }
        public string? Endereco { get; set; }
        public string? AvaliacaoMedia { get; set; }
        public string? Rua { get; set; }
        public string?  Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public string? Email { get; set; }
    }
}
