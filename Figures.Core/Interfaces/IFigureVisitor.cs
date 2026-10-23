using Figures.Core.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Figures.Core.Interfaces
{
	public interface IFigureVisitor
	{
		void Visit(MyRectangle rectangle);
		void Visit(MySquare square);
		void Visit(MyEllipse ellipse);
		void Visit(MyCircle circle);
		void Visit(MyTriangle triangle);
	}
}
