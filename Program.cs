using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTERNAL
{
    class Program
    {
        // New updates

        private static void Main(string[] args)
        {
            Console.WriteLine("       ------ THINK AND GUESS -------");
            Console.WriteLine("\nI SIMPLY WANT YOU TO GUESS THE SECRET NAME. \n(MOREOVER, YOU HAVE 5 CHANCES OF GUESSING) \n          GOODLUCK TO YOU!!!");

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("                    STAGE 1");
            Console.WriteLine("      HINT 1: I have many features that my user find it hard to notice.");
            Console.WriteLine("       HINT 2: I am a helper of man in different ways. ");
            Console.WriteLine("        HINT 3: I end with the letter \"r\". ");
            Console.WriteLine("         HINT 4: I can perform a much more task that you can't do. ");
            Console.WriteLine("");

            string guess = "";
            string option = "";
            string Continue = "x";
            string Quit = "o";
            string SecretName = "calculator";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;



            while (guess != SecretName && !outOfGuesses)

                if (guessCount < guessLimit)
                {

                    Console.Write("     Enter CodeName: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }


            if (outOfGuesses)
            {
                Console.WriteLine(" \n      YOU LOSE!!! \n      TRY AGAIN");
                Console.WriteLine("      POINTS: 0");
                Console.WriteLine("\n");

            }

            else
            {
                Console.WriteLine(" \n      CONGRATULATIONS!!! \n      YOU WON");
                Console.WriteLine("      POINTS: 10");
                Console.WriteLine("\n");


                Console.WriteLine("Enter \"x\" if you want to continue");
                Console.WriteLine("Enter \"o\" if you want to quit ");

                Console.Write("\nEnter Option: ");
                option = Console.ReadLine();

                while ((option != Quit) && (option != Continue))

                    if ((option != Quit) && (option != Continue))
                    {
                        Console.Write("Enter Option: ");
                        option = Console.ReadLine();
                    }

                if (option != Continue)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("GAME OVER");
                    Console.WriteLine("POINTS: 10");
                    Console.WriteLine("\n");
                }
                else
                {
                    string guess2 = "";
                    string SecretName2 = "henry";
                    int guessCount2 = 0;
                    int guessLimit2 = 5;
                    bool outOfGuesses2 = false;

                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("                     STAGE 2");
                    Console.WriteLine("         HINT 1: I am a male gender.");
                    Console.WriteLine("          HINT 2: I love electrical stuffs. ");
                    Console.WriteLine("           HINT 3: I end with the letter \"y\". ");
                    Console.WriteLine("            HINT 4: I love games. ");
                    Console.WriteLine("");




                    while (guess2 != SecretName2 && !outOfGuesses2)

                        if (guessCount2 < guessLimit2)
                        {
                            Console.Write("         Enter CodeName: ");
                            guess2 = Console.ReadLine();
                            guessCount2++;
                        }
                        else
                        {
                            outOfGuesses2 = true;
                        }
                    if (outOfGuesses2)
                    {
                        Console.WriteLine(" \n          YOU LOSE!!! \n          TRY AGAIN");
                        Console.WriteLine("      POINTS: 10");
                        Console.WriteLine("\n");

                    }

                    else
                    {
                        Console.WriteLine(" \n          CONGRATULATIONS!!! \n         YOU WON");
                        Console.WriteLine("        POINTS: 20");
                        Console.WriteLine("\n");


                        Console.WriteLine("Enter \"x\" if you want to continue");
                        Console.WriteLine("Enter \"o\" if you want to quit ");

                        Console.Write("\nEnter Option: ");
                        option = Console.ReadLine();

                        while ((option != Quit) && (option != Continue))

                            if ((option != Quit) && (option != Continue))
                            {
                                Console.Write("Enter Option: ");
                                option = Console.ReadLine();
                            }

                        if (option != Continue)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("GAME OVER");
                            Console.WriteLine("POINTS: 20");
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            string guess3 = "";
                            string SecretName3 = "henry";
                            int guessCount3 = 0;
                            int guessLimit3 = 5;
                            bool outOfGuesses3 = false;

                            Console.WriteLine("\n");
                            Console.WriteLine("\n");
                            Console.WriteLine("                     STAGE 3");
                            Console.WriteLine("         HINT 1: I am a male gender.");
                            Console.WriteLine("          HINT 2: I love electrical stuffs. ");
                            Console.WriteLine("           HINT 3: I end with the letter \"y\". ");
                            Console.WriteLine("            HINT 4: I love games. ");
                            Console.WriteLine("");




                            while (guess3 != SecretName3 && !outOfGuesses3)

                                if (guessCount3 < guessLimit3)
                                {
                                    Console.Write("         Enter CodeName: ");
                                    guess3 = Console.ReadLine();
                                    guessCount2++;
                                }
                                else
                                {
                                    outOfGuesses3 = true;
                                }
                            if (outOfGuesses3)
                            {
                                Console.WriteLine(" \n          YOU LOSE!!! \n          TRY AGAIN");
                                Console.WriteLine("      POINTS: 20");
                                Console.WriteLine("\n");

                            }

                            else
                            {
                                Console.WriteLine(" \n          CONGRATULATIONS!!! \n         YOU WON");
                                Console.WriteLine("        POINTS: 30");
                                Console.WriteLine("\n");


                                Console.WriteLine("Enter \"x\" if you want to continue");
                                Console.WriteLine("Enter \"o\" if you want to quit ");

                                Console.Write("\nEnter Option: ");
                                option = Console.ReadLine();

                                while ((option != Quit) && (option != Continue))

                                    if ((option != Quit) && (option != Continue))
                                    {
                                        Console.Write("Enter Option: ");
                                        option = Console.ReadLine();
                                    }

                                if (option != Continue)
                                {
                                    Console.WriteLine("\n");
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine("POINTS: 30");
                                    Console.WriteLine("\n");
                                }
                                else
                                {
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}







