using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000076 RID: 118
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	public class MainWidgetAttribute : global::System.Attribute
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0001BF24 File Offset: 0x0001A124
		public MainWidgetAttribute()
		{
			this.Name = null;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001BF33 File Offset: 0x0001A133
		public MainWidgetAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0001BF42 File Offset: 0x0001A142
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0001BF4A File Offset: 0x0001A14A
		private string Name { get; set; }
	}
}
