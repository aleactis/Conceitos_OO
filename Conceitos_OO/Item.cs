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
        private string nomeItem;
        private double valorItem;
        private int quantidadeItem;

        public string NomeItem { get => nomeItem; set => nomeItem = value; }
        public double ValorItem { get => valorItem; set => valorItem = value; }
        public int QuantidadeItem { get => quantidadeItem; set => quantidadeItem = value; }

        public Item(string nomeItem, double valorItem, int quantidadeItem)
        {
            NomeItem = nomeItem;
            ValorItem = valorItem;
            QuantidadeItem = quantidadeItem;
        }

        public Item(string nomeItem, double valorItem)
        {
            NomeItem = nomeItem;
            ValorItem = valorItem;
        }

        public Item(string nomeItem)
        {
            NomeItem = nomeItem;
        }

        public Item() { }

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

        //Sobrescrita do método ToString()
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
