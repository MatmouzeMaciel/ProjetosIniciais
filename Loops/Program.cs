using System.Diagnostics.Metrics;

int counter = 0;
Console.WriteLine($"A = {counter}"); //output 0
counter = counter + 1; // Adicionar um ao valor já existente.
Console.WriteLine($"A = {counter}"); //output 1
counter++; // Adicionar um ao valor já existente.
Console.WriteLine($"A = {counter}"); //output 2
counter--; // Diminuir um ao valor já existente.
Console.WriteLine($"A = {counter}"); //output 1

int counterB = 0;
//Aciona um comando enquanto a condição entre parênteses for verdadeira.
while (counterB < 3){
    counterB++;// Adicionar um ao valor já existente enquanto a condição acima for verdadeira.
    Console.WriteLine($"B = {counterB}"); //primeiro output será 1
}

int counterC = 0;
//Aciona uma tarefa e a repete enquanto a condição em evidência seja verdadeira, ou seja, fara a primeria vez, mesmo que a condição seja falsa.
do
{
    counterC++;// Adicionar um ao valor já existente enquanto a condição acima for verdadeira.
    Console.WriteLine($"C = {counterC}"); //primeiro output será 1

}
while (counterC < 2 );

//Para o valor indicado, enquanto a condição for verdadeira, execute a tarefa, e adicione um ao valor indicado e o atualize, caso a condição seja false, interrompa 
for (int counterD = 0; counterD < 2; counterD++){
    Console.WriteLine($"D = {counterD}"); //primeiro output será 0
}

/*
Para a letra indicada, enquanto a condição for verdadeira, execute a tarefa, e substitua a letra pela próxima de acordo com o alfabeto e atualize a letra indicada
caso a condição seja false, interrompa
*/
for (char counterE = 'a'; counterE < 'k'; counterE++){
    Console.WriteLine($"E = {counterE}"); //primeiro output será 0
}

