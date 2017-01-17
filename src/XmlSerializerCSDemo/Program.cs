using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // kişi objesini oluşturalım
            var kisi = new Kisi
            {
                Id = 1,
                Adi = "Alper",
                Soyadi = "Konuralp",
                DogumTarihi = new DateTime(1978, 6, 19),
                Adresler = new List<Adres>
                {
                    new Adres {
                        Id = 1,
                        AdresTipi = AdresTipi.Ev,
                        AdresSatiri1 = "Mehmet Akif Mah.",
                        Ilce = "Çekmeköy",
                        Il = "İstanbul"
                    },
                    new Adres {
                        Id = 2,
                        AdresTipi = AdresTipi.Is,
                        AdresSatiri1 = "Arçelik A.Ş.",
                        AdresSatiri2 = "Sütlüce",
                        Ilce = "Beyoğlu",
                        Il = "İstanbul"
                    }
                }
            };

            // xml serileştirme ile string e dönüştürelim.
            var str = Serialize(kisi);

            Console.WriteLine(str);

            // string'den deserileştirme ile objeyi alıyoruz.
            var obj = Deserialize<Kisi>(str);

            Console.WriteLine(obj.Id);
        }


        public static string Serialize<T>(T obj)
        {
            var xs = new XmlSerializer(typeof(T));

            using (var ms = new MemoryStream())
            {
                xs.Serialize(ms, obj);

                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }
        public static T Deserialize<T>(string str)
        {
            var xs = new XmlSerializer(typeof(T));

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(str)))
            {
                return (T)xs.Deserialize(ms);
            }
        }
    }
}
