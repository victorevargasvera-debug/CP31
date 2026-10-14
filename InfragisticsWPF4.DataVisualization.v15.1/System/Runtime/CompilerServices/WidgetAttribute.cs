using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000075 RID: 117
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class WidgetAttribute : global::System.Attribute
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x0001BEF5 File Offset: 0x0001A0F5
		public WidgetAttribute()
		{
			this.Name = null;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001BF04 File Offset: 0x0001A104
		public WidgetAttribute(string name)
		{
			this.Name = name;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001BF13 File Offset: 0x0001A113
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0001BF1B File Offset: 0x0001A11B
		private string Name { get; set; }
	}
}
