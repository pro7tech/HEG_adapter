using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;

namespace BxAdapter {
    public class ProgramsSerializer {
        private const string FileNameForSerializedObjects = "Programs.xml";
        private static string GetFilePath(string path) {
            return path + "\\" + FileNameForSerializedObjects;
        }

        public static void SaveSerializedObjectToFile(Programs programs, string path) {
            XmlSerializer serializer = new XmlSerializer(typeof(Programs));
            TextWriter writer = new StreamWriter(GetFilePath(path), false);
            serializer.Serialize(writer, programs);
            writer.Close();
        }

        public static Programs LoadSerializedObjectFromFile(string path) {
            string fullpath = GetFilePath(path);
            if (!File.Exists(fullpath)) {
                return new Programs();
            }

            Programs programs;
            using (FileStream fs = new FileStream(fullpath, FileMode.Open)) {
                XmlSerializer serializer = new XmlSerializer(typeof(Programs));
                programs = (Programs)serializer.Deserialize(fs);
            }
            return programs;
        }
    }
}
