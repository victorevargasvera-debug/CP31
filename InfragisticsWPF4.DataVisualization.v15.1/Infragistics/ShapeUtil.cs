using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x020000B5 RID: 181
	public static class ShapeUtil
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x000250C4 File Offset: 0x000232C4
		public static global::System.Windows.Shapes.Shape Duplicate(this global::System.Windows.Shapes.Shape shape)
		{
			global::System.Windows.Shapes.Ellipse ellipse = shape as global::System.Windows.Shapes.Ellipse;
			if (ellipse != null)
			{
				return ellipse.Duplicate();
			}
			global::System.Windows.Shapes.Line line = shape as global::System.Windows.Shapes.Line;
			if (line != null)
			{
				return line.Duplicate();
			}
			global::System.Windows.Shapes.Rectangle rectangle = shape as global::System.Windows.Shapes.Rectangle;
			if (rectangle != null)
			{
				return rectangle.Duplicate();
			}
			global::System.Windows.Shapes.Polygon polygon = shape as global::System.Windows.Shapes.Polygon;
			if (polygon != null)
			{
				return polygon.Duplicate();
			}
			global::System.Windows.Shapes.Polyline polyline = shape as global::System.Windows.Shapes.Polyline;
			if (polyline != null)
			{
				return polyline.Duplicate();
			}
			global::System.Windows.Shapes.Path path = shape as global::System.Windows.Shapes.Path;
			if (path != null)
			{
				return path.Duplicate();
			}
			return null;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00025140 File Offset: 0x00023340
		public static global::System.Windows.Shapes.Ellipse Duplicate(this global::System.Windows.Shapes.Ellipse ellipse)
		{
			global::System.Windows.Shapes.Ellipse ellipse2 = new global::System.Windows.Shapes.Ellipse();
			global::Infragistics.ShapeUtil.DuplicateShapeProperties(ellipse2, ellipse);
			return ellipse2;
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0002515C File Offset: 0x0002335C
		public static global::System.Windows.Shapes.Line Duplicate(this global::System.Windows.Shapes.Line line)
		{
			global::System.Windows.Shapes.Line line2 = new global::System.Windows.Shapes.Line();
			line2.X1 = line.X1;
			line2.X2 = line.X2;
			line2.Y1 = line.Y1;
			line2.Y2 = line.Y2;
			global::Infragistics.ShapeUtil.DuplicateShapeProperties(line2, line);
			return line2;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x000251A8 File Offset: 0x000233A8
		public static global::System.Windows.Shapes.Rectangle Duplicate(this global::System.Windows.Shapes.Rectangle rectangle)
		{
			global::System.Windows.Shapes.Rectangle rectangle2 = new global::System.Windows.Shapes.Rectangle();
			rectangle2.RadiusX = rectangle.RadiusX;
			rectangle2.RadiusY = rectangle.RadiusY;
			global::Infragistics.ShapeUtil.DuplicateShapeProperties(rectangle2, rectangle);
			return rectangle2;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000251DC File Offset: 0x000233DC
		public static global::System.Windows.Shapes.Polygon Duplicate(this global::System.Windows.Shapes.Polygon polygon)
		{
			global::System.Windows.Shapes.Polygon polygon2 = new global::System.Windows.Shapes.Polygon();
			polygon2.Points = polygon.Points.Duplicate();
			polygon2.FillRule = polygon.FillRule;
			global::Infragistics.ShapeUtil.DuplicateShapeProperties(polygon2, polygon);
			return polygon2;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00025214 File Offset: 0x00023414
		public static global::System.Windows.Shapes.Polyline Duplicate(this global::System.Windows.Shapes.Polyline polyline)
		{
			global::System.Windows.Shapes.Polyline polyline2 = new global::System.Windows.Shapes.Polyline();
			polyline2.Points = polyline.Points.Duplicate();
			polyline2.FillRule = polyline.FillRule;
			global::Infragistics.ShapeUtil.DuplicateShapeProperties(polyline2, polyline);
			return polyline2;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0002524C File Offset: 0x0002344C
		public static global::System.Windows.Shapes.Path Duplicate(this global::System.Windows.Shapes.Path path)
		{
			global::System.Windows.Shapes.Path path2 = new global::System.Windows.Shapes.Path();
			global::System.Windows.Media.Geometry data = path.Data.Duplicate();
			path2.Data = data;
			global::Infragistics.ShapeUtil.DuplicateShapeProperties(path2, path);
			return path2;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0002527C File Offset: 0x0002347C
		private static void DuplicateShapeProperties(global::System.Windows.Shapes.Shape newShape, global::System.Windows.Shapes.Shape shape)
		{
			newShape.Fill = shape.Fill.Duplicate();
			newShape.Stroke = shape.Stroke.Duplicate();
			newShape.StrokeDashArray = shape.StrokeDashArray.Duplicate();
			newShape.StrokeDashCap = shape.StrokeDashCap;
			newShape.StrokeDashOffset = shape.StrokeDashOffset;
			newShape.StrokeEndLineCap = shape.StrokeEndLineCap;
			newShape.StrokeLineJoin = shape.StrokeLineJoin;
			newShape.StrokeMiterLimit = shape.StrokeMiterLimit;
			newShape.StrokeStartLineCap = shape.StrokeStartLineCap;
			newShape.StrokeThickness = shape.StrokeThickness;
			newShape.HorizontalAlignment = shape.HorizontalAlignment;
			newShape.VerticalAlignment = shape.VerticalAlignment;
			newShape.Visibility = shape.Visibility;
			newShape.Margin = shape.Margin;
			newShape.Stretch = shape.Stretch;
			newShape.RenderTransform = shape.RenderTransform.Duplicate();
			newShape.RenderTransformOrigin = shape.RenderTransformOrigin;
			newShape.IsHitTestVisible = shape.IsHitTestVisible;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00025378 File Offset: 0x00023578
		public static global::System.Windows.Media.DoubleCollection Duplicate(this global::System.Windows.Media.DoubleCollection doubleCollection)
		{
			if (doubleCollection == null)
			{
				return null;
			}
			global::System.Windows.Media.DoubleCollection doubleCollection2 = new global::System.Windows.Media.DoubleCollection();
			foreach (double num in doubleCollection)
			{
				double value = num;
				doubleCollection2.Add(value);
			}
			return doubleCollection2;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000253D4 File Offset: 0x000235D4
		public static global::System.Windows.Media.PointCollection Duplicate(this global::System.Windows.Media.PointCollection pointCollection)
		{
			if (pointCollection == null)
			{
				return null;
			}
			global::System.Windows.Media.PointCollection pointCollection2 = new global::System.Windows.Media.PointCollection();
			foreach (global::System.Windows.Point value in pointCollection)
			{
				pointCollection2.Add(value);
			}
			return pointCollection2;
		}
	}
}
