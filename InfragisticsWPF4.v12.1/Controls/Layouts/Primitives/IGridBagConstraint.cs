using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000038 RID: 56
	public interface IGridBagConstraint
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600024B RID: 587
		int Column { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600024C RID: 588
		int ColumnSpan { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600024D RID: 589
		float ColumnWeight { get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600024E RID: 590
		global::System.Windows.HorizontalAlignment HorizontalAlignment { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600024F RID: 591
		global::System.Windows.Thickness Margin { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000250 RID: 592
		int Row { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000251 RID: 593
		int RowSpan { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000252 RID: 594
		float RowWeight { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000253 RID: 595
		global::System.Windows.VerticalAlignment VerticalAlignment { get; }
	}
}
