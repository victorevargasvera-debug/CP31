using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000070 RID: 112
	internal class RightClipper : global::Infragistics.EdgeClipper
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x00018A16 File Offset: 0x00016C16
		protected override bool IsInside(global::System.Windows.Point pt)
		{
			return pt.X <= this.Edge;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00018A2C File Offset: 0x00016C2C
		protected override global::System.Windows.Point Intersection(global::System.Windows.Point b, global::System.Windows.Point e)
		{
			return new global::System.Windows.Point(this.Edge, b.Y + (e.Y - b.Y) * (this.Edge - b.X) / (e.X - b.X));
		}

		// Token: 0x04000273 RID: 627
		public double Edge;
	}
}
