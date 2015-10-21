using System;
using System.Threading;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.SetBufferSize(80, 25);
			// drow frame
			HorizontalLine upLine = new HorizontalLine(0,78,0,'*');
			HorizontalLine downLinw = new HorizontalLine(0,78,24,'*');
			VerticalLine leftLine = new VerticalLine(0,24,0,'*');
			VerticalLine rightLine = new VerticalLine(0,24, 78, '*');

			upLine.Draw();
			downLinw.Draw();
			leftLine.Draw();
			rightLine.Draw();

			// drow point

			Point point = new Point(5, 10, '*');
			Snake snake = new Snake (point, 5, Direction.RIGHT);
			snake.Draw ();

			for (int i = 0; i < 10; i++) {
				snake.Move ();
				Thread.Sleep (300);
			}


			Console.ReadLine ();
		}
	}
}