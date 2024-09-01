using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

int[] scores = [23,45,76,12,89,34,06,23,94,62];
int pontosBons = 0;
int pontosRuins = 0;
//Tanto Lenght quanto Count() resultariam no msm resultado se tratando de um array/lista.
//Length está sendo utilizado para determinar quantos index há no array para verificação.
for (int i = 0; i < scores.Length; i++){
    if(scores[i] > 80){
        Console.WriteLine(scores[i]);
        pontosBons++;
    }
    else{
        pontosRuins++;
    }
}
Console.WriteLine($"um total de {pontosBons} pontuações acima de 80, e {pontosRuins} abaixo.");
pontosBons = 0;
pontosRuins = 0;


//declara a criação de uma variável para armazenar um método de verificação(quary) que executa o método em uma coleção de dados filtrando os valores.
IEnumerable<int> scoreQuary = 
    //basicamente um foreach
    from score in scores
    //detalhe da condição para a seleção
    where score > 80
    //retorna os valores que encaixam na condição
    select score;

//utilizando o quary acima ele especifica o index para verificação do Quary
foreach (int i in scoreQuary){
    pontosBons++;
    Console.WriteLine($"{i}");
}
pontosRuins = scores.Length - pontosBons;
Console.WriteLine($"um total de {pontosBons} pontuações acima de 80, e {pontosRuins} abaixo.");
pontosBons = 0;
pontosRuins = 0;


IEnumerable<string> scoreQuaryA = 
    from score in scores
    where score > 80
    orderby score descending
    select $"{score}";

foreach (string i in scoreQuaryA)
{
    pontosBons++;
    Console.WriteLine(i);
}

pontosRuins = scores.Length - pontosBons;
Console.WriteLine($"um total de {pontosBons} pontuações acima de 80, e {pontosRuins} abaixo.");


//declara a criação de uma variável para armazenar um método de verificação(quary) que executa o método em uma coleção de dados filtrando os valores.
IEnumerable<int> scoreQuaryB =
    from score in scores
    where score > 45
    orderby score descending
    select score;
//Como o resultado do Quary gera um ou mais valores podemos assimilar à uma lista/Array

var scoreSuperiorB = scoreQuaryB.ToList();
Console.WriteLine(scoreSuperiorB[0]);


// IEnumerable<int> scoreQuaryC =
//     from score in scores
//     where score > 45
//     select score;

var scoreQuaryC = scores.Where(s => s > 45).OrderByDescending(s => s); 
List<int> scoreSuperiorC = [.. scoreQuaryC];  

Console.WriteLine(scoreSuperiorC[0]);











