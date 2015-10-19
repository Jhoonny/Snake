using System;

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

			Point point = new Point(40, 12, 'X');
			Snake snake = new Snake (point, 15, Direction.LEFT);
			snake.Draw ();


			Console.ReadLine ();
		}
	}
}