using System.Diagnostics.Contracts;

namespace Arrays
{
    public class Program
    {
        //recebe um array de inteiros, e soma 1 à todos os valores do
        static int[] ParesParaImpares(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
            return array;
        }
        public static void Main()
        {
            //Criando array de pares
            int[] numerosPares = [0, 2, 4, 6, 8];
            foreach (var num in numerosPares)
            {
                Console.WriteLine($"{num}"); //output: 0, 2, 4, 6, 8
            }
            //Criando array para receber os valores impares e chamando o método para alocar os valores
            int[] numerosImpares = ParesParaImpares(numerosPares);
            foreach (var num in numerosImpares)
            {
                Console.WriteLine($"{num}"); //output: 1, 3, 5, 7, 9
            }
            Console.WriteLine("*****************************************");


            //Criando um array multidimensional(matriz) vazia que tem 4 linhas e 3 colunas
            int[,] matriz = new int[4, 3];
            //Criando uma matriz com valores predefinidos, onde cada valor entre {} representa os valores em cada linha
            int[,] matriz2 = new int[3, 2]
            {
                { 0, 0}, //primeira linha, valores de [0,0] e [0,1]
                { 1, 0}, //segunda linha, valores de [1,0] e [1,1]
                { 4, 5} // terceira linha, valores de [2,0] e [2,1]
            };

            //ao chamar Lenght em uma matriz ele retorna a quantidade de campos dentro do array
            Console.WriteLine(matriz.Length); // output: 12
            //ao chamar GetLenght(0) em uma matriz ele retorna a quantidade vetores da primeira dimensão
            Console.WriteLine(matriz.GetLength(0)); // output: 4
            //ao chamar GetLenght(1) em uma matriz ele retorna a quantidade vetores da segunda dimensão
            Console.WriteLine(matriz.GetLength(1)); // output: 3
            //ao chamar GetLenght(x) em uma matriz ele retorna a quantidade de vetores na (x+1)ª dimensão 
            //Console.WriteLine(matriz.GetLength(x));

            //Loop que multiplica a posição da linha pela coluna e aloca no valor na respectiva posição
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int x = i * j;
                    matriz[i, j] = x;
                }
            }
            /*Retorna os valores alocados no loop for acima, arrays, em qualquer dimensãop, o valor da primeira posição sempre será 0,
            da segunda posição será 1 e assim por diante*/
            for (var i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"|{matriz[i, 0]}  {matriz[i, 1]}  {matriz[i, 2]}|");
            }
            







        }
    }
}


