using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000A4 RID: 164
	public static class PathFigureUtil
	{
		// Token: 0x0600073C RID: 1852 RVA: 0x00022844 File Offset: 0x00020A44
		public static global::System.Windows.Media.PathFigureCollection Duplicate(this global::System.Windows.Media.PathFigureCollection pathFigureCollection)
		{
			global::System.Windows.Media.PathFigureCollection pathFigureCollection2 = new global::System.Windows.Media.PathFigureCollection();
			foreach (global::System.Windows.Media.PathFigure pathFigure in pathFigureCollection)
			{
				pathFigureCollection2.Add(pathFigure.Duplicate());
			}
			return pathFigureCollection2;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x000228A0 File Offset: 0x00020AA0
		public static global::System.Windows.Media.PathFigure Duplicate(this global::System.Windows.Media.PathFigure pathFigure)
		{
			if (pathFigure == null)
			{
				return null;
			}
			global::System.Windows.Media.PathSegmentCollection pathSegmentCollection = new global::System.Windows.Media.PathSegmentCollection();
			foreach (global::System.Windows.Media.PathSegment pathSegment in pathFigure.Segments)
			{
				global::System.Windows.Media.ArcSegment arcSegment = pathSegment as global::System.Windows.Media.ArcSegment;
				if (arcSegment != null)
				{
					pathSegmentCollection.Add(new global::System.Windows.Media.ArcSegment
					{
						IsLargeArc = arcSegment.IsLargeArc,
						Point = arcSegment.Point,
						RotationAngle = arcSegment.RotationAngle,
						Size = arcSegment.Size,
						SweepDirection = arcSegment.SweepDirection
					});
				}
				else
				{
					global::System.Windows.Media.BezierSegment bezierSegment = pathSegment as global::System.Windows.Media.BezierSegment;
					if (bezierSegment != null)
					{
						pathSegmentCollection.Add(new global::System.Windows.Media.BezierSegment
						{
							Point1 = bezierSegment.Point1,
							Point2 = bezierSegment.Point2,
							Point3 = bezierSegment.Point3
						});
					}
					else
					{
						global::System.Windows.Media.LineSegment lineSegment = pathSegment as global::System.Windows.Media.LineSegment;
						if (lineSegment != null)
						{
							pathSegmentCollection.Add(new global::System.Windows.Media.LineSegment
							{
								Point = lineSegment.Point
							});
						}
						else
						{
							global::System.Windows.Media.PolyBezierSegment polyBezierSegment = pathSegment as global::System.Windows.Media.PolyBezierSegment;
							if (polyBezierSegment != null)
							{
								global::System.Windows.Media.PointCollection pointCollection = new global::System.Windows.Media.PointCollection();
								foreach (global::System.Windows.Point value in polyBezierSegment.Points)
								{
									pointCollection.Add(value);
								}
								pathSegmentCollection.Add(new global::System.Windows.Media.PolyBezierSegment
								{
									Points = pointCollection
								});
							}
							else
							{
								global::System.Windows.Media.PolyLineSegment polyLineSegment = pathSegment as global::System.Windows.Media.PolyLineSegment;
								if (polyLineSegment != null)
								{
									global::System.Windows.Media.PointCollection pointCollection2 = new global::System.Windows.Media.PointCollection();
									foreach (global::System.Windows.Point value2 in polyLineSegment.Points)
									{
										pointCollection2.Add(value2);
									}
									pathSegmentCollection.Add(new global::System.Windows.Media.PolyLineSegment
									{
										Points = pointCollection2
									});
								}
								else
								{
									global::System.Windows.Media.PolyQuadraticBezierSegment polyQuadraticBezierSegment = pathSegment as global::System.Windows.Media.PolyQuadraticBezierSegment;
									if (polyQuadraticBezierSegment != null)
									{
										global::System.Windows.Media.PointCollection pointCollection3 = new global::System.Windows.Media.PointCollection();
										foreach (global::System.Windows.Point value3 in polyQuadraticBezierSegment.Points)
										{
											pointCollection3.Add(value3);
										}
										pathSegmentCollection.Add(new global::System.Windows.Media.PolyQuadraticBezierSegment
										{
											Points = pointCollection3
										});
									}
									else
									{
										global::System.Windows.Media.QuadraticBezierSegment quadraticBezierSegment = pathSegment as global::System.Windows.Media.QuadraticBezierSegment;
										if (quadraticBezierSegment == null)
										{
											throw new global::System.NotImplementedException("PathFigure.Duplicate: " + pathSegment.ToString());
										}
										pathSegmentCollection.Add(new global::System.Windows.Media.QuadraticBezierSegment
										{
											Point1 = quadraticBezierSegment.Point1,
											Point2 = quadraticBezierSegment.Point2
										});
									}
								}
							}
						}
					}
				}
			}
			return new global::System.Windows.Media.PathFigure
			{
				IsClosed = pathFigure.IsClosed,
				IsFilled = pathFigure.IsFilled,
				StartPoint = pathFigure.StartPoint,
				Segments = pathSegmentCollection
			};
		}
	}
}
