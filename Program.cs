using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace pokeApp
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Program
    {
        public static async Task Main()
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/")
            };

            Console.Write("Search for a Pokemon by name or id: ");
            var input = Console.ReadLine();

            User? user = await client.GetFromJsonAsync<User>(input);
            Console.WriteLine($"Name: {user?.Name}");
            Console.WriteLine($"Id: {user?.Id}");

        }
    }
}