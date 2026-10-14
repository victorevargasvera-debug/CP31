using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000088 RID: 136
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	public class WidgetModuleAttribute : global::System.Attribute
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x0001C03B File Offset: 0x0001A23B
		public WidgetModuleAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001C04A File Offset: 0x0001A24A
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0001C052 File Offset: 0x0001A252
		public string Name { get; set; }
	}
}
