using Figures.Core;
using Figures.Core.Figures;
using Figures.Core.Interfaces;
using Figures.WPF;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Media;

namespace Figures
{
	public partial class App : Application
	{
		private IServiceProvider _serviceProvider;
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			var services = new ServiceCollection();
			services.AddTransient<Func<DrawingContext, IFigureRender>>(sp => context => ActivatorUtilities.CreateInstance<WPFFigureRenderer>(sp, context));

			services.AddTransient<MainWindow>();

			_serviceProvider = services.BuildServiceProvider();


			var figures = new List<Figure>
			{
				new MySquare(100){ Position = new System.Drawing.Point(50, 50), FillColor = "LightBlue", StrokeColor = "Black", StrokeThickness = 1},
				new MyCircle(50){ Position = new System.Drawing.Point(200, 50), FillColor = "LightGreen", StrokeColor = "Black", StrokeThickness = 2},
				new MyTriangle
				{
					Position = new System.Drawing.Point(350, 50),
					FillColor = "LightCoral",
					StrokeColor = "Black",
					StrokeThickness = 3,
					A = new System.Drawing.Point(0, 0),
					B = new System.Drawing.Point(80, 0),
					C = new System.Drawing.Point(40, 70),
				}
			}; 

			var drawing = new DrawingGroup();

			var createRenderer = _serviceProvider
				.GetRequiredService<Func<DrawingContext, IFigureRender>>();

			using (var context = drawing.Open())
			{
				var renderer = createRenderer(context);
				renderer.DrawFigures(figures);
			}

			var window = _serviceProvider.GetRequiredService<MainWindow>();

			window.Content = new System.Windows.Controls.Image
			{
				Source = new DrawingImage(drawing),
				Stretch = Stretch.None,
				HorizontalAlignment = HorizontalAlignment.Left,
				VerticalAlignment = VerticalAlignment.Top
			};

			MainWindow = window;
			window.Show();
		}
	}

}
