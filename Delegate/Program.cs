using System.Security.Cryptography.X509Certificates;
using Delegate.Models;

namespace Delegate
{
    class Program()
    {
        public delegate void Operacao(int x, int y);
        public static void Main()
        {
            Operacao op = new(Calculadora.Somar);
            Operacao op2 = new(Calculadora.Subtrair);
            op += Calculadora.Subtrair;
            op.Invoke(10,10);
            
        }
    }
}