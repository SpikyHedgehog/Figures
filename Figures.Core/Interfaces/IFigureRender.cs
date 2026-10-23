using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Core.Interfaces
{
	public interface IFigureRender
	{
		void DrawFigure(Figure figure);
		void DrawFigures(IEnumerable<Figure> figures);
		void Clear();
	}
}
