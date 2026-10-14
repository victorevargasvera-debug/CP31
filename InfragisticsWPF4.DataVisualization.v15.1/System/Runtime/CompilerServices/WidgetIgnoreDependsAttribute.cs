using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200008B RID: 139
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	public class WidgetIgnoreDependsAttribute : global::System.Attribute
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x0001C09B File Offset: 0x0001A29B
		public WidgetIgnoreDependsAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0001C0AA File Offset: 0x0001A2AA
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x0001C0B2 File Offset: 0x0001A2B2
		public string Name { get; set; }
	}
}
