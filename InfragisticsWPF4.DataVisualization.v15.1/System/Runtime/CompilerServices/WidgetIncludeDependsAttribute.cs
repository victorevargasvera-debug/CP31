using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200008C RID: 140
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class WidgetIncludeDependsAttribute : global::System.Attribute
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x0001C0BB File Offset: 0x0001A2BB
		public WidgetIncludeDependsAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0001C0CA File Offset: 0x0001A2CA
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x0001C0D2 File Offset: 0x0001A2D2
		public string Name { get; set; }
	}
}
