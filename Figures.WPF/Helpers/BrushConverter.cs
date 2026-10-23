using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Figures.WPF.Helpers
{
	public static class BrushHelper
	{
		public static Brush ConvertBrush(string colorName)
		{
			if (string.IsNullOrEmpty(colorName)) 
			{
				return null;
			}

			var color = (Color)ColorConverter.ConvertFromString(colorName);
			return new SolidColorBrush(color);
		}
		public static Pen CreatePen(string colorName, double thickness)
		{
			if (string.IsNullOrEmpty(colorName) || thickness <= 0)
			{
				return null;
			}

			var brush = ConvertBrush(colorName);
			return new Pen(brush, thickness);
		}
	}
}
