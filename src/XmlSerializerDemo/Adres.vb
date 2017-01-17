Imports System.Xml.Serialization

''' <summary>
''' Adres Sınıfı
''' </summary>
<XmlRoot>
Public Class Adres
    ''' <summary>
    ''' Gets or sets the identifier.
    ''' </summary>
    ''' <value>
    ''' The identifier.
    ''' </value>
    <XmlAttribute>
    Public Property Id() As Long

    ''' <summary>
    ''' Gets or sets the adres tipi.
    ''' </summary>
    ''' <value>
    ''' The adres tipi.
    ''' </value>
    <XmlAttribute>
    Public Property AdresTipi() As AdresTipi

    ''' <summary>
    ''' Gets or sets the adres satiri1.
    ''' </summary>
    ''' <value>
    ''' The adres satiri1.
    ''' </value>
    <XmlElement>
    Public Property AdresSatiri1() As String

    ''' <summary>
    ''' Gets or sets the adres satiri2.
    ''' </summary>
    ''' <value>
    ''' The adres satiri2.
    ''' </value>
    <XmlElement>
    Public Property AdresSatiri2() As String

    ''' <summary>
    ''' Gets or sets the ilce.
    ''' </summary>
    ''' <value>
    ''' The ilce.
    ''' </value>
    <XmlElement>
    Public Property Ilce() As String

    ''' <summary>
    ''' Gets or sets the il.
    ''' </summary>
    ''' <value>
    ''' The il.
    ''' </value>
    <XmlElement>
    Public Property Il() As String
End Class
