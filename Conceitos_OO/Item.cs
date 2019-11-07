using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conceitos_OO
{
    class Item
    {
        public string NomeItem;
        public double ValorItem;
        public int QuantidadeItem;

        public double AtualizaInventario()
        {
            return ValorItem * QuantidadeItem;
        }

        public void AdicionaItens(int quantidade)
        {
            QuantidadeItem += quantidade;
        }

        public void RemoveItens(int quantidade)
        {
            QuantidadeItem -= quantidade;
        }

        public override string ToString()
        {
            return NomeItem
                + ", $ "
                + ValorItem.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeItem
                + " unidades, Total: $"
                + AtualizaInventario().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
