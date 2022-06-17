using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasExcecoes
{
    abstract class Calculadora
    {
        public decimal Primeiro { get; set; }
        public decimal Segundo { get; set; }

        public Calculadora()
        {
        }

        protected Calculadora(decimal primeiro, decimal segundo)
        {
            Primeiro = primeiro;
            Segundo = segundo;
        }

        public decimal Soma()
        {
            return Primeiro + Segundo;
        }

        public decimal Subtracao()
        {
            return Primeiro - Segundo;
        }

        public decimal Multiplicacao()
        {
            return Primeiro * Segundo;
        }

        public decimal Divisao()
        {
            return Primeiro / Segundo;
        }
    }
}
