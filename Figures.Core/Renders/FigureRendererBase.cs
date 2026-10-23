using Figures.Core.Figures;
using Figures.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Core.Renders
{
	public abstract class FigureRendererBase : IFigureRender, IFigureVisitor
	{
		public abstract void Visit(MyRectangle rectangle);
		public abstract void Visit(MySquare square);
		public abstract void Visit(MyEllipse ellipse);
		public abstract void Visit(MyCircle circle);
		public abstract void Visit(MyTriangle triangle);

		public void DrawFigure(Figure figure)
		{
			figure.Accept(this);
		}

		public void DrawFigures(IEnumerable<Figure> figures)
		{
			foreach (var figure in figures)
			{
				figure.Accept(this);
			}
		}

		public virtual void Clear()
		{ }
	}
}
