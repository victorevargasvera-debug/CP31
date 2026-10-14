using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000172 RID: 370
	internal class GridBagConstraint : global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x0600158E RID: 5518 RVA: 0x00061E86 File Offset: 0x00060086
		public GridBagConstraint()
		{
			this.RowSpan = 1;
			this.ColumnSpan = 1;
			this.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
			this.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00061EAA File Offset: 0x000600AA
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x00061EB2 File Offset: 0x000600B2
		public int Column { get; set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00061EBB File Offset: 0x000600BB
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00061EC3 File Offset: 0x000600C3
		public int ColumnSpan { get; set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00061ECC File Offset: 0x000600CC
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00061ED4 File Offset: 0x000600D4
		public float ColumnWeight { get; set; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00061EDD File Offset: 0x000600DD
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x00061EE5 File Offset: 0x000600E5
		public int Row { get; set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00061EEE File Offset: 0x000600EE
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00061EF6 File Offset: 0x000600F6
		public int RowSpan { get; set; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00061EFF File Offset: 0x000600FF
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00061F07 File Offset: 0x00060107
		public float RowWeight { get; set; }

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00061F10 File Offset: 0x00060110
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x00061F18 File Offset: 0x00060118
		public global::System.Windows.Thickness Margin { get; set; }

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00061F21 File Offset: 0x00060121
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x00061F29 File Offset: 0x00060129
		public global::System.Windows.HorizontalAlignment HorizontalAlignment { get; set; }

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00061F32 File Offset: 0x00060132
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00061F3A File Offset: 0x0006013A
		public global::System.Windows.VerticalAlignment VerticalAlignment { get; set; }

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00061F43 File Offset: 0x00060143
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this.Column;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00061F4B File Offset: 0x0006014B
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this.ColumnSpan;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00061F53 File Offset: 0x00060153
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this.ColumnWeight;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00061F5B File Offset: 0x0006015B
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return this.HorizontalAlignment;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00061F63 File Offset: 0x00060163
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				return this.Margin;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00061F6B File Offset: 0x0006016B
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this.Row;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00061F73 File Offset: 0x00060173
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this.RowSpan;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00061F7B File Offset: 0x0006017B
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this.RowWeight;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00061F83 File Offset: 0x00060183
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return this.VerticalAlignment;
			}
		}
	}
}
