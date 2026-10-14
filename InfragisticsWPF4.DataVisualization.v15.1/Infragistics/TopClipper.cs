using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000071 RID: 113
	internal class TopClipper : global::Infragistics.EdgeClipper
	{
		// Token: 0x06000633 RID: 1587 RVA: 0x00018A82 File Offset: 0x00016C82
		protected override bool IsInside(global::System.Windows.Point pt)
		{
			return pt.Y >= this.Edge;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00018A98 File Offset: 0x00016C98
		protected override global::System.Windows.Point Intersection(global::System.Windows.Point b, global::System.Windows.Point e)
		{
			return new global::System.Windows.Point(b.X + (e.X - b.X) * (this.Edge - b.Y) / (e.Y - b.Y), this.Edge);
		}

		// Token: 0x04000274 RID: 628
		public double Edge;
	}
}
