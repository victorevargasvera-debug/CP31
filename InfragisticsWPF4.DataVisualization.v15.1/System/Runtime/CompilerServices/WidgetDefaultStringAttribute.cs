using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000082 RID: 130
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	public class WidgetDefaultStringAttribute : global::System.Attribute
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x0001BFC3 File Offset: 0x0001A1C3
		public WidgetDefaultStringAttribute(string value)
		{
			this.Value = value;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001BFD2 File Offset: 0x0001A1D2
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0001BFDA File Offset: 0x0001A1DA
		public string Value { get; set; }
	}
}
