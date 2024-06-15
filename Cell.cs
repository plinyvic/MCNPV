using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MCNPV
{
    public struct Cell
    {
        public Func<Vector3, bool> CellDefinition { get; }

        public Cell(Func<Vector3, bool> cellFunc)
        {
            CellDefinition = cellFunc;
        }
    }
}
