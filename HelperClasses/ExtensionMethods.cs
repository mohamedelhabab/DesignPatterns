using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPatterns.HelperClasses
{
    public static class ExtensionMethods
    {
        public static T DeepCopyByBinaryFormatter<T>(this T type)
        {           
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(stream,type);

                stream.Seek(0, SeekOrigin.Begin);

                T copy = (T)formatter.Deserialize(stream);

                return copy;
            }
        }
        public static T DeepCopyByXmlFormatter<T>(this T type)
        {
            using (var stream = new MemoryStream())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(stream, type);

                stream.Seek(0, SeekOrigin.Begin);

                T copy = (T)xmlSerializer.Deserialize(stream);

                return copy;
            }
        }
    }
}
