using TesteCsharp.models;
using System.Text.Json;
using TesteCsharp.services;

namespace TesteCsharp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ElevadorService servico = new ElevadorService();
            LeitorService leitor = new LeitorService();

            Console.WriteLine("Andares Menos frequentado");
            servico.andarMenosUtilizado();
            
            Console.WriteLine("Elevador Mais frequentado");
            servico.elevadorMaisFrequentado();

            Console.WriteLine("Elevador Menos frequentado");
            servico.elevadorMenosFrequentado();

            Console.WriteLine("periodo de maior utilização do conjunto de elevadores");
            servico.periodoMaiorUtilizacaoConjuntoElevadores();


        }
    }
}
