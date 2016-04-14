using System.Xml.Serialization;

namespace Bjerre.Runkeeper.ValueObjects
{
    public class Trkpt
    {
        [XmlAttribute(AttributeName = "lat")]
        public string Lat { get; set; }

        [XmlAttribute(AttributeName = "lon")]
        public string Lon { get; set; }

        [XmlElement(ElementName = "ele")]
        public string Ele { get; set; }

        [XmlElement(ElementName = "time")]
        public string Time { get; set; }
    }
}