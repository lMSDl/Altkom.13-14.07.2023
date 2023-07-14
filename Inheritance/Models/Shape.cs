using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //klasa abstrakcyjna - baza dla innych klas, nie można utworzyć jej instancji
    //każda klasa dziedziczy po klasie Object
    public abstract class Shape /*: Object*/
    {
        private string _name;

        public Shape(string name)
        {
            _name = name;
        }

        //override nadpisuje metodę z klasy bazowej
        //możemy nadpisywać tylko metody abstrakcyjne i virtualne
        public override string ToString()
        {
            return _name;
        }

        //metoda wirtualna - posiada ciało, ale możemy je zmienić w klasach pochodnych
        public virtual void DoSth()
        {

        }
    }
}
