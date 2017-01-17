Imports Newtonsoft.Json
Imports System.Xml.Serialization

Namespace XmlSerializerDemo
    ''' <summary>
    ''' Kisi Sınıfı
    ''' </summary>
    <Serializable, XmlRoot, JsonObject>
    Public Class Kisi
        ''' <summary>
        ''' Gets or sets the identifier.
        ''' </summary>
        ''' <value>
        ''' The identifier.
        ''' </value>
        <XmlAttribute, JsonProperty("id")>
        Public Property Id() As Long

        ''' <summary>
        ''' Gets or sets the adi.
        ''' </summary>
        ''' <value>
        ''' The adi.
        ''' </value>
        <XmlAttribute, JsonProperty("adi")>
        Public Property Adi() As String

        ''' <summary>
        ''' Gets or sets the soyadi.
        ''' </summary>
        ''' <value>
        ''' The soyadi.
        ''' </value>
        <XmlAttribute, JsonProperty("soyadi")>
        Public Property Soyadi() As String

        ''' <summary>
        ''' Gets or sets the dogum tarihi.
        ''' </summary>
        ''' <value>
        ''' The dogum tarihi.
        ''' </value>
        <XmlElement, JsonProperty("dogumTarihi")>
        Public Property DogumTarihi() As Date

        ''' <summary>
        ''' Gets or sets the adresler.
        ''' </summary>
        ''' <value>
        ''' The adresler.
        ''' </value>
        <XmlElement("Adres"), JsonProperty("adresler")>
        Public Property Adresler() As List(Of Adres)
    End Class

End Namespace
