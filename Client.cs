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
        public async Task GetData()
        {
            httpClient = new HttpClient();
            string call = "https://narutodb.xyz/api/character?page=1&limit=5";
            string response = await httpClient.GetStringAsync(call);
            //Console.WriteLine(response);
            AllCharacters allCharacters = new AllCharacters();
            allCharacters = JsonSerializer.Deserialize<AllCharacters>(response);
            foreach(var character in allCharacters.characters)
            {
                Console.WriteLine(character);
            }
            Console.WriteLine(allCharacters.characters.Count);
        }
    }
}
