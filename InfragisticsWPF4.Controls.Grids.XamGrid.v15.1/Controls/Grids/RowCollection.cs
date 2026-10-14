using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000282 RID: 642
	public class RowCollection : global::Infragistics.Collections.BindableItemCollection<global::Infragistics.Controls.Grids.Row>
	{
		// Token: 0x06001551 RID: 5457 RVA: 0x0004DE42 File Offset: 0x0004C042
		public RowCollection(global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row> owner, global::Infragistics.Controls.Grids.ColumnLayout columnLayout) : base(owner)
		{
			this._columnLayout = columnLayout;
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0004DE52 File Offset: 0x0004C052
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Clear()
		{
			base.Clear();
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0004DE5A File Offset: 0x0004C05A
		public new void RemoveRange(global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row> itemsToRemove)
		{
			base.RemoveRange(itemsToRemove);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0004DE63 File Offset: 0x0004C063
		public void SelectAll()
		{
			if (this._columnLayout != null && this._columnLayout.Grid != null)
			{
				this._columnLayout.Grid.SelectionSettings.SelectedRows.SelectRange(this);
			}
		}

		// Token: 0x04000668 RID: 1640
		private global::Infragistics.Controls.Grids.ColumnLayout _columnLayout;
	}
}
