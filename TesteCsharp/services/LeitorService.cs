using System.Text.Json;
using TesteCsharp.models;

namespace TesteCsharp.services
{
    public class LeitorService
    {
        public List<Pesquisa> findAll()
        {
           StreamReader leitor = new StreamReader("input.json");
            string jsonString = leitor.ReadToEnd();
            List<Pesquisa> psq = JsonSerializer.Deserialize<List<Pesquisa>>(jsonString)!;
            return psq;

        }
    }
    
}