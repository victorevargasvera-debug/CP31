using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000E2 RID: 226
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PolyBezierSegmentData : global::Infragistics.SegmentData
	{
		// Token: 0x06000954 RID: 2388 RVA: 0x00029672 File Offset: 0x00027872
		public PolyBezierSegmentData()
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00029688 File Offset: 0x00027888
		public PolyBezierSegmentData(global::System.Windows.Media.PolyBezierSegment poly)
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			for (int i = 0; i < poly.Points.Count; i++)
			{
				this.Points.Add(poly.Points[i]);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x000296D3 File Offset: 0x000278D3
		public override string Type
		{
			get
			{
				return "PolyBezierSpline";
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000296DA File Offset: 0x000278DA
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000296E2 File Offset: 0x000278E2
		public global::System.Collections.Generic.List<global::System.Windows.Point> Points { get; set; }

		// Token: 0x06000959 RID: 2393 RVA: 0x000296EC File Offset: 0x000278EC
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

		// Token: 0x0600095A RID: 2394 RVA: 0x000297AC File Offset: 0x000279AC
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				this.Points[i] = new global::System.Windows.Point((this.Points[i].X - viewport.Left) / viewport.Width, (this.Points[i].Y - viewport.Top) / viewport.Height);
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00029828 File Offset: 0x00027A28
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Windows.Point> current, global::Infragistics.GetPointsSettings settings)
		{
			for (int i = 0; i < this.Points.Count; i++)
			{
				current.Add(new global::System.Windows.Point(this.Points[i].X, this.Points[i].Y));
			}
		}
	}
}
