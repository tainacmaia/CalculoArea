using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    public class Retangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override string CalcularArea()
        {
            return $"A área do retângulo de base {Base} e altura {Altura} é {Base * Altura}";
        }
    }
}
