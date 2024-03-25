using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2_NET
{
    internal class Client
    {
        public HttpClient httpClient;
        public async Task GetData(string call, Search search)
        {
            httpClient = new HttpClient();
            string response = await httpClient.GetStringAsync(call);
            Console.WriteLine(response);

            switch (search)
            {
                case Search.ID:
                    Character character = new Character();
                    character = JsonSerializer.Deserialize<Character>(response);
                    Console.WriteLine(character);
                    break;
                case Search.NAME:
                    Character name = new Character();
                    character = JsonSerializer.Deserialize<Character>(response);
                    Console.WriteLine(character);
                    break;
                case Search.NUMBER:
                    AllCharacters allCharacters = new AllCharacters();
                    allCharacters = JsonSerializer.Deserialize<AllCharacters>(response);
                    foreach (var characterIterator in allCharacters.characters)
                    {
                        Console.WriteLine(characterIterator);
                    }
                    break;
            }
            
        }
    }
}
