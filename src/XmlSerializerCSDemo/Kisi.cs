using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{
    /// <summary>
    /// Kisi Sınıfı
    /// </summary>
    [Serializable]
    [XmlRoot]
    [JsonObject]
    public class Kisi
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
        /// Gets or sets the adi.
        /// </summary>
        /// <value>
        /// The adi.
        /// </value>
        [XmlAttribute]
        [JsonProperty("adi")]
        public string Adi { get; set; }

        /// <summary>
        /// Gets or sets the soyadi.
        /// </summary>
        /// <value>
        /// The soyadi.
        /// </value>
        [XmlAttribute]
        [JsonProperty("soyadi")]
        public string Soyadi { get; set; }

        /// <summary>
        /// Gets or sets the dogum tarihi.
        /// </summary>
        /// <value>
        /// The dogum tarihi.
        /// </value>
        [XmlElement]
        [JsonProperty("dogumTarihi")]
        public DateTime DogumTarihi { get; set; }

        /// <summary>
        /// Gets or sets the adresler.
        /// </summary>
        /// <value>
        /// The adresler.
        /// </value>
        [XmlElement("Adres")]
        [JsonProperty("adresler")]
        public List<Adres> Adresler { get; set; }
    }

}
