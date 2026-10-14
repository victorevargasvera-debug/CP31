using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000082 RID: 130
	public class ViewRegisteredEventArgs : global::System.EventArgs
	{
		// Token: 0x0600037F RID: 895 RVA: 0x00009D0D File Offset: 0x00007F0D
		public ViewRegisteredEventArgs(string regionName, global::System.Func<object> getViewDelegate)
		{
			this.GetView = getViewDelegate;
			this.RegionName = regionName;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00009D23 File Offset: 0x00007F23
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00009D2B File Offset: 0x00007F2B
		public string RegionName { get; private set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00009D34 File Offset: 0x00007F34
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00009D3C File Offset: 0x00007F3C
		public global::System.Func<object> GetView { get; private set; }
	}
}
