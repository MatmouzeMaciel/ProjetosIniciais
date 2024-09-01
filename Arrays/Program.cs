namespace Arrays
{
    public class Program
    {
        static void ParesParaImpares(int[] array){
            for (int i = 0; i < array.Length; i++)
            {
                array[i]++;
            }
        }
        public static void Main(){
            int[] numeros = [0,2,4,6,8];
            foreach (var num in numeros)
            {
                Console.WriteLine($"{num}"); //output: 0, 2, 4, 6, 8
            }
            ParesParaImpares(numeros);
            foreach (var num in numeros)
            {
                Console.WriteLine($"{num}"); //output: 1, 3, 5, 7, 9

            }

        }
    }
}


