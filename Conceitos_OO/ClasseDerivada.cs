using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_OO
{
    public class ClasseDerivada : ClasseBase
    {
        public override void ExibeTexto()
        {
            base.ExibeTexto();
            Console.WriteLine("\nTexto da classe derivada");
        }
    }
}
