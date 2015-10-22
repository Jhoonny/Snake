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
			Walls walls = new Walls(MaxMapWidth, MaxMapHeight);
			walls.Draw();
			

			// drow point draw snake

			Point point = new Point(5, 10, '*');
			Snake snake = new Snake (point, 5, Direction.RIGHT);
			snake.Draw ();

			// draw food

			FoodCreater foodCreator = new FoodCreater (MaxMapWidth, MaxMapHeight, '$');
			Point food = foodCreator.CreateFood ();
			//Console.ForegroundColor = ConsoleColor.Cyan;
			food.Draw ();

			while (true) {
				// data de perete
				if (walls.IsHit (snake) || snake.IsHitTail()) break;

				// daca maninca

				if(snake.Eat(food)){
					food = foodCreator.CreateFood ();
					food.Draw ();
				}
				else
					snake.Move ();
				
				Thread.Sleep (200);
			

				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey ();
					snake.Hadlekey (key.Key);

					if (key.Key == ConsoleKey.Escape)
						break;
				}

			}
			// END


			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(MaxMapWidth/3 , 10);
			Console.WriteLine ("--=***=--  E N D  --=***=--");
			Console.SetCursorPosition(MaxMapWidth/3 , 12);
			//Thread.Sleep (300);
			//Console.ReadLine ();


		}
	}
}