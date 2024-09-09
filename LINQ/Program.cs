using System.Globalization;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            
            int[] numeros = [5,234,561,235,235,465,234,465,34412,2514,65,1124,43,15,36,7474,123,5436,867,978,456,2347,3245,6875,423];


            //Query sintaxy para numeros pares:
            IEnumerable<int> quaryDeNumerosPares = 
            from numero in numeros
            where numero % 2 == 0
            orderby numero
            select numero
            ;
            
            //Metodo sintaxy para numeros impares:
            IEnumerable<int> MetodoDeNumerosImpares = numeros.Where(numero => numero % 2 != 0).OrderBy(n => n);

            //Busca o menor valor do array
            var minimo = numeros.Min();
            //Buscar o maior valor do array
            var maximo = numeros.Max();
            //Calcula a média entre os valores de um array
            double media = numeros.Average();
            //Calcula a soma dos valores de um array
            int soma = numeros.Sum();
            //Retorna um novo array com os valores de outro array sem repetições dentro do array
            int[] novoNumeros2 = numeros.Distinct().ToArray();

            System.Console.WriteLine("Números pares quary: " + string.Join(", ", quaryDeNumerosPares) + ".");
            System.Console.WriteLine("Números pares quary: " + string.Join(", ", MetodoDeNumerosImpares) + ".");
            System.Console.WriteLine($"Menor valor do array: {minimo}");
            System.Console.WriteLine($"Maior valor do array: {maximo}");
            System.Console.WriteLine($"Média entre os valores do array: {media:F2}");
            System.Console.WriteLine($"Soma dos valores do array: {soma}");
            
        }
    }
}