using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using static System.Console;

namespace TipoValueTipoRef
{
    public class Program{


        static int AdicionarValor(int valorBase, int qtdAdicionar){
            return valorBase = valorBase + qtdAdicionar;

        }
        public static void Main(){

            //ao referenciar a biblioteca "System.Console" podemos ignogar o uso do Console e chamar diretamente o comando WriteLine
            //Console.WriteLine($"teste"); vira:
            WriteLine($"teste");

            string nome = "Mirella";
            string RG = "Sem documento";
            int idade = 2;
            int anosAcrescentar = 5;
            int idadeFuturo = AdicionarValor(idade, anosAcrescentar);
            var p1 = new Pessoa(idade, idadeFuturo, nome, RG);
            WriteLine($"a {p1.Nome} tem {p1.Idade} anos e terá {p1.IdadeFuturo} daqui {anosAcrescentar}");
           
           
            //Quando eu crio p2 estou criando uma nova instancia e copiando os valores do momento,
            //Sem que as alterações futuras em p1 afete p2.
            //VALUE TYPES instanciados.
            Pessoa p2 = new Pessoa(0,0,"","");
            p2.Nome = p1.Nome;
            p2.Idade = p1.Idade;
            p2.Documento = p1.Documento;
            p2.IdadeFuturo = AdicionarValor(p2.Idade, anosAcrescentar);
            
            //Quando eu crio o p3 eu de imediato referêncio o p1, fazendo com que as mudanças em p1 altere p3 a qualquer momento
            //REF TYPES instanciados.
            Pessoa p3 = p1;

            //Chama o método clone do objeto Pessoa utilizando o p1 como base para criar um novo objeto com os mesmos valores, assim como o p2.
            Pessoa p4 = p1.Clone();

            TrocarNome(p1, "Juliane");

            WriteLine($"{p2.Nome} agora é {p1.Nome}"); // output: Mirella agora é Juliane
            WriteLine($"{p3.Nome} agora é {p1.Nome}"); // output: Juliane agora é Juliane
            WriteLine($"{p4.Nome} {p4.Idade} {p4.IdadeFuturo} {p4.Documento}"); // Output: Mirella 2 7 Sem documento

            Pessoa2 p5 = new(2, 7, "Mirella", "Sem Documento");
            var p6 = p5;

            //por ser uma struct o método não consegue alterar o valor do atributo desse Struct
            //é necessário atribuir o valor gerado pela função diretamente na struct 
            p5 = StructTrocarNome(p5, "Juliane");
            WriteLine($"{p5.Nome}");
            WriteLine($"{p6.Nome}");

        }

        public class Pessoa(int idade, int idadeFuturo, string primeiroNome, string rg){
            public int Idade {get; set;} = idade;
            public int IdadeFuturo {get; set;} = idadeFuturo;
            public string Nome {get; set;} = primeiroNome;
            public string Documento {get; set;} = rg;

            public Pessoa Clone(){
                return new Pessoa(Idade, IdadeFuturo, Nome, Documento){
                    Documento = this.Documento,
                    Idade = this.Idade,
                    Nome = this.Nome,
                    IdadeFuturo = this.IdadeFuturo
                };
            }
        }
        public struct Pessoa2(int idade, int idadeFuturo, string primeiroNome, string rg){
                        public int Idade {get; set;} = idade;
                        public int IdadeFuturo {get; set;} = idadeFuturo;
                        public string Nome {get; set;} = primeiroNome;
                        public string Documento {get; set;} = rg;
        }
        static void TrocarNome(Pessoa p1, string nomeNovo){
            p1.Nome = nomeNovo;

        }
        static Pessoa2 StructTrocarNome(Pessoa2 p5, string nomeNovo){
            p5.Nome = nomeNovo;
            return p5;
        }
        

    }
}