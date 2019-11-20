using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_OO
{
    public class ClasseBase
    {
        public virtual void ExibeTexto()
        {
            string texto = "Texto da classe base";
            Console.WriteLine(texto);
        }
    }
}
