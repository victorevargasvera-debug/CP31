using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200004C RID: 76
	public interface IGridBagConstraint
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002DC RID: 732
		int Column { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060002DD RID: 733
		int ColumnSpan { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060002DE RID: 734
		float ColumnWeight { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060002DF RID: 735
		global::System.Windows.HorizontalAlignment HorizontalAlignment { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060002E0 RID: 736
		global::System.Windows.Thickness Margin { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060002E1 RID: 737
		int Row { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002E2 RID: 738
		int RowSpan { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002E3 RID: 739
		float RowWeight { get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002E4 RID: 740
		global::System.Windows.VerticalAlignment VerticalAlignment { get; }
	}
}
