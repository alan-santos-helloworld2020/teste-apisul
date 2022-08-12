using ProvaAdmissionalCSharpApisul;

namespace TesteCsharp.services
{
    public class ElevadorService : IElevadorService
    {
        LeitorService leitor = new LeitorService();
        public List<int> andarMenosUtilizado()
        {
            
            List<int> numeros = new List<int>();
            leitor.findAll().ForEach(x =>
            {
                numeros.Add(x.andar);
            });
            List<int> andares = numeros.GroupBy(p => p).Where(g => g.Count() == 1)
            .Select(c => c.Key).ToList();
            return andares;

        }

        public List<char> elevadorMaisFrequentado()
        {
            throw new NotImplementedException();
        }

        public List<char> elevadorMenosFrequentado()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            throw new NotImplementedException();
        }
    }

}