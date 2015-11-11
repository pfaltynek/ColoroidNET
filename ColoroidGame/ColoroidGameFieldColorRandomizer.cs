using System;

namespace ColoroidGame {
	internal static class ColoroidGameFieldColorRandomizer {
		private static Array _colors = Enum.GetValues(typeof(ColoroidGameFieldColor));
		private static Random _rnd = new Random(Environment.TickCount);

		internal static ColoroidGameFieldColor GetNext() {
			return (ColoroidGameFieldColor)_colors.GetValue(_rnd.Next(_colors.Length));
		}
	}
}
