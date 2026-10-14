using System;

namespace Infragistics
{
	// Token: 0x02000004 RID: 4
	public class AnimationEventArgs : global::System.EventArgs
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000025E0 File Offset: 0x000007E0
		public double Value { get; internal set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000025E9 File Offset: 0x000007E9
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000025F1 File Offset: 0x000007F1
		public double Difference { get; internal set; }
	}
}
