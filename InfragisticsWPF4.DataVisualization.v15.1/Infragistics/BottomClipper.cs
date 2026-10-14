using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006F RID: 111
	internal class BottomClipper : global::Infragistics.EdgeClipper
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x000189AA File Offset: 0x00016BAA
		protected override bool IsInside(global::System.Windows.Point pt)
		{
			return pt.Y <= this.Edge;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000189C0 File Offset: 0x00016BC0
		protected override global::System.Windows.Point Intersection(global::System.Windows.Point b, global::System.Windows.Point e)
		{
			return new global::System.Windows.Point(b.X + (e.X - b.X) * (this.Edge - b.Y) / (e.Y - b.Y), this.Edge);
		}

		// Token: 0x04000272 RID: 626
		public double Edge;
	}
}
