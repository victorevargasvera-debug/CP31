using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200026B RID: 619
	public abstract class ExpandableRowBase : global::Infragistics.Controls.Grids.RowBase
	{
		// Token: 0x06001433 RID: 5171 RVA: 0x0004B758 File Offset: 0x00049958
		protected internal ExpandableRowBase(global::Infragistics.Controls.Grids.RowsManagerBase manager) : base(manager)
		{
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0004B761 File Offset: 0x00049961
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0004B76C File Offset: 0x0004996C
		public bool IsExpanded
		{
			get
			{
				return this._expanded;
			}
			set
			{
				if (this._expanded != value)
				{
					if (!this.ColumnLayout.Grid.OnRowExpansionChanging(this))
					{
						this._expanded = value;
						if (value && this.HasChildren)
						{
							base.Manager.RegisterChildRowsManager(this.ChildRowsManager);
						}
						else
						{
							base.Manager.UnregisterChildRowsManager(this.ChildRowsManager);
						}
						this.OnPropertyChanged("Expanded");
						this.ColumnLayout.Grid.OnRowExpansionChanged(this);
					}
					this.ColumnLayout.Grid.InvalidateScrollPanel(true);
				}
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001436 RID: 5174
		public abstract bool HasChildren { get; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001437 RID: 5175
		// (set) Token: 0x06001438 RID: 5176
		protected internal abstract global::Infragistics.Controls.Grids.RowsManagerBase ChildRowsManager { get; set; }

		// Token: 0x04000631 RID: 1585
		private bool _expanded;
	}
}
