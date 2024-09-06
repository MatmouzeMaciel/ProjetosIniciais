namespace Arrays.Helper
{
    public class OperacoesArray
    {
        //Método bubbleSorte utilizado para ordenar de forma crescente os valores dentro de um array linear
        public void OrdenarBubbleSort(ref int[] array){
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array [j];
                        array[j] = temp;
                    }
                }
            }
        }
        //Literalmente printa todos os campos de uma array linear
        public void ImprimirArray(int[] array){
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        //Usando a Classe Array dentro de System para puxar o método pronto de ordenar
        public void OrdenarArray(ref int[] array){
            Array.Sort(array);
        }

        //Usando a Classe Array dentro de System para puxar o método pronto de copiar
        public void CopiarArray(ref int [] arrayDestino, int[] arrayCopia){
            Array.Copy(arrayCopia, arrayDestino, arrayCopia.Length);
        }
        //Usando a Classe Array dentro de System para puxar o método pronto para procurar um valor dentro do array
        public Boolean ExisteNoArray(int[] arrayAlvo, int valorProcurado){
            //após o lambda o operacional de condição == pode ser substituído pelas demais, tais como >= ou !=
            return Array.Exists(arrayAlvo, valor => valor == valorProcurado);
        }

        public Boolean TodosNoArrayMaiorQue(int[] arrayAlvo){
            //verifica se TODOS os valores dentro do array atendem a condição
            return Array.TrueForAll(arrayAlvo, valor => valor >= 0);
        }

        public int[] RetornarValoresDoArrayMaioresQue(int[] arrayAlvo, int valorVerificador){
            return Array.FindAll(arrayAlvo, valor => valor >= valorVerificador);
        }
        
        public int RetornarIndexDoValorNoArray(int[] arrayAlvo, int valorVerificador){
            return Array.FindIndex(arrayAlvo, valor => valor == valorVerificador);
        }
        public string[] ConverterArrayIntParaString(int[] arrayAlvo){
            return Array.ConvertAll(arrayAlvo, valor => valor.ToString());
        }
    }
}