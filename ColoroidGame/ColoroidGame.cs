using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoroidGame {
	public class ColoroidGame {

		#region consts

		private const int GameSizeMax = 35;
		private const int GameSizeMin = 4;
		private const int GameSizeDefault = GameSizeMin;
		//private const int GameParsSize = GameSizeMax - GameSizeMin + 1;

		#endregion

		#region static items

		private static Random _rnd = new Random((int)DateTime.Now.Ticks);
		private static int[] _pars = {
			7, 9, 11, 13, 15, 17, 19, // 4-10
			20, 22, 24, 26, 28, 30, 32, 34, 36, 38, //11-20
			39, 41, 43, 45, 47, 49, 51, 53, 55, 57, //21-30
			58, 60, 62, 64, 66 //31-35
		};



		#endregion

		#region ctor

		public ColoroidGame() {

		}

		#endregion
	}
}
