using System;
using System.Xml.Serialization;

namespace ConsoleApp13
{
    public class Program
    {
        [XmlIgnore] public string MyProperty { get; set; }

        private static void Main(string[] args)
        {
            Console.WriteLine($"nameof(MyProperty) = {nameof(MyProperty)}");
            Console.WriteLine($"MyProperty = {typeof(Program).GetProperties()[0].Name}");
        }
    }
}
