using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutaja eesime sisestada;
            //programm palub kasutajal sisestada number 1-3;
            //kui kasutaja sisestab numbri 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse eesnime esimene t'ht
            //kui kasutaja valib 3, siis kuvatakse eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta number (1-3)");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    UserNameReversed(userName);
                    break;
                case 2:
                    UserNameFirstLetter(userName);
                    break;
                case 3:
                    UserNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void UserNameReversed(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void UserNameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void UserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

    }
}
