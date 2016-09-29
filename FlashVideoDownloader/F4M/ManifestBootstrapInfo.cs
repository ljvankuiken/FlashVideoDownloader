using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FlashVideoFiles.F4M
{
    [Serializable]
    public class ManifestBootstrapInfo
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlAttribute("profile")]
        public string Profile { get; set; }

        [XmlAttribute("url")]
        public string Url { get; set; }

        [XmlText]
        public string BootstrapInfo { get; set; }

        [XmlIgnore]
        public BootstrapInfoBox BootstrapInfoBox
        {
            get
            {
                if (BootstrapInfo == null)
                    return null;
                else
                    return BootstrapInfoBox.FromBase64String(BootstrapInfo);
            }
        }
    }

}
