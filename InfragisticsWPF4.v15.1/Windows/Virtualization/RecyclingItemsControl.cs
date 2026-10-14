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
	// Token: 0x02000253 RID: 595
	public abstract class RecyclingItemsControl : global::System.Windows.Controls.ItemsControl
	{
		// Token: 0x060017ED RID: 6125 RVA: 0x0005BBF8 File Offset: 0x00059DF8
		protected RecyclingItemsControl()
		{
			this._recyclingGenerator = new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator(this);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0005BC0C File Offset: 0x00059E0C
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer recyclingItemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer;
			if (recyclingItemsControlAutomationPeer != null)
			{
				recyclingItemsControlAutomationPeer.OnItemsChanged(e);
			}
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x0005BC38 File Offset: 0x00059E38
		protected override void OnItemsPanelChanged(global::System.Windows.Controls.ItemsPanelTemplate oldItemsPanel, global::System.Windows.Controls.ItemsPanelTemplate newItemsPanel)
		{
			base.OnItemsPanelChanged(oldItemsPanel, newItemsPanel);
			global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer recyclingItemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer;
			if (recyclingItemsControlAutomationPeer != null)
			{
				recyclingItemsControlAutomationPeer.OnItemsPanelChanged();
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0005BC64 File Offset: 0x00059E64
		protected override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer recyclingItemsControlAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer;
			if (recyclingItemsControlAutomationPeer != null)
			{
				recyclingItemsControlAutomationPeer.OnItemsSourceChanged(oldValue, newValue);
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0005BC90 File Offset: 0x00059E90
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0005BD0A File Offset: 0x00059F0A
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0005BD1C File Offset: 0x00059F1C
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0005BD2F File Offset: 0x00059F2F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator RecyclingItemContainerGenerator
		{
			get
			{
				return this._recyclingGenerator;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0005BD37 File Offset: 0x00059F37
		protected internal virtual int MaxDeactivatedContainersWithoutIndexes
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0005BD3A File Offset: 0x00059F3A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal virtual int UnderlyingItemsCount
		{
			get
			{
				return base.Items.Count;
			}
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0005BD47 File Offset: 0x00059F47
		internal void ClearContainerForItemInternal(global::System.Windows.DependencyObject container, object item)
		{
			this.ClearContainerForItemOverride(container, item);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0005BD51 File Offset: 0x00059F51
		internal global::System.Windows.DependencyObject GetContainerForItemInternal(object item)
		{
			return this.GetContainerForItemOverride(item);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0005BD5A File Offset: 0x00059F5A
		internal bool IsItemItsOwnContainerInternal(object item)
		{
			return this.IsItemItsOwnContainerOverride(item);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0005BD63 File Offset: 0x00059F63
		internal void PrepareContainerForItemInternal(global::System.Windows.DependencyObject container, object item)
		{
			this.PrepareContainerForItemOverride(container, item);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0005BD6D File Offset: 0x00059F6D
		internal bool ShouldApplyItemContainerStyleInternal(global::System.Windows.DependencyObject container, object item)
		{
			return this.ShouldApplyItemContainerStyle(container, item);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0005BD77 File Offset: 0x00059F77
		protected internal virtual void DeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0005BD79 File Offset: 0x00059F79
		protected virtual global::System.Windows.DependencyObject GetContainerForItemOverride(object item)
		{
			return this.GetContainerForItemOverride();
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0005BD81 File Offset: 0x00059F81
		protected internal virtual bool IsContainerCompatibleWithItem(global::System.Windows.DependencyObject container, object item)
		{
			return true;
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0005BD84 File Offset: 0x00059F84
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal virtual bool? IsStillValid(global::System.Windows.DependencyObject container, object item)
		{
			return null;
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0005BD9A File Offset: 0x00059F9A
		protected virtual void OnNavigationServiceInitialized()
		{
			this.RecyclingItemContainerGenerator.RemoveAll();
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0005BDA7 File Offset: 0x00059FA7
		protected internal virtual void ReactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0005BDAC File Offset: 0x00059FAC
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

		// Token: 0x06001803 RID: 6147 RVA: 0x0005BDED File Offset: 0x00059FED
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected internal virtual bool ShouldDeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			return false;
		}

		// Token: 0x04000C35 RID: 3125
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator _recyclingGenerator;

		// Token: 0x04000C36 RID: 3126
		private global::System.Windows.DependencyProperty _navigationServiceDependencyProperty;

		// Token: 0x04000C37 RID: 3127
		public static readonly global::System.Windows.DependencyProperty ItemContainerGenerationModeProperty = global::System.Windows.DependencyProperty.Register("ItemContainerGenerationMode", typeof(global::Infragistics.Windows.Controls.ItemContainerGenerationMode), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemsControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle));
	}
}
