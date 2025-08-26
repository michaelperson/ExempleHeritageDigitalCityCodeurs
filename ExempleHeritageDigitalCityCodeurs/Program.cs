// See https://aka.ms/new-console-template for more information
using ExempleHeritageDigitalCityCodeurs.Models;

Console.WriteLine("Hello, Zoo!");
List<Animal> MyAnimals = new List<Animal>();
Animal Dog1 = new Dog();
MyAnimals.Add(Dog1);
//Dog1.ChangeNameWhenIPlay("Paf");
////Dog1.NbPaws = 3;
//Dog1.SetNumberOfPaws(3);
//Dog1.Species = "Canus vulgaris Europeanius";
//Dog1.IsAlive = true;

//Console.WriteLine($"Le chien a {Dog1.NbPaws} pattes");
//Dog1.Move();
//Dog1.Stop();
//Dog1.Eat();
//Dog1.MakeNoise();
//Dog1.Dead();


Animal Cat1 = new Cat();
MyAnimals.Add(Cat1);
//Cat1.SetMyName("Misty");
//Cat1.SetNumberOfPaws();
//Cat1.CatPaws = 1;
//Cat1.Species = "Catus Goutierrus Bruxellis";
//Cat1.IsAlive = true;

//Console.WriteLine($"Le chat a {Cat1.CatPaws} pattes");
//Cat1.Move();
//Cat1.Stop();
//Cat1.Eat();
//Cat1.MakeNoise();
//Cat1.Dead();

foreach (Animal animal in MyAnimals)
{
    animal.Move();
    animal.Stop();
    animal.Eat();
    animal.MakeNoise();
    animal.Dead();
    if (animal is Dog)
    {
        ((Dog)animal).SetNumberOfPaws(3);
        Camel? Wali = animal as Camel;
        if(Wali is null) Console.WriteLine("It's not a Camel");       

        Console.WriteLine($"The dog has :{((Dog)animal).NbPaws}");
        Console.WriteLine("Animal");
        Console.WriteLine($"The animal has :{animal.NbPaws}");
    }
    if (animal is Cat)
    {
        ((Cat)animal).NbPaws = 1;

        Console.WriteLine($"The cat has :{((Cat)animal).NbPaws}");
        Console.WriteLine("Animal");
        Console.WriteLine($"The animal has :{animal.NbPaws}");

    }
    
   
}

