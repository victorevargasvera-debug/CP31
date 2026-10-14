using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000E0 RID: 224
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class LineSegmentData : global::Infragistics.SegmentData
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x00029330 File Offset: 0x00027530
		public LineSegmentData()
		{
			this.Point = default(global::System.Windows.Point);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00029352 File Offset: 0x00027552
		public LineSegmentData(global::System.Windows.Media.LineSegment seg)
		{
			this.Point = seg.Point;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00029366 File Offset: 0x00027566
		public override string Type
		{
			get
			{
				return "Line";
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0002936D File Offset: 0x0002756D
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00029375 File Offset: 0x00027575
		public global::System.Windows.Point Point { get; set; }

		// Token: 0x06000949 RID: 2377 RVA: 0x00029380 File Offset: 0x00027580
		protected override string SerializeOverride()
		{
			return string.Concat(new object[]
			{
				"point: { x: ",
				this.Point.X,
				", y: ",
				this.Point.Y,
				"}"
			});
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000293E0 File Offset: 0x000275E0
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.Point = new global::System.Windows.Point((this.Point.X - viewport.Left) / viewport.Width, (this.Point.Y - viewport.Top) / viewport.Height);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00029434 File Offset: 0x00027634
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Windows.Point> current, global::Infragistics.GetPointsSettings settings)
		{
			current.Add(new global::System.Windows.Point(this.Point.X, this.Point.Y));
		}
	}
}
