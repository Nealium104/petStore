using System;
using System.Text.Json;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add cat food or 2 to add a dog leash");
            Console.WriteLine("Type 'exit' to quit");

            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    CatFood newCatFood = new CatFood();

                    Console.Write("Please type the name of the cat food: ");
                    newCatFood.Name = Console.ReadLine();

                    Console.Write("Please type the price of the food (no dollar sign): ");
                    newCatFood.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Please type how much is currently in stock: ");
                    newCatFood.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Please enter a description: ");
                    newCatFood.Description = Console.ReadLine();

                    Console.Write("Please enter the weight of your cat food in pounds: ");
                    newCatFood.WeightPounds = double.Parse(Console.ReadLine());

                    Console.Write("Is your cat food specifically for kittens? Type true if so, false if not ");
                    newCatFood.KittenFood = bool.Parse(Console.ReadLine());

                    Console.Write(JsonSerializer.Serialize(newCatFood));
                    Console.WriteLine($"Added cat food {newCatFood.Name} with a price of {newCatFood.Price} a weight of {newCatFood.WeightPounds} which is '{newCatFood.Description}'. It is kitten food: {newCatFood.KittenFood}");
                } else if (userInput == "2") 
                {
                    DogLeash newDogLeash = new DogLeash();

                    Console.Write("Please name your dog leash: ");
                    newDogLeash.Name = Console.ReadLine();

                    Console.Write("Please give your dog leash a price using only numbers: ");
                    newDogLeash.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Please give the number of dog leashes in stock: ");
                    newDogLeash.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Please write a description for your leash: ");
                    newDogLeash.Description = Console.ReadLine();

                    Console.Write("Please state how long your dog leash is in inches using only numbers: ");
                    newDogLeash.LengthInches = int.Parse(Console.ReadLine());

                    Console.Write("Please state what material your dog leash is made of: ");
                    newDogLeash.Material = Console.ReadLine();

                    Console.WriteLine($"Added new dog leash {newDogLeash.Name}, with a price of {newDogLeash.Price}, a length in inches of {newDogLeash.LengthInches}, made of {newDogLeash.Material}. It is a '{newDogLeash.Description}'. There are currently {newDogLeash.Quantity} in stock.");
                }
                Console.WriteLine("Press 1 to add a cat food or 2 to add a dog leash");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
            }
        }
    }

    class Product
    {
        public string Name;
        public decimal Price;
        public int Quantity;
        public string Description;
    }

    class CatFood : Product
    {
        public double WeightPounds;
        public bool KittenFood;
    }

    class DogLeash : Product
    {
        public int LengthInches;
        public string Material;
    }
}