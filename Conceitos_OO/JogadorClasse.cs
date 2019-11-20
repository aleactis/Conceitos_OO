using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_OO
{
    class JogadorClasse
    {
        public int Codigo { get; set; }
        public ClasseJogador Status { get; set; }

        public JogadorClasse(int codigo, ClasseJogador status)
        {
            Codigo = codigo;
            Status = status;
        }

        public JogadorClasse()
        {
        }

        public JogadorClasse(ClasseJogador status)
        {
            Status = status;
        }
    }
}
