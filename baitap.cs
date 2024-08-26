using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04
{
    internal class baitap
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("You have 1000 coins. If you win, you will gain 50 coins. If you lose, you will lose 50 coins.");
            int coin = 1000;
            int a = 0;
            int thang = 0;
            int thua = 0;

            do
            {
                Console.WriteLine("You have to pay 25 coins to start the game");
                if (coin < 25)
                {
                    Console.WriteLine("You don't have enough coins to start the game. END");
                    break;
                }
                coin = coin - 25;
                Random rnd = new Random();
                int comp_num = rnd.Next(1, 100);
                Console.WriteLine(comp_num);
                int man_num = 0;
                for (int i = 0; i < 5; i++) 
                {
                    Console.WriteLine("Your number: ");
                    man_num = int.Parse("0"+Console.ReadLine());
                    if (man_num == comp_num)
                    {
                        Console.WriteLine("Bravo! You are a genius");
                        coin += 50;
                        Console.WriteLine($"You have {coin} coins");
                        thang++;
                        break;
                    }
                    else
                    
                        if (man_num < comp_num)
                            Console.WriteLine("Your guessing number is less than computer number");
                        else Console.WriteLine("Your guessing number is greater than computer number");
                  
                }
                if (man_num != comp_num)
                {
                    Console.WriteLine($"Your number is {man_num} but computer number is {comp_num} ---> You lose!!");
                    thua++;
                    coin -= 50;
                    Console.WriteLine($"You have {coin} coins");
                }
                Console.WriteLine("Do you want to continue? Y/N");
                a++;
                string res = ""+Console.ReadLine();
                if (res.ToUpper().Equals("N"))
                {
                    Console.WriteLine("Bye! See you again");
                    break;
                }
                
            } while (true);
            Console.WriteLine($"So lan thang la: {thang}");
            Console.WriteLine($"So lan thua la: {thua}");
            Console.WriteLine($"So lan da choi la: {a}");
            Console.WriteLine($"So tien con lai la: {coin}");
    }
    }
}


