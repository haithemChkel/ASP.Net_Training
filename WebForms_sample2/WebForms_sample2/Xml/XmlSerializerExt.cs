using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace WebForms_sample2.Xml
{
    public static class XmlSerializerExt
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public static T DeserializeToObject<T>(string fileContent) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (TextReader sr = new StringReader(fileContent))
            {
                return (T)ser.Deserialize(sr);
            }
        }

        public static List<T> DeserializeToList<T>(string fileContent) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<T>));

            using (TextReader sr = new StringReader(fileContent))
            {
                return (List<T>)ser.Deserialize(sr);
            }
        }
    }
}