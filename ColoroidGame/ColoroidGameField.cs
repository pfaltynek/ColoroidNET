using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoroidGame {
	class ColoroidGameField {
		#region ctors
		
		public ColoroidGameField(){
			_color = ColoroidGameFieldColor.DarkGray;
			_border = ColoroidGameFieldBorder.None;
		}
		
		#endregion

		#region properties
		
		ColoroidGameFieldColor _color = ColoroidGameFieldColor.DarkGray;
		public ColoroidGameFieldColor Color {
			get { return _color; }
		}

		ColoroidGameFieldBorder _border = ColoroidGameFieldBorder.None;
		public ColoroidGameFieldBorder Border {
			get { return _border; }
		}

		#endregion

		#region internal methods

		internal void SetColor(ColoroidGameFieldColor color) {
			_color = color;
		}

		internal void SetBorder(ColoroidGameFieldBorder border){
			_border = border;
		}

		internal void ClearBorder() {
			_border = ColoroidGameFieldBorder.None;
		}

		internal void AddBorder(ColoroidGameFieldBorder border) {
			_border |= border;
		}

		#endregion
	}
}
