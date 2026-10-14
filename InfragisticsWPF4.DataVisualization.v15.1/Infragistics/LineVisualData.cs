using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Shapes;

namespace Infragistics
{
	// Token: 0x020000D5 RID: 213
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class LineVisualData : global::Infragistics.PrimitiveVisualData
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00028262 File Offset: 0x00026462
		public override string Type
		{
			get
			{
				return "Line";
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00028269 File Offset: 0x00026469
		public LineVisualData() : base("line1")
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00028278 File Offset: 0x00026478
		public LineVisualData(string name, global::System.Windows.Shapes.Line line) : base(name)
		{
			this.X1 = line.X1;
			this.Y1 = line.Y1;
			this.X2 = line.X2;
			this.Y2 = line.Y2;
			global::Infragistics.AppearanceHelper.GetShapeAppearance(base.Appearance, line);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x000282C8 File Offset: 0x000264C8
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x000282D0 File Offset: 0x000264D0
		public double X1 { get; set; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x000282D9 File Offset: 0x000264D9
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x000282E1 File Offset: 0x000264E1
		public double Y1 { get; set; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000282EA File Offset: 0x000264EA
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x000282F2 File Offset: 0x000264F2
		public double X2 { get; set; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000282FB File Offset: 0x000264FB
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00028303 File Offset: 0x00026503
		public double Y2 { get; set; }

		// Token: 0x060008E6 RID: 2278 RVA: 0x0002830C File Offset: 0x0002650C
		protected override string SerializeOverride()
		{
			return string.Concat(new object[]
			{
				"x1: ",
				this.X1,
				", y1: ",
				this.Y1,
				", x2: ",
				this.X2,
				", y2: ",
				this.Y2
			});
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00028380 File Offset: 0x00026580
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			base.ScaleByViewport(viewport);
			this.X1 = (this.X1 - viewport.Left) / viewport.Width;
			this.Y1 = (this.Y1 - viewport.Top) / viewport.Height;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000283CC File Offset: 0x000265CC
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			list.Add(new global::System.Windows.Point(this.X1, this.Y1));
			list.Add(new global::System.Windows.Point(this.X2, this.Y2));
		}
	}
}
