using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{
    [XmlRoot]
    public class Kisi
    {
        [XmlAttribute]
        public long Id { get; set; }

        [XmlAttribute]
        public string Adi { get; set; }

        [XmlAttribute]
        public string Soyadi { get; set; }

        [XmlElement]
        public DateTime DogumTarihi { get; set; }

        [XmlElement("Adres")]
        public List<Adres> Adresler { get; set; }
    }

}
