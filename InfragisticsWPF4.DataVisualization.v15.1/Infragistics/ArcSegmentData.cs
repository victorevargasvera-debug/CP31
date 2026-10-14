using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000E3 RID: 227
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public class ArcSegmentData : global::Infragistics.SegmentData
	{
		// Token: 0x0600095C RID: 2396 RVA: 0x00029880 File Offset: 0x00027A80
		public ArcSegmentData()
		{
			this.Point = default(global::System.Windows.Point);
			this.IsLargeArc = false;
			this.IsCounterClockwise = true;
			this.RotationAngle = 0.0;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000298C0 File Offset: 0x00027AC0
		public ArcSegmentData(global::System.Windows.Media.ArcSegment arc)
		{
			this.Point = arc.Point;
			this.IsLargeArc = arc.IsLargeArc;
			this.IsCounterClockwise = (arc.SweepDirection == global::System.Windows.Media.SweepDirection.Counterclockwise);
			this.SizeX = arc.Size.Width;
			this.SizeY = arc.Size.Height;
			this.RotationAngle = arc.RotationAngle;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002992E File Offset: 0x00027B2E
		public override string Type
		{
			get
			{
				return "Arc";
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00029935 File Offset: 0x00027B35
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0002993D File Offset: 0x00027B3D
		public global::System.Windows.Point Point { get; set; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00029946 File Offset: 0x00027B46
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0002994E File Offset: 0x00027B4E
		public bool IsLargeArc { get; set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00029957 File Offset: 0x00027B57
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0002995F File Offset: 0x00027B5F
		public bool IsCounterClockwise { get; set; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00029968 File Offset: 0x00027B68
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00029970 File Offset: 0x00027B70
		public double SizeX { get; set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00029979 File Offset: 0x00027B79
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00029981 File Offset: 0x00027B81
		public double SizeY { get; set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0002998A File Offset: 0x00027B8A
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00029992 File Offset: 0x00027B92
		public double RotationAngle { get; set; }

		// Token: 0x0600096B RID: 2411 RVA: 0x0002999C File Offset: 0x00027B9C
		protected override string SerializeOverride()
		{
			return string.Concat(new object[]
			{
				"point: { x: ",
				this.Point.X,
				", y: ",
				this.Point.Y,
				" }, isLargeArc: ",
				this.IsLargeArc ? "true" : "false",
				", isCounterClockwise: ",
				this.IsCounterClockwise ? "true" : "false",
				", sizeX: ",
				this.SizeX,
				", sizeY: ",
				this.SizeY,
				", rotationAngle: ",
				this.RotationAngle
			});
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00029A78 File Offset: 0x00027C78
		public override void ScaleByViewport(global::System.Windows.Rect viewport)
		{
			this.Point = new global::System.Windows.Point((this.Point.X - viewport.Left) / viewport.Width, (this.Point.Y - viewport.Top) / viewport.Height);
			this.SizeX /= viewport.Width;
			this.SizeY /= viewport.Height;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00029AF4 File Offset: 0x00027CF4
		public override void GetPointsOverride(global::System.Collections.Generic.List<global::System.Windows.Point> current, global::Infragistics.GetPointsSettings settings)
		{
			current.Add(new global::System.Windows.Point(this.Point.X, this.Point.Y));
		}
	}
}
