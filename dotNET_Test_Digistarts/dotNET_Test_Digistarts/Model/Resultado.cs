using System.ComponentModel;

namespace dotNET_Test_Digistarts.Model
{

    public class Resultado
    {
        public List<Result> Results { get; set; } = new List<Result>();
    }
    public class Result
    {

        [DisplayName("Mortes Confirmadas")]
        public int confirmed { get; set; }

        [DisplayName("Morte por 100k habitantes")]
        public float confirmed_per_100k_inhabitants { get; set; }

        public string? date { get; set; }

        [DisplayName("Data")]
        public DateTime? data { get; set; }

        [DisplayName("Indice de Mortalidade")]
        public float death_rate { get; set; }

        [DisplayName("Mortes")]
        public int deaths { get; set; }

        [DisplayName("População Estimada")]
        public int estimated_population { get; set; }

        [DisplayName("População Estimada em 2019")]
        public int estimated_population_2019 { get; set; }

        [DisplayName("Tipo Local")]
        public string? place_type { get; set; }

        [DisplayName("Estado")]
        public string? state { get; set; }
    }

}
