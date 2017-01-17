using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{
    /// <summary>
    /// Program class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
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
            /* sonuç : 
<?xml version="1.0"?>
<Kisi xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Id="1" Adi="Alper" Soyadi="Konuralp">
  <DogumTarihi>1978-06-19T00:00:00</DogumTarihi>
  <Adres Id="1" AdresTipi="Ev">
    <AdresSatiri1>Mehmet Akif Mah.</AdresSatiri1>
    <Ilce>Çekmeköy</Ilce>
    <Il>İstanbul</Il>
  </Adres>
  <Adres Id="2" AdresTipi="Is">
    <AdresSatiri1>Arçelik A.Ş.</AdresSatiri1>
    <AdresSatiri2>Sütlüce</AdresSatiri2>
    <Ilce>Beyoğlu</Ilce>
    <Il>İstanbul</Il>
  </Adres>
</Kisi>
            */

            // string'den deserileştirme ile objeyi alıyoruz.
            var obj = Deserialize<Kisi>(str);

            Console.WriteLine(obj.Id);
        }


        /// <summary>
        /// Serializes the specified object.
        /// </summary>
        /// <typeparam name="T">type parameter</typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>the xml string</returns>
        public static string Serialize<T>(T obj)
        {
            var xs = new XmlSerializer(typeof(T));

            using (var ms = new MemoryStream())
            {
                xs.Serialize(ms, obj);

                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        /// <summary>
        /// Deserializes the specified string.
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="str">The xml string.</param>
        /// <returns>the object</returns>
        public static T Deserialize<T>(string str)
        {
            var xs = new XmlSerializer(typeof(T));

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(str)))
            {
                return (T)xs.Deserialize(ms);
            }
        }

        /// <summary>
        /// json serialize from object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>the json string</returns>
        public static string JsonSerialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }


        /// <summary>
        /// Jsons the deserialize.
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="str">The json string.</param>
        /// <returns>the object</returns>
        public static T JsonDeserialize<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
