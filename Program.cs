//1. Any
// How to use Any method from LINQ
// - used to check if any element in the collection matches the given criteria.

using LinnqPractice.Pets;
using LinqPractice.Pets;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate - a function to test each elemetn for a condition
            //Lamdba expression - anonymous function defined right here,
            // passing the lambda expression that takes the element from this collection and returns a bool
            // a function that takes an int and returns true if int is larger than 10,other wise false.
            // Any - simply iterates the collection and executes the parameter function for all elements.
            var numbers = new[] { 5, 9, 2, 12, 6 };
            //bool isAnyLargerThan10 = numbers.Any(number => number > 10);
            //Console.WriteLine(isAnyLargerThan10);
            //Console.ReadKey();

            //Determines wheter all elemenets satisft the condition
            var areAllLargerThanZero = numbers.All(number => number > 0);

            var pets =
            new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 1.1f),
                new Pet(3, "Deku", PetType.Cat, 1.1f),
                new Pet(4, "Shiba", PetType.Dog, 1.1f),
                new Pet(5, "Tested", PetType.Dog, 1.1f),
                new Pet(6, "Krypto", PetType.Dog, 1.1f),
                new Pet(7, "Tom", PetType.Cat, 1.1f),
                new Pet(8, "Gar", PetType.Cat, 1.1f)
            };

            var doAllHaveNonEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));

            var areAllCats = pets.All(pet => pet.PetType == PetType.Cat);



            var isAnyPetNamedAnthony = pets.Any(pet => pet.Name == "Anthony");

            var isAnyFish = pets.Any(pet => pet.PetType == PetType.Fish);
            //name longer than 6 letters and Id thats even number
            var isThereAnySpecificPet = pets.Any(pet => pet.Name.Length > 6 && pet.Id % 2 == 0);
        }
    }


}