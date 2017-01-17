Imports System.Xml.Serialization

''' <summary>
''' Kisi Sınıfı
''' </summary>
<XmlRoot>
Public Class Kisi
    ''' <summary>
    ''' Gets or sets the identifier.
    ''' </summary>
    ''' <value>
    ''' The identifier.
    ''' </value>
    <XmlAttribute>
    Public Property Id() As Long

    ''' <summary>
    ''' Gets or sets the adi.
    ''' </summary>
    ''' <value>
    ''' The adi.
    ''' </value>
    <XmlAttribute>
    Public Property Adi() As String

    ''' <summary>
    ''' Gets or sets the soyadi.
    ''' </summary>
    ''' <value>
    ''' The soyadi.
    ''' </value>
    <XmlAttribute>
    Public Property Soyadi() As String

    ''' <summary>
    ''' Gets or sets the dogum tarihi.
    ''' </summary>
    ''' <value>
    ''' The dogum tarihi.
    ''' </value>
    <XmlElement>
    Public Property DogumTarihi() As Date

    ''' <summary>
    ''' Gets or sets the adresler.
    ''' </summary>
    ''' <value>
    ''' The adresler.
    ''' </value>
    <XmlElement("Adres")>
    Public Property Adresler() As List(Of Adres)
End Class
