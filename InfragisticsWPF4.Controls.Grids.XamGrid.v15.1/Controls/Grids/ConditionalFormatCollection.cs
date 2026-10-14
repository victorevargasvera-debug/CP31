using System;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000026 RID: 38
	public class ConditionalFormatCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.IConditionalFormattingRule>
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000A612 File Offset: 0x00008812
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000A61C File Offset: 0x0000881C
		public global::Infragistics.Controls.Grids.Column Column
		{
			get
			{
				return this._column;
			}
			protected internal set
			{
				if (this._column != value)
				{
					this._column = value;
					foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule conditionalFormattingRule in this.Items)
					{
						conditionalFormattingRule.Column = value;
					}
				}
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A67C File Offset: 0x0000887C
		protected override void OnItemAdded(int index, global::Infragistics.Controls.Grids.IConditionalFormattingRule item)
		{
			if (this.Column != null)
			{
				item.Column = this.Column;
				item.PropertyChanged += this.Item_PropertyChanged;
			}
			base.OnItemAdded(index, item);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000A6AC File Offset: 0x000088AC
		protected override void OnItemRemoved(int index, global::Infragistics.Controls.Grids.IConditionalFormattingRule item)
		{
			base.OnItemRemoved(index, item);
			item.PropertyChanged -= this.Item_PropertyChanged;
			if (item.Column == this.Column)
			{
				item.Column = null;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A6E0 File Offset: 0x000088E0
		protected override void ResetItems()
		{
			foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule conditionalFormattingRule in this.Items)
			{
				conditionalFormattingRule.Column = null;
			}
			base.ResetItems();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A734 File Offset: 0x00008934
		private void Item_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnCollectionItemChanged();
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001D5 RID: 469 RVA: 0x0000A73C File Offset: 0x0000893C
		// (remove) Token: 0x060001D6 RID: 470 RVA: 0x0000A774 File Offset: 0x00008974
		public event global::System.EventHandler<global::System.EventArgs> CollectionItemChanged;

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A7A9 File Offset: 0x000089A9
		protected virtual void OnCollectionItemChanged()
		{
			if (this.CollectionItemChanged != null)
			{
				this.CollectionItemChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000079 RID: 121
		private global::Infragistics.Controls.Grids.Column _column;
	}
}
