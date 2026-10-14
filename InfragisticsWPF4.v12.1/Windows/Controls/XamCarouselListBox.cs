using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Xml;
using Infragistics.Windows.Automation.Peers;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000222 RID: 546
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCarouselListBox", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCarouselListBox : global::Infragistics.Windows.Virtualization.RecyclingItemsControl, global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x000553FC File Offset: 0x000535FC
		static XamCarouselListBox()
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectionChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.SelectionChangedEventHandler), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox));
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.Controls.XamCarouselPanel)));
			itemsPanelTemplate.VisualTree.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.IsInCarouselListBoxProperty, global::Infragistics.KnownBoxes.TrueBox);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox)));
			global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnIsSelectedChanged)));
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00055698 File Offset: 0x00053898
		public XamCarouselListBox()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			base.Items.CurrentChanged += this.OnItemsCurrentChanged;
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00055710 File Offset: 0x00053910
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00055714 File Offset: 0x00053914
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.ClearContainerForItemOverride(element, item);
			global::Infragistics.Windows.Controls.CarouselListBoxItem carouselListBoxItem = element as global::Infragistics.Windows.Controls.CarouselListBoxItem;
			if (carouselListBoxItem != null)
			{
				carouselListBoxItem.ClearContainerForItem(item);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0005573A File Offset: 0x0005393A
		protected internal override void DeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			base.DeactivateContainer(container, item);
			container.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.FalseBox);
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00055754 File Offset: 0x00053954
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Controls.CarouselListBoxItem(this._carouselPanel);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00055761 File Offset: 0x00053961
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Infragistics.Windows.Controls.CarouselListBoxItem;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0005576C File Offset: 0x0005396C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (this._carouselPanel == null)
			{
				this._carouselPanel = (global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.Controls.XamCarouselPanel), true) as global::Infragistics.Windows.Controls.XamCarouselPanel);
				if (this._carouselPanel != null)
				{
					this._carouselPanel.SelectionHost = this;
					this.BindCarouselPanelViewSettings(this._carouselPanel);
					this._carouselPanel.CarouselPanelAdorner.SetBinding(global::System.Windows.UIElement.OpacityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.OpacityProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				}
			}
			return result;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000557E8 File Offset: 0x000539E8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer(this);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000557F0 File Offset: 0x000539F0
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, this.ViewSettings);
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0005581C File Offset: 0x00053A1C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			bool flag = false;
			bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
			if (isKeyboardFocusWithin)
			{
				flag = true;
			}
			if ((bool)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectionActiveProperty) != flag)
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectionActivePropertyKey, global::Infragistics.KnownBoxes.FromValue(flag));
			}
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00055862 File Offset: 0x00053A62
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (base.Items != null && base.Items.CurrentItem != null && this._isSynchronizedWithCurrentItemPrivate)
			{
				this.SetSelectedToCurrent();
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0005588E File Offset: 0x00053A8E
		protected override void OnItemsPanelChanged(global::System.Windows.Controls.ItemsPanelTemplate oldItemsPanel, global::System.Windows.Controls.ItemsPanelTemplate newItemsPanel)
		{
			if (this._carouselPanel != null)
			{
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this._carouselPanel);
				this._carouselPanel = null;
			}
			base.OnItemsPanelChanged(oldItemsPanel, newItemsPanel);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000558B2 File Offset: 0x00053AB2
		protected override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			if (oldValue != null && (base.ItemTemplate != null || base.ItemTemplateSelector != null))
			{
				base.RecyclingItemContainerGenerator.RemoveAll();
			}
			this.SetSynchronizationWithCurrentItem();
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000558D8 File Offset: 0x00053AD8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(this._viewSettings);
					if (parent is global::Infragistics.Windows.Controls.XamCarouselPanel)
					{
						((global::Infragistics.Windows.Controls.XamCarouselPanel)parent).RemoveLogicalChildProxy(this._viewSettings);
					}
					else if (parent == this)
					{
						base.RemoveLogicalChild(this._viewSettings);
					}
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.Controls.CarouselViewSettings);
				if (this._carouselPanel != null)
				{
					this.BindCarouselPanelViewSettings(this._carouselPanel);
				}
				if (this._viewSettings != null)
				{
					global::System.Windows.DependencyObject parent2 = global::System.Windows.LogicalTreeHelper.GetParent(this._viewSettings);
					if (parent2 != null && parent2 is global::Infragistics.Windows.Controls.XamCarouselPanel)
					{
						((global::Infragistics.Windows.Controls.XamCarouselPanel)parent2).RemoveLogicalChildProxy(this._viewSettings);
						parent2 = global::System.Windows.LogicalTreeHelper.GetParent(this._viewSettings);
					}
					if (parent2 == null)
					{
						base.AddLogicalChild(this._viewSettings);
					}
				}
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000559B0 File Offset: 0x00053BB0
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			global::Infragistics.Windows.Controls.CarouselListBoxItem carouselListBoxItem = element as global::Infragistics.Windows.Controls.CarouselListBoxItem;
			if (carouselListBoxItem != null)
			{
				carouselListBoxItem.PrepareContainerForItem(item);
			}
			if (item == this.SelectedItem)
			{
				element.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000559EF File Offset: 0x00053BEF
		protected internal override void ReactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			base.ReactivateContainer(container, item);
			if (item == this.SelectedItem)
			{
				container.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00055A12 File Offset: 0x00053C12
		protected internal override void ReuseContainerForNewItem(global::System.Windows.DependencyObject container, object item)
		{
			base.ReuseContainerForNewItem(container, item);
			if (item == this.SelectedItem)
			{
				container.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			container.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.FalseBox);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00055A46 File Offset: 0x00053C46
		public static bool GetIsSelected(global::System.Windows.DependencyObject element)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			return (bool)element.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00055A66 File Offset: 0x00053C66
		public static void SetIsSelected(global::System.Windows.DependencyObject element, bool isSelected)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			element.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(isSelected));
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00055A87 File Offset: 0x00053C87
		public static bool GetIsSelectionActive(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectionActiveProperty);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00055A99 File Offset: 0x00053C99
		private static void OnIsSynchronizedWithCurrentItemChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.XamCarouselListBox)d).SetSynchronizationWithCurrentItem();
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00055AA6 File Offset: 0x00053CA6
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x00055AB8 File Offset: 0x00053CB8
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? IsSynchronizedWithCurrentItem
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSynchronizedWithCurrentItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSynchronizedWithCurrentItemProperty, value);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00055ACB File Offset: 0x00053CCB
		public global::System.Windows.Controls.Primitives.IScrollInfo ScrollInfo
		{
			get
			{
				return this._carouselPanel;
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00055AD4 File Offset: 0x00053CD4
		private static void OnSelectedIndexChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				global::System.Collections.Generic.List<object> list2 = new global::System.Collections.Generic.List<object>();
				xamCarouselListBox._updateSelectedIndex = false;
				try
				{
					global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = xamCarouselListBox.ActiveItemContainerGenerator;
					if ((int)e.OldValue != -1 && (int)e.OldValue < xamCarouselListBox.Items.Count)
					{
						list.Add(xamCarouselListBox.Items[(int)e.OldValue]);
						global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem = xamCarouselListBox.ContainerFromIndex((int)e.OldValue) as global::Infragistics.Windows.Controls.CarouselPanelItem;
						if (carouselPanelItem != null)
						{
							carouselPanelItem.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.FalseBox);
						}
						if (xamCarouselListBox._updateSelectedItem)
						{
							xamCarouselListBox.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedItemProperty, null);
						}
					}
					if ((int)e.NewValue != -1 && (int)e.NewValue < xamCarouselListBox.Items.Count)
					{
						bool flag = false;
						list2.Add(xamCarouselListBox.Items[(int)e.NewValue]);
						if (xamCarouselListBox.GetGeneratorPositionFromItemIndex((int)e.NewValue).Offset == 0)
						{
							global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem2 = xamCarouselListBox.ContainerFromIndex((int)e.NewValue) as global::Infragistics.Windows.Controls.CarouselPanelItem;
							if (carouselPanelItem2 != null && !global::Infragistics.Windows.Controls.XamCarouselListBox.GetIsSelected(carouselPanelItem2))
							{
								carouselPanelItem2.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
							}
						}
						else
						{
							flag = true;
						}
						if (xamCarouselListBox._updateSelectedItem)
						{
							xamCarouselListBox.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedItemProperty, xamCarouselListBox.Items[(int)e.NewValue]);
						}
						xamCarouselListBox.UpdateSelectedValueBinding();
						if (flag && xamCarouselListBox._carouselPanel != null)
						{
							((global::System.Windows.Controls.Primitives.IScrollInfo)xamCarouselListBox._carouselPanel).SetVerticalOffset((double)((int)e.NewValue));
						}
					}
				}
				finally
				{
					xamCarouselListBox._updateSelectedIndex = true;
				}
				xamCarouselListBox.SetCurrentToSelected();
				global::System.Windows.Controls.SelectionChangedEventArgs args = new global::System.Windows.Controls.SelectionChangedEventArgs(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent, list, list2);
				xamCarouselListBox.RaiseSelectionChanged(args);
				global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer xamCarouselListBoxAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(xamCarouselListBox) as global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer;
				if (xamCarouselListBoxAutomationPeer != null)
				{
					xamCarouselListBoxAutomationPeer.RaiseSelectionChanged(args);
				}
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00055CE4 File Offset: 0x00053EE4
		private static object OnCoerceSelectedIndex(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null && value is int && (int)value >= xamCarouselListBox.Items.Count)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			return value;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00055D1D File Offset: 0x00053F1D
		private static bool OnValidateSelectedIndex(object value)
		{
			return (int)value >= -1;
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00055D2B File Offset: 0x00053F2B
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x00055D3D File Offset: 0x00053F3D
		[global::System.ComponentModel.Bindable(true)]
		public int SelectedIndex
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedIndexProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedIndexProperty, value);
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00055D50 File Offset: 0x00053F50
		private static void OnSelectedItemChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null && xamCarouselListBox._updateSelectedIndex)
			{
				xamCarouselListBox._updateSelectedItem = false;
				try
				{
					xamCarouselListBox.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedIndexProperty, xamCarouselListBox.Items.IndexOf(e.NewValue));
				}
				finally
				{
					xamCarouselListBox._updateSelectedItem = true;
				}
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x00055DB4 File Offset: 0x00053FB4
		// (set) Token: 0x06001629 RID: 5673 RVA: 0x00055DC1 File Offset: 0x00053FC1
		[global::System.ComponentModel.Bindable(true)]
		public object SelectedItem
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedItemProperty, value);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x00055DCF File Offset: 0x00053FCF
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object SelectedValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValueProperty);
			}
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00055DDC File Offset: 0x00053FDC
		private static void OnSelectedValuePathChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				xamCarouselListBox.UpdateSelectedValueBinding();
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00055DF9 File Offset: 0x00053FF9
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x00055E0B File Offset: 0x0005400B
		[global::System.ComponentModel.Bindable(true)]
		public string SelectedValuePath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValuePathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValuePathProperty, value);
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00055E19 File Offset: 0x00054019
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00055E2D File Offset: 0x0005402D
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00055E50 File Offset: 0x00054050
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.CarouselViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._viewSettings = new global::Infragistics.Windows.Controls.CarouselViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty, value);
			}
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00055E5E File Offset: 0x0005405E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00055E7F File Offset: 0x0005407F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00055E9C File Offset: 0x0005409C
		protected global::System.Windows.Controls.Primitives.IItemContainerGenerator ActiveItemContainerGenerator
		{
			get
			{
				global::Infragistics.Windows.Controls.ItemContainerGenerationMode itemContainerGenerationMode = global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Virtualize;
				global::Infragistics.Windows.Virtualization.RecyclingItemsPanel carouselPanel = this._carouselPanel;
				if (carouselPanel != null)
				{
					itemContainerGenerationMode = carouselPanel.ItemContainerGenerationModeResolved;
				}
				if (itemContainerGenerationMode == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
				{
					return base.RecyclingItemContainerGenerator;
				}
				return base.ItemContainerGenerator;
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00055ECC File Offset: 0x000540CC
		private static void OnSelectedValueInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				xamCarouselListBox.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValuePropertyKey, e.NewValue);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00055EF5 File Offset: 0x000540F5
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x00055F02 File Offset: 0x00054102
		private object SelectedValueInternal
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValueInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValueInternalProperty, value);
			}
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00055F10 File Offset: 0x00054110
		private void BindCarouselPanelViewSettings(global::Infragistics.Windows.Controls.XamCarouselPanel carouselPanel)
		{
			if (carouselPanel == null)
			{
				return;
			}
			if (this._viewSettings == null)
			{
				global::System.Windows.Data.BindingOperations.ClearAllBindings(carouselPanel);
				return;
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Source = this;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Path = new global::System.Windows.PropertyPath("ViewSettings", new object[0]);
			carouselPanel.SetBinding(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, binding);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00055F67 File Offset: 0x00054167
		private global::System.Windows.DependencyObject ContainerFromIndex(int itemIndex)
		{
			if (this.ActiveItemContainerGenerator is global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator)
			{
				return base.RecyclingItemContainerGenerator.GetContainer(this.GetChildIndexFromItemIndex(itemIndex), false);
			}
			return base.ItemContainerGenerator.ContainerFromIndex(itemIndex);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00055F98 File Offset: 0x00054198
		private int GetChildIndexFromItemIndex(int itemIndex)
		{
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(itemIndex);
			if (generatorPositionFromItemIndex.Offset != 0)
			{
				return generatorPositionFromItemIndex.Index + 1;
			}
			return generatorPositionFromItemIndex.Index;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00055FC7 File Offset: 0x000541C7
		private global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex)
		{
			return this.ActiveItemContainerGenerator.GeneratorPositionFromIndex(itemIndex);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00055FD5 File Offset: 0x000541D5
		private bool IsXmlNode(object item)
		{
			return item != null && item.GetType().FullName.StartsWith("System.Xml", global::System.StringComparison.Ordinal) && item is global::System.Xml.XmlNode;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00056000 File Offset: 0x00054200
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(d) as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer xamCarouselListBoxAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(xamCarouselListBox) as global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer;
				xamCarouselListBoxAutomationPeer.RaiseIsSelectedChanged(d, (bool)e.NewValue);
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x0005603B File Offset: 0x0005423B
		private void OnItemsCurrentChanged(object sender, global::System.EventArgs e)
		{
			if (this._isSynchronizedWithCurrentItemPrivate)
			{
				this.SetSelectedToCurrent();
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0005604B File Offset: 0x0005424B
		private void SetCurrentToSelected()
		{
			if (this.SelectedItem == null)
			{
				base.Items.MoveCurrentToPosition(-1);
				return;
			}
			base.Items.MoveCurrentTo(this.SelectedItem);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00056078 File Offset: 0x00054278
		private void SetSelectedToCurrent()
		{
			object currentItem = base.Items.CurrentItem;
			if (currentItem != null)
			{
				this.SelectedItem = currentItem;
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0005609C File Offset: 0x0005429C
		private void SetSynchronizationWithCurrentItem()
		{
			bool flag = false;
			bool? isSynchronizedWithCurrentItem = this.IsSynchronizedWithCurrentItem;
			bool isSynchronizedWithCurrentItemPrivate = this._isSynchronizedWithCurrentItemPrivate;
			if (isSynchronizedWithCurrentItem != null)
			{
				flag = isSynchronizedWithCurrentItem.Value;
			}
			this._isSynchronizedWithCurrentItemPrivate = flag;
			if (!isSynchronizedWithCurrentItemPrivate && flag)
			{
				this.SetSelectedToCurrent();
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000560E0 File Offset: 0x000542E0
		private void UpdateSelectedValueBinding()
		{
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValueInternalProperty);
			if (this.SelectedItem == null)
			{
				return;
			}
			if (this.SelectedValuePath == null || this.SelectedValuePath == string.Empty)
			{
				return;
			}
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Source = this.SelectedItem;
			if (this.IsXmlNode(this.SelectedItem))
			{
				binding.XPath = this.SelectedValuePath;
				binding.Path = new global::System.Windows.PropertyPath("/InnerText", new object[0]);
			}
			else
			{
				binding.Path = new global::System.Windows.PropertyPath(this.SelectedValuePath, new object[0]);
			}
			base.SetBinding(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValueInternalProperty, binding);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00056184 File Offset: 0x00054384
		protected virtual void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0005618D File Offset: 0x0005438D
		internal void RaiseSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent;
			args.Source = this;
			this.OnSelectionChanged(args);
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06001644 RID: 5700 RVA: 0x000561A8 File Offset: 0x000543A8
		// (remove) Token: 0x06001645 RID: 5701 RVA: 0x000561B6 File Offset: 0x000543B6
		public event global::System.Windows.Controls.SelectionChangedEventHandler SelectionChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent, value);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x000561C4 File Offset: 0x000543C4
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x000561CC File Offset: 0x000543CC
		int global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost.SelectedItemIndex
		{
			get
			{
				return this.SelectedIndex;
			}
			set
			{
				this.SelectedIndex = value;
			}
		}

		// Token: 0x04000AD6 RID: 2774
		private const int CONTAINER_CACHE_SIZE = 15;

		// Token: 0x04000AD7 RID: 2775
		private global::System.Collections.Generic.Stack<global::System.Windows.DependencyObject> _containerCache = new global::System.Collections.Generic.Stack<global::System.Windows.DependencyObject>(15);

		// Token: 0x04000AD8 RID: 2776
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000AD9 RID: 2777
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x04000ADA RID: 2778
		private global::Infragistics.Windows.Controls.XamCarouselPanel _carouselPanel;

		// Token: 0x04000ADB RID: 2779
		private bool _updateSelectedItem = true;

		// Token: 0x04000ADC RID: 2780
		private bool _updateSelectedIndex = true;

		// Token: 0x04000ADD RID: 2781
		private bool _isSynchronizedWithCurrentItemPrivate;

		// Token: 0x04000ADE RID: 2782
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000ADF RID: 2783
		private static readonly global::System.Windows.DependencyPropertyKey IsSelectionActivePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsSelectionActive", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000AE0 RID: 2784
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectionActivePropertyKey.DependencyProperty;

		// Token: 0x04000AE1 RID: 2785
		public static readonly global::System.Windows.DependencyProperty IsSynchronizedWithCurrentItemProperty = global::System.Windows.DependencyProperty.Register("IsSynchronizedWithCurrentItem", typeof(bool?), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnIsSynchronizedWithCurrentItemChanged)));

		// Token: 0x04000AE2 RID: 2786
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty = global::System.Windows.DependencyProperty.Register("SelectedIndex", typeof(int), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedIndexChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnCoerceSelectedIndex)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnValidateSelectedIndex));

		// Token: 0x04000AE3 RID: 2787
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty = global::System.Windows.DependencyProperty.Register("SelectedItem", typeof(object), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedItemChanged)));

		// Token: 0x04000AE4 RID: 2788
		private static readonly global::System.Windows.DependencyPropertyKey SelectedValuePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SelectedValue", typeof(object), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AE5 RID: 2789
		public static readonly global::System.Windows.DependencyProperty SelectedValueProperty = global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValuePropertyKey.DependencyProperty;

		// Token: 0x04000AE6 RID: 2790
		public static readonly global::System.Windows.DependencyProperty SelectedValuePathProperty = global::System.Windows.DependencyProperty.Register("SelectedValuePath", typeof(string), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedValuePathChanged)));

		// Token: 0x04000AE7 RID: 2791
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnCoerceViewSettings)));

		// Token: 0x04000AE8 RID: 2792
		private static readonly global::System.Windows.DependencyProperty SelectedValueInternalProperty = global::System.Windows.DependencyProperty.Register("SelectedValueInternal", typeof(object), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedValueInternalChanged)));
	}
}
