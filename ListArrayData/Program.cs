/*var é o tipo de variável que pode armazenar varaiados tipo do msm tipo de de variáveis
portanto se utiliza em sequencias mais complexas de valores ou valores que variam sem mutar o anterior
tal como uma lista de nomes
var a = 1;
var b = "name";
*/


var names = new List<string> {"Vini", "Giggio", "Peu"};
//"foreach (var item in collection){}" 
//em foreach cria-se uma variável para asmazenar um dos vários valores armazenados em uma variável
//para names em foreach, é possível setar um range como em names[3..5], onde só utilizará as posições 3, 4 e 5.
foreach (var name in names)
{
    Console.WriteLine($"bão {name}");
}  

//o valor entre [] significa a posição do valor na lista/array
//o valor 0 representa o primeiro da lista
//se utilizado ^1 significa o primeiro do ultimo pra trás
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[^1]);

//o [] após do tipo de variável declarado significa a criação de um Array, que diferente da lista, é bidimentional
var namesA = new string[] {"Brendum", "jão", "Rogher"};
//para adicionar mais valores ao array, chame novamente na variável, adicione ela mesma, e acrescente os valores nescessários.
namesA = [..namesA, "Isac"];
//name é uma variável local do foreach, portanto a repetir não irá gerar conflitos
foreach (var name in namesA)
{
    Console.WriteLine($"bão {name}");
}  

//INDEX
Console.WriteLine(names[0]);
Console.WriteLine($"bão {names[0]}");
//para saber o index de um valor também é possível:
Console.WriteLine($"O index de Giggio é {names.IndexOf("Giggio")}");
//método Sort executará uma organização crescente(a menos qu se diga o contrário), da lista e atribuirá a própria lista caso não haja nenhuma atribuição antes. 
names.Sort();
Console.WriteLine(names[0]);
Console.WriteLine($"bão {names[0]}");
//para saber o index de um valor também é possível:
Console.WriteLine($"O index de Giggio é {names.IndexOf("Giggio")}");


