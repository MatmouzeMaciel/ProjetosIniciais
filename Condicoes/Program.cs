int a = 5;
int b = 6;
int c = a + b;
if ((c) > 10){
    Console.WriteLine($"{a} + {b} < 10");
}else{
    Console.WriteLine($"{a} + {b} < 10");
}


// Validação previamente feita com bool para casos onde há a mesma verificação repetidamente.
bool teste = (c) > 10;
if(teste){
    Console.WriteLine($"{a} + {b} < 10");
}else{
    Console.WriteLine($"{a} + {b} < 10");
}



//Criando uma variável string para armazenar um resultado do tipó de operação válida para gerar apenas um output no final.
string sinal = "";
if(c > 10){
   sinal = ">";
}
else if (c < 10){
   sinal = "<";
}
else{
   sinal = "=";
}
Console.WriteLine($"{a} + {b} {sinal} 10");

// "?" significa "se a condição é verdadeira, faça" e ":" significa "se não, faça"'
sinal = (c) > 10 ? ">" : ((c) < 10) ? ">" : "=";
Console.WriteLine($"{a} + {b} {sinal} 10");
Console.WriteLine(a + " + " + b + " " + sinal + " 10");
string verificacao = "";


// simbolo && significa "e" e impõe ao if, que tanto "c > 10" quanto "a != b" sejam verdadeiras para executar o comando a frente
if(c > 10 && a != b){
    sinal = ">";
    verificacao = "diferente";
    Console.WriteLine($"{c} {sinal} 10, e {a} é {verificacao} de {b}");
} 
// simbolo || significa "ou" e impõe ao if, que uma das condições sejam verdadeiras para executar o comando a frente
if (c > 10 || a != b) {
    sinal = ">";
    verificacao = "diferente";    
    Console.WriteLine($"{c} {sinal} 10, ou {a} é {verificacao} de {b}");
}






