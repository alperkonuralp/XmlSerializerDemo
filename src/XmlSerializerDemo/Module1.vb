Imports System.IO
Imports System.Text
Imports System.Xml.Serialization
Imports Newtonsoft.Json

Module Module1

    Sub Main()


        ' kişi objesini oluşturalım
        Dim kisi = New Kisi With {
            .Id = 1,
            .Adi = "Alper",
            .Soyadi = "Konuralp",
            .DogumTarihi = New Date(1978, 6, 19),
            .Adresler = New List(Of Adres) From {
                New Adres With {
                    .Id = 1,
                    .AdresTipi = AdresTipi.Ev,
                    .AdresSatiri1 = "Mehmet Akif Mah.",
                    .Ilce = "Çekmeköy",
                    .Il = "İstanbul"
                },
                New Adres With {
                    .Id = 2,
                    .AdresTipi = AdresTipi.Is,
                    .AdresSatiri1 = "Arçelik A.Ş.",
                    .AdresSatiri2 = "Sütlüce",
                    .Ilce = "Beyoğlu",
                    .Il = "İstanbul"
                }
            }
        }

        ' xml serileştirme ile string e dönüştürelim.
        Dim str = Serialize(kisi)

        Console.WriteLine(str)
        'sonuç : 
        '<?xml version="1.0"?>
        '<Kisi xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Id="1" Adi="Alper" Soyadi="Konuralp">
        '  <DogumTarihi>1978-06-19T00:00:00</DogumTarihi>
        '  <Adres Id="1" AdresTipi="Ev">
        '    <AdresSatiri1>Mehmet Akif Mah.</AdresSatiri1>
        '    <Ilce>Çekmeköy</Ilce>
        '    <Il>İstanbul</Il>
        '  </Adres>
        '  <Adres Id="2" AdresTipi="Is">
        '    <AdresSatiri1>Arçelik A.Ş.</AdresSatiri1>
        '    <AdresSatiri2>Sütlüce</AdresSatiri2>
        '    <Ilce>Beyoğlu</Ilce>
        '    <Il>İstanbul</Il>
        '  </Adres>
        '</Kisi>
        '            

        ' string'den deserileştirme ile objeyi alıyoruz.
        Dim obj = Deserialize(Of Kisi)(str)

        Console.WriteLine(obj.Id)


    End Sub


    ''' <summary>
    ''' Serializes the specified object.
    ''' </summary>
    ''' <typeparam name="T">type parameter</typeparam>
    ''' <param name="obj">The object.</param>
    ''' <returns>the xml string</returns>
    Public Function Serialize(Of T)(ByVal obj As T) As String
        Dim xs = New XmlSerializer(GetType(T))

        Using ms = New MemoryStream()
            xs.Serialize(ms, obj)

            Return Encoding.UTF8.GetString(ms.ToArray())
        End Using
    End Function

    ''' <summary>
    ''' Deserializes the specified string.
    ''' </summary>
    ''' <typeparam name="T">Type parameter</typeparam>
    ''' <param name="str">The xml string.</param>
    ''' <returns>the object</returns>
    Public Function Deserialize(Of T)(ByVal str As String) As T
        Dim xs = New XmlSerializer(GetType(T))

        Using ms = New MemoryStream(Encoding.UTF8.GetBytes(str))
            Return CType(xs.Deserialize(ms), T)
        End Using
    End Function

    ''' <summary>
    ''' json serialize from object.
    ''' </summary>
    ''' <param name="obj">The object.</param>
    ''' <returns>the json string</returns>
    Public Function JsonSerialize(ByVal obj As Object) As String
        Return JsonConvert.SerializeObject(obj)
    End Function


    ''' <summary>
    ''' Jsons the deserialize.
    ''' </summary>
    ''' <typeparam name="T">Type parameter</typeparam>
    ''' <param name="str">The json string.</param>
    ''' <returns>the object</returns>
    Public Function JsonDeserialize(Of T)(ByVal str As String) As T
        Return JsonConvert.DeserializeObject(Of T)(str)
    End Function


End Module
