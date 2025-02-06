using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_4_Roll_dice_with_teacher
{
    internal class Program
    {

        //create meathod rolldice to gernate random number from 1 to 6
        static int RollDice();
        {

                  int retVal = 0;
                   
                  int randomNumber = 0;

                  //process
                  Random random = new Random();

                  randomNumber = Random.Next(1, 7); // gernate a number from 1 to 6
                
                  retVal = randomNumber;

                  return retVal; //decalre retrun value

        }

        static void Main(string[] args)
        {
            //decalrations

            //input
            //user input

            //

            //loop asking for user to input until user types quit

            string userInput = "";
            int userGuess;
            int rollNumber;

            do
            {
                //process if user does not input

                Console.WriteLine(" enter a number from 1 to 6 or type quit to exit ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userInput == "QUIT")
                {
                    break;
                }
                else
                {
                    try
                    {
                        userGuess = Convert.ToInt32(userInput); //coverts input to int and sace to user guess
                        rollNumber = RollDice();// get roll dice number
                                                //determine who win

                        Console.WriteLine(" you rolled " + rollNumber);

                        if (userGuess > rollNumber)
                        {
                            Console.WriteLine(" you win ");
                        }
                        else if (userGuess < rollNumber)
                        {
                            Console.WriteLine(" you lost ry again ");
                        }
                        else 
                        {
                            Console.WriteLine( " it is a tie ");
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please input a valid number");
                    }
                }


            }
            while (userInput != "Quit");

            Console.WriteLine(" the application exits ");

            Console.Read();
            

        }
    }
}
