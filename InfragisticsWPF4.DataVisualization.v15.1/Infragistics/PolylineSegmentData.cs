using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000E1 RID: 225
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PolylineSegmentData : global::Infragistics.SegmentData
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x00029468 File Offset: 0x00027668
		public PolylineSegmentData()
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0002947C File Offset: 0x0002767C
		public PolylineSegmentData(global::System.Windows.Media.PolyLineSegment poly)
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			for (int i = 0; i < poly.Points.Count; i++)
			{
				this.Points.Add(poly.Points[i]);
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x000294C7 File Offset: 0x000276C7
		public override string Type
		{
			get
			{
				return "Polyline";
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x000294CE File Offset: 0x000276CE
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x000294D6 File Offset: 0x000276D6
		public global::System.Collections.Generic.List<global::System.Windows.Point> Points { get; set; }

		// Token: 0x06000951 RID: 2385 RVA: 0x000294E0 File Offset: 0x000276E0
		protected override string SerializeOverride()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("points: [");
			for (int i = 0; i < this.Points.Count; i++)
			{
				if (i != 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(string.Concat(new object[]
				{
					"{ x: ",
					this.Points[i].X,
					", y: ",
					this.Points[i].Y,
					"}"
				}));
			}
			stringBuilder.AppendLine("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000295A0 File Offset: 0x000277A0
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				this.Points[i] = new global::System.Windows.Point((this.Points[i].X - viewport.Left) / viewport.Width, (this.Points[i].Y - viewport.Top) / viewport.Height);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0002961C File Offset: 0x0002781C
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Windows.Point> current, global::Infragistics.GetPointsSettings settings)
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				current.Add(new global::System.Windows.Point(this.Points[i].X, this.Points[i].Y));
			}
		}
	}
}
