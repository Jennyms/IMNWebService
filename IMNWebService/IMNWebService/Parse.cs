using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace IMNWebService
{
    public static class Parse
    {
        public static T ParseXML<T>(this string texto) where T : class
        {
            var reader = XmlReader.Create(texto.Trim().ToClean().ToStream(), 
                new XmlReaderSettings { ConformanceLevel = ConformanceLevel.Document });
            return new XmlSerializer(typeof(T)).Deserialize(reader) as T;
        }

        public static string ToClean(this string texto)
        {
            texto = texto.Replace("<string xmlns=\"http://tempuri.org/\">", "");
            texto = texto.Replace("</string>", "");
            return texto;
        }

        public static Stream ToStream(this string texto)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(texto);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
