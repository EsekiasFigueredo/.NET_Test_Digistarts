using dotNET_Test_Digistarts.Model;
using RestSharp;
using RestSharp.Serialization.Json;

namespace dotNET_Test_Digistarts.Logic
{
    public class ResultadoLogic
    {
        public Resultado resultadoLogica()
        {
            var client = new RestClient("https://api.brasil.io/v1/dataset/covid19/caso/data/?search=&date=&state=&place_type=state&is_last=&city_ibge_code=");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Token 8b34c604f8c467c5950550f6870bde20dc5229fb");
            IRestResponse response = client.Execute(request);
            Resultado res = new JsonDeserializer().Deserialize<Resultado>(response);
            Resultado resultado = new();
                resultado.Results= res.Results.Select(o => new Result()
                {
                    confirmed = o.confirmed,
                    confirmed_per_100k_inhabitants = o.confirmed_per_100k_inhabitants,
                    date =Convert.ToDateTime(o.date).ToShortDateString()   ,
                    death_rate = o.death_rate,
                    deaths = o.deaths,
                    estimated_population = o.estimated_population,
                    estimated_population_2019 = o.estimated_population_2019,
                    state = o.state
                }).DistinctBy(o => o.state).OrderBy(o => o.state).ToList();            
            return resultado;
        }
    }
}
