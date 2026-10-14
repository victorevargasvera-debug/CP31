using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200006E RID: 110
	public class NavigationResult
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00008E1C File Offset: 0x0000701C
		public NavigationResult(global::Microsoft.Practices.Prism.Regions.NavigationContext context, bool? result)
		{
			this.Context = context;
			this.Result = result;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00008E32 File Offset: 0x00007032
		public NavigationResult(global::Microsoft.Practices.Prism.Regions.NavigationContext context, global::System.Exception error)
		{
			this.Context = context;
			this.Error = error;
			this.Result = new bool?(false);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00008E54 File Offset: 0x00007054
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00008E5C File Offset: 0x0000705C
		public bool? Result { get; private set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00008E65 File Offset: 0x00007065
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00008E6D File Offset: 0x0000706D
		public global::System.Exception Error { get; private set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00008E76 File Offset: 0x00007076
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00008E7E File Offset: 0x0000707E
		public global::Microsoft.Practices.Prism.Regions.NavigationContext Context { get; private set; }
	}
}
