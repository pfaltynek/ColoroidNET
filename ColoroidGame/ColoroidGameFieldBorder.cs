using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
