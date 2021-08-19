using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDominio
{
    public class Usuario
    {
        public int IdUsu { get; set; }
        public string NomeUsu { get; set; }
        public string Cargo { get; set; }
        public DateTime Data { get; set; }
    }
}
