using System.Collections.Generic;
using System.Xml.Serialization;

namespace Bjerre.Runkeeper.ValueObjects
{
    public class Trkseg
    {
        [XmlElement("trkpt")]
        public List<Trkpt> Trkpt { get; set; }
    }
}