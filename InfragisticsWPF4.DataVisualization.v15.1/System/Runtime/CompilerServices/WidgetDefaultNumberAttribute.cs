using System;
using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000083 RID: 131
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Property)]
	public class WidgetDefaultNumberAttribute : global::System.Attribute
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x0001BFE3 File Offset: 0x0001A1E3
		public WidgetDefaultNumberAttribute(double value)
		{
			this.Value = value;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0001BFF2 File Offset: 0x0001A1F2
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x0001BFFA File Offset: 0x0001A1FA
		public double Value { get; set; }
	}
}
