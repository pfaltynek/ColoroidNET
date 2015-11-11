namespace ColoroidGame {
	public class ColoroidGame {
		#region ctor

		public ColoroidGame() {

		}

		#endregion

		#region properties

		private ColoroidGameField[,] _game_fields = null;

		private int _steps = -1;
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


		public int CurrentGamePar {
			get { return ColoroidGamePar.GetColoroidGamePar(_current_game_size); }
		}
		#endregion

		#region public methods

		public void StartGame(ColoroidGameSize size) {
			GenerateGame(size);
		}

		public void CancelGame() {
			_steps = -1;
			_game_fields = null;
		}

		public void GameTurnByColor(ColoroidGameFieldColor color) {
			if ((_steps >= 0) && (_game_fields != null)) {
				PerformGameTurn(color);
			}
		}

		public static int GetGameParBySize(ColoroidGameSize size) {
			return ColoroidGamePar.GetColoroidGamePar(size);
		}

		#endregion

		#region private methods

		private void GenerateGame(ColoroidGameSize size) {
			_current_game_size = size;
			_steps = 0;
			int game_size = CurrentGameSizeNum;
			_game_fields = new ColoroidGameField[game_size, game_size];

			for (int j = 0; j < game_size; j++) {
				for (int i = 0; i < game_size; i++) {
					_game_fields[i, j].SetColor(ColoroidGameFieldColorRandomizer.GetNext());
				}
			}
		}

		private void PerformGameTurn(ColoroidGameFieldColor color) {

			if (_game_fields[0, 0].Color.Equals(color)) {
				// turn by current color is invalid -> do not perform anything and do not signal anything
				return;
			}

			ColoroidGameFieldColor prev_color = _game_fields[0, 0].Color;


			//signal that turn done - >refresh of game fields needed
		}

		#endregion
	}
}
