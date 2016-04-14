using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bjerre.Runkeeper.ValueObjects
{
    public class Trk
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("time")]
        public string Time { get; set; }

        [XmlElement("trkseg")]
        public List<Trkseg> Trkseg { get; set; }
    }
}
