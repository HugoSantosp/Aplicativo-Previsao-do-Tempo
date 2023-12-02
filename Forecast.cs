using Newtonsoft.Json;

namespace Aplicativo_Previsão_do_Tempo
{
     public class Forecast
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("weekday")]
        public string Weekday { get; set; }

        [JsonProperty("max")]
        public long Max { get; set; }

        [JsonProperty("min")]
        public long Min { get; set; }

        [JsonProperty("cloudiness")]
        public long Cloudiness { get; set; }

        [JsonProperty("rain")]
        public double Rain { get; set; }

        [JsonProperty("rain_probability")]
        public long RainProbability { get; set; }

        [JsonProperty("wind_speedy")]
        public string WindSpeedy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

    }
    public enum Condition { ClearDay, CloudlyDay, Rain };
}
