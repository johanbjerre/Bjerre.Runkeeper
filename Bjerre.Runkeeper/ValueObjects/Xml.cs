using System.Xml.Serialization;

namespace Bjerre.Runkeeper.ValueObjects
{
    [XmlRoot(ElementName = "xml")]
    public class Xml
    {
        [XmlElement("trk")]
        public Trk Trk { get; set; }
    }
}