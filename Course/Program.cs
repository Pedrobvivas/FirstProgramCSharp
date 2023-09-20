using System;
using System.Runtime.Serialization;
using System.Globalization;
using System.Formats.Asn1;
using System.Net.Mail;

namespace Course
{
    class Program

    {
        static void Main(string[] args)
        {
            List<Entities> entities = new List<Entities>();
         

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine(CultureInfo.InvariantCulture));
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                entities.Add(new Entities(id,name,salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employye id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
       
            Entities data = entities.Find(x=> x.id == searchId);
            if (data != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                data.calculate(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach (Entities entity in entities)
            {
                Console.WriteLine(entity);
            }



        }
    }
} 