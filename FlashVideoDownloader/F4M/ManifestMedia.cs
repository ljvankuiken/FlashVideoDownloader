using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlashVideoFiles.F4M
{
    [Serializable]
    public class ManifestMedia
    {
        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlAttribute("bitrate")]
        public int BitRate { get; set; }

        [XmlAttribute("streamId")]
        public string StreamID { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

        [XmlAttribute("bootstrapInfoId")]
        public string BootstrapInfoID { get; set; }

        [XmlAttribute("drmAdditionalHeaderId")]
        public string DRMAdditionalHeaderID { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("alternate")]
        public string Alternate { get; set; }

        [XmlAttribute("label")]
        public string Label { get; set; }

        [XmlAttribute("lang")]
        public string Language { get; set; }

        [XmlAttribute("href")]
        public string Href { get; set; }

        [XmlElement("moov")]
        public string Moov { get; set; }

        [XmlElement("metadata")]
        public string Metadata { get; set; }

        [XmlIgnore]
        public ManifestBootstrapInfo ManifestBootstrapInfo { get; set; }
    }
}
