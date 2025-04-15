//1. Any
// How to use Any method from LINQ
// - used to check if any element in the collection matches the given criteria.

// All
//  Check if all element in the collection satisfy the condition

// Count , Long Count
// - Count the elements in the collection that match the given predicate

// Contains
// - checks if the given element is present in the collection

// Order by, OrderByDescending, ThenBy, ThenByDescending
// order collections
// Order by: orders the collection by some criteria

// First AND LAST METHOD
// Along with FirstOrDefault and LastOrDefault
// First - returns the first element from the collection
// - if a predicate is given, it returns the first element that matches this predicate
// Last - same, last element returned;



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

            //bool isAnyLargerThan10 = numbers.Any(number => number > 10);
            //Console.WriteLine(isAnyLargerThan10);
            //Console.ReadKey();

            //Determines wheter all elemenets satisft the condition
            var numbers = new[] { 5, 9, 2, 12, 6 };
            var orderedNumbers = numbers.OrderBy(number => number);

            bool is7Present = numbers.Contains(7);

            var areAllLargerThanZero = numbers.All(number => number > 0);

            var words = new[] { "lion", "tiger", "snow leopard" };
            var isTigerPresent = words.Contains("tiger");
            var orderByWordsDesc = words.OrderBy(words => words);
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

            // This keyword is used to declare an extention method parameter
            IEnumerable<int> numberss = new[] { 16, 8, 9, -1, 2 };
            var firstNumber = numberss.First();

            var firstOddNumber = numberss.First(number => number % 2 == 1);

            var lastDog = pets.Last(pet => pet.PetType == PetType.Dog);

            var petsOrderedByName = pets.OrderBy(pet => pet.Name);

            var petsOrderedByIdDesc = pets.OrderByDescending(pet => pet.Id);

            var petsOrderByTypeThenName = pets.OrderBy(pet => pet.PetType).ThenBy(pet => pet.Name);

            //var lastPetHeavierThan100 = pets.Last(pet => pet.Weight > 100);

            var lastPetHeavierThan100 = pets.LastOrDefault(pet => pet.Weight > 100);

            var heaviestPet = pets.OrderByDescending(pet => pet.Weight).First();

            var countOfDogs = pets.Count(pet => pet.PetType == PetType.Dog);

            var countOfPetsNamedDeku = pets.LongCount(pet => pet.Name == "Bruce");

            var countOfDogsLighterThan10Kg = pets.Count(pet => pet.PetType == PetType.Dog && pet.Weight < 10);

            var doAllHaveNonEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));

            var homeManyPets = pets.Count();

            var areAllCats = pets.All(pet => pet.PetType == PetType.Cat);



            var isAnyPetNamedAnthony = pets.Any(pet => pet.Name == "Anthony");

            var isAnyFish = pets.Any(pet => pet.PetType == PetType.Fish);
            //name longer than 6 letters and Id thats even number
            var isThereAnySpecificPet = pets.Any(pet => pet.Name.Length > 6 && pet.Id % 2 == 0);
        }
    }


}