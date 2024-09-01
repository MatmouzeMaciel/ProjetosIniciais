
using System.Security.AccessControl;

int a = 18;
int b = 6;
int c = a + b;
//resultará em c = 24 com o output "24".
Console.WriteLine($"1. {c} ");

//int d = 20000000000;
//int e = 6;
//int f = d + e;
// o valor alocado em d é acima do suportado dentro dos 32bits do tipo int.
//resultando no na falha de compilação.
//Console.WriteLine($"2. {f} ");


//para contornar isso se utiliza o tipo "long" de variável.
long d = 20000000000;
long e = 222;
long f = d + e;
//resultará em d = 20000000222, e o output será 20000000222.
Console.WriteLine($"2. {f} ");



//Nesta parte por mais que os valores armazenados em g e h estejam dentro do suportável numa variável de 32bits, o resultado de sua soma será maior do que o suportado.
int g = 2000000000;
int h = 2000000000;
//para resolver isso no resultado transformamos as três variaveis em long para realizar o calculo.
long i = (long)g + (long)h;
Console.WriteLine($"3. {i} ");

decimal j = 40 + 3.2M; // Decimal é um tipo de variável explicita que demanda um sufixo M nos valores quebrados para interpretação.
decimal k = 36.7M;   // Decimal armazena pequenas quantidades dee numeros após a virgula, porém geralmente é o necessário.
decimal l = j + k;
Console.WriteLine($"4. {l} ");

double m = 40 + 3.2;  // Double armazena uma quantidade maior de numeros após a virgula.
float n = 36.7F;
double o = m + n;
Console.WriteLine($"5. {o} ");

float p = 40 + 3.2F;  // Float é um tipo de variável explicita que demanda um sufixo F nos valores quebrados para interpretação.
float q = 36.7F;  // Float Armazena mais numero após a virgula do que decimal, porém não é enorme igual Double.
float r = p + q;
Console.WriteLine($"6. {r} ");

string textoA = "145,059495045304905";
float AAA = float.Parse(textoA);

Console.WriteLine($"{AAA:F3}");



