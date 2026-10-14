using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000089 RID: 137
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false)]
	public sealed class ViewSortHintAttribute : global::System.Attribute
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x0000A505 File Offset: 0x00008705
		public ViewSortHintAttribute(string hint)
		{
			this.Hint = hint;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000A514 File Offset: 0x00008714
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000A51C File Offset: 0x0000871C
		public string Hint { get; private set; }
	}
}
