using SoftSystemEgzamin2.Models.Abstraction;

namespace SoftSystemEgzamin2.Models
{
    internal class Triangle : Figure
    {
        private int _base { get; set; }
        private int _height { get; set; }

        public Triangle(int @base, int height)
        {
            _base = @base;
            _height = height;
        }

        public override int GetArea()
        {
            return _base * _height / 2;
        }
    }
}
