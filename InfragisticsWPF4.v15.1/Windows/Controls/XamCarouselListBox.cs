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
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000257 RID: 599
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCarouselListBox", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCarouselListBox : global::Infragistics.Windows.Virtualization.RecyclingItemsControl, global::Infragistics.Windows.Controls.ICarouselPanelSelectionHost
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x0005BE30 File Offset: 0x0005A030
		static XamCarouselListBox()
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectionChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.SelectionChangedEventHandler), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox));
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.Controls.XamCarouselPanel)));
			itemsPanelTemplate.VisualTree.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.IsInCarouselListBoxProperty, global::Infragistics.KnownBoxes.TrueBox);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox)));
			global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnIsSelectedChanged)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox));
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0005C0DC File Offset: 0x0005A2DC
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0005C154 File Offset: 0x0005A354
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0005C158 File Offset: 0x0005A358
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.ClearContainerForItemOverride(element, item);
			global::Infragistics.Windows.Controls.CarouselListBoxItem carouselListBoxItem = element as global::Infragistics.Windows.Controls.CarouselListBoxItem;
			if (carouselListBoxItem != null)
			{
				carouselListBoxItem.ClearContainerForItem(item);
			}
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0005C17E File Offset: 0x0005A37E
		protected internal override void DeactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			base.DeactivateContainer(container, item);
			container.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.FalseBox);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0005C198 File Offset: 0x0005A398
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.Controls.CarouselListBoxItem(this._carouselPanel);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0005C1A5 File Offset: 0x0005A3A5
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Infragistics.Windows.Controls.CarouselListBoxItem;
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
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

		// Token: 0x06001811 RID: 6161 RVA: 0x0005C22C File Offset: 0x0005A42C
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer(this);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0005C234 File Offset: 0x0005A434
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (this._viewSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty, this.ViewSettings);
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0005C260 File Offset: 0x0005A460
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

		// Token: 0x06001814 RID: 6164 RVA: 0x0005C2A6 File Offset: 0x0005A4A6
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (base.Items != null && base.Items.CurrentItem != null && this._isSynchronizedWithCurrentItemPrivate)
			{
				this.SetSelectedToCurrent();
			}
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0005C2D2 File Offset: 0x0005A4D2
		protected override void OnItemsPanelChanged(global::System.Windows.Controls.ItemsPanelTemplate oldItemsPanel, global::System.Windows.Controls.ItemsPanelTemplate newItemsPanel)
		{
			if (this._carouselPanel != null)
			{
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this._carouselPanel);
				this._carouselPanel = null;
			}
			base.OnItemsPanelChanged(oldItemsPanel, newItemsPanel);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0005C2F6 File Offset: 0x0005A4F6
		protected override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			if (oldValue != null && (base.ItemTemplate != null || base.ItemTemplateSelector != null))
			{
				base.RecyclingItemContainerGenerator.RemoveAll();
			}
			this.SetSynchronizationWithCurrentItem();
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0005C31C File Offset: 0x0005A51C
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

		// Token: 0x06001818 RID: 6168 RVA: 0x0005C3F4 File Offset: 0x0005A5F4
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

		// Token: 0x06001819 RID: 6169 RVA: 0x0005C433 File Offset: 0x0005A633
		protected internal override void ReactivateContainer(global::System.Windows.DependencyObject container, object item)
		{
			base.ReactivateContainer(container, item);
			if (item == this.SelectedItem)
			{
				container.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0005C456 File Offset: 0x0005A656
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

		// Token: 0x0600181B RID: 6171 RVA: 0x0005C48A File Offset: 0x0005A68A
		public static bool GetIsSelected(global::System.Windows.DependencyObject element)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			return (bool)element.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0005C4AA File Offset: 0x0005A6AA
		public static void SetIsSelected(global::System.Windows.DependencyObject element, bool isSelected)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			element.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(isSelected));
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0005C4CB File Offset: 0x0005A6CB
		public static bool GetIsSelectionActive(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectionActiveProperty);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0005C4DD File Offset: 0x0005A6DD
		private static void OnIsSynchronizedWithCurrentItemChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.XamCarouselListBox)d).SetSynchronizationWithCurrentItem();
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x0005C4EA File Offset: 0x0005A6EA
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x0005C4FC File Offset: 0x0005A6FC
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x0005C50F File Offset: 0x0005A70F
		public global::System.Windows.Controls.Primitives.IScrollInfo ScrollInfo
		{
			get
			{
				return this._carouselPanel;
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0005C518 File Offset: 0x0005A718
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
						global::Infragistics.Windows.Controls.CarouselPanelItem carouselPanelItem2 = xamCarouselListBox.ContainerFromIndex((int)e.NewValue) as global::Infragistics.Windows.Controls.CarouselPanelItem;
						if (carouselPanelItem2 != null)
						{
							if (!global::Infragistics.Windows.Controls.XamCarouselListBox.GetIsSelected(carouselPanelItem2))
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

		// Token: 0x06001823 RID: 6179 RVA: 0x0005C70C File Offset: 0x0005A90C
		private static object OnCoerceSelectedIndex(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null && value is int && (int)value >= xamCarouselListBox.Items.Count)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			return value;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0005C745 File Offset: 0x0005A945
		private static bool OnValidateSelectedIndex(object value)
		{
			return (int)value >= -1;
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x0005C753 File Offset: 0x0005A953
		// (set) Token: 0x06001826 RID: 6182 RVA: 0x0005C765 File Offset: 0x0005A965
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

		// Token: 0x06001827 RID: 6183 RVA: 0x0005C778 File Offset: 0x0005A978
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

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x0005C7DC File Offset: 0x0005A9DC
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0005C7E9 File Offset: 0x0005A9E9
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

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0005C7F7 File Offset: 0x0005A9F7
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public object SelectedValue
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValueProperty);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0005C804 File Offset: 0x0005AA04
		private static void OnSelectedValuePathChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				xamCarouselListBox.UpdateSelectedValueBinding();
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0005C821 File Offset: 0x0005AA21
		// (set) Token: 0x0600182D RID: 6189 RVA: 0x0005C833 File Offset: 0x0005AA33
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

		// Token: 0x0600182E RID: 6190 RVA: 0x0005C841 File Offset: 0x0005AA41
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				return new global::Infragistics.Windows.Controls.CarouselViewSettings();
			}
			return value;
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x0005C855 File Offset: 0x0005AA55
		// (set) Token: 0x06001830 RID: 6192 RVA: 0x0005C878 File Offset: 0x0005AA78
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

		// Token: 0x06001831 RID: 6193 RVA: 0x0005C886 File Offset: 0x0005AA86
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0005C8A7 File Offset: 0x0005AAA7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			this.ViewSettings = (global::Infragistics.Windows.Controls.CarouselViewSettings)global::Infragistics.Windows.Controls.XamCarouselListBox.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0005C8C4 File Offset: 0x0005AAC4
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

		// Token: 0x06001834 RID: 6196 RVA: 0x0005C8F4 File Offset: 0x0005AAF4
		private static void OnSelectedValueInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = d as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				xamCarouselListBox.SetValue(global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValuePropertyKey, e.NewValue);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0005C91D File Offset: 0x0005AB1D
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0005C92A File Offset: 0x0005AB2A
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

		// Token: 0x06001837 RID: 6199 RVA: 0x0005C938 File Offset: 0x0005AB38
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

		// Token: 0x06001838 RID: 6200 RVA: 0x0005C98F File Offset: 0x0005AB8F
		private global::System.Windows.DependencyObject ContainerFromIndex(int itemIndex)
		{
			if (this.ActiveItemContainerGenerator is global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator)
			{
				return base.RecyclingItemContainerGenerator.GetContainer(this.GetChildIndexFromItemIndex(itemIndex), false);
			}
			return base.ItemContainerGenerator.ContainerFromIndex(itemIndex);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0005C9C0 File Offset: 0x0005ABC0
		private int GetChildIndexFromItemIndex(int itemIndex)
		{
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(itemIndex);
			if (generatorPositionFromItemIndex.Offset != 0)
			{
				return generatorPositionFromItemIndex.Index + 1;
			}
			return generatorPositionFromItemIndex.Index;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0005C9EF File Offset: 0x0005ABEF
		private global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex)
		{
			return this.ActiveItemContainerGenerator.GeneratorPositionFromIndex(itemIndex);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0005C9FD File Offset: 0x0005ABFD
		private bool IsXmlNode(object item)
		{
			return item != null && item.GetType().FullName.StartsWith("System.Xml", global::System.StringComparison.Ordinal) && item is global::System.Xml.XmlNode;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0005CA28 File Offset: 0x0005AC28
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(d) as global::Infragistics.Windows.Controls.XamCarouselListBox;
			if (xamCarouselListBox != null)
			{
				global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer xamCarouselListBoxAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(xamCarouselListBox) as global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer;
				xamCarouselListBoxAutomationPeer.RaiseIsSelectedChanged(d, (bool)e.NewValue);
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0005CA63 File Offset: 0x0005AC63
		private void OnItemsCurrentChanged(object sender, global::System.EventArgs e)
		{
			if (this._isSynchronizedWithCurrentItemPrivate)
			{
				this.SetSelectedToCurrent();
			}
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0005CA73 File Offset: 0x0005AC73
		private void SetCurrentToSelected()
		{
			if (this.SelectedItem == null)
			{
				base.Items.MoveCurrentToPosition(-1);
				return;
			}
			base.Items.MoveCurrentTo(this.SelectedItem);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0005CAA0 File Offset: 0x0005ACA0
		private void SetSelectedToCurrent()
		{
			object currentItem = base.Items.CurrentItem;
			if (currentItem != null)
			{
				this.SelectedItem = currentItem;
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0005CAC4 File Offset: 0x0005ACC4
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

		// Token: 0x06001841 RID: 6209 RVA: 0x0005CB08 File Offset: 0x0005AD08
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

		// Token: 0x06001842 RID: 6210 RVA: 0x0005CBAC File Offset: 0x0005ADAC
		protected virtual void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0005CBB5 File Offset: 0x0005ADB5
		internal void RaiseSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.XamCarouselListBox.SelectionChangedEvent;
			args.Source = this;
			this.OnSelectionChanged(args);
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06001844 RID: 6212 RVA: 0x0005CBD0 File Offset: 0x0005ADD0
		// (remove) Token: 0x06001845 RID: 6213 RVA: 0x0005CBDE File Offset: 0x0005ADDE
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0005CBEC File Offset: 0x0005ADEC
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0005CBF4 File Offset: 0x0005ADF4
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

		// Token: 0x04000C38 RID: 3128
		private const int CONTAINER_CACHE_SIZE = 15;

		// Token: 0x04000C39 RID: 3129
		private global::System.Collections.Generic.Stack<global::System.Windows.DependencyObject> _containerCache = new global::System.Collections.Generic.Stack<global::System.Windows.DependencyObject>(15);

		// Token: 0x04000C3A RID: 3130
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C3B RID: 3131
		private global::Infragistics.Windows.Controls.CarouselViewSettings _viewSettings;

		// Token: 0x04000C3C RID: 3132
		private global::Infragistics.Windows.Controls.XamCarouselPanel _carouselPanel;

		// Token: 0x04000C3D RID: 3133
		private bool _updateSelectedItem = true;

		// Token: 0x04000C3E RID: 3134
		private bool _updateSelectedIndex = true;

		// Token: 0x04000C3F RID: 3135
		private bool _isSynchronizedWithCurrentItemPrivate;

		// Token: 0x04000C40 RID: 3136
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000C41 RID: 3137
		private static readonly global::System.Windows.DependencyPropertyKey IsSelectionActivePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsSelectionActive", typeof(bool), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000C42 RID: 3138
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Windows.Controls.XamCarouselListBox.IsSelectionActivePropertyKey.DependencyProperty;

		// Token: 0x04000C43 RID: 3139
		public static readonly global::System.Windows.DependencyProperty IsSynchronizedWithCurrentItemProperty = global::System.Windows.DependencyProperty.Register("IsSynchronizedWithCurrentItem", typeof(bool?), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnIsSynchronizedWithCurrentItemChanged)));

		// Token: 0x04000C44 RID: 3140
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty = global::System.Windows.DependencyProperty.Register("SelectedIndex", typeof(int), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedIndexChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnCoerceSelectedIndex)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnValidateSelectedIndex));

		// Token: 0x04000C45 RID: 3141
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty = global::System.Windows.DependencyProperty.Register("SelectedItem", typeof(object), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedItemChanged)));

		// Token: 0x04000C46 RID: 3142
		private static readonly global::System.Windows.DependencyPropertyKey SelectedValuePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SelectedValue", typeof(object), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C47 RID: 3143
		public static readonly global::System.Windows.DependencyProperty SelectedValueProperty = global::Infragistics.Windows.Controls.XamCarouselListBox.SelectedValuePropertyKey.DependencyProperty;

		// Token: 0x04000C48 RID: 3144
		public static readonly global::System.Windows.DependencyProperty SelectedValuePathProperty = global::System.Windows.DependencyProperty.Register("SelectedValuePath", typeof(string), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedValuePathChanged)));

		// Token: 0x04000C49 RID: 3145
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::Infragistics.Windows.Controls.XamCarouselPanel.ViewSettingsProperty.AddOwner(typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnCoerceViewSettings)));

		// Token: 0x04000C4A RID: 3146
		private static readonly global::System.Windows.DependencyProperty SelectedValueInternalProperty = global::System.Windows.DependencyProperty.Register("SelectedValueInternal", typeof(object), typeof(global::Infragistics.Windows.Controls.XamCarouselListBox), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamCarouselListBox.OnSelectedValueInternalChanged)));
	}
}
