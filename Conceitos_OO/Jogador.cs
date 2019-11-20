using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_OO
{
    class Jogador
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Score { get; set; }
        public bool X { get; set; }
        public bool Y { get; set; }
        public ClasseJogador Status { get; set; }

        public Jogador(int codigo, string nome, int score, bool x, bool y, ClasseJogador status)
        {
            Codigo = codigo;
            Nome = nome;
            Score = score;
            X = x;
            Y = y;
            Status = status;
        }

        public string Movimentar(bool x, bool y)
        {
            if (x || y == true)
            {
                return "movimentando-se";
            }
            return "parado";
        }

        public bool Pular(float x, float y)
        {
            return y > 0 ? true : false;
        }

        public void Atirar()
        {

        }
    }
}
