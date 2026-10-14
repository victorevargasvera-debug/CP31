using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Virtualization
{
	// Token: 0x02000220 RID: 544
	public abstract class RecyclingItemsControl : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x060015EF RID: 5615 RVA: 0x000551D4 File Offset: 0x000533D4
		protected RecyclingItemsControl()
		{
			this._recyclingGenerator = new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator(this);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000551E8 File Offset: 0x000533E8
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer recyclingItemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer;
			if (recyclingItemsControlAutomationPeer != null)
			{
				recyclingItemsControlAutomationPeer.OnItemsChanged(e);
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00055214 File Offset: 0x00053414
		protected override void OnItemsPanelChanged(global::System.Windows.Controls.ItemsPanelTemplate oldItemsPanel, global::System.Windows.Controls.ItemsPanelTemplate newItemsPanel)
		{
			base.OnItemsPanelChanged(oldItemsPanel, newItemsPanel);
			global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer recyclingItemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer;
			if (recyclingItemsControlAutomationPeer != null)
			{
				recyclingItemsControlAutomationPeer.OnItemsPanelChanged();
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00055240 File Offset: 0x00053440
		protected override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer recyclingItemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer;
			if (recyclingItemsControlAutomationPeer != null)
			{
				recyclingItemsControlAutomationPeer.OnItemsSourceChanged(oldValue, newValue);
			}
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0005526C File Offset: 0x0005346C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			bool flag = false;
			if (this._navigationServiceDependencyProperty == null)
			{
				if (e.Property.Name == "NavigationService")
				{
					this._navigationServiceDependencyProperty = e.Property;
					flag = true;
				}
			}
			else
			{
				flag = (e.Property == this._navigationServiceDependencyProperty);
			}
			if (flag && e.OldValue == null && e.NewValue != null && this.ItemContainerGenerationMode == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				this.OnNavigationServiceInitialized();
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000552E6 File Offset: 0x000534E6
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x000552F8 File Offset: 0x000534F8
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)]
		public global::Infragistics.Windows.Controls.ItemContainerGenerationMode ItemContainerGenerationMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ItemContainerGenerationMode)base.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemsControl.ItemContainerGenerationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Virtualization.RecyclingItemsControl.ItemContainerGenerationModeProperty, value);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x0005530B File Offset: 0x0005350B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator RecyclingItemContainerGenerator
		{
			get
			{
				return this._recyclingGenerator;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00055313 File Offset: 0x00053513
		protected internal virtual int MaxDeactivatedContainersWithoutIndexes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x00055316 File Offset: 0x00053516
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal virtual int UnderlyingItemsCount
		{
			get
			{
				return base.Items.Count;
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00055323 File Offset: 0x00053523
		internal void ClearContainerForItemInternal(global::System.Windows.DependencyObject container, object item)
		{
			this.ClearContainerForItemOverride(container, item);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0005532D File Offset: 0x0005352D
		internal global::System.Windows.DependencyObject GetContainerForItemInternal(object item)
		{
			return this.GetContainerForItemOverride(item);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00055336 File Offset: 0x00053536
		internal bool IsItemItsOwnContainerInternal(object item)
		{
			return this.IsItemItsOwnContainerOverride(item);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0005533F File Offset: 0x0005353F
		internal void PrepareContainerForItemInternal(global::System.Windows.DependencyObject container, object item)
		{
			this.PrepareContainerForItemOverride(container, item);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00055349 File Offset: 0x00053549
		internal bool ShouldApplyItemContainerStyleInternal(global::System.Windows.DependencyObject container, object item)
		{
			return this.ShouldApplyItemContainerStyle(container, item);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x00055353 File Offset: 0x00053553
		protected internal virtual void DeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00055355 File Offset: 0x00053555
		protected virtual global::System.Windows.DependencyObject GetContainerForItemOverride(object item)
		{
			return this.GetContainerForItemOverride();
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0005535D File Offset: 0x0005355D
		protected internal virtual bool IsContainerCompatibleWithItem(global::System.Windows.DependencyObject container, object item)
		{
			return true;
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00055360 File Offset: 0x00053560
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal virtual bool? IsStillValid(global::System.Windows.DependencyObject container, object item)
		{
			return null;
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00055376 File Offset: 0x00053576
		protected virtual void OnNavigationServiceInitialized()
		{
			this.RecyclingItemContainerGenerator.RemoveAll();
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00055383 File Offset: 0x00053583
		protected internal virtual void ReactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00055388 File Offset: 0x00053588
		protected internal virtual void ReuseContainerForNewItem(global::System.Windows.DependencyObject container, object item)
		{
			global::System.Windows.FrameworkElement frameworkElement = container as global::System.Windows.FrameworkElement;
			if (frameworkElement == null)
			{
				return;
			}
			if (frameworkElement is global::System.Windows.Controls.ContentControl)
			{
				((global::System.Windows.Controls.ContentControl)frameworkElement).Content = item;
				return;
			}
			if (frameworkElement is global::System.Windows.Controls.ContentPresenter)
			{
				((global::System.Windows.Controls.ContentPresenter)frameworkElement).Content = item;
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000553C9 File Offset: 0x000535C9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal virtual bool ShouldDeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			return false;
		}

		// Token: 0x04000AD3 RID: 2771
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator _recyclingGenerator;

		// Token: 0x04000AD4 RID: 2772
		private global::System.Windows.DependencyProperty _navigationServiceDependencyProperty;

		// Token: 0x04000AD5 RID: 2773
		public static readonly global::System.Windows.DependencyProperty ItemContainerGenerationModeProperty = global::System.Windows.DependencyProperty.Register("ItemContainerGenerationMode", typeof(global::Infragistics.Windows.Controls.ItemContainerGenerationMode), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemsControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle));
	}
}
