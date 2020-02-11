using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public void ShowPerson()
        {
            if (Id != 0) Console.WriteLine($"Id: {Id}");
            if (FirstName != null) Console.WriteLine($"First Name: {FirstName}");
            if (LastName != null) Console.WriteLine($"Last Name: {LastName}");
            if (BirthYear != 0) Console.WriteLine($"Year of birth: {BirthYear}");
            if (DeathYear != 0) Console.WriteLine($"Year of death: {DeathYear}");
            if (Father != null) Console.WriteLine($"Father's name: {Father.FirstName}, ID: {Father.Id}");
            if (Mother != null) Console.WriteLine($"Mother's name: {Mother.FirstName}, ID: {Mother.Id}");
        }
    }
}
