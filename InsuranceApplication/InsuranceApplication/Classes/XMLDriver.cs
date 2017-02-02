using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace InsuranceApplication.Classes {
    class XMLDriver {
        public static String SerializeXML<T>(T input) {
            string xml = null;
            using (StringWriter sw = new StringWriter()) {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, input);
                try {
                    xml = sw.ToString();
                } catch (Exception ex) {
                    throw ex;
                }
            }
            return xml;
        }

        public static T DeserializeXML<T>(string xml) {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using(StringReader sr = new StringReader(xml)) {
                using(var xmlread = XmlReader.Create(sr)) {
                    return (T)xs.Deserialize(xmlread);
                }
            }
        }
    }
}
