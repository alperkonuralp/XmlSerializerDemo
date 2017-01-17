using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{

    /// <summary>
    /// Adres Sýnýfý
    /// </summary>
    [XmlRoot]
    public class Adres
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [XmlAttribute]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the adres tipi.
        /// </summary>
        /// <value>
        /// The adres tipi.
        /// </value>
        [XmlAttribute]
        public AdresTipi AdresTipi { get; set; }

        /// <summary>
        /// Gets or sets the adres satiri1.
        /// </summary>
        /// <value>
        /// The adres satiri1.
        /// </value>
        [XmlElement]
        public string AdresSatiri1 { get; set; }

        /// <summary>
        /// Gets or sets the adres satiri2.
        /// </summary>
        /// <value>
        /// The adres satiri2.
        /// </value>
        [XmlElement]
        public string AdresSatiri2 { get; set; }

        /// <summary>
        /// Gets or sets the ilce.
        /// </summary>
        /// <value>
        /// The ilce.
        /// </value>
        [XmlElement]
        public string Ilce { get; set; }

        /// <summary>
        /// Gets or sets the il.
        /// </summary>
        /// <value>
        /// The il.
        /// </value>
        [XmlElement]
        public string Il { get; set; }
    }

}