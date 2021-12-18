using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Mnr
{
    [Serializable]
    public class Update
    {
        public int Version { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }

        public Update() { }

        public Update(int Version, string Link, string Name)
        {
            this.Version = Version;
            this.Link = Link;
            this.Name = Name;
        }

        public static Update Deserialize(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Update));
                return (Update)serializer.Deserialize(fs);
            }
        }

    }
}
