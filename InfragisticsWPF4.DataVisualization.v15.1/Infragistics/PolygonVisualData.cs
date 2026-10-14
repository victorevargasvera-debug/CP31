using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x020000D7 RID: 215
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PolygonVisualData : global::Infragistics.PrimitiveVisualData
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00028626 File Offset: 0x00026826
		public override string Type
		{
			get
			{
				return "Polygon";
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0002862D File Offset: 0x0002682D
		public PolygonVisualData() : base("polygon1")
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00028648 File Offset: 0x00026848
		public PolygonVisualData(string name, global::System.Windows.Shapes.Polygon polygon) : base(name)
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			for (int i = 0; i < polygon.Points.Count; i++)
			{
				this.Points.Add(polygon.Points[i]);
			}
			global::Infragistics.AppearanceHelper.GetShapeAppearance(base.Appearance, polygon);
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000286A0 File Offset: 0x000268A0
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x000286A8 File Offset: 0x000268A8
		public global::System.Collections.Generic.List<global::System.Windows.Point> Points { get; set; }

		// Token: 0x060008F6 RID: 2294 RVA: 0x000286B4 File Offset: 0x000268B4
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

		// Token: 0x060008F7 RID: 2295 RVA: 0x00028774 File Offset: 0x00026974
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			base.ScaleByViewport(viewport);
			for (int i = 0; i < this.Points.Count; i++)
			{
				this.Points[i] = new global::System.Windows.Point((this.Points[i].X - viewport.Left) / viewport.Width, (this.Points[i].Y - viewport.Top) / viewport.Height);
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000287F8 File Offset: 0x000269F8
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			for (int i = 0; i < this.Points.Count; i++)
			{
				list.Add(this.Points[i]);
			}
		}
	}
}
