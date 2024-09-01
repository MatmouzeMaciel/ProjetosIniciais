using System.Dynamic;

namespace QuaryArrayList
{
    public class Program
    {
        static void AcharNumeros(int[] array,int numeroEscolhido){
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == numeroEscolhido){
                    Console.WriteLine($"Foi achado o número {numeroEscolhido} no index {i} do array numeros");
                }
                else{
                    Console.WriteLine($"Não foi achado o número {numeroEscolhido} no index {i} do array numeros");
                }
            }
        }

        static void AcharPessoa(List<string> lista, string pessoaEscolhida){
            IEnumerable<string> AcharPessoa = 
            from pessoa in lista
            where pessoa == pessoaEscolhida
            select $"{pessoa}"
            ;
            int totalPessoasAchadas = 0;
            foreach (var pessoa in AcharPessoa)
            {
                totalPessoasAchadas++;
            }
            if(totalPessoasAchadas >0){
                Console.WriteLine($"há um total de {totalPessoasAchadas} {pessoaEscolhida} na lista de pessoas");
            }
            else{
                Console.WriteLine($"Não há nenhum {pessoaEscolhida} na Lista!");
            }
            

        }
        public static void Main(){
            int[] numeros = [34,65,87,12,52,48,52,47,94,25,74,97];
            var pessoas = new List<string>{"Gabi","Mario","Jhonny","Thiago","Alex"};
            int x = 12;
            string y = "Thiago";

            AcharNumeros(numeros, x);
            AcharPessoa(pessoas, y);

        }
    }
}

