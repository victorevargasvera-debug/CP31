using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200018E RID: 398
	internal class GridBagConstraint : global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x06001910 RID: 6416 RVA: 0x00073FDA File Offset: 0x000721DA
		public GridBagConstraint()
		{
			this.RowSpan = 1;
			this.ColumnSpan = 1;
			this.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
			this.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00073FFE File Offset: 0x000721FE
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00074006 File Offset: 0x00072206
		public int Column { get; set; }

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0007400F File Offset: 0x0007220F
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00074017 File Offset: 0x00072217
		public int ColumnSpan { get; set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x00074020 File Offset: 0x00072220
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x00074028 File Offset: 0x00072228
		public float ColumnWeight { get; set; }

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x00074031 File Offset: 0x00072231
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x00074039 File Offset: 0x00072239
		public int Row { get; set; }

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00074042 File Offset: 0x00072242
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x0007404A File Offset: 0x0007224A
		public int RowSpan { get; set; }

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00074053 File Offset: 0x00072253
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0007405B File Offset: 0x0007225B
		public float RowWeight { get; set; }

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00074064 File Offset: 0x00072264
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0007406C File Offset: 0x0007226C
		public global::System.Windows.Thickness Margin { get; set; }

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x00074075 File Offset: 0x00072275
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x0007407D File Offset: 0x0007227D
		public global::System.Windows.HorizontalAlignment HorizontalAlignment { get; set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00074086 File Offset: 0x00072286
		// (set) Token: 0x06001922 RID: 6434 RVA: 0x0007408E File Offset: 0x0007228E
		public global::System.Windows.VerticalAlignment VerticalAlignment { get; set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x00074097 File Offset: 0x00072297
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this.Column;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x0007409F File Offset: 0x0007229F
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this.ColumnSpan;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x000740A7 File Offset: 0x000722A7
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this.ColumnWeight;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x000740AF File Offset: 0x000722AF
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return this.HorizontalAlignment;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x000740B7 File Offset: 0x000722B7
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				return this.Margin;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000740BF File Offset: 0x000722BF
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this.Row;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x000740C7 File Offset: 0x000722C7
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this.RowSpan;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000740CF File Offset: 0x000722CF
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this.RowWeight;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x000740D7 File Offset: 0x000722D7
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return this.VerticalAlignment;
			}
		}
	}
}
