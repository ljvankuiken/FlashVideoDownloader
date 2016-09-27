using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlashVideoFiles.F4M
{
    [Serializable]
    public class ManifestDRMAdditionalHeader
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlText]
        public string AdditionalHeader { get; set; }
    }
}
