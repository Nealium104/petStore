using System;
using System.Text.Json;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
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
                }
                Console.WriteLine("Press 1 to add a product");
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