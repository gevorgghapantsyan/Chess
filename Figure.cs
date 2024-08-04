using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    internal class Figure
    {
        public Color color { get; set; }
        public FigureType type { get; set; }

        public Figure(FigureType type, Color guyn = 0)
        {
            this.color = guyn;
            this.type = type;
        }
    }
}
