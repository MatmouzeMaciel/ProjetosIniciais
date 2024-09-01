using System.Xml;

namespace Refs
{
    public class Program()
    {
        static void AdicionarValor(ref int valorInicial, int valorAdicionado){
            valorInicial += valorAdicionado;
        }
        public static void Main(){

            int a = 5;
            int b = 35;
            //Referencia a variável alterando seu valor na base inicial
            AdicionarValor(ref a, b);
            Console.WriteLine(a); //output: 40



        }
    }
}