using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasExcecoes
{
    class FuncionalCalculadora : Calculadora
    {
        public FuncionalCalculadora()
        {
        }

        public FuncionalCalculadora(decimal primeiro, decimal segundo) : base(primeiro, segundo)
        {
            Primeiro = primeiro;
            Segundo = segundo;
        }
    }
}
