using System;

namespace ColoroidNET {
	class MainClass {
		static void ConsoleColorsAndBoxesTest () {
			ConsoleColor orig_fg, orig_bg;
			Array colors;
			int max_len = 0, row = 1;

			Console.SetCursorPosition (0, 0);
			orig_fg = Console.ForegroundColor;
			orig_bg = Console.BackgroundColor;

			Console.SetWindowSize(80, 50);

			Console.Write ("Console colors ({0}x{1})", Console.WindowWidth, Console.WindowHeight);
			Console.Write(" ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Write("\u2580\u2584\u2580\u2584\u2580\u2584\u2580\u2584");

			colors = System.Enum.GetValues (typeof(ConsoleColor));

			//get maximum length of color name first
			foreach (var item in colors) {
				if (item.ToString ().Length > max_len) {
					max_len = item.ToString ().Length;
				}
			}

			foreach (var item in colors) {
				Console.SetCursorPosition (0, row);
				Console.ForegroundColor = orig_fg;
				Console.BackgroundColor = orig_bg;
				Console.Write (item.ToString ());
				Console.SetCursorPosition (max_len + 1, row);
				Console.BackgroundColor = (ConsoleColor)item;
				Console.Write ("          ");
				row++;
			}
			Console.ForegroundColor = orig_fg;
			Console.BackgroundColor = orig_bg;
			Console.WriteLine ();

			Console.WriteLine ();
			Console.WriteLine ("\u250C\u2500\u2510");
			Console.WriteLine ("\u2502 \u2502");
			Console.WriteLine ("\u2514\u2500\u2518");
		}

		public static void Main (string[] args) {
			ConsoleColorsAndBoxesTest ();
		}
	}
}
