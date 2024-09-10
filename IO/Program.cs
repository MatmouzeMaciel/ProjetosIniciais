using System;
namespace IO
{
    class Program
    {
        static void Main()
        {
            //cria e armazena valor do path a ser adicionado a pasta
            var path = System.AppContext.BaseDirectory + "\\testeBinFolder.txt";
            //cria projectRoot como uma variável de texto pra armazenar o path raiz do projeto
            string projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
            //Utiliza o path raiz 
            var path2 = Path.Combine(projectRoot, "testeRoot.txt");
            Console.WriteLine("Digite o nome do arquivo a ser criado");
            var nome = Console.ReadLine();
            FormatarNome(ref nome);
            var path3 = Path.Combine(projectRoot, nome);


            //Utilizado para inserção de daos de forma simples e rápida em um arquivo, ideal para casos que não necessitam multiplas mudanças no arquivo
            File.WriteAllText(path, "texto simples e direto em 1 linha sem abrir instancia");

            //cria a instancia que consegue escrever dentro do arquivo path
            //mais utilizado quando se necessita de mais flexibilidade e performance ao mexer com arquivos mais longos que necessitam de manutenção em várias linhas
            var sw = File.CreateText(path2);

            //chama a instancia que cria texto no path, e passa o texto a ser criado dentro do arquivo
            //O StreamWriter dentro de CreateText após escrever não salva automaticamente nada no arquivo
            sw.WriteLine("Essa é a linha 1");
            sw.WriteLine("Essa é a linha 2");
            sw.WriteLine("Essa é a linha 3");
            sw.WriteLine("Essa é a linha 4");

            //o método Flush() justamente realiza a modificação do arquivo
            sw.Flush();


            CriarArquivo(path3);
            
            
            

            


        }

        static void FormatarNome(ref string nome)
        {
            foreach (var @char in Path.GetInvalidFileNameChars())
            {
                nome = nome.Replace(@char, '-');
            }
        }

        static void CriarArquivo(string path)
        {
            try{
                var sw = File.CreateText(path);
                sw.WriteLine("adicionado texto à linha 1 do arquivo");
                sw.Flush();
            
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                System.Console.WriteLine(path);
            }
            

        }
    }
}
