namespace Strings
{
    public class Program{

        //Utilizar void quando o método não retorna um valor.
        //utilizar o static logo que a main também é uma static, e para a main conseguir chamar este método precisa estar setado como static.
        static void TrocarNome(ref string nome, string novoNome) {
            nome = novoNome;
        }

        public static void Main(){

            string nome = "Matheus";
            Console.WriteLine($"Meu nome é {nome}");
            TrocarNome(ref nome, "Roberto");
            Console.WriteLine($"Meu nome é {nome}");

        }

    }
}