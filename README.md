# pokeApp

working GraphQL query:

query samplePokeAPIquery {
  pokemon_v2_pokemon {
    id
    name
    pokemon_v2_pokemontypes {
      pokemon_v2_type {
        name
      }
    }
  }
}
