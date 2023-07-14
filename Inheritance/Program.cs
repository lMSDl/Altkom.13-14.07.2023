

using Inheritance.Models;
using Inheritance.Models.DB;

//Shape shape = new Shape("shape1");
//Shape1D shape1d = new Shape1D(12, "shape2");
//Shape2D shape2d = new Shape2D(1, 22, "shape3");

//Console.WriteLine(shape);
//Console.WriteLine(shape1d);
//Console.WriteLine(shape2d);

Point point = new Point();
Line line = new Line(10);

Rectangle rectangle = new Rectangle(12, 15);
Shape2D elipse = new Elipse(10, 10);

List<Shape> shapes = new List<Shape>();
shapes.Add(point);
shapes.Add(line);
shapes.Add(rectangle);
shapes.Add(elipse);

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
}


List<Shape2D> shapes2d = new List<Shape2D>();
shapes.Add(rectangle);
shapes.Add(elipse);

foreach (Shape2D shape in shapes2d)
{
    Console.WriteLine(shape.GetArea());
}


Person person = new Person();
SetPesel(person.PersonalData, 1702129876);


Console.WriteLine(person.Age);


void SetPesel(PersonalData personalData, long pesel)
{
    personalData.PESEL = pesel;
}