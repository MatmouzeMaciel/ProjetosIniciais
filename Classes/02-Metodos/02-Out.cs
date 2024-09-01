using System.Threading.Tasks;

namespace Classes.Metodos
{
    public class Out
    {   
        //Utilizar do "out" dentro dos parametro de um método faz com que possa ser criado uma variável apenas para que haja o retorno dos valores gerados,
        //sem a necessidade de um alocamento prévio dos valores ou de seus tipos
        static void Dividir(int x, int y, out int resultado, out int resto) 
        {
            resultado = x / y;
            resto = x % y;
        }
        
        public static void Dividir() 
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
}