using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Model
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int IdCuidador { get; set; }
        public int IdCliente { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
    }
}
