using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Model
{
    public class Pacientes
    {
        public int Id { get; set; }
        public int IdResponsavel { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? CondicaoFisica { get; set; }
        public bool? UsaFralda { get; set; }
        public string? HorarioMedicacao { get; set; }
        public string? Medicacao { get; set; }
        public string? Nome { get; set; }
        public string? Comorbidade { get; set; }
        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public string? Email { get; set; }


    }
}
