using System.Net;

namespace pokeApp.Entities;

public class Ability : HttpClient
{
    public Ability1 ability { get; set; }
    public bool is_hidden { get; set; }
    public int slot { get; set; }
}
