using Figures.Core.Interfaces;
using System.Drawing;

namespace Figures.Core
{
	public abstract class Figure
	{
		public Point Position { get; set; }
		public required string FillColor { get; set; }
		public required string StrokeColor { get; set; }
		public double StrokeThickness { get; set; }
		public abstract void Accept(IFigureVisitor visitor);
	}

	
}
