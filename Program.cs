using System.ComponentModel;
using System.Text;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Board board = new Board();
            board.Print();
            Console.WriteLine();
            Console.WriteLine("Print the cordinates of figure");
            char x = Convert.ToChar(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Print the type of figure");
            int figureType = Convert.ToInt32(Console.ReadLine());
            FigureType figure = (FigureType)figureType;
            Console.WriteLine("Print the color of figure");
            int color = Convert.ToInt32(Console.ReadLine());
            Color color1 = (Color)color;
            Figure figure1 = new Figure(figure, color1);
            board.AddFigure(figure1, x, y);
            board.Print();
        }
    }
}
