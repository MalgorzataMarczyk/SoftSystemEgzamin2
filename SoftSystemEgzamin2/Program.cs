using SoftSystemEgzamin2.Models;
using SoftSystemEgzamin2.Models.Abstraction;

namespace SoftSystemEgzamin2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Square square1 = new Square(2);
            Square square2 = new Square(5);
            Square square3 = new Square(9);

            Triangle triangle1 = new Triangle(3, 6);
            Triangle triangle2 = new Triangle(1, 6);
            Triangle triangle3 = new Triangle(2, 4);

            Cube cube1 = new Cube(5);

            List<Figure> figures = new List<Figure>
            {
                cube1,
                square1,
                square2,
                square3,
                triangle1,
                triangle2,
                triangle3,
            };

            AreaSorter areaSorter = new AreaSorter();

            List<Figure> result = areaSorter.SortAreas(figures);

            foreach (var figure in result.Select((value, i) => new { i, value }))
            {
                Console.WriteLine($"{figure.i}: object: {figure.value.GetType().Name} with area: {figure.value.GetArea()}");
            }
            #endregion

            #region Taks2
            PasswordGenerator passwordGenerator = new PasswordGenerator("[2{A,B,C,D,E,f,g}][1{*,$,%,@}][2{1,2,3}]");
            Console.WriteLine(passwordGenerator.GeneratePassword());
            #endregion
        }
    }
}