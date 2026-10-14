using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200009D RID: 157
	public static class GeometryUtil
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x0001E71C File Offset: 0x0001C91C
		public static double SimplifyAngle(double angle)
		{
			if (double.IsNaN(angle) || double.IsInfinity(angle))
			{
				return angle;
			}
			while (angle > 360.0)
			{
				angle -= 360.0;
			}
			while (angle < 0.0)
			{
				angle += 360.0;
			}
			return angle;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001E770 File Offset: 0x0001C970
		public static double AngleFromSlope(double slope)
		{
			return global::System.Math.Atan(slope);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001E778 File Offset: 0x0001C978
		public static double Slope(global::System.Windows.Point point1, global::System.Windows.Point point2)
		{
			return (point2.Y - point1.Y) / (point2.X - point1.X);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001E79C File Offset: 0x0001C99C
		public static double Eccentricity(global::System.Windows.Rect bounds)
		{
			return 1.0 - global::System.Math.Pow(bounds.Height / 2.0, 2.0) / global::System.Math.Pow(bounds.Width / 2.0, 2.0);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001E7F4 File Offset: 0x0001C9F4
		public static global::System.Windows.Point PointOnEllipse(double theta, double eccentricity, global::System.Windows.Point center, double halfHeight, double extent)
		{
			double num = global::System.Math.Cos(theta);
			double num2 = global::System.Math.Sin(theta);
			double num3 = global::System.Math.Sqrt(halfHeight * halfHeight / (1.0 - eccentricity * global::System.Math.Pow(num, 2.0)));
			num3 *= extent;
			return new global::System.Windows.Point(num3 * num + center.X, num3 * num2 + center.Y);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0001E854 File Offset: 0x0001CA54
		public static global::System.Windows.Point FindCenter(double width, double height, bool exploded, double angle, double radius)
		{
			global::System.Windows.Point result;
			if (exploded)
			{
				result = global::Infragistics.GeometryUtil.FindRadialPoint(new global::System.Windows.Point(width / 2.0, height / 2.0), angle, radius);
			}
			else
			{
				result = new global::System.Windows.Point(width / 2.0, height / 2.0);
			}
			return result;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0001E8A8 File Offset: 0x0001CAA8
		public static global::System.Windows.Point FindRadialPoint(global::System.Windows.Point center, double angle, double radius)
		{
			angle = angle / 180.0 * 3.141592653589793;
			double y = center.Y + radius * global::System.Math.Sin(angle);
			double x = center.X + radius * global::System.Math.Cos(angle);
			return new global::System.Windows.Point(x, y);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0001E8F8 File Offset: 0x0001CAF8
		public static global::System.Windows.Point PointAtDistance(global::System.Windows.Point p1, global::System.Windows.Point p2, double distance)
		{
			double num = p2.X - p1.X;
			double num2 = p2.Y - p1.Y;
			double num3 = global::System.Math.Sqrt(num * num + num2 * num2);
			num = num / num3 * distance;
			num2 = num2 / num3 * distance;
			return new global::System.Windows.Point(p1.X + num, p1.Y + num2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0001E958 File Offset: 0x0001CB58
		public static double GetSegmentLength(global::System.Windows.Point p1, global::System.Windows.Point p2)
		{
			double num = global::System.Math.Abs(p2.X - p1.X);
			double num2 = global::System.Math.Abs(p2.Y - p1.Y);
			return global::System.Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0001E99B File Offset: 0x0001CB9B
		public static global::System.Windows.Media.Geometry Duplicate(this global::System.Windows.Media.Geometry G)
		{
			if (G == null)
			{
				return null;
			}
			return G.Clone();
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		public static global::System.Windows.Media.Geometry UnitNone
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitNone) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitNone = new global::System.Windows.Media.PathGeometry());
				}
				return result;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
		public static global::System.Windows.Media.Geometry UnitBubble
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitBubble) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitBubble = new global::System.Windows.Media.EllipseGeometry
					{
						Center = new global::System.Windows.Point(0.0, 0.0),
						RadiusX = 1.0,
						RadiusY = 1.0
					});
				}
				return result;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0001EA1E File Offset: 0x0001CC1E
		public static global::System.Windows.Media.Geometry UnitTriangle
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitTriangle) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitTriangle = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitTriangleXY));
				}
				return result;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0001EA39 File Offset: 0x0001CC39
		public static global::System.Windows.Media.Geometry UnitPyramid
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitPyramid) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitPyramid = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitPyramidXY));
				}
				return result;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0001EA54 File Offset: 0x0001CC54
		public static global::System.Windows.Media.Geometry UnitSquare
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitSquare) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitSquare = new global::System.Windows.Media.RectangleGeometry
					{
						Rect = new global::System.Windows.Rect(-1.0, -1.0, 2.0, 2.0)
					});
				}
				return result;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0001EAA6 File Offset: 0x0001CCA6
		public static global::System.Windows.Media.Geometry UnitDiamond
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitDiamond) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitDiamond = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitDiamondXY));
				}
				return result;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0001EAC1 File Offset: 0x0001CCC1
		public static global::System.Windows.Media.Geometry UnitPentagon
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitPentagon) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitPentagon = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitPentagonXY));
				}
				return result;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0001EADC File Offset: 0x0001CCDC
		public static global::System.Windows.Media.Geometry UnitHexagon
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitHexagon) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitHexagon = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitHexagonXY));
				}
				return result;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0001EAF7 File Offset: 0x0001CCF7
		public static global::System.Windows.Media.Geometry UnitTetragram
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitTetragram) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitTetragram = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitTetragramXY));
				}
				return result;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0001EB12 File Offset: 0x0001CD12
		public static global::System.Windows.Media.Geometry UnitPentagram
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitPentagram) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitPentagram = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitPentagramXY));
				}
				return result;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0001EB2D File Offset: 0x0001CD2D
		public static global::System.Windows.Media.Geometry UnitHexagram
		{
			get
			{
				global::System.Windows.Media.Geometry result;
				if ((result = global::Infragistics.GeometryUtil.unitHexagram) == null)
				{
					result = (global::Infragistics.GeometryUtil.unitHexagram = global::Infragistics.GeometryUtil.PolygonGeometry(global::Infragistics.GeometryUtil.unitHexagramXY));
				}
				return result;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0001EB48 File Offset: 0x0001CD48
		public static global::System.Windows.Media.Geometry UnitThermometer
		{
			get
			{
				if (global::Infragistics.GeometryUtil.unitThermometer == null)
				{
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
					{
						Segments = new global::System.Windows.Media.PathSegmentCollection(),
						IsClosed = true,
						IsFilled = true,
						StartPoint = new global::System.Windows.Point(-0.2, -1.0)
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(0.2, -0.8),
						IsLargeArc = false,
						Size = new global::System.Windows.Size(0.2, 0.2),
						SweepDirection = global::System.Windows.Media.SweepDirection.Clockwise
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.LineSegment
					{
						Point = new global::System.Windows.Point(0.2, 0.2)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(-0.2, 0.2),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(0.4, 0.4),
						SweepDirection = global::System.Windows.Media.SweepDirection.Clockwise
					});
					global::Infragistics.GeometryUtil.unitThermometer = new global::System.Windows.Media.PathGeometry
					{
						Figures = new global::System.Windows.Media.PathFigureCollection()
					};
					global::Infragistics.GeometryUtil.unitThermometer.Figures.Add(pathFigure);
				}
				return global::Infragistics.GeometryUtil.unitThermometer;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		public static global::System.Windows.Media.Geometry UnitHourglass
		{
			get
			{
				if (global::Infragistics.GeometryUtil.unitHourglass == null)
				{
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
					{
						Segments = new global::System.Windows.Media.PathSegmentCollection(),
						IsClosed = true,
						IsFilled = true,
						StartPoint = new global::System.Windows.Point(-0.6, -1.0)
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.BezierSegment
					{
						Point1 = new global::System.Windows.Point(-0.6, -0.4),
						Point2 = new global::System.Windows.Point(-0.1, -0.4),
						Point3 = new global::System.Windows.Point(-0.1, 0.0)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.BezierSegment
					{
						Point1 = new global::System.Windows.Point(-0.1, 0.4),
						Point2 = new global::System.Windows.Point(-0.6, 0.4),
						Point3 = new global::System.Windows.Point(-0.6, 1.0)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.LineSegment
					{
						Point = new global::System.Windows.Point(0.6, 1.0)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.BezierSegment
					{
						Point1 = new global::System.Windows.Point(0.6, 0.4),
						Point2 = new global::System.Windows.Point(0.1, 0.4),
						Point3 = new global::System.Windows.Point(0.1, 0.0)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.BezierSegment
					{
						Point1 = new global::System.Windows.Point(0.1, -0.4),
						Point2 = new global::System.Windows.Point(0.6, -0.4),
						Point3 = new global::System.Windows.Point(0.6, -1.0)
					});
					global::Infragistics.GeometryUtil.unitHourglass = new global::System.Windows.Media.PathGeometry
					{
						Figures = new global::System.Windows.Media.PathFigureCollection()
					};
					global::Infragistics.GeometryUtil.unitHourglass.Figures.Add(pathFigure);
				}
				return global::Infragistics.GeometryUtil.unitHourglass;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0001EF1C File Offset: 0x0001D11C
		public static global::System.Windows.Media.Geometry UnitTube
		{
			get
			{
				if (global::Infragistics.GeometryUtil.unitTube == null)
				{
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
					{
						Segments = new global::System.Windows.Media.PathSegmentCollection(),
						IsClosed = true,
						IsFilled = true,
						StartPoint = new global::System.Windows.Point(-0.2, -0.8)
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.LineSegment
					{
						Point = new global::System.Windows.Point(-0.2, 0.8)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(0.2, 0.8),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(0.2, 0.2),
						SweepDirection = global::System.Windows.Media.SweepDirection.Counterclockwise
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.LineSegment
					{
						Point = new global::System.Windows.Point(0.2, -0.8)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(-0.2, -0.8),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(0.2, 0.2),
						SweepDirection = global::System.Windows.Media.SweepDirection.Counterclockwise
					});
					global::Infragistics.GeometryUtil.unitTube = new global::System.Windows.Media.PathGeometry
					{
						Figures = new global::System.Windows.Media.PathFigureCollection()
					};
					global::Infragistics.GeometryUtil.unitTube.Figures.Add(pathFigure);
				}
				return global::Infragistics.GeometryUtil.unitTube;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0001F0BC File Offset: 0x0001D2BC
		public static global::System.Windows.Media.Geometry UnitRaindrop
		{
			get
			{
				if (global::Infragistics.GeometryUtil.unitRaindrop == null)
				{
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
					{
						Segments = new global::System.Windows.Media.PathSegmentCollection(),
						IsClosed = true,
						IsFilled = true,
						StartPoint = new global::System.Windows.Point(0.0, -1.0)
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.BezierSegment
					{
						Point1 = new global::System.Windows.Point(0.0, -0.4),
						Point2 = new global::System.Windows.Point(0.6, -0.2),
						Point3 = new global::System.Windows.Point(0.6, 0.4)
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(-0.6, 0.4),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(0.6, 0.6),
						SweepDirection = global::System.Windows.Media.SweepDirection.Clockwise
					});
					pathFigure.Segments.Add(new global::System.Windows.Media.BezierSegment
					{
						Point1 = new global::System.Windows.Point(-0.6, -0.2),
						Point2 = new global::System.Windows.Point(0.0, -0.4),
						Point3 = new global::System.Windows.Point(0.0, -1.0)
					});
					global::Infragistics.GeometryUtil.unitRaindrop = new global::System.Windows.Media.PathGeometry
					{
						Figures = new global::System.Windows.Media.PathFigureCollection()
					};
					global::Infragistics.GeometryUtil.unitRaindrop.Figures.Add(pathFigure);
				}
				return global::Infragistics.GeometryUtil.unitRaindrop;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0001F274 File Offset: 0x0001D474
		public static global::System.Windows.Media.Geometry UnitSmiley
		{
			get
			{
				if (global::Infragistics.GeometryUtil.unitSmiley == null)
				{
					global::Infragistics.GeometryUtil.unitSmiley = new global::System.Windows.Media.PathGeometry();
					global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
					{
						StartPoint = new global::System.Windows.Point(0.0, -1.0),
						IsClosed = true,
						IsFilled = true
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(0.0, -1.0),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(1.0, 1.0)
					});
					global::Infragistics.GeometryUtil.unitSmiley.Figures.Add(pathFigure);
					pathFigure = new global::System.Windows.Media.PathFigure
					{
						StartPoint = new global::System.Windows.Point(-0.31, -0.15),
						IsClosed = true,
						IsFilled = true
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(-0.31, -0.15),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(0.24, 0.34)
					});
					global::Infragistics.GeometryUtil.unitSmiley.Figures.Add(pathFigure);
					pathFigure = new global::System.Windows.Media.PathFigure
					{
						StartPoint = new global::System.Windows.Point(0.31, -0.15),
						IsClosed = true,
						IsFilled = true
					};
					pathFigure.Segments.Add(new global::System.Windows.Media.ArcSegment
					{
						Point = new global::System.Windows.Point(0.31, -0.15),
						IsLargeArc = true,
						Size = new global::System.Windows.Size(0.24, 0.34)
					});
					global::Infragistics.GeometryUtil.unitSmiley.Figures.Add(pathFigure);
				}
				return global::Infragistics.GeometryUtil.unitSmiley;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001F46C File Offset: 0x0001D66C
		private static global::System.Windows.Media.Geometry PolygonGeometry(double[] xy)
		{
			global::System.Windows.Media.PointCollection pointCollection = new global::System.Windows.Media.PointCollection();
			for (int i = 2; i < xy.Length; i += 2)
			{
				pointCollection.Add(new global::System.Windows.Point(xy[i], xy[i + 1]));
			}
			global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
			{
				Segments = new global::System.Windows.Media.PathSegmentCollection(),
				IsClosed = true,
				IsFilled = true,
				StartPoint = new global::System.Windows.Point(xy[0], xy[1])
			};
			pathFigure.Segments.Add(new global::System.Windows.Media.PolyLineSegment
			{
				Points = pointCollection
			});
			global::System.Windows.Media.PathGeometry pathGeometry = new global::System.Windows.Media.PathGeometry
			{
				Figures = new global::System.Windows.Media.PathFigureCollection()
			};
			pathGeometry.Figures.Add(pathFigure);
			return pathGeometry;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001F518 File Offset: 0x0001D718
		public static global::System.Windows.Point GetCenterFromArcSegment(global::System.Windows.Point startPoint, global::System.Windows.Point endPoint, double radius, bool isCounter, bool isLargeArc)
		{
			global::System.Windows.Point point = new global::System.Windows.Point((startPoint.X + endPoint.X) / 2.0, (startPoint.Y + endPoint.Y) / 2.0);
			double num = endPoint.X - startPoint.X;
			double num2 = endPoint.Y - startPoint.Y;
			double num3 = global::System.Math.Sqrt(num * num + num2 * num2);
			double num4 = num2;
			double num5 = num * -1.0;
			if (isLargeArc == isCounter)
			{
				num4 = num2 * -1.0;
				num5 = num;
			}
			double num6 = global::System.Math.Max(global::System.Math.Abs(num4), global::System.Math.Abs(num5));
			num4 /= num6;
			num5 /= num6;
			double num7 = global::System.Math.Sqrt(num4 * num4 + num5 * num5);
			double num8 = num4 / num7;
			double num9 = num5 / num7;
			double num10 = num3 / 2.0;
			double num11 = global::System.Math.Sqrt(radius * radius - num10 * num10);
			if (double.IsNaN(num11))
			{
				num11 = 0.0;
			}
			double num12 = num11 * num8;
			double num13 = num11 * num9;
			global::System.Windows.Point result = new global::System.Windows.Point(point.X + num12, point.Y + num13);
			return result;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001F650 File Offset: 0x0001D850
		public static double GetAngleTo(global::System.Windows.Point center, global::System.Windows.Point toPoint)
		{
			double num = global::System.Math.Sqrt(global::System.Math.Pow(toPoint.X - center.X, 2.0) + global::System.Math.Pow(toPoint.Y - center.Y, 2.0));
			double num2 = global::System.Math.Acos((toPoint.X - center.X) / num);
			if (toPoint.Y - center.Y < 0.0)
			{
				num2 = 6.283185307179586 - num2;
			}
			return num2;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001F6DC File Offset: 0x0001D8DC
		public static global::System.Tuple<global::System.Windows.Point, global::System.Windows.Point> GetCircleIntersection(global::System.Windows.Point startPoint, global::System.Windows.Point endPoint, global::System.Windows.Point circleCenter, double circleRadius)
		{
			double num = startPoint.X - circleCenter.X;
			double num2 = startPoint.Y - circleCenter.Y;
			double num3 = endPoint.X - circleCenter.X;
			double num4 = endPoint.Y - circleCenter.Y;
			double num5 = num3 - num;
			double num6 = num4 - num2;
			double num7 = global::System.Math.Sqrt(num5 * num5 + num6 * num6);
			double num8 = num * num4 - num3 * num2;
			double num9 = circleRadius * circleRadius;
			double num10 = num7 * num7;
			double num11 = num8 * num8;
			double num12 = num9 * num10 - num11;
			if (num12 < 0.0)
			{
				return new global::System.Tuple<global::System.Windows.Point, global::System.Windows.Point>(new global::System.Windows.Point(double.NaN, double.NaN), new global::System.Windows.Point(double.NaN, double.NaN));
			}
			int num13 = 1;
			if (num6 < 0.0)
			{
				num13 = -1;
			}
			double num14 = (num8 * num6 + (double)num13 * num5 * global::System.Math.Sqrt(num12)) / num10;
			double num15 = (num8 * num6 - (double)num13 * num5 * global::System.Math.Sqrt(num12)) / num10;
			double num16 = (-1.0 * num8 * num5 + global::System.Math.Abs(num6) * global::System.Math.Sqrt(num12)) / num10;
			double num17 = (-1.0 * num8 * num5 - global::System.Math.Abs(num6) * global::System.Math.Sqrt(num12)) / num10;
			return new global::System.Tuple<global::System.Windows.Point, global::System.Windows.Point>(new global::System.Windows.Point(num14 + circleCenter.X, num16 + circleCenter.Y), new global::System.Windows.Point(num15 + circleCenter.X, num17 + circleCenter.Y));
		}

		// Token: 0x040002A0 RID: 672
		private static global::System.Windows.Media.Geometry unitNone;

		// Token: 0x040002A1 RID: 673
		private static global::System.Windows.Media.Geometry unitBubble;

		// Token: 0x040002A2 RID: 674
		private static global::System.Windows.Media.Geometry unitTriangle;

		// Token: 0x040002A3 RID: 675
		private static double[] unitTriangleXY = new double[]
		{
			0.0,
			1.0,
			-0.866,
			-0.5,
			0.866,
			-0.5
		};

		// Token: 0x040002A4 RID: 676
		private static global::System.Windows.Media.Geometry unitPyramid;

		// Token: 0x040002A5 RID: 677
		private static double[] unitPyramidXY = new double[]
		{
			0.0,
			-1.0,
			-0.866,
			0.5,
			0.866,
			0.5
		};

		// Token: 0x040002A6 RID: 678
		private static global::System.Windows.Media.Geometry unitSquare;

		// Token: 0x040002A7 RID: 679
		private static global::System.Windows.Media.Geometry unitDiamond;

		// Token: 0x040002A8 RID: 680
		private static double[] unitDiamondXY = new double[]
		{
			0.0,
			-1.0,
			-1.0,
			0.0,
			0.0,
			1.0,
			1.0,
			0.0
		};

		// Token: 0x040002A9 RID: 681
		private static global::System.Windows.Media.Geometry unitPentagon;

		// Token: 0x040002AA RID: 682
		private static double[] unitPentagonXY = new double[]
		{
			0.0,
			-1.0,
			-0.9511,
			-0.309,
			-0.5875,
			0.809,
			0.5875,
			0.809,
			0.9511,
			-0.309
		};

		// Token: 0x040002AB RID: 683
		private static global::System.Windows.Media.Geometry unitHexagon;

		// Token: 0x040002AC RID: 684
		private static double[] unitHexagonXY = new double[]
		{
			0.0,
			-1.0,
			-0.866,
			-0.5,
			-0.866,
			0.5,
			0.0,
			1.0,
			0.866,
			0.5,
			0.866,
			-0.5
		};

		// Token: 0x040002AD RID: 685
		private static global::System.Windows.Media.Geometry unitTetragram;

		// Token: 0x040002AE RID: 686
		private static double[] unitTetragramXY = new double[]
		{
			0.0,
			-1.0,
			-0.3536,
			-0.3536,
			-1.0,
			0.0,
			-0.3536,
			0.3536,
			0.0,
			1.0,
			0.3536,
			0.3536,
			1.0,
			0.0,
			0.3536,
			-0.3536
		};

		// Token: 0x040002AF RID: 687
		private static global::System.Windows.Media.Geometry unitPentagram;

		// Token: 0x040002B0 RID: 688
		private static double[] unitPentagramXY = new double[]
		{
			0.0,
			-1.0,
			-0.2939,
			-0.4045,
			-0.9511,
			-0.309,
			-0.4755,
			0.1545,
			-0.5878,
			0.809,
			0.0,
			0.5,
			0.5878,
			0.809,
			0.4755,
			0.1545,
			0.9511,
			-0.309,
			0.2939,
			-0.4045
		};

		// Token: 0x040002B1 RID: 689
		private static global::System.Windows.Media.Geometry unitHexagram;

		// Token: 0x040002B2 RID: 690
		private static double[] unitHexagramXY = new double[]
		{
			0.0,
			-1.0,
			-0.25,
			-0.433,
			-0.866,
			-0.5,
			-0.5,
			0.0,
			-0.866,
			0.5,
			-0.25,
			0.433,
			0.0,
			1.0,
			0.25,
			0.433,
			0.866,
			0.5,
			0.5,
			0.0,
			0.866,
			-0.5,
			0.25,
			-0.433
		};

		// Token: 0x040002B3 RID: 691
		private static global::System.Windows.Media.PathGeometry unitThermometer;

		// Token: 0x040002B4 RID: 692
		private static global::System.Windows.Media.PathGeometry unitHourglass;

		// Token: 0x040002B5 RID: 693
		private static global::System.Windows.Media.PathGeometry unitTube;

		// Token: 0x040002B6 RID: 694
		private static global::System.Windows.Media.PathGeometry unitRaindrop;

		// Token: 0x040002B7 RID: 695
		private static global::System.Windows.Media.PathGeometry unitSmiley;
	}
}
