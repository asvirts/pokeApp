using System.Net.Http.Json;
using pokeApp.Entities;

namespace pokeApp
{

    public class Program
    {
        public static async Task Main()
        {
            using var client = new HttpClient()
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/")
            };

            await client.GetFromJsonAsync(Pokemon);

            string input = "";

            while (input != "exit")
            {
                Console.Write("Search for a Pokemon by Id or type 'exit' to exit the app: ");
                input = Console.ReadLine().ToLower();
                Console.WriteLine(input);
            }

            return;

        }
    }
}