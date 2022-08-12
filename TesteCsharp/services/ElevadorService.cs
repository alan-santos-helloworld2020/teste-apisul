using ProvaAdmissionalCSharpApisul;

namespace TesteCsharp.services
{
    public class ElevadorService : IElevadorService
    {
        LeitorService leitor = new LeitorService();
        public List<int> andarMenosUtilizado()
        {
            List<int> andares = new List<int>();
            var andar = from el in leitor.findAll() group el by el.andar into SelectAndar select SelectAndar;
            var adr = andar.OrderBy(x=>x.Count()).ToList(); 
            foreach (var item in adr)
            {
                Console.WriteLine($"andar = {item.Key} | visitas = {item.Count()}");
                andares.Add(item.Key);
            }
            return andares;
        }

        public List<char> elevadorMaisFrequentado()
        {
            List<char> keyElevador = new List<char>();
            var elevador = from el in leitor.findAll() group el by el.elevador into SelectElevadores select SelectElevadores;
            Dictionary<char, int> items = new Dictionary<char, int>();
            var elev = elevador.OrderByDescending(x=>x.Count()).ToList();
            foreach (var item in elev)
            {
                Console.WriteLine($"elevador = {item.Key}");
                keyElevador.Add(item.Key);
            }
            return keyElevador;
        }

        public List<char> elevadorMenosFrequentado()
        {
            List<char> keyElevador = new List<char>();
            var elevador = from el in leitor.findAll() group el by el.elevador into SelectElevadores select SelectElevadores;
            var elev = elevador.OrderBy(x=>x.Count()).ToList();
            foreach (var item in elev)
            {
                Console.WriteLine($"elevador = {item.Key}");
                keyElevador.Add(item.Key);
            }

            return keyElevador;            
        }

        public float percentualDeUsoElevadorA()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorB()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorC()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorD()
        {
            throw new NotImplementedException();
        }

        public float percentualDeUsoElevadorE()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            throw new NotImplementedException();
        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            List<char> lisTurno = new List<char>();
            var turno = from p in leitor.findAll() group p by p.turno into SelectTurno select SelectTurno;

            var pe = turno.OrderByDescending(x=>x.Count()).ToList();
            foreach (var item in pe)
            {
               Console.WriteLine($"periodo = {item.Key}");
               lisTurno.Add(item.Key);

            }
            return lisTurno;            
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            throw new NotImplementedException();
        }
    }

}