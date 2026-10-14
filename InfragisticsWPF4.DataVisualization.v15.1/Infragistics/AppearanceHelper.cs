using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Infragistics.Controls;

namespace Infragistics
{
	// Token: 0x020000E4 RID: 228
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class AppearanceHelper
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x00029B28 File Offset: 0x00027D28
		public static global::System.Windows.Media.Color FromBrush(global::System.Windows.Media.Brush b)
		{
			if (b == null)
			{
				return global::System.Windows.Media.Color.FromArgb(0, 0, 0, 0);
			}
			global::System.Windows.Media.Color result = global::System.Windows.Media.Color.FromArgb(0, 0, 0, 0);
			if (b is global::System.Windows.Media.SolidColorBrush)
			{
				byte a = (byte)(b.Opacity * (double)((global::System.Windows.Media.SolidColorBrush)b).Color.A);
				result = ((global::System.Windows.Media.SolidColorBrush)b).Color;
				result.A = a;
			}
			else if (b is global::System.Windows.Media.LinearGradientBrush && ((global::System.Windows.Media.LinearGradientBrush)b).GradientStops.Count > 0)
			{
				result = ((global::System.Windows.Media.LinearGradientBrush)b).GradientStops[0].Color;
			}
			else if (b is global::System.Windows.Media.RadialGradientBrush && ((global::System.Windows.Media.RadialGradientBrush)b).GradientStops.Count > 0)
			{
				result = ((global::System.Windows.Media.RadialGradientBrush)b).GradientStops[0].Color;
			}
			return result;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00029BF0 File Offset: 0x00027DF0
		public static global::Infragistics.BrushAppearanceData FromBrushExtended(global::System.Windows.Media.Brush b)
		{
			if (b is global::System.Windows.Media.SolidColorBrush)
			{
				global::Infragistics.SolidBrushAppearanceData solidBrushAppearanceData = new global::Infragistics.SolidBrushAppearanceData();
				byte a = (byte)(b.Opacity * 255.0);
				global::System.Windows.Media.Color color = ((global::System.Windows.Media.SolidColorBrush)b).Color;
				color.A = a;
				solidBrushAppearanceData.ColorValue = color;
				return solidBrushAppearanceData;
			}
			if (b is global::System.Windows.Media.LinearGradientBrush)
			{
				global::Infragistics.LinearGradientBrushAppearanceData linearGradientBrushAppearanceData = new global::Infragistics.LinearGradientBrushAppearanceData();
				global::System.Windows.Media.LinearGradientBrush linearGradientBrush = (global::System.Windows.Media.LinearGradientBrush)b;
				linearGradientBrushAppearanceData.StartX = linearGradientBrush.StartPoint.X;
				linearGradientBrushAppearanceData.StartY = linearGradientBrush.StartPoint.Y;
				linearGradientBrushAppearanceData.EndX = linearGradientBrush.EndPoint.X;
				linearGradientBrushAppearanceData.EndY = linearGradientBrush.EndPoint.Y;
				foreach (global::System.Windows.Media.GradientStop gradientStop in linearGradientBrush.GradientStops)
				{
					linearGradientBrushAppearanceData.Stops.Add(new global::Infragistics.GradientStopAppearanceData
					{
						ColorValue = gradientStop.Color,
						Offset = gradientStop.Offset
					});
				}
				return linearGradientBrushAppearanceData;
			}
			if (b is global::System.Windows.Media.RadialGradientBrush)
			{
				return null;
			}
			return null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00029D2C File Offset: 0x00027F2C
		public static double GetCanvasLeft(global::System.Windows.FrameworkElement visual)
		{
			double num = global::System.Windows.Controls.Canvas.GetLeft(visual);
			global::System.Windows.Media.Transform transform = visual.RenderTransform;
			if (transform is global::System.Windows.Media.TransformGroup)
			{
				global::System.Windows.Media.TransformGroup transformGroup = (global::System.Windows.Media.TransformGroup)transform;
				foreach (global::System.Windows.Media.Transform transform2 in transformGroup.Children)
				{
					if (transform2 is global::System.Windows.Media.TranslateTransform)
					{
						transform = transform2;
						break;
					}
				}
			}
			if (transform != null && transform is global::System.Windows.Media.TranslateTransform)
			{
				if (double.IsNaN(num))
				{
					num = ((global::System.Windows.Media.TranslateTransform)transform).X;
				}
				else
				{
					num += ((global::System.Windows.Media.TranslateTransform)transform).X;
				}
			}
			return num;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00029DD4 File Offset: 0x00027FD4
		public static double GetCanvasTop(global::System.Windows.FrameworkElement visual)
		{
			double num = global::System.Windows.Controls.Canvas.GetTop(visual);
			global::System.Windows.Media.Transform transform = visual.RenderTransform;
			if (transform is global::System.Windows.Media.TransformGroup)
			{
				global::System.Windows.Media.TransformGroup transformGroup = (global::System.Windows.Media.TransformGroup)transform;
				foreach (global::System.Windows.Media.Transform transform2 in transformGroup.Children)
				{
					if (transform2 is global::System.Windows.Media.TranslateTransform)
					{
						transform = transform2;
						break;
					}
				}
			}
			if (transform != null && transform is global::System.Windows.Media.TranslateTransform)
			{
				if (double.IsNaN(num))
				{
					num = ((global::System.Windows.Media.TranslateTransform)transform).Y;
				}
				else
				{
					num += ((global::System.Windows.Media.TranslateTransform)transform).Y;
				}
			}
			return num;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00029E7C File Offset: 0x0002807C
		public static int GetCanvasZIndex(global::System.Windows.FrameworkElement line)
		{
			return global::System.Windows.Controls.Panel.GetZIndex(line);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00029E84 File Offset: 0x00028084
		public static global::System.Collections.Generic.List<global::Infragistics.GeometryData> FromPathData(global::System.Windows.Shapes.Path path)
		{
			return global::Infragistics.AppearanceHelper.FromGeometry(path.Data);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00029E94 File Offset: 0x00028094
		public static global::System.Collections.Generic.List<global::Infragistics.GeometryData> FromGeometry(global::System.Windows.Media.Geometry data)
		{
			if (data == null)
			{
				return new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
			}
			if (data is global::System.Windows.Media.GeometryGroup)
			{
				global::System.Collections.Generic.List<global::Infragistics.GeometryData> list = new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
				global::System.Windows.Media.GeometryGroup geometryGroup = (global::System.Windows.Media.GeometryGroup)data;
				for (int i = 0; i < geometryGroup.Children.Count; i++)
				{
					global::System.Collections.Generic.List<global::Infragistics.GeometryData> list2 = global::Infragistics.AppearanceHelper.FromGeometry(geometryGroup.Children[i]);
					for (int j = 0; j < list2.Count; j++)
					{
						list.Add(list2[j]);
					}
				}
				return list;
			}
			if (data is global::System.Windows.Media.PathGeometry)
			{
				return global::Infragistics.AppearanceHelper.FromPathGeometry((global::System.Windows.Media.PathGeometry)data);
			}
			if (data is global::System.Windows.Media.LineGeometry)
			{
				return global::Infragistics.AppearanceHelper.FromLineGeometry((global::System.Windows.Media.LineGeometry)data);
			}
			if (data is global::System.Windows.Media.RectangleGeometry)
			{
				return global::Infragistics.AppearanceHelper.FromRectangleGeometry((global::System.Windows.Media.RectangleGeometry)data);
			}
			if (data is global::System.Windows.Media.EllipseGeometry)
			{
				return global::Infragistics.AppearanceHelper.FromEllipseGeometry((global::System.Windows.Media.EllipseGeometry)data);
			}
			if (data is global::System.Windows.Media.StreamGeometry)
			{
				string xaml = "<PathGeometry xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" Figures=\"" + data.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + "\" />";
				global::System.Windows.Media.PathGeometry pathGeometry = global::Infragistics.Controls.PresentationUtilities.LoadXaml(xaml) as global::System.Windows.Media.PathGeometry;
				return global::Infragistics.AppearanceHelper.FromPathGeometry(pathGeometry);
			}
			throw new global::System.Exception("not supported");
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00029FA0 File Offset: 0x000281A0
		private static global::System.Collections.Generic.List<global::Infragistics.GeometryData> FromEllipseGeometry(global::System.Windows.Media.EllipseGeometry ellipseGeometry)
		{
			global::System.Collections.Generic.List<global::Infragistics.GeometryData> list = new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
			global::Infragistics.EllipseGeometryData ellipseGeometryData = new global::Infragistics.EllipseGeometryData();
			list.Add(ellipseGeometryData);
			ellipseGeometryData.CenterX = ellipseGeometry.Center.X;
			ellipseGeometryData.CenterY = ellipseGeometry.Center.Y;
			ellipseGeometryData.RadiusX = ellipseGeometry.RadiusX;
			ellipseGeometryData.RadiusY = ellipseGeometry.RadiusY;
			return list;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002A004 File Offset: 0x00028204
		private static global::System.Collections.Generic.List<global::Infragistics.GeometryData> FromRectangleGeometry(global::System.Windows.Media.RectangleGeometry rectangleGeometry)
		{
			global::System.Collections.Generic.List<global::Infragistics.GeometryData> list = new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
			global::Infragistics.RectangleGeometryData rectangleGeometryData = new global::Infragistics.RectangleGeometryData();
			list.Add(rectangleGeometryData);
			rectangleGeometryData.X = rectangleGeometry.Rect.X;
			rectangleGeometryData.Y = rectangleGeometry.Rect.Y;
			rectangleGeometryData.Width = rectangleGeometry.Rect.Width;
			rectangleGeometryData.Height = rectangleGeometry.Rect.Height;
			return list;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002A078 File Offset: 0x00028278
		private static global::System.Collections.Generic.List<global::Infragistics.GeometryData> FromLineGeometry(global::System.Windows.Media.LineGeometry lineGeometry)
		{
			global::System.Collections.Generic.List<global::Infragistics.GeometryData> list = new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
			global::Infragistics.LineGeometryData lineGeometryData = new global::Infragistics.LineGeometryData();
			list.Add(lineGeometryData);
			lineGeometryData.X1 = lineGeometry.StartPoint.X;
			lineGeometryData.Y1 = lineGeometry.StartPoint.Y;
			lineGeometryData.X2 = lineGeometry.EndPoint.X;
			lineGeometryData.Y2 = lineGeometry.EndPoint.Y;
			return list;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002A0EC File Offset: 0x000282EC
		private static global::System.Collections.Generic.List<global::Infragistics.GeometryData> FromPathGeometry(global::System.Windows.Media.PathGeometry pathGeometry)
		{
			global::System.Collections.Generic.List<global::Infragistics.GeometryData> list = new global::System.Collections.Generic.List<global::Infragistics.GeometryData>();
			global::Infragistics.PathGeometryData pathGeometryData = new global::Infragistics.PathGeometryData();
			list.Add(pathGeometryData);
			for (int i = 0; i < pathGeometry.Figures.Count; i++)
			{
				global::System.Windows.Media.PathFigure fig = pathGeometry.Figures[i];
				global::Infragistics.PathFigureData item = new global::Infragistics.PathFigureData(fig);
				pathGeometryData.Figures.Add(item);
			}
			return list;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0002A148 File Offset: 0x00028348
		public static void GetShapeAppearance(global::Infragistics.PrimitiveAppearanceData appearance, global::System.Windows.Shapes.Shape path)
		{
			appearance.Stroke = global::Infragistics.AppearanceHelper.FromBrush(path.Stroke);
			appearance.Fill = global::Infragistics.AppearanceHelper.FromBrush(path.Fill);
			appearance.StrokeExtended = global::Infragistics.AppearanceHelper.FromBrushExtended(path.Stroke);
			appearance.FillExtended = global::Infragistics.AppearanceHelper.FromBrushExtended(path.Fill);
			appearance.StrokeThickness = path.StrokeThickness;
			if (path.StrokeDashArray == null)
			{
				appearance.DashArray = null;
			}
			else
			{
				appearance.DashArray = new global::System.Collections.Generic.List<double>();
				foreach (double num in path.StrokeDashArray)
				{
					double item = num;
					appearance.DashArray.Add(item);
				}
			}
			appearance.DashCap = (int)path.StrokeDashCap;
			appearance.Visibility = path.Visibility;
			appearance.Opacity = path.Opacity;
			appearance.CanvasLeft = global::Infragistics.AppearanceHelper.GetCanvasLeft(path);
			appearance.CanvasTop = global::Infragistics.AppearanceHelper.GetCanvasTop(path);
			appearance.CanvaZIndex = global::Infragistics.AppearanceHelper.GetCanvasZIndex(path);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002A258 File Offset: 0x00028458
		public static global::Infragistics.LabelAppearanceData FromTextElement(global::System.Windows.FrameworkElement frameworkElement, global::Infragistics.FontInfo fontInfo)
		{
			global::Infragistics.LabelAppearanceData labelAppearanceData = new global::Infragistics.LabelAppearanceData();
			global::System.Windows.Controls.TextBlock textBlock = (global::System.Windows.Controls.TextBlock)frameworkElement;
			labelAppearanceData.Text = textBlock.Text;
			labelAppearanceData.LabelBrush = global::Infragistics.AppearanceHelper.FromBrush(textBlock.Foreground);
			labelAppearanceData.LabelBrushExtended = global::Infragistics.AppearanceHelper.FromBrushExtended(textBlock.Foreground);
			labelAppearanceData.Visibility = (textBlock.Visibility == global::System.Windows.Visibility.Visible);
			labelAppearanceData.Opacity = textBlock.Opacity;
			if (fontInfo.FontFamily != null)
			{
				labelAppearanceData.FontFamily = fontInfo.FontFamily;
			}
			if (!double.IsNaN(fontInfo.FontSize))
			{
				labelAppearanceData.FontSize = fontInfo.FontSize;
			}
			if (fontInfo.FontWeight != null)
			{
				labelAppearanceData.FontWeight = fontInfo.FontWeight;
			}
			if (fontInfo.FontStyle != null)
			{
				labelAppearanceData.FontStyle = fontInfo.FontStyle;
			}
			if (fontInfo.FontStretch != null)
			{
				labelAppearanceData.FontStretch = fontInfo.FontStyle;
			}
			double angle = 0.0;
			global::System.Windows.Media.Transform renderTransform = textBlock.RenderTransform;
			if (renderTransform is global::System.Windows.Media.RotateTransform)
			{
				global::System.Windows.Media.RotateTransform rotateTransform = renderTransform as global::System.Windows.Media.RotateTransform;
				angle = rotateTransform.Angle;
			}
			else if (renderTransform is global::System.Windows.Media.TransformGroup)
			{
				global::System.Windows.Media.TransformGroup transformGroup = renderTransform as global::System.Windows.Media.TransformGroup;
				foreach (global::System.Windows.Media.Transform transform in transformGroup.Children)
				{
					if (transform is global::System.Windows.Media.RotateTransform)
					{
						global::System.Windows.Media.RotateTransform rotateTransform2 = transform as global::System.Windows.Media.RotateTransform;
						angle = rotateTransform2.Angle;
						break;
					}
				}
			}
			labelAppearanceData.Angle = angle;
			return labelAppearanceData;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002A3C8 File Offset: 0x000285C8
		public static string SerializeColor(global::System.Windows.Media.Color color)
		{
			return string.Concat(new object[]
			{
				"{ r: ",
				color.R,
				", g: ",
				color.G,
				", b: ",
				color.B,
				", a: ",
				color.A,
				"}"
			});
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002A448 File Offset: 0x00028648
		public static bool SerializeItems(global::System.Text.StringBuilder sb, string name, global::System.Collections.Generic.IEnumerable<global::Infragistics.IVisualData> items, bool isFirst)
		{
			if (items != null)
			{
				if (!isFirst)
				{
					sb.Append(", ");
				}
				sb.Append(name);
				sb.Append(": [");
				bool flag = false;
				foreach (global::Infragistics.IVisualData visualData in items)
				{
					if (flag)
					{
						sb.AppendLine(", ");
					}
					else
					{
						flag = true;
					}
					sb.Append(visualData.Serialize());
				}
				sb.AppendLine("]");
				return true;
			}
			return false;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002A4E0 File Offset: 0x000286E0
		public static bool SerializeItem(global::System.Text.StringBuilder sb, string name, global::Infragistics.IVisualData item, bool isFirst)
		{
			if (item != null)
			{
				if (!isFirst)
				{
					sb.Append(", ");
				}
				sb.Append(name);
				sb.Append(": ");
				sb.AppendLine(item.Serialize());
				return true;
			}
			return false;
		}
	}
}
