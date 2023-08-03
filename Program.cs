using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22_Reflection
{
    internal class Program
    {
        public static void MapProperties(Source source, Destination destination)
        {
            Type src = typeof(Source);
            Type des = typeof(Destination);
            PropertyInfo[] srcprop = src.GetProperties();
            PropertyInfo[] desprop = des.GetProperties();
            foreach (var sprop in srcprop)
            {
                foreach (var dprop in desprop)
                {
                    if (sprop.Name == dprop.Name && sprop.PropertyType == dprop.PropertyType)
                    {
                        Console.WriteLine("Common Properties: " + sprop.Name);
                        var values = sprop.GetValue(source);
                        dprop.SetValue(destination, values);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Source source = new Source();
            Destination destination = new Destination();
            source.ID = 1;
            source.Name = "Test";
            destination.ID = 2;
            destination.Password = "password";
            MapProperties(source, destination);
            Console.WriteLine("Destination Property values ");
            Console.WriteLine("ID: "+destination.ID);
            Console.WriteLine("Password: "+destination.Password);
            Console.ReadKey();
        }
    }
}
