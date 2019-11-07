using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Conceitos_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intanciar a classe Item
            Item i = new Item();
            WriteLine("Entre com os dados do item: ");
            Write("Nome do item: ");
            i.NomeItem = ReadLine();
            Write("Valor do item: ");
            i.ValorItem = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            Write("Quantidade no inventário: ");
            i.QuantidadeItem = int.Parse(ReadLine());

            WriteLine();
            Write("Dados do item: " + i);

            WriteLine("");
            Write("Digite o número de itens a ser adicionado ao inventário: ");
            int qtdA = int.Parse(ReadLine());
            i.AdicionaItens(qtdA);

            WriteLine("");
            WriteLine("Dados atualizados: " + i);

            WriteLine("");
            Write("Digite o número de itens a ser removido do inventário: ");
            int qtdR = int.Parse(ReadLine());
            i.RemoveItens(qtdR);

            WriteLine("");
            WriteLine("Dados atualizados: " + i);
        }
    }
}
