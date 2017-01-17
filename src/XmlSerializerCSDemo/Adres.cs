using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{

    /// <summary>
    /// Adres Sýnýfý
    /// </summary>
    [Serializable]
    [XmlRoot]
    [JsonObject]
    public class Adres
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [XmlAttribute]
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the adres tipi.
        /// </summary>
        /// <value>
        /// The adres tipi.
        /// </value>
        [XmlAttribute]
        [JsonProperty("adresTipi")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AdresTipi AdresTipi { get; set; }

        /// <summary>
        /// Gets or sets the adres satiri1.
        /// </summary>
        /// <value>
        /// The adres satiri1.
        /// </value>
        [XmlElement]
        [JsonProperty("adresSatiri1")]
        public string AdresSatiri1 { get; set; }

        /// <summary>
        /// Gets or sets the adres satiri2.
        /// </summary>
        /// <value>
        /// The adres satiri2.
        /// </value>
        [XmlElement]
        [JsonProperty("adresSatiri2")]
        public string AdresSatiri2 { get; set; }

        /// <summary>
        /// Gets or sets the ilce.
        /// </summary>
        /// <value>
        /// The ilce.
        /// </value>
        [XmlElement]
        [JsonProperty("ilce")]
        public string Ilce { get; set; }

        /// <summary>
        /// Gets or sets the il.
        /// </summary>
        /// <value>
        /// The il.
        /// </value>
        [XmlElement]
        [JsonProperty("il")]
        public string Il { get; set; }
    }

}