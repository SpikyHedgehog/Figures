using Figures.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Core.Figures
{
	public class MySquare : MyRectangle
	{
		public double Side 
		{
			get 
			{
				return this.Width;
			}
			set 
			{
				this.Width = value;
				this.Height = value;
			}
		}

		public MySquare(double side)
		{
			Side = side;
		}

		public override void Accept(IFigureVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
