using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150Activity11
{
    class Dice
    {
        private int numberOfSides;
        private int valueOfDiceFace;

        public Dice()
        {
            numberOfSides = 6;
        }

        //This is the Dice object constructor that takes an integer between 4  and 20, inclusive and sets the number of sides of the die.
        public Dice(int faces)
        {
            if (faces >= 4 && faces <= 20)          //between 4 and 20 inclusive
            {
                this.numberOfSides = faces;         //sets number of sides
            }
            else
            {
                Console.WriteLine("Cant roll a " + faces + "-sided die." + "Here, we'll provide you with a 6-sided die.");  //If the user tries to use a number outside of the 4 to 20 range
                this.numberOfSides = 6;                                                                                      //they will be provided with a 6-sided die instead.
            }
        }

        //This method will perform the action of rolling the die using the int data type
        public int rollTheDice(Dice dice)
        {
            Random random = new Random();               //Here we call the random class in order to simulate the roll and randomness thereof

            dice.valueOfDiceFace = random.Next(1, dice.numberOfSides + 1);      //we set the value of the user's die to the random value while rolling

            return dice.valueOfDiceFace;                                //method returns the int face value of the die roll
        }
    }
}

