// See https://aka.ms/new-console-template for more information
Console.WriteLine("AOBA");
string AmigoUm = "tico";
string AmigoDois = "teco";
string Cumprimentar = $"bão {AmigoUm} e {AmigoDois}?\n";
Console.Write(Cumprimentar);
Cumprimentar = Cumprimentar.Replace(AmigoUm,"Vini").Replace(AmigoDois,"Giggio");
Console.Write(Cumprimentar.ToUpper());
