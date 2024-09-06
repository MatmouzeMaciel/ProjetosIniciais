/*Coleções padrão de Generics são:
Dictionary<TKet,Tvalue>
List<T>
Queue<T>
SortedList<Tkey,TValue>
Stack<T>

<T> significa coleção de algo, pode ser coleção de objetos ou coleção de valores de um determinado tipo, tais como:
List<Nomes> nomes = que representa a criação de uma lista "nomes" que armazena objetos criados pela Classe Nomes como base;
List<string> nomes = que representa a criação de uma lista "nomes" que armazena valores do tipo string;

<TKey,TValue> armazenas valores e os ordenas com base em uma chave específica.

Queue<T> e Stack<T> tem ordens de entrada e saída de dados, onde:
Queue representa literalmente uma fila, onde o primeiro que entrar, será o primeiro a sair;
Stack representa
*/
using Generics.Helper;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OperacoesLista operacoes = new OperacoesLista();
            List<string> estados =
            [
                "DF",
                "MG",
                "SC",
                "RN",
                "MT"    
            ];

            Console.WriteLine($"Temos {estados.Count} estados listados.");
            //operacoes.ImprimirListaEstados(estados);
            estados.Remove("MG");
            Console.WriteLine($"Nove Lista:");
            //operacoes.ImprimirListaEstados(estados);
            Console.WriteLine($"Adicionando valores à Lista:");
            string[] estadosAdicionar = ["SP", "RJ", "CE", "AC"];
            operacoes.adicionarArrayDeValoresTextoAoFinalDaLista(estados, estadosAdicionar);
            //operacoes.ImprimirListaEstados(estados);
            int indexAlvo = operacoes.retornaIndexDaLista(estados, "SP");
            string estadoAdicionadoPorIndex = "MG";
            Console.WriteLine($"Adicionando valores {estadoAdicionadoPorIndex} à Lista antes de SP:");
            operacoes.adicionarVariavelTextoNoIndexDaLista(estados, estadoAdicionadoPorIndex, indexAlvo);
            //operacoes.ImprimirListaEstados(estados);

            Console.WriteLine($"**************************************************************************************************");
            


            




        }
    }
}