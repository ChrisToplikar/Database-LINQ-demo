using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch
            {
                printSpace();
                Console.WriteLine("Error in user input.  Only use Red, Green, or Blue for question 1.  Question 2 must be an number(1-4) Restarting...");
                printSpace();
                doWork();
            }

        }
        public static void printSpace()
        {
            Console.WriteLine("");
        }
        public static void doWork()
        {
            var suppliers = new[]
            {
                //Example: new {SN = 1, SName = "Smith", Status = 20, City = "London"},
                new {SN = 1, SName = "Smith", Status = 20, City = "London"},
                new {SN = 2, SName = "Jones", Status = 10, City = "Paris"},
                new {SN = 3, SName = "Blake", Status = 30, City = "Paris"},
                new {SN = 4, SName = "Clark", Status = 20, City = "London"},
                new {SN = 5, SName = "Adams", Status = 30, City = "Athens"},
            };
            Console.WriteLine("Suppliers array data:");
            foreach (var s in suppliers)
            {
                Console.WriteLine(s);
            }
            printSpace();

            var parts = new[]
            {
                //Example: new {PN = 1, PName = "Nut", Color = "Red", Weight = 12, City = "London"},
                new {PN = 1, PName = "Nut", Color = "Red", Weight = 12, City = "London"},
                new {PN = 2, PName = "Bolt", Color = "Green", Weight = 17, City = "Paris"},
                new {PN = 3, PName = "Screw", Color = "Blue", Weight = 17, City = "Rome"},
                new {PN = 4, PName = "Screw", Color = "Red", Weight = 14, City = "London"},
                new {PN = 5, PName = "Cam", Color = "Blue", Weight = 12, City = "Paris"},
                new {PN = 6, PName = "Cog", Color = "Red", Weight = 19, City = "London"},
            };
            Console.WriteLine("Parts array data:");
            foreach (var p in parts)
            {
                Console.WriteLine(p);
            }
            printSpace();
            var shipment = new[] {
                new {SN = 1, PN = 1, Qty = 300},
                new {SN = 1, PN = 2, Qty = 200},
                new {SN = 1, PN = 3, Qty = 400},
                new {SN = 1, PN = 4, Qty = 200},
                new {SN = 1, PN = 5, Qty = 100},
                new {SN = 1, PN = 6, Qty = 100},
                new {SN = 2, PN = 1, Qty = 300},
                new {SN = 2, PN = 2, Qty = 400},
                new {SN = 3, PN = 2, Qty = 200},
                new {SN = 4, PN = 2, Qty = 200},
                new {SN = 4, PN = 4, Qty = 300},
                new {SN = 4, PN = 5, Qty = 400},

            };
            Console.WriteLine("Shipments array data:");
            foreach (var sh in shipment)
            {
                Console.WriteLine(sh);
            }
            printSpace();
            Console.WriteLine("Select a color, and see all cities that have a part with that color:  ");
            var input = Console.ReadLine().ToLower();
            var cityColors = parts
                .Where(x => x.Color.ToLower() == input)
                .Select(x => x.City).Distinct();
            printSpace();
            Console.WriteLine($"The cities that have parts with color {input}:");
            foreach (var x in cityColors)
            {
                Console.WriteLine(x);
            }
            printSpace();
            Console.WriteLine("Querying suppliers data and displaying only the suppliers names in ascending order(A-Z):");
            var supplierNames = suppliers.
                OrderBy(x => x.SName)
                .Select(x => x.SName);

            foreach (var s in supplierNames)
            {
                Console.WriteLine(s);
            }
            printSpace();
            Console.WriteLine("Select a SN number to query and display the orders for a particular supplier");
            var snInput = Console.ReadLine();


            var lastQuery = from x in shipment
                            join y in parts
                            on x.PN equals y.PN
                            where x.SN == int.Parse(snInput)
                            select new { y.PName, x.Qty };
            printSpace();
            Console.WriteLine($"Below are the part names and quantities for supplier number {snInput}:");
            foreach (var v in lastQuery)
            {
                Console.WriteLine($"Part name: {v.PName}. Qty: {v.Qty}.");
            }
            if (!lastQuery.Any())
            {
                Console.WriteLine($"Supplier Number {snInput} has 0 products");
            }
           
        }
        

    }

}
