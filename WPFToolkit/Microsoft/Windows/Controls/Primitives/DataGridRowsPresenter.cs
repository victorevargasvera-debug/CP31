using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x02000082 RID: 130
	public class DataGridRowsPresenter : global::System.Windows.Controls.VirtualizingStackPanel
	{
		// Token: 0x06000906 RID: 2310 RVA: 0x00028464 File Offset: 0x00026664
		internal void InternalBringIndexIntoView(int index)
		{
			this.BringIndexIntoView(index);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00028470 File Offset: 0x00026670
		protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
		{
			base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
			if (newIsItemsHost)
			{
				global::Microsoft.Windows.Controls.DataGrid owner = this.Owner;
				if (owner != null)
				{
					global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = owner.ItemContainerGenerator;
					if (itemContainerGenerator != null && itemContainerGenerator == itemContainerGenerator.GetItemContainerGeneratorForPanel(this))
					{
						owner.InternalItemsHost = this;
						return;
					}
				}
			}
			else
			{
				if (this._owner != null && this._owner.InternalItemsHost == this)
				{
					this._owner.InternalItemsHost = null;
				}
				this._owner = null;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000284D8 File Offset: 0x000266D8
		protected override void OnViewportSizeChanged(global::System.Windows.Size oldViewportSize, global::System.Windows.Size newViewportSize)
		{
			global::Microsoft.Windows.Controls.DataGrid owner = this.Owner;
			if (owner != null)
			{
				global::System.Windows.Controls.ScrollContentPresenter internalScrollContentPresenter = owner.InternalScrollContentPresenter;
				if (internalScrollContentPresenter == null || internalScrollContentPresenter.CanContentScroll)
				{
					owner.OnViewportSizeChanged(oldViewportSize, newViewportSize);
				}
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00028509 File Offset: 0x00026709
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			this._availableSize = constraint;
			return base.MeasureOverride(constraint);
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00028519 File Offset: 0x00026719
		internal global::System.Windows.Size AvailableSize
		{
			get
			{
				return this._availableSize;
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00028521 File Offset: 0x00026721
		protected override void OnCleanUpVirtualizedItem(global::System.Windows.Controls.CleanUpVirtualizedItemEventArgs e)
		{
			base.OnCleanUpVirtualizedItem(e);
			if (e.UIElement != null && global::System.Windows.Controls.Validation.GetHasError(e.UIElement))
			{
				e.Cancel = true;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00028546 File Offset: 0x00026746
		internal global::Microsoft.Windows.Controls.DataGrid Owner
		{
			get
			{
				if (this._owner == null)
				{
					this._owner = (global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::Microsoft.Windows.Controls.DataGrid);
				}
				return this._owner;
			}
		}

		// Token: 0x040002C3 RID: 707
		private global::Microsoft.Windows.Controls.DataGrid _owner;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Size _availableSize;
	}
}
