namespace SoftUni_CSharp_Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0;
            while (input != "Start")
            {
                if (double.Parse(input) != 0.1 && double.Parse(input) != 0.2 && double.Parse(input) != 0.5 && double.Parse(input) != 1 && double.Parse(input) != 2)
                {
                    Console.WriteLine("Cannot accept " + input);
                }
                else
                {
                    money += double.Parse(input);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    switch (input)
                    {
                        case "Nuts":
                            if (money < 2)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                money -= 2;
                                Console.WriteLine($"Purchased nuts");
                            }
                            break;
                        case "Water":
                            if (money < 0.7)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                money -= 0.7;
                                Console.WriteLine($"Purchased water");
                            }
                            break;
                        case "Crisps":
                            if (money < 1.5)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                money -= 1.5;
                                Console.WriteLine($"Purchased crisps");
                            }
                            break;
                        case "Soda":
                            if (money < 0.8)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                money -= 0.8;
                                Console.WriteLine($"Purchased soda");
                            }
                            break;
                        case "Coke":
                            if (money < 1)
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            else
                            {
                                money -= 1;
                                Console.WriteLine($"Purchased coke");
                            }
                            break;
                        default:
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Change: " + money.ToString("0.00"));
        }
    }
}