using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public abstract class Shape1D : Shape
    {
        //read-only property - nie posiada settera, ma możliwość ustawienia wartości tylko raz w konstruktorze
        public int Width { get; }

        //base - odwołanie się do konstruktora klasy bazowej
        public Shape1D(int width, string name) : base(name)
        {
            Width = width;
        }

        public override string ToString()
        {
            //base odwołanie się do bazowej implementacji wskazanej metody
            return base.ToString() + " o szerokości " + Width;
        }
    }
}
