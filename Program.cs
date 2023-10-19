using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace pokeApp
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }

    public class Program
    {
        public static async Task Main()
        {
            using HttpClient client = new()
            {
                BaseAddress = new Uri("https://pokeapi.co/api/v2/")
            };

            Console.Write("Search for a Pokemon by name or id: ");
            var input = Console.ReadLine();

            Pokemon? pokemon = await client.GetFromJsonAsync<Pokemon>($"pokemon/{input}");
            Console.WriteLine($"Name: {pokemon?.Name}");
            Console.WriteLine($"Id: {pokemon?.Id}");
            Console.WriteLine($"Type: {pokemon?.Type}");
        }
    }
}