using System;

namespace Infragistics
{
	// Token: 0x020000D3 RID: 211
	public class AnimationEventArgs : global::System.EventArgs
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
		public double Value { get; internal set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0001C0DD File Offset: 0x0001A2DD
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0001C0E5 File Offset: 0x0001A2E5
		public double Difference { get; internal set; }
	}
}
