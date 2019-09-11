
using System;



namespace Raad_het_getal
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxAantalBeurten = 5;
            int aantalBeurten = 0;
           
            bool nietgeraden = true;
            Random rand = new Random();
            int deradegetal = rand.Next(0, 10);

            while (nietgeraden)
            {
                


                int beurtenOver = (maxAantalBeurten - aantalBeurten);

                if (aantalBeurten < maxAantalBeurten)
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("De computer heeft een getal in zijn hoofd, raad het getal tussen 0 en 10 (u heeft nog maximaal {0} beurten over) : ", beurtenOver);
                    string stringgetal = Console.ReadLine();

                    try
                    {
                        int getal = Int32.Parse(stringgetal);

                        if (getal == deradegetal)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Bingo, je hebt het goed geraden!!");
                            Console.WriteLine("Wilt u nog een spel doen? (Y/N): ");
                            string nogEenKeer = Console.ReadLine();
                            if (nogEenKeer == "Y" || nogEenKeer == "y")
                            {
                                nietgeraden = true;
                                aantalBeurten = 0;
                                deradegetal = rand.Next(0, 10);
                                continue;
                            }
                            else
                            {
                                break;
                            }

                        }
                        else if (getal > deradegetal)
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fout! Het getal moet lager. ");
                            aantalBeurten++;
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fout! Het getal moet hoger. ");
                            aantalBeurten++;
                            continue;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Het invoer moet een getal zijn"); ;
                    }
                }
                else
                {
                    Console.WriteLine("Game Over, u heeft het helaas niet geraden! Het getal was {0}",deradegetal);
                    Console.WriteLine("Wilt u het nog een keer proberen? (Y/N): ");
                    string nogEenKeer = Console.ReadLine();
                    if (nogEenKeer=="Y" || nogEenKeer=="y")
                    {
                        nietgeraden = true;
                        aantalBeurten = 0;
                        deradegetal = rand.Next(0, 10);
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
               
                
                }
            }
        }
    }

