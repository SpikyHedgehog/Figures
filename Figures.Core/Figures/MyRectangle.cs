using Figures.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Core.Figures
{
	public class MyRectangle : Figure
	{
		public double Width { get; set; }
		public double Height { get; set; }

		public override void Accept(IFigureVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
