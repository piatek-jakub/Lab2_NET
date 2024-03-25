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
            Console.WriteLine("2.Get Naruto Character by Name");
            Console.WriteLine("3.Get first X (1-20) characters");
            Console.WriteLine("4.Exit");
            var userInput = Console.ReadLine();
            string call = "";
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
                        call = "https://narutodb.xyz/api/character/" + characterID;
                        client.GetData(call,Search.ID).Wait();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input - you have to put number!");
                    }

                    break;

                case "2":
                    string characterName;
                    Console.WriteLine("Write Name of a character");
                    characterName = Console.ReadLine();
                    call = "https://narutodb.xyz/api/character/search?name=" + characterName;
                    client.GetData(call, Search.NAME).Wait();
                    break;

                case "3":
                    Console.WriteLine("Write number of characters (1-20)");
                    int numberOfCharacters;
                    if (int.TryParse(Console.ReadLine(), out numberOfCharacters))
                    {
                        if (numberOfCharacters < 0 || numberOfCharacters > 20)
                        {
                            Console.WriteLine("ID out of range!");
                            return;
                        }
                        call = "https://narutodb.xyz/api/character?page=1&limit=" + numberOfCharacters;
                        client.GetData(call, Search.NUMBER).Wait();
                    }
                    else
                    {
                        Console.WriteLine("Wrong input - you have to put number!");
                    }
                    break;

                case "4":
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
