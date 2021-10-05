using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeDados.Dominio
{
    public class No : EntidadeComValor
    {
        public No Direita { get; set; }
        public No Esquerda { get; set; }
    }
}
