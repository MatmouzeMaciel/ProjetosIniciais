using System.ComponentModel;
using System.Diagnostics.Contracts;
using Arrays.Helper;

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
                { 24, 19}, //primeira linha, valores de [0,0] e [0,1]
                { 14, 45}, //segunda linha, valores de [1,0] e [1,1]
                { 5, 89} // terceira linha, valores de [2,0] e [2,1]
            };
            int[] matriz3 = [3, 54, 23, 671, 213, 436, 12, 46, 345, 123, 534];
            int[] matriz4 = [34,651,64,652,234,6,3621,24,543,23,46,1,34,431,525,5];
            int[] matriz5 = new int[matriz4.Length];
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
            Console.WriteLine("matriz:");
            /*Retorna os valores alocados no loop for acima, arrays, em qualquer dimensãop, o valor da primeira posição sempre será 0,
            da segunda posição será 1 e assim por diante*/
            for (var i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"|{matriz[i, 0]}  {matriz[i, 1]}  {matriz[i, 2]}|");
            }
            
            OperacoesArray operacoes = new OperacoesArray();
            Console.WriteLine("matriz3 original:");
            operacoes.ImprimirArray(matriz3);
            Console.WriteLine("matriz3 BubbleSort:");
            operacoes.OrdenarBubbleSort(ref matriz3);
            operacoes.ImprimirArray(matriz3);
            
            Console.WriteLine("*****************************************");
            Console.WriteLine("Utilizando os métodos da Classe Array pronta do sistema:");
            Console.WriteLine("matriz4 original:");
            operacoes.ImprimirArray(matriz4);
            Console.WriteLine("matriz4 OrdenarArray(Sort()):");
            operacoes.OrdenarArray(ref matriz4);
            operacoes.ImprimirArray(matriz4);
            Console.WriteLine("*****************************************");
            Console.WriteLine("matriz5 CopiarArray(Copy()) da matriz4:");
            operacoes.CopiarArray(ref matriz5, matriz4);
            operacoes.ImprimirArray(matriz5);
            Console.WriteLine("*****************************************");
            Console.WriteLine("matriz5 ExisteNoArray(Exists())");
            int valorProcurado = 25;
            Boolean existe = operacoes.ExisteNoArray(matriz5, valorProcurado);
            if (existe == true)
            {
                Console.WriteLine($"Valor {valorProcurado} encontrado");
            }
            else
            {
                Console.WriteLine($"Valor {valorProcurado} não Encontrado");
            }
            Boolean maiorQueZero = operacoes.TodosNoArrayMaiorQue(matriz5);
            if (maiorQueZero == true)
            {
                Console.WriteLine($"Todos os valores dentro de matriz5 são Maiores que zero");
            }
            else
            {
                Console.WriteLine($"Nem todos os valores dentro de matriz5 são Maiores que zero");
            }
            int valorVerificador = 234;
            int[] arrayGeradoValores = operacoes.RetornarValoresDoArrayMaioresQue(matriz5, valorVerificador);
            if (arrayGeradoValores != null)
            {
                Console.WriteLine("*****************************************");
                Console.WriteLine("matriz5 RetornarValoresDoArrayMaioresQue(FindAll()) > 140");
                foreach (var a in arrayGeradoValores)
                {
                    System.Console.Write($"{a}  ");
                }
            }
            int indexAchado = operacoes.RetornarIndexDoValorNoArray(matriz5,valorVerificador);
            System.Console.WriteLine($"\nO index {indexAchado} dentro de matriz 5 corresponde ao valor {valorVerificador} ");
            Console.WriteLine("*****************************************");
            //Converter a matriz5 de int em um array de strings
            string[] arrayConvertido = operacoes.ConverterArrayIntParaString(matriz5);
            if (arrayConvertido.GetType() == typeof(string[]))
            {
                Console.WriteLine("tipo texto");
            }
            if (arrayConvertido is string[])
            {
                Console.WriteLine("tipo texto");
            }




        }
    }
}


