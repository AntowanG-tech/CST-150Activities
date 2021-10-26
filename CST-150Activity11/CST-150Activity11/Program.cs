using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150Activity11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice(20);
            Dice dice2 = new Dice(20);

            rollForInitiative(dice1, dice2);
        }

        private static void rollForInitiative(Dice dice1, Dice dice2)
        {
            int rolls = 1;              //counts rolls made
            bool isSakeEyes = false;      //checks for double 1's rolled

            while (isSakeEyes == false)
            {
                int dieFaceValue1, dieFaceValue2;

                dieFaceValue1 = dice1.rollTheDice(dice1);
                dieFaceValue2 = dice2.rollTheDice(dice2);

                Console.WriteLine("Roll #" + rolls + ": " + dieFaceValue1 + ", " + dieFaceValue2);

                if (dieFaceValue1 == 1 && dieFaceValue2 == 1)
                {
                    isSakeEyes = true;
                    Console.WriteLine("Snake Eyes!! " + "And it only took " + rolls + " to get there.");
                    Console.WriteLine("Both adventurers roll nat 1's. They trip and fall into their own bags of holding! The End.");
                }

                rolls++;
            }
        }
    }
}
