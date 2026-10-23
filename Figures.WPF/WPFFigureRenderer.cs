using Figures.Core.Figures;
using Figures.Core.Renders;
using Figures.WPF.Helpers;
using System.Windows;
using System.Windows.Media;
namespace Figures.WPF
{
	public class WPFFigureRenderer : FigureRendererBase
	{
		private readonly DrawingContext _drawingContext;
		public WPFFigureRenderer(DrawingContext drawingContext)
		{
			_drawingContext = drawingContext;
		}

		public override void Visit(MyRectangle rectangle)
		{
			var wpfRect = new Rect(rectangle.Position.X, rectangle.Position.Y, rectangle.Width, rectangle.Height);
			var fill = BrushHelper.ConvertBrush(rectangle.FillColor);
			var pen = BrushHelper.CreatePen(rectangle.StrokeColor, rectangle.StrokeThickness);
			_drawingContext.DrawRectangle(fill, pen, wpfRect);
		}

		public override void Visit(MySquare square)
		{
			Visit((MyRectangle)square);
		}

		public override void Visit(MyEllipse ellipse)
		{
			var center = new Point(ellipse.Position.X + ellipse.RadiusX, ellipse.Position.Y + ellipse.RadiusY);
			var fill = BrushHelper.ConvertBrush(ellipse.FillColor);
			var pen = BrushHelper.CreatePen(ellipse.StrokeColor, ellipse.StrokeThickness);
			_drawingContext.DrawEllipse(fill, pen, center, ellipse.RadiusX, ellipse.RadiusY);
		}

		public override void Visit(MyCircle circle)
		{
			Visit((MyEllipse)circle);
		}

		public override void Visit(MyTriangle triangle)
		{
			var geometry = new StreamGeometry();
			using (var ctx = geometry.Open())
			{
				ctx.BeginFigure(new Point(triangle.Position.X + triangle.A.X, triangle.Position.Y + triangle.A.Y), true, true);
				ctx.LineTo(new Point(triangle.Position.X + triangle.B.X, triangle.Position.Y + triangle.B.Y), true, true);
				ctx.LineTo(new Point(triangle.Position.X + triangle.C.X, triangle.Position.Y + triangle.C.Y), true, true);
			}

			var fill = BrushHelper.ConvertBrush(triangle.FillColor);
			var pen = BrushHelper.CreatePen(triangle.StrokeColor, triangle.StrokeThickness);
			_drawingContext.DrawGeometry(fill, pen, geometry);
		}
	}
}
