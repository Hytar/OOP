
using System;
using System.Collections.Generic;

// Hayvan sınıfı
class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; } //Consturctora atanacak özellikler olusturuyorum

    public Animal(string name, string species, int age)//özellikleri atıyorum
    {
        Name = name;
        Species = species;
        Age = age;
    }

    
}

// Hayvanat Bahçesi sınıfı
class Zoo
{
    public string Name { get; set; }
    public List<Animal> Animals { get; set; }//liste hayvanlar classından tutar

    public Zoo(string name)//Constructor
    {
        Name = name;
        Animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)//Hayvanat bahcesine hayvan ekler
    {
        Animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)//Hayvanat bahcesinden hayvan cıkarır
    {
        Animals.Remove(animal);
    }

    public void ListAnimals()//Hayvannların özelliklerini listeler
    {
        Console.WriteLine($"Hayvanat Bahçesi: {Name}");
        Console.WriteLine("Hayvanlar:");
        foreach (var animal in Animals)
        {
            Console.WriteLine($"- {animal.Name} ({animal.Species}), Yaş: {animal.Age}");
        }
    }
}


class Program
{
    static void Main()
    {
        Zoo myZoo = new Zoo("Mutlu Hayvanat Bahçesi");//Zoo classı olusturdum

        // Hayvanları olusturuyorum
        Animal lion = new Animal("Aslan", "Memeli", 5);
        Animal parrot = new Animal("Papağan", "Kuş", 2);
        Animal dolphin = new Animal("Yunus", "Memeli", 10);

        // Hayvanat bahçesine hayvanlar ekliyorum
        myZoo.AddAnimal(lion);
        myZoo.AddAnimal(parrot);
        myZoo.AddAnimal(dolphin);

        // Hayvanları listeliyorum
        myZoo.ListAnimals();

        
    }
}
