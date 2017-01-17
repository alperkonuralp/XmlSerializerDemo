using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{

    [XmlRoot]
    public class Adres
    {
        [XmlAttribute]
        public long Id { get; set; }

        [XmlAttribute]
        public AdresTipi AdresTipi { get; set; }

        [XmlElement]
        public string AdresSatiri1 { get; set; }

        [XmlElement]
        public string AdresSatiri2 { get; set; }

        [XmlElement]
        public string Ilce { get; set; }

        [XmlElement]
        public string Il { get; set; }
    }

}