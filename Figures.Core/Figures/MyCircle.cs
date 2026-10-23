using Figures.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Core.Figures
{
	public class MyCircle : MyEllipse
	{
		public double Radius 
		{
			get 
			{
				return this.RadiusX;
			}
			set
			{
				this.RadiusX = value;
				this.RadiusY = value;
			}
		}

		public MyCircle(double radius)
		{
			Radius = radius;
		}

		public override void Accept(IFigureVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
