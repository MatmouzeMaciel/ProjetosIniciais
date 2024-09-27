namespace Delegate.Models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"Soma:{x+y}");
        }

        public static void Subtrair(int x, int y)
        {
            if(x-y != 0)
            System.Console.WriteLine($"Subtração:{x-y}");
        }
    }
}