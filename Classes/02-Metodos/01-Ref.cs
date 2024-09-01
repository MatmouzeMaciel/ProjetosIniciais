namespace Classes.Metodos
{
    public class Ref
    {
        //quando o método é chamado e inserido o calor de 2 variáveis, elas são adicionadas por referência
        //o que implica que as mudanças feitas pelo método atuarão diretamente na fonte
        static void Inverter(ref int x, ref int y)
        {
            (y, x) = (x, y);
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}