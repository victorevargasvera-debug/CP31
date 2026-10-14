using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000DC RID: 220
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class RectangleGeometryData : global::Infragistics.GeometryData
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00028CB4 File Offset: 0x00026EB4
		public override string Type
		{
			get
			{
				return "Rectangle";
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00028CBB File Offset: 0x00026EBB
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x00028CC3 File Offset: 0x00026EC3
		public double X { get; set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00028CCC File Offset: 0x00026ECC
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x00028CD4 File Offset: 0x00026ED4
		public double Y { get; set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00028CDD File Offset: 0x00026EDD
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00028CE5 File Offset: 0x00026EE5
		public double Width { get; set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00028CEE File Offset: 0x00026EEE
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00028CF6 File Offset: 0x00026EF6
		public double Height { get; set; }

		// Token: 0x06000924 RID: 2340 RVA: 0x00028D00 File Offset: 0x00026F00
		protected override string SerializeOverride()
		{
			return string.Concat(new object[]
			{
				"x: ",
				this.X,
				", y: ",
				this.Y,
				", width: ",
				this.Width,
				", height: ",
				this.Height
			});
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00028D74 File Offset: 0x00026F74
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.X = (this.X - viewport.Left) / viewport.Width;
			this.Y = (this.Y - viewport.Top) / viewport.Height;
			this.Width /= viewport.Width;
			this.Height /= viewport.Height;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00028DE4 File Offset: 0x00026FE4
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points, global::Infragistics.GetPointsSettings settings)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			points.Add(list);
			list.Add(new global::System.Windows.Point(this.X, this.Y));
			list.Add(new global::System.Windows.Point(this.X + this.Width, this.Y));
			list.Add(new global::System.Windows.Point(this.X + this.Width, this.Y + this.Height));
			list.Add(new global::System.Windows.Point(this.X, this.Y + this.Height));
		}
	}
}
