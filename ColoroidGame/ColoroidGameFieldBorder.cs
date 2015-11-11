using System;

namespace ColoroidGame {
	[Flags]
	enum ColoroidGameFieldBorder {
		None = 0x00,
		Left = 0x01,
		Right = 0x02,
		Top = 0x04,
		Bottom = 0x08
	}
}
