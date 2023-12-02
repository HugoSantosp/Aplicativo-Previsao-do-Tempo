using Newtonsoft.Json;

namespace Aplicativo_Previsão_do_Tempo
{
    public class GeoIP
    {

        [JsonProperty("results")]
        public Results Results { get; set; }

    }
}
