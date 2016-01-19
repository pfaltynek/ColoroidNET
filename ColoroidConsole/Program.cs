using System;
using ColoroidGame;

namespace ColoroidNET {
	class MainClass {

		#region game logo related

		private static string[] _logo = {
			// . = backround
			// W = White
			// B = Blue
			// R = Red
			// G = Green
			// C = Cyan
			// Y = Yellow
			// D = Dark Gray
			"................................................................................",
			"...WWWWWWWW..............WWWW..................................WWWW........WWWW.",
			"...WBBBBBBW..............WGGW..................................WYYW........WDDW.",
			".WWWBBBBBBWWW............WGGW..................................WYYW........WDDW.",
			".WBBWWWWWWBBW............WGGW..................................WWWW........WDDW.",
			".WBBW....WBBW..WWWWWWWW..WGGW..WWWWWWWW..WWWWWWWWWW..WWWWWWWW..WWWW..WWWWWWWDDW.",
			".WBBW....WWWW..WRRRRRRW..WGGW..WRRRRRRW..WCCWWCCCCW..WRRRRRRW..WYYW..WDDDDDDDDW.",
			".WBBW........WWWRRRRRRWWWWGGWWWWRRRRRRWWWWCCWWCCCCWWWWRRRRRRWWWWYYWWWWDDDDDDDDW.",
			".WBBW........WRRWWWWWWRRWWGGWWRRWWWWWWRRWWCCCCWWWWWWRRWWWWWWRRWWYYWWDDWWWWWWDDW.",
			".WBBW........WRRW....WRRWWGGWWRRW....WRRWWCCCCW....WRRW....WRRWWYYWWDDW....WDDW.",
			".WBBW........WRRW....WRRWWGGWWRRW....WRRWWCCWWW....WRRW....WRRWWYYWWDDW....WDDW.",
			".WBBW....WWWWWRRW....WRRWWGGWWRRW....WRRWWCCW......WRRW....WRRWWYYWWDDW....WDDW.",
			".WBBW....WBBWWRRW....WRRWWGGWWRRW....WRRWWCCW......WRRW....WRRWWYYWWDDW....WDDW.",
			".WBBWWWWWWBBWWRRWWWWWWRRWWGGWWRRWWWWWWRRWWCCW......WRRWWWWWWRRWWYYWWDDWWWWWWDDW.",
			".WWWBBBBBBWWWWWWRRRRRRWWWWGGWWWWRRRRRRWWWWCCW......WWWRRRRRRWWWWYYWWWWDDDDDDDDW.",
			"...WBBBBBBW....WRRRRRRW..WGGW..WRRRRRRW..WCCW........WRRRRRRW..WYYW..WDDDDDDDDW.",
			"...WWWWWWWW....WWWWWWWW..WWWW..WWWWWWWW..WWWW........WWWWWWWW..WWWW..WWWWWWWWWW.",
			"................................................................................"
		};

		private static int GetLogoMaxWidth() {
			int w = 0;

			for (int i = 0; i < _logo.Length; i++) {
				if (_logo[i].Length > w) {
					w = _logo[i].Length;
				}
			}

			return w;
		}

		public static void TestGameLogoTall() {
			int w = Console.WindowWidth;
			int lw = GetLogoMaxWidth();
			int padleft = 0;

			Console.WriteLine();

			padleft = (w - lw) / 2;

			for (int i = 0; i < _logo.Length; i++) {
				for (int j = 0; j < padleft; j++) {
					Console.Write(" ");
				}

				for (int j = 0; j < _logo[i].Length; j++) {
					Console.BackgroundColor = DecodeConsoleLogoColor(_logo[i][j]);
					Console.Write(' ');
				}
				if (!Console.CursorLeft.Equals(0)) {
					Console.WriteLine();
				}
			}
		}

		public static void TestGameLogoHalf() {
			int w = Console.WindowWidth;
			int lw = GetLogoMaxWidth();
			int padleft = 0;

			Console.WriteLine();

			padleft = (w - lw) / 2;

			for (int i = 0; i < _logo.Length; i += 2) {
				for (int j = 0; j < padleft; j++) {
					Console.Write(" ");
				}

				for (int j = 0; j < _logo[i].Length; j++) {
					if (_logo[i][j].Equals(_logo[i + 1][j])) {
						Console.BackgroundColor = DecodeConsoleLogoColor(_logo[i][j]);
						Console.Write(' ');
					}
					else {
						Console.BackgroundColor = DecodeConsoleLogoColor(_logo[i][j]);
						Console.ForegroundColor = DecodeConsoleLogoColor(_logo[i + 1][j]);
						Console.Write('\u2584');
					}
				}
				if (!Console.CursorLeft.Equals(0)) {
					Console.WriteLine();
				}
			}
		}

		private static ConsoleColor DecodeConsoleLogoColor(char c) {
			switch (c) {
				case '.':
					return ConsoleColor.Black;
				case 'B':
					return ConsoleColor.Blue;
				case 'W':
					return ConsoleColor.White;
				case 'R':
					return ConsoleColor.Red;
				case 'G':
					return ConsoleColor.Green;
				case 'C':
					return ConsoleColor.Cyan;
				case 'D':
					return ConsoleColor.DarkGray;
				case 'Y':
					return ConsoleColor.Yellow;
				default:
					throw new ArgumentOutOfRangeException("Unknown console logo color symbol");
			}
		}

		#endregion

		static void ConsoleColorsAndBoxesTest() {
			Array colors;
			int max_len = 0, row;

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.BackgroundColor = ConsoleColor.Black;
			//Console.Clear ();

			Console.CursorLeft = 0;
			//Console.SetCursorPosition (0, 0);
			row = Console.CursorTop;

			Console.Write("Console colors ({0}x{1})", Console.WindowWidth, Console.WindowHeight);
			Console.Write(" ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Write("\u2580\u2584\u2580\u2584\u2580\u2584\u2580\u2584");
			Console.CursorTop++;

			colors = System.Enum.GetValues(typeof(ConsoleColor));

			//get maximum length of color name first
			foreach (var item in colors) {
				if (item.ToString().Length > max_len) {
					max_len = item.ToString().Length;
				}
			}

			foreach (var item in colors) {
				Console.CursorLeft = 0;
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.BackgroundColor = ConsoleColor.Black;
				Console.Write(item.ToString());
				Console.CursorLeft = max_len + 1;
				Console.BackgroundColor = (ConsoleColor)item;
				Console.Write("          ");
				Console.CursorTop++;
			}
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.WriteLine();

			Console.WriteLine();
			Console.WriteLine("\u250C\u2500\u2510");
			Console.WriteLine("\u2502 \u2502");
			Console.WriteLine("\u2514\u2500\u2518");
		}

		public static void TestGameEnums() {
			foreach (var item in Enum.GetValues(typeof(ColoroidGameSize))) {
				Console.WriteLine("{0,3}    {1}", (int)item, item.ToString());
			}

			Console.WriteLine();

			foreach (var item in Enum.GetValues(typeof(ColoroidGameFieldColor))) {
				Console.WriteLine("{0,3}    {1}", (int)item, item.ToString());
			}
		}

		private static void WriteDivider() {
			int w = Console.WindowWidth;

			for (int i = 0; i < w; i++) {
				Console.Write("-");
			}
			Console.WriteLine();
		}

		public static void Main(string[] args) {
			ConsoleColor orig_fg, orig_bg;
			orig_fg = Console.ForegroundColor;
			orig_bg = Console.BackgroundColor;

			Console.ForegroundColor = ConsoleColor.Gray;
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine();

			WriteDivider();
			WriteDivider();
			ConsoleColorsAndBoxesTest();
			WriteDivider();
			TestGameEnums();
			WriteDivider();
			TestGameLogoTall();
			WriteDivider();
			TestGameLogoHalf();
			WriteDivider();

			Console.WriteLine();

			Console.ForegroundColor = orig_fg;
			Console.BackgroundColor = orig_bg;
		}
	}
}
