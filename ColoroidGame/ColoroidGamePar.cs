using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoroidGame {
	internal static class ColoroidGamePar {
		static int GetColoroidGamePar(ColoroidGameSize size) {
			switch (size){
				case ColoroidGameSize.Size4x4:
					return 7;
				case ColoroidGameSize.Size5x5:
					return 9;
				case ColoroidGameSize.Size6x6:
					return 11;
				case ColoroidGameSize.Size7x7:
					return 13;
				case ColoroidGameSize.Size8x8:
					return 15;
				case ColoroidGameSize.Size9x9:
					return 17;
				case ColoroidGameSize.Size10x10:
					return 19;
				case ColoroidGameSize.Size11x11:
					return 20;
				case ColoroidGameSize.Size12x12:
					return 22;
				case ColoroidGameSize.Size13x13:
					return 24;
				case ColoroidGameSize.Size14x14:
					return 26;
				case ColoroidGameSize.Size15x15:
					return 28;
				case ColoroidGameSize.Size16x16:
					return 30;
				case ColoroidGameSize.Size17x17:
					return 32;
				case ColoroidGameSize.Size18x18:
					return 34;
				case ColoroidGameSize.Size19x19:
					return 36;
				case ColoroidGameSize.Size20x20:
					return 38;
				case ColoroidGameSize.Size21x21:
					return 39;
				case ColoroidGameSize.Size22x22:
					return 41;
				case ColoroidGameSize.Size23x23:
					return 43;
				case ColoroidGameSize.Size24x24:
					return 45;
				case ColoroidGameSize.Size25x25:
					return 47;
				case ColoroidGameSize.Size26x26:
					return 49;
				case ColoroidGameSize.Size27x27:
					return 51;
				case ColoroidGameSize.Size28x28:
					return 53;
				case ColoroidGameSize.Size29x29:
					return 55;
				case ColoroidGameSize.Size30x30:
					return 57;
				case ColoroidGameSize.Size31x31:
					return 58;
				case ColoroidGameSize.Size32x32:
					return 60;
				case ColoroidGameSize.Size33x33:
					return 62;
				case ColoroidGameSize.Size34x34:
					return 64;
				case ColoroidGameSize.Size35x35:
					return 66;
				default:
					throw new ArgumentOutOfRangeException(string.Format("Unknown Coloroid game size '{0}'", size));
			}
		}
	}
}
