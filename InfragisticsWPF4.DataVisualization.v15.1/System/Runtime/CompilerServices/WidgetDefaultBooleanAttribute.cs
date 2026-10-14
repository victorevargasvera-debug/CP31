using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000084 RID: 132
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	public class WidgetDefaultBooleanAttribute : global::System.Attribute
	{
		// Token: 0x06000666 RID: 1638 RVA: 0x0001C003 File Offset: 0x0001A203
		public WidgetDefaultBooleanAttribute(bool value)
		{
			this.Value = value;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001C012 File Offset: 0x0001A212
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0001C01A File Offset: 0x0001A21A
		public bool Value { get; set; }
	}
}
