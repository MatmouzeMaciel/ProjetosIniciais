//registra um novo objeto utilizando a classe Person.
var p1 = new Person("Giggio","Gigi",new DateOnly(2000,7,31));
var p2 = new Person("Vini","LivraOMal",new DateOnly(2006,6,6));
List<Person> people = [p1,p2];
//Registra um novo valor à característica Pets da do objeto referenciado, p1 e p2 no caso.
p2.Pets.Add(new Cat("fred"));
p1.Pets.Add(new Dog("Danete"));
p1.Pets.Add(new Dog("Jinx"));
foreach(var person in people){
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"     {pet}");
    }
}

//Classes são objetos e suas caracteristicas mutáveis ou imutáveis.
public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First {get;} = firstname;
    public string Last {get;} = lastname;
    public DateOnly Birthday {get;} = birthday;
    //Cria uma lista de possíveis Pets dentro de Person, não quer dizer que tem, quer dizer que pode ter.
    public List<Pet> Pets {get;} = [];

    //quando Person for chamado o padrão a ser exibido será o String em Return.
    public override string ToString()
    {
        return $"Eu sou {First} {Last} e eu tenho:";
    }

}

//ABSTRACT classes são classes que funcionam como blueprint para outras classes.
//Pessoas tem Pets, e esses Pets são cães ou gatos.
public abstract class Pet(string firstname){
    public string First {get;} = firstname;
    //Abstract string cria um característica mutável ao Pet.
    public abstract string MakeNoise();
    //quando Person for chamado o padrão a ser exibido será o String em Return.
    public override string ToString()
    {
        return $"{First} que é um {GetType().Name} que {MakeNoise()}";
    }

}

//Ao utilizar : se diz que Cat é derivado de Pet e está utilizando Pet como molde.
public class Cat(string firstname):Pet(firstname){
    //para mutar essa característica exclusivamente à Cat, tem que sobreescrever com Override.
    public override string MakeNoise() => "mia";
}

public class Dog(string firstname):Pet(firstname){
    //para mutar essa característica exclusivamente à bark, tem que sobreescrever com Override.
    public override string MakeNoise() => "late";
}

