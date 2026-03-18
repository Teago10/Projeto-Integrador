using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Model
{
    public class NovoAtendimento
    {
        public int Id_Plantão { get; set; }
        public int Id_Cuidador { get; set; }
        public int Id_Paciente { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }

    }
}
