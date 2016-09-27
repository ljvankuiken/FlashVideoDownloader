using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace FlashVideoFiles.F4M
{
    [Serializable]
    [XmlRoot("manifest")]
    public class F4Manifest
    {
        [XmlElement("id")]
        public string ID { get; set; }

        [XmlElement("label")]
        public string Label { get; set; }

        [XmlElement("lang")]
        public string Language { get; set; }

        [XmlElement("duration")]
        public float Duration { get; set; }

        [XmlElement("startTime")]
        public DateTime StartTime { get; set; }

        [XmlElement("mimeType")]
        public string MimeType { get; set; }

        [XmlElement("streamType")]
        public string StreamType { get; set; }

        [XmlElement("deliveryType")]
        public string DeliveryType { get; set; }

        [XmlElement("baseURL")]
        public string BaseUrl { get; set; }

        [XmlElement("drmAdditionalHeader")]
        public List<ManifestDRMAdditionalHeader> DRMAdditionalHeader { get; set; }

        [XmlElement("bootstrapInfo")]
        public List<ManifestBootstrapInfo> BootstrapInfo { get; set; }

        [XmlElement("media")]
        public List<ManifestMedia> Media { get; set; }

        public static F4Manifest FromXmlString(string xmlString)
        {
            xmlString = System.Text.RegularExpressions.Regex.Replace(xmlString, "xmlns=\".*?\"", "");
            var s = new XmlSerializer(typeof(F4Manifest));
            using (TextReader reader = new StringReader(xmlString))
            {
                var manifest = (F4Manifest)s.Deserialize(reader);
                foreach (var media in manifest.Media)
                    media.ManifestBootstrapInfo = manifest.BootstrapInfo.Where(bootstrap => bootstrap.ID == media.BootstrapInfoID).FirstOrDefault();
                return manifest;
            }
        }
    }
}