using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.Algorithms.Satish.StringAsnmt
{
    class MatrixRowColumnTest
    {
        internal  static void Run()
        {
            int[,] input = { { 0, 1, 2 },
                       {2, 1, 0 },
                       {1, 2, 3 }
            };

            MatrixZeroRowColumn.MakeRowColumn(input);

            int[,] input1 = { { 1, 1, 2 },
                       {2, 1, 0 },
                       {1, 2, 3 }
            };

            MatrixZeroRowColumn.MakeRowColumn(input1);

        }
        
    }
}
