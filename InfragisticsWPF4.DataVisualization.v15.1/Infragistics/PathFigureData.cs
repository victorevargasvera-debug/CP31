using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000DE RID: 222
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PathFigureData : global::Infragistics.IVisualData
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00028FEC File Offset: 0x000271EC
		public PathFigureData()
		{
			this.Segments = new global::System.Collections.Generic.List<global::Infragistics.SegmentData>();
			this.StartPoint = default(global::System.Windows.Point);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0002901C File Offset: 0x0002721C
		public PathFigureData(global::System.Windows.Media.PathFigure fig)
		{
			this.Segments = new global::System.Collections.Generic.List<global::Infragistics.SegmentData>();
			this.StartPoint = fig.StartPoint;
			for (int i = 0; i < fig.Segments.Count; i++)
			{
				global::System.Windows.Media.PathSegment pathSegment = fig.Segments[i];
				global::Infragistics.SegmentData item = null;
				if (pathSegment is global::System.Windows.Media.LineSegment)
				{
					item = new global::Infragistics.LineSegmentData((global::System.Windows.Media.LineSegment)pathSegment);
				}
				else if (pathSegment is global::System.Windows.Media.PolyLineSegment)
				{
					item = new global::Infragistics.PolylineSegmentData((global::System.Windows.Media.PolyLineSegment)pathSegment);
				}
				else if (pathSegment is global::System.Windows.Media.ArcSegment)
				{
					item = new global::Infragistics.ArcSegmentData((global::System.Windows.Media.ArcSegment)pathSegment);
				}
				else if (pathSegment is global::System.Windows.Media.PolyBezierSegment)
				{
					item = new global::Infragistics.PolyBezierSegmentData((global::System.Windows.Media.PolyBezierSegment)pathSegment);
				}
				this.Segments.Add(item);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000290D0 File Offset: 0x000272D0
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x000290D8 File Offset: 0x000272D8
		public global::System.Windows.Point StartPoint { get; set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x000290E1 File Offset: 0x000272E1
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x000290E9 File Offset: 0x000272E9
		public global::System.Collections.Generic.List<global::Infragistics.SegmentData> Segments { get; set; }

		// Token: 0x0600093B RID: 2363 RVA: 0x000290F4 File Offset: 0x000272F4
		public string Serialize()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("{");
			stringBuilder.AppendLine(string.Concat(new object[]
			{
				"startPoint: { x: ",
				this.StartPoint.X,
				", y: ",
				this.StartPoint.Y,
				"}, "
			}));
			stringBuilder.AppendLine("segments: [");
			for (int i = 0; i < this.Segments.Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(this.Segments[i].Serialize());
			}
			stringBuilder.AppendLine("]");
			stringBuilder.AppendLine("}");
			return stringBuilder.ToString();
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000291D4 File Offset: 0x000273D4
		internal void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.StartPoint = new global::System.Windows.Point((this.StartPoint.X - viewport.Left) / viewport.Width, (this.StartPoint.Y - viewport.Top) / viewport.Height);
			for (int i = 0; i < this.Segments.Count; i++)
			{
				this.Segments[i].ScaleByViewport(viewport);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00029250 File Offset: 0x00027450
		public void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			if (!settings.IgnoreFigureStartPoint)
			{
				list.Add(new global::System.Windows.Point(this.StartPoint.X, this.StartPoint.Y));
			}
			for (int i = 0; i < this.Segments.Count; i++)
			{
				this.Segments[i].GetPointsOverride(list, settings);
			}
		}
	}
}
