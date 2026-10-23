using Figures.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Core.Figures
{
	public class MyEllipse : Figure
	{
		public double RadiusX { get; set; }
		public double RadiusY { get; set; }

		public override void Accept(IFigureVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
