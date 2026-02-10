using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCuidadores.Model
{
    public class Responsaveis
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Tipo_Usuario { get; set; }
        public string? Senha { get; set; }
    }
}
