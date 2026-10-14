using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000DB RID: 219
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class LineGeometryData : global::Infragistics.GeometryData
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00028B24 File Offset: 0x00026D24
		public override string Type
		{
			get
			{
				return "Line";
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00028B2B File Offset: 0x00026D2B
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x00028B33 File Offset: 0x00026D33
		public double X1 { get; set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00028B3C File Offset: 0x00026D3C
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00028B44 File Offset: 0x00026D44
		public double Y1 { get; set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00028B4D File Offset: 0x00026D4D
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00028B55 File Offset: 0x00026D55
		public double X2 { get; set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00028B5E File Offset: 0x00026D5E
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00028B66 File Offset: 0x00026D66
		public double Y2 { get; set; }

		// Token: 0x06000917 RID: 2327 RVA: 0x00028B70 File Offset: 0x00026D70
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
				", y2:",
				this.Y2
			});
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00028BE4 File Offset: 0x00026DE4
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.X1 = (this.X1 - viewport.Left) / viewport.Width;
			this.Y1 = (this.Y1 - viewport.Top) / viewport.Height;
			this.X2 = (this.X2 - viewport.Left) / viewport.Width;
			this.Y2 = (this.Y2 - viewport.Top) / viewport.Height;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00028C64 File Offset: 0x00026E64
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			list.Add(new global::System.Windows.Point(this.X1, this.Y1));
			list.Add(new global::System.Windows.Point(this.X2, this.Y2));
		}
	}
}
