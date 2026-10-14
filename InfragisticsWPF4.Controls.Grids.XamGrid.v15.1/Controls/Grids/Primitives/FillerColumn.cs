using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200024D RID: 589
	public sealed class FillerColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x00045C08 File Offset: 0x00043E08
		internal FillerColumn()
		{
			this._width = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, true);
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00045C25 File Offset: 0x00043E25
		public override global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00045C2D File Offset: 0x00043E2D
		public override bool IsSortable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00045C30 File Offset: 0x00043E30
		public override bool IsFixable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00045C33 File Offset: 0x00043E33
		public override bool IsFilterable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00045C36 File Offset: 0x00043E36
		public override bool IsMovable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00045C39 File Offset: 0x00043E39
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00045C3C File Offset: 0x00043E3C
		protected internal override bool SupportsHeaderFooterContent
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00045C3F File Offset: 0x00043E3F
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00045C42 File Offset: 0x00043E42
		protected internal override void FillAvailableFilters(global::Infragistics.Controls.Grids.FilterOperandCollection availableFilters)
		{
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x00045C44 File Offset: 0x00043E44
		public override bool IsSummable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00045C47 File Offset: 0x00043E47
		public override global::System.Windows.Style CellStyleResolved
		{
			get
			{
				if (base.CellStyle == null)
				{
					return base.ColumnLayout.FillerColumnSettings.StyleResolved;
				}
				return base.CellStyle;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00045C68 File Offset: 0x00043E68
		public override global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				if (base.HeaderStyle == null)
				{
					return base.ColumnLayout.FillerColumnSettings.HeaderStyleResolved;
				}
				return base.HeaderStyle;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00045C89 File Offset: 0x00043E89
		public override global::System.Windows.Style FooterStyleResolved
		{
			get
			{
				if (base.FooterStyle == null)
				{
					return base.ColumnLayout.FillerColumnSettings.FooterStyleResolved;
				}
				return base.FooterStyle;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00045CAA File Offset: 0x00043EAA
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x00045CAD File Offset: 0x00043EAD
		public override bool IsGroupable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsGroupable = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00045CB6 File Offset: 0x00043EB6
		public override bool IsHideable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00045CB9 File Offset: 0x00043EB9
		protected internal override global::Infragistics.Controls.Grids.Primitives.SelectionControl GenerateFilterSelectionControl()
		{
			return null;
		}

		// Token: 0x040005D6 RID: 1494
		private global::Infragistics.Controls.Grids.ColumnWidth _width;
	}
}
