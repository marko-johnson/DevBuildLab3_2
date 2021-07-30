using System;
using System.Collections.Generic;

namespace Lab3_2
{
    class Program
    {



        static void Main(string[] args)
        {
            Dictionary<string, decimal> item = new Dictionary<string, decimal>();

            item["turkey"] = 0.99m;
            item["ham"] = 0.59m;
            item["salami"] = 1.59m;
            item["cheddar"] = 2.09m;


            // Display Menu
            Console.WriteLine("Item" + "\t\tPrice");
            Console.WriteLine("==============================");
            foreach (var pair in item)
            {
                Console.WriteLine($"{pair.Key}" + $"\t\t{pair.Value}");
            }


            while (true)
            {
                // User Prompts
                Console.Write("\nWould you like to (A)dd , (R)emove , (C)hange an item or (Q)uit: ");
                string entry = Console.ReadLine();


                if (entry == "A" || entry == "a")
                {
                    Console.Write("\nYou entered \"A\".  Please add an item: ");
                    string delicutName = Console.ReadLine();


                    /*
                    if delicutName exists in dictionary
                    {
                        Console.WriteLine("this item already exists");
                    }
                    */

                    if (item.ContainsKey(delicutName))
                    {
                        Console.WriteLine("this item already exists");
                    }
                    else
                    {

                        Console.Write("Enter price: ");
                        string price = Console.ReadLine();
                        decimal delicutPrice;
                        decimal.TryParse(price, out delicutPrice);
                        item[delicutName] = delicutPrice;
                        Console.WriteLine();


                        // Updated Menu Display
                        Console.WriteLine("Updated Menu");
                        Console.WriteLine("Item" + "\t\tPrice");
                        Console.WriteLine("==============================");
                        foreach (var pair in item)
                        {
                            Console.WriteLine($"{pair.Key}" + $"\t\t{pair.Value}");
                        }
                    }

                }
                else if (entry == "R" || entry == "r")
                {
                    Console.Write("You entered \"R\".  What item would you like to remove?: ");
                    string delicutName = Console.ReadLine();
                    item.Remove(delicutName);


                    foreach (var pair in item)
                    {
                        Console.WriteLine($"{pair.Key}" + $"\t\t{pair.Value}");
                    }

                }
                else if (entry == "C" || entry == "c")
                {
                    Console.Write("You entered \"C\".  What item would you like to change?: ");

                    string delicutName = Console.ReadLine();

                    //Print price of selected deli item
                    Console.WriteLine(item[delicutName]);


                    Console.Write("Enter price: ");
                    string price = Console.ReadLine();
                    decimal delicutPrice;
                    decimal.TryParse(price, out delicutPrice);
                    item[delicutName] = delicutPrice;
                    Console.WriteLine();

                    // Updated Menu Display
                    Console.WriteLine("Updated Menu");
                    Console.WriteLine("Item" + "\t\tPrice");
                    Console.WriteLine("==============================");
                    foreach (var pair in item)
                    {
                        Console.WriteLine($"{pair.Key}" + $"\t\t{pair.Value}");
                    }

                }
                else if (entry == "Q" || entry == "q")
                {
                    Console.WriteLine("You entered \"Q\" to quit.  Thank you. Byeee");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection");

                }
            }
        }
    }
}
