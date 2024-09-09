namespace QueueAndStacks
{
    class Program
    {
        static void Main()
        {
            //Cria uma variável Queue do tipo texto onde o primeiro valor a entrar será o primeiro a sair
            Queue<string> fila = new();

            fila.Enqueue("Giggio"); // 1º a entrar e 1º a sair
            fila.Enqueue("Pedro"); // 2º a entrar e 2º a sair
            fila.Enqueue("Vinicius"); // 3º a entrar e 3º a sair

            System.Console.WriteLine($"pessoas na fila: {fila.Count}");

            while (fila.Count > 0)
            {
                //Peek() retorna o valor da primeira posição da queue
                System.Console.WriteLine($"Próximo a ser atendido: {fila.Peek()}");
                //Dequeue retorna o valor e remove da queue a primeira posição
                System.Console.WriteLine($"Por favor, Sr(a) {fila.Dequeue()} apresente-se ao guichê");
                System.Console.WriteLine($"pessoas na fila: {fila.Count}");

                
            }

            System.Console.WriteLine("********************************************************************************************");

            //Cria uma variável Stack do tipo texto onde o ultimo à entrar é o primeiro a sair
            Stack<string> livrosAEstudar = new();

            livrosAEstudar.Push("Matemática"); // 1º a entrar e último a sair
            livrosAEstudar.Push("Portugues"); // 2º a entrar e penúltimo a sair
            livrosAEstudar.Push("Geografia"); // 3º a entrar e anti-penúltimo a sair
            livrosAEstudar.Push("Historia"); // ultimo a entrar e 1º a sair
            System.Console.WriteLine($"livros restantes: {livrosAEstudar.Count}");

            while (livrosAEstudar.Count > 0)
            {
                //Peek() retorna o valor da ultima posição posição da Stack
                System.Console.WriteLine($"Próximo livro para estudar: {livrosAEstudar.Peek()}");
                //Pop retorna o valor e remove da queue a primeira posição
                System.Console.WriteLine($"Livro {livrosAEstudar.Pop()} pego para estudar");
                System.Console.WriteLine($"livros restantes: {livrosAEstudar.Count}");

                
            }

            

        }
    }
}