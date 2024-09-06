using System.Reflection.Metadata.Ecma335;

namespace Generics.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaEstados(List<string> estados)
        {
            Console.WriteLine($"Os estados listados são:");
            for (var i = 0; i < estados.Count; i++)
            {
                Console.WriteLine($"Na posição de Index Nº{i} tem o estado {estados[i]}");
                
            }
        }

        public int retornaIndexDaLista(List<string> lista, string valorAlvo)
        {
            return lista.IndexOf(valorAlvo);
        }

        public void adicionarVariavelTextoAoFinalDaLista(List<string> lista, string valorAdicionar)
        {
            lista.Add(valorAdicionar);
        }
    
        public void adicionarArrayDeValoresTextoAoFinalDaLista(List<string> lista, string[] array)
        {
            lista.AddRange(array);
        }

        public void adicionarVariavelTextoNoIndexDaLista(List<string> lista, string valorAdicionar,int indexAlvo)
        {
            lista.Insert(indexAlvo, valorAdicionar);
        }
    }
}