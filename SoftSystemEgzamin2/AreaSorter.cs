using SoftSystemEgzamin2.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftSystemEgzamin2
{
    internal class AreaSorter
    {
        public List<Figure> SortAreas(List<Figure> figures)
        {
            figures.Sort();
            return figures;
        }
    }
}
