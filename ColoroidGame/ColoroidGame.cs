using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoroidGame {
	public class ColoroidGame {
		#region ctor

		public ColoroidGame() {

		}

		#endregion

		#region properties

		private ColoroidGameField[,] _game_fields = null;

		private int _steps = 0;
		public int Steps {
			get { return _steps; }
		}

		private ColoroidGameSize _current_game_size;
		public ColoroidGameSize CurrentGameSize {
			get { return _current_game_size; }
		}

		public int CurrentGameSizeNum {
			get { return (int)_current_game_size; }
		}

		#endregion

		#region public methods

		public void StartGame(ColoroidGameSize size) {
			GenerateGame(size);
		}

		public void CancelGame() {

		}

		public void GameTurnByColor(ColoroidGameFieldColor color) {

		}

		#endregion

		#region private methods

		private void GenerateGame(ColoroidGameSize size) {
			_current_game_size = size;
			int game_size = CurrentGameSizeNum;
			_game_fields = new ColoroidGameField[game_size, game_size];

			for (int j = 0; j < game_size; j++) {
				for (int i = 0; i < game_size; i++) {
					_game_fields[i, j].SetColor(ColoroidGameFieldColorRandomizer.GetNext());
				}
			}

		}

		#endregion
	}
}
