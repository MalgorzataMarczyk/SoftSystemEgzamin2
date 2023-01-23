namespace SoftSystemEgzamin2.Models.Abstraction
{
    abstract class Figure : IComparable<Figure>
    {
        public int CompareTo(Figure? other)
        {
            if (other == null)
                return 1;

            return GetArea() - other.GetArea();

        }

        public abstract int GetArea();
    }
}
