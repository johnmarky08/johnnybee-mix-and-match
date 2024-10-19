namespace johnnybee_mix_and_match
{
    internal class Program
    {
        static void Main()
        {
            //Developed by Nico Gabriel Domingo and John Marky Natividad

            //JOHNNYBEE MIX AND MATCH
            //Price and Discount
            const decimal price = 150.00m;
            const decimal seniorDiscount = 0.20m;

            //Meals
            string meal1 = "1-Piece Chickenjoy";
            string meal2 = "Jolly Spaghetti";
            string meal3 = "Burger Steak";

            //Sides
            string side1 = "French Fries";
            string side2 = "Mash Potato";
            string side3 = "Buttered Corn";

            //Drinks
            string drink1 = "Coke";
            string drink2 = "Sprite";
            string drink3 = "Iced Tea";

            int set = 0;
            string isSenior = "";

            Console.WriteLine("===================================");
            Console.WriteLine("Welcome to Johnnybee Mix and Match!");
            Console.WriteLine("===================================\n");

            //Choose a meal
            Console.WriteLine($"Please select a meal:\n[ 1 ] - {meal1}\n[ 2 ] - {meal2}\n[ 3 ] - {meal3}");
            Console.Write("\nYour Meal: ");

            string chosenMeal = Console.ReadLine() ?? "";
            switch (chosenMeal)
            {
                case "1":
                    {
                        chosenMeal = meal1;
                        break;
                    }
                case "2":
                    {
                        chosenMeal = meal2;
                        break;
                    }
                case "3":
                    {
                        chosenMeal = meal3;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Meal Selection! Exiting...");
                        return;
                    }
            }

            //Choose a sides
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"\nPlease select a side:\n[ 1 ] - {side1}\n[ 2 ] - {side2}\n[ 3 ] - {side3}");
            Console.Write("\nYour Side: ");

            string chosenSide = Console.ReadLine() ?? "";
            switch (chosenSide)
            {
                case "1":
                    {
                        chosenSide = side1;
                        break;
                    }
                case "2":
                    {
                        chosenSide = side2;
                        break;
                    }
                case "3":
                    {
                        chosenSide = side3;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Side Selection! Exiting...");
                        return;
                    }
            }

            //Choose a drink
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"\nPlease select a drink:\n[ 1 ] - {drink1}\n[ 2 ] - {drink2}\n[ 3 ] - {drink3}");
            Console.Write("\nYour Drink: ");

            string chosenDrink = Console.ReadLine() ?? "";
            switch (chosenDrink)
            {
                case "1":
                    {
                        chosenDrink = drink1;
                        break;
                    }
                case "2":
                    {
                        chosenDrink = drink2;
                        break;
                    }
                case "3":
                    {
                        chosenDrink = drink3;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Drink Selection! Exiting...");
                        return;
                    }
            }

            Console.WriteLine("\n---------------------");
            Console.WriteLine($"\nPrice: PHP{price} per set\n");

            //Quantity
            Console.Write($"How many sets do you want? ");

            try
            {
                set = int.Parse(Console.ReadLine() ?? "");

                if (set <= 0)
                {
                    Console.WriteLine("Invalid Set! Exiting...");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid Set! Exiting...");
                return;
            }

            //Is Senior Citizen?
            Console.Write("Are you a senior citizen? Yes/No? ");
            isSenior = Console.ReadLine() ?? "";
            isSenior = isSenior.ToLower();

            //Caculate Total Price
            decimal totalPrice = price * set;

            if (isSenior == "yes") totalPrice -= (totalPrice * seniorDiscount);

            //Finalize
            Console.WriteLine("\n---------------------");
            Console.WriteLine($"\nYOUR ORDER\n\n{set} set/s of the following:\nMeal - {chosenMeal}\nSide - {chosenSide}\nDrink - {chosenDrink}\n\nTotal Price: PHP{Math.Round(totalPrice, 2)}");
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nThank you for ordering at Johnnybee! Please come again! Exiting...");
        }
    }
}
