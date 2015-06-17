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

			Console.Write ("Console colors");
			colors = System.Enum.GetValues (typeof(ConsoleColor));

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
