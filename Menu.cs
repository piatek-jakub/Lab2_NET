using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Lab2_NET
{
    public enum Search
    {
        ID,
        NAME,
        NUMBER
    }
    internal class Menu
    {
        public AllCharacters allCharacters;
        public Client client;
        
        public void UI()
        {
            Console.WriteLine("1.Find Naruto Character by ID");
            Console.WriteLine("2.Get first X (1-20) characters");
            Console.WriteLine("3.Exit");
            var userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Write ID of a character (1-1400)");
                    int characterID;
                    if(int.TryParse(Console.ReadLine(),out characterID))
                    {
                        if(characterID < 0 || characterID > 1400)
                        {
                            Console.WriteLine("ID out of range!");
                            return;
                        }
                        string call = "https://narutodb.xyz/api/character/" + characterID;
                        client.GetData(call,Search.ID).Wait();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input - you have to put number!");
                    }

                    break;
                case "2":
                    Console.WriteLine("Write number of characters (1-20)");
                    var numberOfCharacters = Console.ReadLine();
                    break;
                default:

                    break;

            }
        }

        public Menu()
        {
            allCharacters = new AllCharacters();
            client = new Client();
        }
    }
}
