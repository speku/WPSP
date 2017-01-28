using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

// author: Maximilian Roeck - Matrikelnummer: 185594

namespace PlayerCards
{
    public class Spieler
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Position { get; set; }
        public string Rueckennummer { get; set; }
        public string Seit { get; set; }
        public string GeburtsDatum { get; set; }
        public string GroesseInCm { get; set; }
        public string GewichtInKg { get; set; }
        public string SpieleInBundesliga { get; set; }
        public string ToreInBundesliga { get; set; }
        public string Nation { get; set; }
        public string Laenderspiele { get; set; }

        // used for simple retrieval of images
        [XmlIgnoreAttribute]
        public string VollerName => Name + " " + Vorname;
        // so that we can add Player objects to the combo box and get a nice string representation
        public override string ToString()
        {
            return VollerName;
        }
    }
}
