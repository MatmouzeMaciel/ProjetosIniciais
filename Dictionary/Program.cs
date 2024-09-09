using System.Diagnostics.CodeAnalysis;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            //Dictionary cria um conjunto de valores em pares, onde um é o valor utilizável e o outro é uma chave única(dentro daquele dictionary) referente aquele valor:
            //Matrícula: 151515; Aluno: Artur; onde a chave será 151515 e não poderá haver outra dentro do dictionary, enquanto pode havers outros Artur com matrícula diferente;
            Dictionary<string, string> dicionarioDeEstados = [];
            //Adiciona em primeiro a chave e posteriomente seu valor anexado;
            dicionarioDeEstados.Add("SP", "São Paulo");
            dicionarioDeEstados.Add("RJ", "Rio de Janeiro");
            dicionarioDeEstados.Add("DF", "Distrito Federal");
            dicionarioDeEstados.Add("CE", "Ceará");
            dicionarioDeEstados.Add("MG", "Minas Gerais");
            dicionarioDeEstados.Add("SC", "Santa Catarina");
            /*Não é possível vincular valores diferentes à uma chave já existente, o compilar retorna erro.
            dicionarioDeEstados.Add("SC", "São Caetano");*/
            //Porém é possível vincular mesmo valor à diferentes chaves:
            dicionarioDeEstados.Add("SK", "Santa Catarina");

            //KeyValuePair<TKey, Tvalue> é utilizado para referenciar uma variável q armazena um conjunto de dados dulpos, onde um é um chave e o outro um valor
            foreach (KeyValuePair<string, string> estado in dicionarioDeEstados)
            {
                //como estado dentro puxa da coleção dicionarioDeEstados dois valores é preciso referenciar seu uso com Key/Value para especificar qual dos valores está sendo utilizado no momento
                System.Console.WriteLine($"chave: {estado.Key}, valor: {estado.Value} ");
            }
            
            //cria uma lista de siglas para servir como referência de pesquisa dentro de dicionarioDeEstados
            List<string> estadoProcurado = ["BA", "MG", "DF", "MT", "SP"];
            foreach (var estado in estadoProcurado)
            {
                //tenta buscar o valor associado à chave disponibilizada, onde se conseguir executa o primeiro estatment e caso não consiga pela key não exitir ele faz o else
                if(dicionarioDeEstados.TryGetValue(estado, out string? value))
                {
                    System.Console.WriteLine($"Estado de sigla {estado} encontrado: {value}");
                    
                }
                else
                {
                    System.Console.WriteLine($"não foi encontrado no dicionário nenhum estado com a sigla {estado}");
                }
            }

            string estadoErrado = "SK";
            //Atualiza o valor dentro do dictionary
            System.Console.WriteLine($"valor original: {dicionarioDeEstados[estadoErrado]}");
            dicionarioDeEstados[estadoErrado] = "Santa Katarina";
            System.Console.WriteLine($"valor atualizado: {dicionarioDeEstados[estadoErrado]}");

            //já que SK e Santa Katarina não afzem parte dos estados brasileiro, vamos remover
            //Remove() exclui o valor e sua chave utilizando a chave como referencial
            dicionarioDeEstados.Remove(estadoErrado);
            if(dicionarioDeEstados.ContainsKey(estadoErrado))
            {
                System.Console.WriteLine($"estado {estadoErrado} ainda existe");
                System.Console.WriteLine($"estado {estadoErrado} tem o valor: {dicionarioDeEstados[estadoErrado]}");
                
            }
            else
            {
                System.Console.WriteLine($"estado {estadoErrado} removido");
            }
   
            
            



        }
    }
}