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

			while (true) {

				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey ();
					snake.Hadlekey (key.Key);

					if (key.Key == ConsoleKey.Escape)
						break;
				}
				Thread.Sleep (300);
				snake.Move ();
			}

			Console.WriteLine ("--==--  E N D  --==--");
			Thread.Sleep (300);
			//Console.ReadLine ();
		}
	}
}