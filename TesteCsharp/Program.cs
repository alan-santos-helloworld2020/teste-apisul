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

            Console.WriteLine("Lista de andares ordenada por frequencia");
            servico.andarMenosUtilizado();

            Console.WriteLine("\n\n");

            Console.WriteLine("Elevador Mais frequentado");
            servico.elevadorMaisFrequentado();

            Console.WriteLine("\n\n");

            Console.WriteLine("Elevador Menos frequentado");
            servico.elevadorMenosFrequentado();

            Console.WriteLine("\n\n");

            Console.WriteLine("periodo de maior utilização do conjunto de elevadores");
            servico.periodoMaiorUtilizacaoConjuntoElevadores();

            Console.WriteLine("\n");

            Console.WriteLine("percentual de uso elevador A");
            servico.percentualDeUsoElevadorA();

            Console.WriteLine("\n");

            Console.WriteLine("percentual de uso elevador B");
            servico.percentualDeUsoElevadorB();

            Console.WriteLine("\n");

            Console.WriteLine("percentual de uso elevador C");
            servico.percentualDeUsoElevadorC();

            Console.WriteLine("\n");

            Console.WriteLine("percentual de uso elevador D");
            servico.percentualDeUsoElevadorD();

            Console.WriteLine("\n");

            Console.WriteLine("percentual de uso elevador E");
            servico.percentualDeUsoElevadorE();

        }
    }
}
