using System;



int suavariavel = int.Parse(Console.ReadLine());
string[] numeros = Console.ReadLine().Split(' ');
List<int> numerosLidos = [];
foreach (var num in numeros)
{
    numerosLidos.Add(int.Parse(num));
}
int multiplo2 = 0;
int multiplo3 = 0;
int multiplo4 = 0;
int multiplo5 = 0;

//TODO: Complete os espaços em branco com uma possível solução para o desafio
foreach (var num in numerosLidos)                      
{
    if (num % 2 == 0){multiplo2++;};
    if (num % 3 == 0){multiplo3++;};
    if (num % 4 == 0){multiplo4++;};
    if (num % 5 == 0){multiplo5++;};
}

Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
