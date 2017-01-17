Imports System.Xml.Serialization

<XmlRoot>
Public Class Kisi

    Private _id As Long
    Private _adi As String
    Private _soyadi As String
    Private _dogumTarihi As DateTime

    <XmlAttribute>
    Public Property ID() As Long
        Get
            Return _id
        End Get
        Set(ByVal value As Long)
            _id = value
        End Set
    End Property


    <XmlElement>
    Public Property Adi() As String
        Get
            Return _adi
        End Get
        Set(ByVal value As String)
            _adi = value
        End Set
    End Property



    <XmlElement>
    Public Property Soyadi() As String
        Get
            Return _soyadi
        End Get
        Set(ByVal value As String)
            _soyadi = value
        End Set
    End Property


    <XmlElement>
    Public Property DogumTarihi() As DateTime
        Get
            Return _dogumTarihi
        End Get
        Set(ByVal value As DateTime)
            _dogumTarihi = value
        End Set
    End Property


End Class
