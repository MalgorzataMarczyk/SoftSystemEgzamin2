using SoftSystemEgzamin2.Models.Abstraction;

namespace SoftSystemEgzamin2.Models
{
    internal class Cube : Figure
    {
        private int _side { get; set; }

        public Cube(int side)
        {
            _side = side;
        }

        public override int GetArea()
        {
            return _side * _side * _side;
        }
    }
}
