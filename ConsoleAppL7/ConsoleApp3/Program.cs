using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Address new_adr = new Address();
            new_adr.Country = "UA";
            new_adr.City = "Inu";
            new_adr.Street = "Vesta";
            new_adr.House = 1234;
            new_adr.Room = 156;
            new_adr.Index = "0x00000";
            new_adr.get_add();
            Console.ReadKey();
        }
        class Address
        {
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public int House { get; set; }
            public int Room { get; set; }
            public string Index { get; set; }

            public void get_add()
            {
                Console.WriteLine(@"Country: {0}, City: {1}, Street: {2},
House: {3}, Room: {4}, Index: {5}",Country,City,Street,House,Room,Index);

            }
        }

    }
}
