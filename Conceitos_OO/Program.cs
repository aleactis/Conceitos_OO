using static System.Console;

namespace Conceitos_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j = new Jogador(1,"Mario",100,false,false,ClasseJogador.Guerreiro);
            Item i = new Item("Magnum 44");

            Write($"O Jogador {j.Nome} é um {j.Status}, ");
            Write($"possui {j.Score} pontos, ");
            Write($"e está {j.Movimentar(true,false)}.");
            bool isPulando = j.Pular(0f, 1f);
            if (isPulando)
                Write($"\nAgora ele está pulando.");
            else
                Write($"\nAgora ele não está pulando.");
            WriteLine($"\nEle possui um(a) {i.NomeItem}.");

            //ClasseDerivada cd = new ClasseDerivada();
            //cd.ExibeTexto();
            //ReadLine();

            //Instanciar a classe Item
            //Item i = new Item();
            //WriteLine("Entre com os dados do item: ");
            //Write("Nome do item: ");
            //i.NomeItem = ReadLine();
            //Write("Valor do item: ");
            //i.ValorItem = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            //Write("Quantidade no inventário: ");
            //i.QuantidadeItem = int.Parse(ReadLine());

            //WriteLine();
            //WriteLine("Dados do item: " + i);

            ////Adicionando itens ao inventário
            //WriteLine("");
            //Write("Digite o número de itens a ser adicionado ao estoque: ");
            //int qtdA = int.Parse(ReadLine());
            //i.AdicionaItens(qtdA);

            //WriteLine();
            //WriteLine("Dados Atualizados: " + i);

            ////Removendo itens do inventário
            //WriteLine("");
            //Write("Digite o número de itens a ser removido do estoque: ");
            //int qtdR = int.Parse(ReadLine());
            //i.RemoveItens(qtdR);

            //WriteLine();
            //WriteLine("Dados Atualizados: " + i);
        }
    }
}
