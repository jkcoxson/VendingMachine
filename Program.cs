using System;
using System.Collections.Generic;

namespace Project_4
{
    class Program
    {
        public static bool quit = false;
        public static int money=0;
        public static Dictionary<int, int> menu = new Dictionary<int, int>();
        public static List<int> accepted = new List<int>();
        static void Main(string[] args)
        {
            menu.Add(1, 50);
            menu.Add(2, 25);
            menu.Add(3, 100);
            menu.Add(4, 10);
            accepted.Add(50);
            accepted.Add(25);
            accepted.Add(10);
            accepted.Add(5);
            while (quit==false)
            {
                Console.WriteLine("Products: 1=Shampoo 50¢, 2=Vinegar 25¢, 3=Flip Flops $1, 4=Bag of Dirt 10¢");
                
                Console.Write("Type what you want instead of getting it yourself: ");
                string input = Console.ReadLine();
                string[] broken = input.Split(' ');
                if (broken[0] == "select")
                {
                    if (broken.Length == 2)
                    {
                        if (Int32.Parse(broken[1]) > 0 && Int32.Parse(broken[1]) < 5)
                        {
                            if (menu[Int32.Parse(broken[1])] > money)
                            {
                                Console.WriteLine("You don't have enough, silly. Give me more money.");

                            }
                            else
                            {
                                Console.WriteLine("Your stuff has been dropped on the floor and it is probably ruined. Have a good day.");
                                money = money - menu[Int32.Parse(broken[1])];
                                Console.WriteLine("You have " + money + " cents left");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter something real for once!");

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("You need to select one value for purchasing");
                    }
                }
                else
                {
                    if (broken[0] == "insert")
                    {
                        if (broken.Length == 2)
                        {
                            if (accepted.Contains(Int32.Parse(broken[1])))
                            {
                                money = money + Int32.Parse(broken[1]);
                            }
                            else
                            {
                                Console.WriteLine("We don't accept that foreign currency. I don't care where you got it, get off my lawn. Here's your money back.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input two values or I'll take your money and not give you anything.");
                        }
                    }
                    else
                    {
                        if (broken[0]== "quit")
                        {
                            quit = true;
                        }
                        else
                        {
                            Console.WriteLine("We don't speak that language, try again.");
                        }
                    }
                }
                
            }
        }
    }
}
