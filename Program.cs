using System;


namespace NumberGuesser
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            GetAppInfo(); 

            GreetUser(); 

            while (true)
            {
            
                Random random = new Random();

                
                int correctNumber = random.Next(1, 10);

               
                int guess = 0;

                
                Console.WriteLine("Choisis un nombre entre 1 et 10");

                
                while (guess != correctNumber)
                {
                    
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                       
                        PrintColorMessage(ConsoleColor.Red, "Merci de choisir un nombre");

                        
                        continue;
                    }

                    
                    guess = Int32.Parse(input);

                    
                    if (guess != correctNumber)
                    {
                        
                        PrintColorMessage(ConsoleColor.Red, "Mauvais nombre, essaye encore");
                    }
                }

                
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT! Tu as deviné");

                Console.WriteLine("Nouvelle partie ? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }           

        }

        /
        static void GetAppInfo() {
            
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "MH";

          
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

      
        static void GreetUser() {
            Console.WriteLine("Quel est ton prénom ?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Salut {0}, commençons la partie...", inputName);
        }

      
        static void PrintColorMessage(ConsoleColor color, string message) {
           
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
