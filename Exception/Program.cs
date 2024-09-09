using Microsoft.VisualBasic;

int a = 100, b = 0;

//tentará executar o código 
try
{
    double resultado = Dividir(a, b); // retornará a exception DivideByZeroException
    System.Console.WriteLine(resultado);
}
//tentará armazenar a exception específica DivideByZeroException pega Se a for menor que 100
catch(DivideByZeroException exception) when (a<100)
{
    System.Console.WriteLine(exception);
}
//Como a não é menor que 100, passará para o próximo catch que tentará armazenar qualquer exception q foi gerada
catch(Exception exception)
{
    System.Console.WriteLine(exception.Message);
}
//capiturando ou não uma Expetion, executará os comandos dados, geralmente são comandos de finalização tal como um File.Close
finally
{
    System.Console.WriteLine("Foi finalizada a divisão");
    System.Console.WriteLine("A divisão correta é:");
    System.Console.WriteLine($"{b} / {a} = {Dividir(b,a)}");
}

static double Dividir(int valorA, int valorB)
{
    if (valorB != 0){
        return valorA / valorB;
    }else{
        throw new DivideByZeroException();
    }
    
}




