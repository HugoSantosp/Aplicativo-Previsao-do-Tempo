using Newtonsoft.Json;



namespace Aplicativo_Previsão_do_Tempo
{

    public class Weather
    {
        public Weather() { 
            this.Results = new Results();
        }    

        [JsonProperty("results")]
        public Results Results { get; set; }



    }
}
