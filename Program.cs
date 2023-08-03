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
            Console.WriteLine("Enter Id for source: ");
            source.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name for source: ");
            source.Name = Console.ReadLine();
            Console.WriteLine("Enter Id for destination: ");
            destination.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Password for destination: ");
            destination.Password = Console.ReadLine();
            MapProperties(source, destination);
            Console.WriteLine("Destination Property values ");
            Console.WriteLine("ID: "+destination.ID);
            Console.WriteLine("Password: "+destination.Password);
            Console.ReadKey();
        }
    }
}
