using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000089 RID: 137
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	public class WidgetModuleParentAttribute : global::System.Attribute
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x0001C05B File Offset: 0x0001A25B
		public WidgetModuleParentAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001C06A File Offset: 0x0001A26A
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x0001C072 File Offset: 0x0001A272
		public string Name { get; set; }
	}
}
