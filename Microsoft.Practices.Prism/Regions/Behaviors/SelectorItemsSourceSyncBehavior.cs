using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000059 RID: 89
	public class SelectorItemsSourceSyncBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior, global::Microsoft.Practices.Prism.Regions.Behaviors.IHostAwareRegionBehavior, global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00007FB0 File Offset: 0x000061B0
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00007FB8 File Offset: 0x000061B8
		public global::System.Windows.DependencyObject HostControl
		{
			get
			{
				return this.hostControl;
			}
			set
			{
				this.hostControl = (value as global::System.Windows.Controls.Primitives.Selector);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00007FC8 File Offset: 0x000061C8
		protected override void OnAttach()
		{
			bool flag = this.hostControl.ItemsSource != null || global::System.Windows.Data.BindingOperations.GetBinding(this.hostControl, global::System.Windows.Controls.ItemsControl.ItemsSourceProperty) != null;
			if (flag)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.ItemsControlHasItemsSourceException);
			}
			this.SynchronizeItems();
			this.hostControl.SelectionChanged += this.HostControlSelectionChanged;
			base.Region.ActiveViews.CollectionChanged += this.ActiveViews_CollectionChanged;
			base.Region.Views.CollectionChanged += this.Views_CollectionChanged;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00008068 File Offset: 0x00006268
		private void Views_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				int newStartingIndex = e.NewStartingIndex;
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object insertItem = enumerator.Current;
						this.hostControl.Items.Insert(newStartingIndex++, insertItem);
					}
					return;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
			{
				foreach (object removeItem in e.OldItems)
				{
					this.hostControl.Items.Remove(removeItem);
				}
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000813C File Offset: 0x0000633C
		private void SynchronizeItems()
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			foreach (object item in ((global::System.Collections.IEnumerable)this.hostControl.Items))
			{
				list.Add(item);
			}
			foreach (object newItem in base.Region.Views)
			{
				this.hostControl.Items.Add(newItem);
			}
			foreach (object view in list)
			{
				base.Region.Add(view);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00008238 File Offset: 0x00006438
		private void ActiveViews_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.updatingActiveViewsInHostControlSelectionChanged)
			{
				return;
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				if (this.hostControl.SelectedItem != null && this.hostControl.SelectedItem != e.NewItems[0] && base.Region.ActiveViews.Contains(this.hostControl.SelectedItem))
				{
					base.Region.Deactivate(this.hostControl.SelectedItem);
				}
				this.hostControl.SelectedItem = e.NewItems[0];
				return;
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove && e.OldItems.Contains(this.hostControl.SelectedItem))
			{
				this.hostControl.SelectedItem = null;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000082F4 File Offset: 0x000064F4
		private void HostControlSelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			try
			{
				this.updatingActiveViewsInHostControlSelectionChanged = true;
				object originalSource = e.OriginalSource;
				if (originalSource == sender)
				{
					foreach (object obj in e.RemovedItems)
					{
						if (base.Region.Views.Contains(obj) && base.Region.ActiveViews.Contains(obj))
						{
							base.Region.Deactivate(obj);
						}
					}
					foreach (object obj2 in e.AddedItems)
					{
						if (base.Region.Views.Contains(obj2) && !base.Region.ActiveViews.Contains(obj2))
						{
							base.Region.Activate(obj2);
						}
					}
				}
			}
			finally
			{
				this.updatingActiveViewsInHostControlSelectionChanged = false;
			}
		}

		// Token: 0x0400009C RID: 156
		public static readonly string BehaviorKey = "SelectorItemsSourceSyncBehavior";

		// Token: 0x0400009D RID: 157
		private bool updatingActiveViewsInHostControlSelectionChanged;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Controls.Primitives.Selector hostControl;
	}
}
