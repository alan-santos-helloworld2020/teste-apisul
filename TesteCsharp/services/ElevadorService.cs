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
                Console.WriteLine($"elevador = {item.Key} | frequencia = {item.Count()}");
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
                Console.WriteLine($"elevador = {item.Key} | frequencia = {item.Count()}");
                keyElevador.Add(item.Key);
            }

            return keyElevador;            
        }

        public float percentualDeUsoElevadorA()
        {
            float tmUsoGeral = leitor.findAll().Count();
            float qtUseElevador = leitor.findAll().Where(x=>x.elevador.ToString()=="A").Count(); 
            float resp = (100 / tmUsoGeral) * qtUseElevador;
            Console.WriteLine(resp);
            return resp;            
        }

        public float percentualDeUsoElevadorB()
        {
            float tmUsoGeral = leitor.findAll().Count();
            float qtUseElevador = leitor.findAll().Where(x=>x.elevador.ToString()=="B").Count(); 
            float resp = (100 / tmUsoGeral) * qtUseElevador;
            Console.WriteLine(resp);
            return resp;  
        }

        public float percentualDeUsoElevadorC()
        {
            float tmUsoGeral = leitor.findAll().Count();
            float qtUseElevador = leitor.findAll().Where(x=>x.elevador.ToString()=="C").Count(); 
            float resp = (100 / tmUsoGeral) * qtUseElevador;
            Console.WriteLine(resp);
            return resp;  
        }

        public float percentualDeUsoElevadorD()
        {
            float tmUsoGeral = leitor.findAll().Count();
            float qtUseElevador = leitor.findAll().Where(x=>x.elevador.ToString()=="D").Count(); 
            float resp = (100 / tmUsoGeral) * qtUseElevador;
            Console.WriteLine(resp);
            return resp;  
        }

        public float percentualDeUsoElevadorE()
        {
            float tmUsoGeral = leitor.findAll().Count();
            float qtUseElevador = leitor.findAll().Where(x=>x.elevador.ToString()=="E").Count(); 
            float resp = (100 / tmUsoGeral) * qtUseElevador;
            Console.WriteLine(resp);
            return resp;  
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
               Console.WriteLine($"periodo = {item.Key} | total= {item.Count()}");
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