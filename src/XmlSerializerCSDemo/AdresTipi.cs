using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{

    /// <summary>
    /// Adres Tipi enum tipi
    /// </summary>
    [XmlRoot]
    public enum AdresTipi
    {
        /// <summary>
        /// The ev
        /// </summary>
        [XmlEnum]
        Ev,

        /// <summary>
        /// The iþ
        /// </summary>
        [XmlEnum]
        Is
    }

}