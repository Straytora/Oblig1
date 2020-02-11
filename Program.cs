using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1
{
    class Program
    {
        private static List<Person> showRoyal = RoyalFamily();
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'help' to start.");
            while (true)
            {
                var input = Console.ReadLine();
                Console.WriteLine();

                input = input.ToLower();

                if(input == "help")
                {
                    ShowHelp();
                }
                else if (input == "list")
                {
                    foreach (var person in showRoyal)
                    {
                        person.ShowPerson();
                        Console.WriteLine();
                    }
                }

                else if (input.Length > 3 && input.Substring(0, 3) == "id ")
                {
                    var getIdNo = input.Substring(3);
                    var parseIdNo = int.Parse(getIdNo);
                    var idNo = showRoyal.FindIndex(x => x.Id == parseIdNo);

                    var personId = showRoyal[idNo];
                    personId.ShowPerson();
                    ShowChildren(personId);
                }
                else
                {
                    Console.WriteLine("ID not found, or invalid ID. Try again or write \"help\".");
                    continue;
                }
            }
        }

        private static void ShowHelp()
        {
            Console.WriteLine("Write 'help' to get a list of all the functions you can do.");
            Console.WriteLine("Write 'list' to get a list of all the people.");
            Console.WriteLine("Write 'id' + a number to get information about the person.(i.e. 'id 5')");
        }

        private static void ShowChildren(Person parentId)
        {
            foreach(var child in showRoyal)
            {
                if (child.Father == parentId || child.Mother == parentId)
                {
                    Console.WriteLine($"Child: {child.FirstName} - Id: {child.Id}, ");
                }
            }
        }

        private static List<Person> RoyalFamily()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            var listRoyal = new List<Person>
            {
                sverreMagnus, ingridAlexandra, haakon, metteMarit, marius, harald, sonja, olav
            };
            return listRoyal;
        }
    }
}
