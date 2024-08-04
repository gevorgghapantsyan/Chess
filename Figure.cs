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

        public Figure(FigureType type, Color color = 0)
        {
            this.color = color;
            this.type = type;
        }
    }
}
