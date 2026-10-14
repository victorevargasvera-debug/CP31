using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006E RID: 110
	internal class LeftClipper : global::Infragistics.EdgeClipper
	{
		// Token: 0x0600062A RID: 1578 RVA: 0x0001893D File Offset: 0x00016B3D
		protected override bool IsInside(global::System.Windows.Point pt)
		{
			return pt.X >= this.Edge;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00018954 File Offset: 0x00016B54
		protected override global::System.Windows.Point Intersection(global::System.Windows.Point b, global::System.Windows.Point e)
		{
			return new global::System.Windows.Point(this.Edge, b.Y + (e.Y - b.Y) * (this.Edge - b.X) / (e.X - b.X));
		}

		// Token: 0x04000271 RID: 625
		public double Edge;
	}
}
