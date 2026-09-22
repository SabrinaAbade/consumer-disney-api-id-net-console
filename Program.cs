using System.Text.Json;

Console.WriteLine("Personagem Disney:");

using HttpClient client = new HttpClient();

string resposta = await client.GetStringAsync(
    "https://api.disneyapi.dev/character/423"
);

using JsonDocument json = JsonDocument.Parse(resposta);

JsonElement personagem = json.RootElement;

string nome = personagem.GetProperty("name").GetString()!;
string imagem = personagem.GetProperty("imageUrl").GetString()!;

Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Imagem: {imagem}");
