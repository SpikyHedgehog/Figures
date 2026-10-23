using Figures.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Figures.Core.Figures
{
	public class MyTriangle : Figure
	{
		public Point A { get; set; }
		public Point B { get; set; }
		public Point C { get; set; }

		public override void Accept(IFigureVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
