using System;

namespace Assignment1
{
    [Serializable]
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area { get { return Height * Width; } }
    }
}