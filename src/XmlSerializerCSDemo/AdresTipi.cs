using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializerCSDemo
{

    [XmlRoot]
    public enum AdresTipi
    {
        [XmlEnum]
        Ev,

        [XmlEnum]
        Is
    }

}