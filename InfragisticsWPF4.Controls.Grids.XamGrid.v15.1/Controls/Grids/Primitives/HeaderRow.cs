using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200027C RID: 636
	public class HeaderRow : global::Infragistics.Controls.Grids.RowBase
	{
		// Token: 0x06001521 RID: 5409 RVA: 0x0004D993 File Offset: 0x0004BB93
		protected internal HeaderRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(manager)
		{
			base.FixedPositionSortOrder = 1;
			if (manager != null && manager.ColumnLayout != null)
			{
				this._identifer = manager.ColumnLayout.Key;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0004D9BF File Offset: 0x0004BBBF
		protected internal override global::Infragistics.Controls.Grids.RowHoverType ResolveRowHover
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHoverType.Cell;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0004D9C2 File Offset: 0x0004BBC2
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.HeaderRow;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0004D9C8 File Offset: 0x0004BBC8
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.HeaderRowHeightResolved;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0004D9FF File Offset: 0x0004BBFF
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0004DA02 File Offset: 0x0004BC02
		protected override string RecyclingIdentifier
		{
			get
			{
				return this._identifer + "_" + this.RowType.ToString();
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x0004DA24 File Offset: 0x0004BC24
		protected internal override bool IsStandAloneRow
		{
			get
			{
				bool result = base.IsStandAloneRow;
				if (this.ColumnLayout != null)
				{
					bool childrenShouldBeDisplayedResolved = ((global::Infragistics.Controls.Grids.RowsManager)base.Manager).ChildrenShouldBeDisplayedResolved;
					result = (this.ColumnLayout.FilteringSettings.AllowFilteringResolved == global::Infragistics.Controls.Grids.FilterUIType.FilterMenu && childrenShouldBeDisplayedResolved);
				}
				return result;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0004DA6C File Offset: 0x0004BC6C
		protected internal override bool IsStandAloneRowResolved
		{
			get
			{
				bool result = base.IsStandAloneRowResolved;
				if (this.ColumnLayout != null)
				{
					result = (this.ColumnLayout.FilteringSettings.AllowFilteringResolved == global::Infragistics.Controls.Grids.FilterUIType.FilterMenu);
				}
				return result;
			}
		}

		// Token: 0x04000660 RID: 1632
		private string _identifer;
	}
}
