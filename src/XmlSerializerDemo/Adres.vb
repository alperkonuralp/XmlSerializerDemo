Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports System.Xml.Serialization

Namespace XmlSerializerDemo

    ''' <summary>
    ''' Adres Sınıfı
    ''' </summary>
    <Serializable, XmlRoot, JsonObject>
    Public Class Adres
        ''' <summary>
        ''' Gets or sets the identifier.
        ''' </summary>
        ''' <value>
        ''' The identifier.
        ''' </value>
        <XmlAttribute, JsonProperty("id")>
        Public Property Id() As Long

        ''' <summary>
        ''' Gets or sets the adres tipi.
        ''' </summary>
        ''' <value>
        ''' The adres tipi.
        ''' </value>
        <XmlAttribute, JsonProperty("adresTipi"), JsonConverter(GetType(StringEnumConverter))>
        Public Property AdresTipi() As AdresTipi

        ''' <summary>
        ''' Gets or sets the adres satiri1.
        ''' </summary>
        ''' <value>
        ''' The adres satiri1.
        ''' </value>
        <XmlElement, JsonProperty("adresSatiri1")>
        Public Property AdresSatiri1() As String

        ''' <summary>
        ''' Gets or sets the adres satiri2.
        ''' </summary>
        ''' <value>
        ''' The adres satiri2.
        ''' </value>
        <XmlElement, JsonProperty("adresSatiri2")>
        Public Property AdresSatiri2() As String

        ''' <summary>
        ''' Gets or sets the ilce.
        ''' </summary>
        ''' <value>
        ''' The ilce.
        ''' </value>
        <XmlElement, JsonProperty("ilce")>
        Public Property Ilce() As String

        ''' <summary>
        ''' Gets or sets the il.
        ''' </summary>
        ''' <value>
        ''' The il.
        ''' </value>
        <XmlElement, JsonProperty("il")>
        Public Property Il() As String
    End Class

End Namespace
