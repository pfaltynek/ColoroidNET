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
			// mark all
			PerformGameTurn(_game_fields[0, 0].Color);
		}

		private void PerformGameTurn(ColoroidGameFieldColor color) {

			if (_game_fields[0, 0].Color.Equals(color)) {
				// turn by current color is invalid -> do not perform anything and do not signal anything
				return;
			}

			ColoroidGameFieldColor prev_color = _game_fields[0, 0].Color;


			//signal that turn done - >refresh of game fields needed
		}

		private bool CheckFieldRecursive(int x, int y, ColoroidGameFieldColor prev, ColoroidGameFieldColor new_color) {
			#region hint from c++ impementation but BUGGY!
			/*
			bool ColoroidGame::MarkPlayFieldColourRecursive(unsigned char color_index, int field_index) {
				bool finished = true;
				int size = m_global_data->GetGameSize();

				m_colors[field_index] = color_index | PLAY_FIELD_FLAG;

				// left
				if(field_index % size) {
					if ((m_colors[field_index - 1] & PLAY_FIELD_NO_BORDER_MASK ) != (color_index | PLAY_FIELD_FLAG)) {
						if (m_colors[field_index - 1] & PLAY_FIELD_FLAG) {
							// found previous play field with different color - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index - 1))
								finished = false;
						}
						else if ((m_colors[field_index - 1] & PLAY_FIELD_COLOR_MASK) == color_index) {
							// found field with same color not marked as play field - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index - 1))
								finished = false;
						}
						else {
							// found field with different color not marked as play field - game not finished, set border of current
							finished = false;
							m_colors[field_index] |= PLAY_FIELD_LEFT_BORDER;
						}
					}
				}
				else m_colors[field_index] |= PLAY_FIELD_LEFT_BORDER;

				// right
				if((field_index % size) < (size - 1)) {
					if ((m_colors[field_index + 1] & PLAY_FIELD_NO_BORDER_MASK ) != (color_index | PLAY_FIELD_FLAG)) {
						if (m_colors[field_index + 1] & PLAY_FIELD_FLAG) {
							// found previous play field with different color - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index + 1))
								finished = false;
						}
						else if ((m_colors[field_index + 1] & PLAY_FIELD_COLOR_MASK) == color_index) {
							// found field with same color not marked as play field - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index + 1))
								finished = false;
						}
						else {
							// found field with different color not marked as play field - game not finished, set border of current
							finished = false;
							m_colors[field_index] |= PLAY_FIELD_RIGHT_BORDER;
						}
					}
				}
				else m_colors[field_index] |= PLAY_FIELD_RIGHT_BORDER;

				// top
				if(field_index / size) {
					if ((m_colors[field_index - size] & PLAY_FIELD_NO_BORDER_MASK ) != (color_index | PLAY_FIELD_FLAG)) {
						if (m_colors[field_index - size] & PLAY_FIELD_FLAG) {
							// found previous play field with different color - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index - size))
								finished = false;
						}
						else if ((m_colors[field_index - size] & PLAY_FIELD_COLOR_MASK) == color_index) {
							// found field with same color not marked as play field - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index - size))
								finished = false;
						}
						else {
							// found field with different color not marked as play field - game not finished, set border of current
							finished = false;
							m_colors[field_index] |= PLAY_FIELD_TOP_BORDER;
						}
					}
				}
				else m_colors[field_index] |= PLAY_FIELD_TOP_BORDER;

				// bottom
				if((field_index / size) < (size - 1)) {
					if ((m_colors[field_index + size] & PLAY_FIELD_NO_BORDER_MASK ) != (color_index | PLAY_FIELD_FLAG)) {
						if (m_colors[field_index + size] & PLAY_FIELD_FLAG) {
							// found previous play field with different color - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index + size))
								finished = false;
						}
						else if ((m_colors[field_index + size] & PLAY_FIELD_COLOR_MASK) == color_index) {
							// found field with same color not marked as play field - go recursive
							if (!MarkPlayFieldColourRecursive(color_index, field_index + size))
								finished = false;
						}
						else {
							// found field with different color not marked as play field - game not finished, set border of current
							finished = false;
							m_colors[field_index] |= PLAY_FIELD_BOTTOM_BORDER;
						}
					}
				}
				else m_colors[field_index] |= PLAY_FIELD_BOTTOM_BORDER;

				return finished;
			}
			*/
			#endregion

			bool result = true;

			return result;
		}

		#endregion
	}
}
