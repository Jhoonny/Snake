using System;
using System.Threading;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// size of map
			int MaxMapWidth = 80;
			int MaxMapHeight = 25;


			Console.SetBufferSize(MaxMapWidth, MaxMapHeight);
			// drow frame
			HorizontalLine upLine = new HorizontalLine(0,78,0,'*');
			HorizontalLine downLinw = new HorizontalLine(0,78,24,'*');
			VerticalLine leftLine = new VerticalLine(0,24,0,'*');
			VerticalLine rightLine = new VerticalLine(0,24, 78, '*');

			upLine.Draw();
			downLinw.Draw();
			leftLine.Draw();
			rightLine.Draw();

			// drow point draw snake

			Point point = new Point(5, 10, '*');
			Snake snake = new Snake (point, 5, Direction.RIGHT);
			snake.Draw ();

			// draw food

			FoodCreater foodCreator = new FoodCreater (MaxMapWidth, MaxMapHeight, '$');
			Point food = foodCreator.CreateFood ();
			food.Draw ();

			while (true) {

				if(snake.Eat(food)){
					food = foodCreator.CreateFood ();
					food.Draw ();
				}
				else
					snake.Move ();
				
				Thread.Sleep (300);
			

				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey ();
					snake.Hadlekey (key.Key);

					if (key.Key == ConsoleKey.Escape)
						break;
				}

			}

			Console.WriteLine ("--=***=--  E N D  --=***=--");
			Thread.Sleep (300);
			//Console.ReadLine ();
		}
	}
}