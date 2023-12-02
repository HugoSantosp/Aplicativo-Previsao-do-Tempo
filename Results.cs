using Newtonsoft.Json;

namespace Aplicativo_Previsão_do_Tempo
{

    public class Results
    {

        [JsonProperty("temp")]
        public long Temp { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("condition_code")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long ConditionCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("currently")]
        public string Currently { get; set; }

        [JsonProperty("cid")]
        public string Cid { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }

        [JsonProperty("cloudiness")]
        public long Cloudiness { get; set; }

        [JsonProperty("rain")]
        public long Rain { get; set; }

        [JsonProperty("wind_speedy")]
        public string WindSpeedy { get; set; }

        [JsonProperty("wind_direction")]
        public long WindDirection { get; set; }

        [JsonProperty("wind_cardinal")]
        public string WindCardinal { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("moon_phase")]
        public string MoonPhase { get; set; }

        [JsonProperty("condition_slug")]
        public string ConditionSlug { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("forecast")]
        public Forecast[] Forecast { get; set; }


        // RESULTADO DE GEIP

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }



    }


}
