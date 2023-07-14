using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models.DB
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public int Age { 
            get 
            { 
                return DateTime.Now.Year - (1900 + int.Parse(PersonalData.PESEL.ToString().Substring(0, 2))); 
            } 
        }
        public PersonalData PersonalData { get; } = new PersonalData();
    }
}
