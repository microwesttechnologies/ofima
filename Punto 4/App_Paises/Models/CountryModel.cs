using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace App_Paises.Models
{
    public class CountryModel
    {
        [JsonPropertyName("name")]
        public Name? Names { get; set; }

        [JsonPropertyName("cca2")]
        public string? Cca2 { get; set; }

        [JsonPropertyName("currencies")]
        public Dictionary<string, Currency>? Currencies { get; set; }

        [JsonPropertyName("capital")]
        public List<string> Capital { get; set; } = new List<string>();

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("flags")]
        public Flags? Bandera { get; set; }

        public string? CurrencyCode => Currencies?.Keys.FirstOrDefault();
        public string? CurrencyName => Currencies?.Values.FirstOrDefault()?.Name;

        public class Name
        {
            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Currency
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("symbol")]
            public string? Symbol { get; set; }
        }

        public class Flags
        {
            [JsonPropertyName("svg")]
            public string? Svg { get; set; }
        }
    }
}
