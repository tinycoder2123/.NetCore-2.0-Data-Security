using System;
using System.Xml.Serialization;

namespace Assignment1
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [Serializable]
    public abstract class Shape
    {
        public string Colour { get; set; }
        public abstract double Area { get; }
    }
}