using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200008A RID: 138
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	public class WidgetModuleExclusionParentAttribute : global::System.Attribute
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x0001C07B File Offset: 0x0001A27B
		public WidgetModuleExclusionParentAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001C08A File Offset: 0x0001A28A
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x0001C092 File Offset: 0x0001A292
		public string Name { get; set; }
	}
}
