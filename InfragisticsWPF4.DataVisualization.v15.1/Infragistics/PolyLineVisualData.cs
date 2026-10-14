using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x020000D6 RID: 214
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class PolyLineVisualData : global::Infragistics.PrimitiveVisualData
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00028414 File Offset: 0x00026614
		public override string Type
		{
			get
			{
				return "Polyline";
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0002841B File Offset: 0x0002661B
		public PolyLineVisualData() : base("polyLine1")
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00028434 File Offset: 0x00026634
		public PolyLineVisualData(string name, global::System.Windows.Shapes.Polyline line) : base(name)
		{
			this.Points = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			for (int i = 0; i < line.Points.Count; i++)
			{
				this.Points.Add(line.Points[i]);
			}
			global::Infragistics.AppearanceHelper.GetShapeAppearance(base.Appearance, line);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0002848C File Offset: 0x0002668C
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00028494 File Offset: 0x00026694
		public global::System.Collections.Generic.List<global::System.Windows.Point> Points { get; set; }

		// Token: 0x060008EE RID: 2286 RVA: 0x000284A0 File Offset: 0x000266A0
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

		// Token: 0x060008EF RID: 2287 RVA: 0x00028560 File Offset: 0x00026760
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			base.ScaleByViewport(viewport);
			for (int i = 0; i < this.Points.Count; i++)
			{
				this.Points[i] = new global::System.Windows.Point((this.Points[i].X - viewport.Left) / viewport.Width, (this.Points[i].Y - viewport.Top) / viewport.Height);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000285E4 File Offset: 0x000267E4
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
