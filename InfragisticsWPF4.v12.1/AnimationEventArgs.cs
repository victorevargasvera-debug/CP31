using System;

namespace Infragistics
{
	// Token: 0x020000B7 RID: 183
	public class AnimationEventArgs : global::System.EventArgs
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00018924 File Offset: 0x00016B24
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0001892C File Offset: 0x00016B2C
		public double Value { get; internal set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00018935 File Offset: 0x00016B35
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0001893D File Offset: 0x00016B3D
		public double Difference { get; internal set; }
	}
}
