namespace ArrayStrings
{
    public class Program
    {
        static void AcharTrocarNome(string[] array, string nomeRetirado, string nomeNovo){
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == nomeRetirado){
                    array[i] = nomeNovo;
                }
            }

        }

        static int AcharNome(string[] array, string nomeProcurado){
            int indexNomes = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == nomeProcurado){
                    indexNomes = i;
                }
            }
            return indexNomes;
            
        }


        static void TrocarNome(string[] array, int index, string nomeNovo){
            array[index] = nomeNovo;
        }

        
        public static void Main(){
            string[] nomes = ["Thiago", "Gabi", "Mario", "Jhonny"];
            string nomeRetirado = "Mario";
            string nomeNovo = "Daniel";
            int indexNomes = 0;
            // AcharTrocarNome(nomes, nomeRetirado, nomeNovo);
            // foreach (var nome in nomes)
            // {
            //     Console.WriteLine($"{nome}");
            // }
            indexNomes = AcharNome(nomes, nomeRetirado);
            TrocarNome(nomes, indexNomes, nomeNovo);
            foreach (var nome in nomes)
            {
                Console.WriteLine($"{nome}");
            }


        }
    }
}