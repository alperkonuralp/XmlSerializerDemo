Imports System.IO
Imports System.Text
Imports System.Xml.Serialization

Module Module1

    Sub Main()

        Dim kisi = New Kisi
        With kisi
            .ID = 1
            .Adi = "Alper"
            .Soyadi = "Konuralp"
            .DogumTarihi = New DateTime(1978, 6, 19)
        End With

        Dim res = Serialize(kisi)

        Console.WriteLine(res)

    End Sub


    Public Function Serialize(Of T)(obj As T) As String
        Dim xmlSerializer = New XmlSerializer(GetType(T))

        Using ms = New MemoryStream
            xmlSerializer.Serialize(ms, obj)
            Return Encoding.UTF8.GetString(ms.ToArray)
        End Using
    End Function


End Module
