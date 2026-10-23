using Figures.Core.Figures;
using Figures.Core.Renders;
using Microsoft.Extensions.Logging;
using System.Drawing;

namespace FIgures.Logging
{
	public class LoggerFigureRender : FigureRendererBase
	{
		private readonly ILogger _logger;
		public LoggerFigureRender(ILogger logger) 
		{
			_logger = logger;
		}

		public override void Visit(MyRectangle rectangle)
		{
			_logger.LogInformation($"New rectangle: Position: <{rectangle.Position.X}, {rectangle.Position.Y}>, Width: {rectangle.Width}, Height: {rectangle.Height}");
		}

		public override void Visit(MySquare square)
		{
			_logger.LogInformation($"New square: Position: <{square.Position.X}, {square.Position.Y}>, Side: {square.Side}");
		}

		public override void Visit(MyEllipse ellipse)
		{
			_logger.LogInformation($"New ellipse: Position: <{ellipse.Position.X}, {ellipse.Position.Y}>, RadiusX: {ellipse.RadiusX}, RadiusY: {ellipse.RadiusY}");
		}

		public override void Visit(MyCircle circle)
		{
			_logger.LogInformation($"New circle: Position: <{circle.Position.X}, {circle.Position.Y}>, Radius: {circle.Radius}");
		}

		public override void Visit(MyTriangle triangle)
		{
			_logger.LogInformation($"New triangle: Position: <{triangle.Position.X}, {triangle.Position.Y}>, Points: {{<{triangle.A.X}, {triangle.A.Y}>, <{triangle.B.X}, {triangle.B.Y}>, <{triangle.C.X}, {triangle.C.Y}>}}");
		}
	}
}
