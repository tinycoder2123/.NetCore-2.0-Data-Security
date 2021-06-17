using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Shapes.xml";
            var listOfShapes = new List<Shape>
                {
                new Circle { Colour = "Red", Radius = 2.5 },
                new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Colour = "Green", Radius = 8 },
                new Circle { Colour = "Purple", Radius = 12.3 },
                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
                };
            XmlSerializer serializerXml = new XmlSerializer(typeof(List<Shape>));
            System.IO.FileStream fileXmlSerialize = System.IO.File.Create(filePath);
            serializerXml.Serialize(fileXmlSerialize, listOfShapes);
            fileXmlSerialize.Close();
            using (StreamReader fileXml = new StreamReader(filePath))
            {
                List<Shape> loadedShapesXml = serializerXml.Deserialize(fileXml) as List<Shape>;
                foreach (Shape item in loadedShapesXml)
                {
                    Console.WriteLine($"{item.GetType().Name} is {item.Colour} and has an area of { item.Area}");
                }
            }
            Console.ReadLine();
        }
    }
}