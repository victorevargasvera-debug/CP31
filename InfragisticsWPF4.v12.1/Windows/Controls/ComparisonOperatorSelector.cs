using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Automation.Peers;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000141 RID: 321
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplatePart(Name = "PART_ComboBox", Type = typeof(global::System.Windows.Controls.ComboBox))]
	public class ComparisonOperatorSelector : global::System.Windows.Controls.Control
	{
		// Token: 0x06000AC7 RID: 2759 RVA: 0x00023480 File Offset: 0x00021680
		public ComparisonOperatorSelector()
		{
			global::System.Array values = global::System.Enum.GetValues(typeof(global::Infragistics.Windows.Controls.ComparisonOperator));
			this._allOperatorList = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ComparisonOperatorListItem>(values.Length);
			foreach (object obj in values)
			{
				global::Infragistics.Windows.Controls.ComparisonOperator oper = (global::Infragistics.Windows.Controls.ComparisonOperator)obj;
				global::Infragistics.Windows.Controls.ComparisonOperatorListItem item = this.CreateOperatorListItem(oper);
				this._allOperatorList.Add(item);
			}
			this._filteredList = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem>(this._allOperatorList);
			this._items = new global::Infragistics.Windows.Controls.ComparisonOperatorListItemCollection(this._filteredList);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00023540 File Offset: 0x00021740
		static ComparisonOperatorSelector()
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedOperatorChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.SelectedOperatorChangedEventArgs>), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SelectedOperatorInfo", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoProperty = global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEqualsImageProperty = global::System.Windows.DependencyProperty.Register("OperatorEqualsImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEqualsImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorEqualsImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotEqualsImageProperty = global::System.Windows.DependencyProperty.Register("OperatorNotEqualsImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotEqualsImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorNotEqualsImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanImageProperty = global::System.Windows.DependencyProperty.Register("OperatorLessThanImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorLessThanImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanOrEqualToImageProperty = global::System.Windows.DependencyProperty.Register("OperatorLessThanOrEqualToImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanOrEqualToImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorLessThanOrEqualToImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanImageProperty = global::System.Windows.DependencyProperty.Register("OperatorGreaterThanImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorGreaterThanImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanOrEqualToImageProperty = global::System.Windows.DependencyProperty.Register("OperatorGreaterThanOrEqualToImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanOrEqualToImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorGreaterThanOrEqualToImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorContainsImageProperty = global::System.Windows.DependencyProperty.Register("OperatorContainsImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorContainsImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorContainsImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotContainImageProperty = global::System.Windows.DependencyProperty.Register("OperatorDoesNotContainImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotContainImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorDoesNotContainImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLikeImageProperty = global::System.Windows.DependencyProperty.Register("OperatorLikeImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLikeImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorLikeImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotLikeImageProperty = global::System.Windows.DependencyProperty.Register("OperatorNotLikeImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotLikeImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorNotLikeImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorMatchImageProperty = global::System.Windows.DependencyProperty.Register("OperatorMatchImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorMatchImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorMatchImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotMatchImageProperty = global::System.Windows.DependencyProperty.Register("OperatorDoesNotMatchImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotMatchImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorDoesNotMatchImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorStartsWithImageProperty = global::System.Windows.DependencyProperty.Register("OperatorStartsWithImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorStartsWithImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorStartsWithImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotStartWithImageProperty = global::System.Windows.DependencyProperty.Register("OperatorDoesNotStartWithImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotStartWithImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorDoesNotStartWithImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEndsWithImageProperty = global::System.Windows.DependencyProperty.Register("OperatorEndsWithImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEndsWithImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorEndsWithImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotEndWithImageProperty = global::System.Windows.DependencyProperty.Register("OperatorDoesNotEndWithImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotEndWithImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorDoesNotEndWithImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopImageProperty = global::System.Windows.DependencyProperty.Register("OperatorTopImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorTopImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomImageProperty = global::System.Windows.DependencyProperty.Register("OperatorBottomImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorBottomImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopPercentileImageProperty = global::System.Windows.DependencyProperty.Register("OperatorTopPercentileImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopPercentileImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorTopPercentileImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomPercentileImageProperty = global::System.Windows.DependencyProperty.Register("OperatorBottomPercentileImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomPercentileImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorBottomPercentileImageKey");
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector)));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnVisualStatePropertyChanged)));
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00023C7E File Offset: 0x00021E7E
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00023C99 File Offset: 0x00021E99
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.ComparisonOperatorSelectorAutomationPeer(this);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00023CA1 File Offset: 0x00021EA1
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00023CB0 File Offset: 0x00021EB0
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00023CBF File Offset: 0x00021EBF
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00023CD0 File Offset: 0x00021ED0
		private static void OnAllowableOperatorsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector comparisonOperatorSelector = target as global::Infragistics.Windows.Controls.ComparisonOperatorSelector;
			if (comparisonOperatorSelector != null)
			{
				global::Infragistics.Windows.Controls.ComparisonOperatorFlags flags = (global::Infragistics.Windows.Controls.ComparisonOperatorFlags)e.NewValue;
				global::Infragistics.Windows.Controls.ComparisonOperator[] comparisonOperators = global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperators(flags);
				int num = comparisonOperators.Length;
				int count = comparisonOperatorSelector._filteredList.Count;
				if (num < comparisonOperatorSelector._allOperatorList.Count)
				{
					int i = num - 1;
					for (int j = count - 1; j >= 0; j--)
					{
						global::Infragistics.Windows.Controls.ComparisonOperator @operator = comparisonOperatorSelector._filteredList[j].Operator;
						bool flag = false;
						while (i >= 0)
						{
							global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator = comparisonOperators[i];
							if (comparisonOperator == @operator)
							{
								flag = true;
								i--;
								break;
							}
							if (comparisonOperator < @operator)
							{
								break;
							}
							i--;
						}
						if (!flag)
						{
							comparisonOperatorSelector._filteredList.RemoveAt(j);
						}
					}
				}
				count = comparisonOperatorSelector._filteredList.Count;
				if (num > count)
				{
					int k = count - 1;
					for (int l = num - 1; l >= 0; l--)
					{
						global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator2 = comparisonOperators[l];
						bool flag2 = false;
						while (k >= 0)
						{
							global::Infragistics.Windows.Controls.ComparisonOperator operator2 = comparisonOperatorSelector._filteredList[k].Operator;
							if (comparisonOperator2 == operator2)
							{
								flag2 = true;
								break;
							}
							if (comparisonOperator2 > operator2)
							{
								break;
							}
							k--;
						}
						if (!flag2)
						{
							comparisonOperatorSelector._filteredList.Insert(k + 1, comparisonOperatorSelector._allOperatorList[(int)comparisonOperator2]);
						}
					}
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00023E0C File Offset: 0x0002200C
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00023E1E File Offset: 0x0002201E
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ComparisonOperatorFlags AllowableOperators
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ComparisonOperatorFlags)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.AllowableOperatorsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.AllowableOperatorsProperty, value);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00023E31 File Offset: 0x00022031
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00023E43 File Offset: 0x00022043
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style DropDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.DropDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.DropDownButtonStyleProperty, value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00023E51 File Offset: 0x00022051
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00023E63 File Offset: 0x00022063
		[global::System.ComponentModel.Browsable(false)]
		public bool IsDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.IsDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.IsDropDownOpenProperty, value);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00023E76 File Offset: 0x00022076
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.ComparisonOperatorListItemCollection Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00023E80 File Offset: 0x00022080
		private static void OnSelectedIndexChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector comparisonOperatorSelector = target as global::Infragistics.Windows.Controls.ComparisonOperatorSelector;
			if (comparisonOperatorSelector != null)
			{
				comparisonOperatorSelector._cachedSelectedIndex = (int)e.NewValue;
				if (comparisonOperatorSelector._cachedSelectedIndex >= 0)
				{
					comparisonOperatorSelector.SelectedOperator = new global::Infragistics.Windows.Controls.ComparisonOperator?(comparisonOperatorSelector._items[comparisonOperatorSelector._cachedSelectedIndex].Operator);
				}
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00023ED3 File Offset: 0x000220D3
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00023EDB File Offset: 0x000220DB
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int SelectedIndex
		{
			get
			{
				return this._cachedSelectedIndex;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedIndexProperty, value);
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00023EF0 File Offset: 0x000220F0
		private static void OnSelectedOperatorChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector comparisonOperatorSelector = target as global::Infragistics.Windows.Controls.ComparisonOperatorSelector;
			if (comparisonOperatorSelector != null)
			{
				comparisonOperatorSelector._cachedSelectedOperator = (global::Infragistics.Windows.Controls.ComparisonOperator?)e.NewValue;
				if (comparisonOperatorSelector._cachedSelectedOperator == null)
				{
					comparisonOperatorSelector.ClearValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey);
					comparisonOperatorSelector.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedIndexProperty, -1);
				}
				else
				{
					int num = comparisonOperatorSelector._items.IndexOfOperator(comparisonOperatorSelector._cachedSelectedOperator.Value);
					if (num >= 0)
					{
						comparisonOperatorSelector.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey, comparisonOperatorSelector._items[num]);
					}
					else
					{
						global::Infragistics.Windows.Controls.ComparisonOperator value = comparisonOperatorSelector._cachedSelectedOperator.Value;
						int num2 = -1;
						int count = comparisonOperatorSelector._allOperatorList.Count;
						for (int i = 0; i < count; i++)
						{
							if (comparisonOperatorSelector._allOperatorList[i].Operator == value)
							{
								num2 = i;
								break;
							}
						}
						if (num2 >= 0)
						{
							comparisonOperatorSelector.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey, comparisonOperatorSelector._allOperatorList[num2]);
						}
						else
						{
							comparisonOperatorSelector.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey, comparisonOperatorSelector.CreateOperatorListItem(comparisonOperatorSelector._cachedSelectedOperator.Value));
						}
					}
					comparisonOperatorSelector.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedIndexProperty, num);
				}
				comparisonOperatorSelector.OnSelectedOperatorChanged((global::Infragistics.Windows.Controls.ComparisonOperator?)e.OldValue, (global::Infragistics.Windows.Controls.ComparisonOperator?)e.NewValue);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002402C File Offset: 0x0002222C
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00024034 File Offset: 0x00022234
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.ComparisonOperator? SelectedOperator
		{
			get
			{
				return this._cachedSelectedOperator;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorProperty, value);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00024048 File Offset: 0x00022248
		protected virtual void OnSelectedOperatorChanged(global::Infragistics.Windows.Controls.ComparisonOperator? previousValue, global::Infragistics.Windows.Controls.ComparisonOperator? currentValue)
		{
			base.RaiseEvent(new global::Infragistics.Windows.Controls.Events.SelectedOperatorChangedEventArgs(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000ADD RID: 2781 RVA: 0x00024076 File Offset: 0x00022276
		// (remove) Token: 0x06000ADE RID: 2782 RVA: 0x00024084 File Offset: 0x00022284
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.SelectedOperatorChangedEventArgs> SelectedOperatorChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorChangedEvent, value);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00024092 File Offset: 0x00022292
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.ComparisonOperatorListItem SelectedOperatorInfo
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ComparisonOperatorListItem)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoProperty);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000240A4 File Offset: 0x000222A4
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000240B6 File Offset: 0x000222B6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorEqualsImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEqualsImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEqualsImageProperty, value);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x000240C4 File Offset: 0x000222C4
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x000240D6 File Offset: 0x000222D6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorNotEqualsImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotEqualsImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotEqualsImageProperty, value);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000240E4 File Offset: 0x000222E4
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x000240F6 File Offset: 0x000222F6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorLessThanImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanImageProperty, value);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00024104 File Offset: 0x00022304
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00024116 File Offset: 0x00022316
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorLessThanOrEqualToImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanOrEqualToImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLessThanOrEqualToImageProperty, value);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00024124 File Offset: 0x00022324
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00024136 File Offset: 0x00022336
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorGreaterThanImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanImageProperty, value);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00024144 File Offset: 0x00022344
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x00024156 File Offset: 0x00022356
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorGreaterThanOrEqualToImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanOrEqualToImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorGreaterThanOrEqualToImageProperty, value);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00024164 File Offset: 0x00022364
		// (set) Token: 0x06000AED RID: 2797 RVA: 0x00024176 File Offset: 0x00022376
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorContainsImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorContainsImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorContainsImageProperty, value);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00024184 File Offset: 0x00022384
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00024196 File Offset: 0x00022396
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorDoesNotContainImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotContainImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotContainImageProperty, value);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000241A4 File Offset: 0x000223A4
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x000241B6 File Offset: 0x000223B6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorLikeImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLikeImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorLikeImageProperty, value);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000241C4 File Offset: 0x000223C4
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x000241D6 File Offset: 0x000223D6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorNotLikeImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotLikeImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotLikeImageProperty, value);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000241E4 File Offset: 0x000223E4
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x000241F6 File Offset: 0x000223F6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorMatchImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorMatchImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorMatchImageProperty, value);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00024204 File Offset: 0x00022404
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00024216 File Offset: 0x00022416
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorDoesNotMatchImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotMatchImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotMatchImageProperty, value);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00024224 File Offset: 0x00022424
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00024236 File Offset: 0x00022436
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorStartsWithImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorStartsWithImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorStartsWithImageProperty, value);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00024244 File Offset: 0x00022444
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00024256 File Offset: 0x00022456
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorDoesNotStartWithImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotStartWithImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotStartWithImageProperty, value);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00024264 File Offset: 0x00022464
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00024276 File Offset: 0x00022476
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorEndsWithImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEndsWithImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorEndsWithImageProperty, value);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00024284 File Offset: 0x00022484
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00024296 File Offset: 0x00022496
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorDoesNotEndWithImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotEndWithImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorDoesNotEndWithImageProperty, value);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000242A4 File Offset: 0x000224A4
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x000242B6 File Offset: 0x000224B6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorTopImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopImageProperty, value);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x000242C4 File Offset: 0x000224C4
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x000242D6 File Offset: 0x000224D6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorBottomImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomImageProperty, value);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x000242E4 File Offset: 0x000224E4
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x000242F6 File Offset: 0x000224F6
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorTopPercentileImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopPercentileImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorTopPercentileImageProperty, value);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00024304 File Offset: 0x00022504
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00024316 File Offset: 0x00022516
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorBottomPercentileImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomPercentileImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorBottomPercentileImageProperty, value);
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00024324 File Offset: 0x00022524
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (base.IsEnabled)
			{
				if (base.IsMouseOver)
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"MouseOver",
						"Normal"
					});
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
				}
			}
			else
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"Disabled",
					"Normal"
				});
			}
			if (this.IsDropDownOpen)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"FocusedDropDown",
					"Focused"
				});
				return;
			}
			if (base.IsKeyboardFocusWithin)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Focused", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Unfocused", useTransitions);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x000243DC File Offset: 0x000225DC
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector comparisonOperatorSelector = target as global::Infragistics.Windows.Controls.ComparisonOperatorSelector;
			comparisonOperatorSelector.UpdateVisualStates();
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000243F6 File Offset: 0x000225F6
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000243FF File Offset: 0x000225FF
		private void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002441C File Offset: 0x0002261C
		private global::Infragistics.Windows.Controls.ComparisonOperatorListItem CreateOperatorListItem(global::Infragistics.Windows.Controls.ComparisonOperator oper)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorListItem comparisonOperatorListItem = new global::Infragistics.Windows.Controls.ComparisonOperatorListItem(oper);
			global::System.Windows.Data.BindingOperations.SetBinding(comparisonOperatorListItem, global::Infragistics.Windows.Controls.ComparisonOperatorListItem.ImageProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Operator" + oper.ToString() + "Image", global::System.Windows.Data.BindingMode.OneWay, this));
			return comparisonOperatorListItem;
		}

		// Token: 0x040004E2 RID: 1250
		private global::Infragistics.Windows.Controls.ComparisonOperatorListItemCollection _items;

		// Token: 0x040004E3 RID: 1251
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ComparisonOperatorListItem> _allOperatorList;

		// Token: 0x040004E4 RID: 1252
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem> _filteredList;

		// Token: 0x040004E5 RID: 1253
		private bool _hasVisualStateGroups;

		// Token: 0x040004E6 RID: 1254
		public static readonly global::System.Windows.DependencyProperty AllowableOperatorsProperty = global::System.Windows.DependencyProperty.Register("AllowableOperators", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorFlags), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ComparisonOperatorFlags.All, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnAllowableOperatorsChanged)));

		// Token: 0x040004E7 RID: 1255
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::System.Windows.DependencyProperty.Register("DropDownButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040004E8 RID: 1256
		public static readonly global::System.Windows.ResourceKey DropDownButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "DropDownButtonStyleKey");

		// Token: 0x040004E9 RID: 1257
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnVisualStatePropertyChanged)));

		// Token: 0x040004EA RID: 1258
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty = global::System.Windows.DependencyProperty.Register("SelectedIndex", typeof(int), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnSelectedIndexChanged)));

		// Token: 0x040004EB RID: 1259
		private int _cachedSelectedIndex = -1;

		// Token: 0x040004EC RID: 1260
		public static readonly global::System.Windows.DependencyProperty SelectedOperatorProperty = global::System.Windows.DependencyProperty.Register("SelectedOperator", typeof(global::Infragistics.Windows.Controls.ComparisonOperator?), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnSelectedOperatorChanged)));

		// Token: 0x040004EE RID: 1262
		private global::Infragistics.Windows.Controls.ComparisonOperator? _cachedSelectedOperator = null;

		// Token: 0x040004EF RID: 1263
		private static readonly global::System.Windows.DependencyPropertyKey SelectedOperatorInfoPropertyKey;

		// Token: 0x040004F0 RID: 1264
		public static readonly global::System.Windows.DependencyProperty SelectedOperatorInfoProperty;

		// Token: 0x040004F1 RID: 1265
		public static readonly global::System.Windows.DependencyProperty OperatorEqualsImageProperty;

		// Token: 0x040004F2 RID: 1266
		public static readonly global::System.Windows.ResourceKey OperatorEqualsImageKey;

		// Token: 0x040004F3 RID: 1267
		public static readonly global::System.Windows.DependencyProperty OperatorNotEqualsImageProperty;

		// Token: 0x040004F4 RID: 1268
		public static readonly global::System.Windows.ResourceKey OperatorNotEqualsImageKey;

		// Token: 0x040004F5 RID: 1269
		public static readonly global::System.Windows.DependencyProperty OperatorLessThanImageProperty;

		// Token: 0x040004F6 RID: 1270
		public static readonly global::System.Windows.ResourceKey OperatorLessThanImageKey;

		// Token: 0x040004F7 RID: 1271
		public static readonly global::System.Windows.DependencyProperty OperatorLessThanOrEqualToImageProperty;

		// Token: 0x040004F8 RID: 1272
		public static readonly global::System.Windows.ResourceKey OperatorLessThanOrEqualToImageKey;

		// Token: 0x040004F9 RID: 1273
		public static readonly global::System.Windows.DependencyProperty OperatorGreaterThanImageProperty;

		// Token: 0x040004FA RID: 1274
		public static readonly global::System.Windows.ResourceKey OperatorGreaterThanImageKey;

		// Token: 0x040004FB RID: 1275
		public static readonly global::System.Windows.DependencyProperty OperatorGreaterThanOrEqualToImageProperty;

		// Token: 0x040004FC RID: 1276
		public static readonly global::System.Windows.ResourceKey OperatorGreaterThanOrEqualToImageKey;

		// Token: 0x040004FD RID: 1277
		public static readonly global::System.Windows.DependencyProperty OperatorContainsImageProperty;

		// Token: 0x040004FE RID: 1278
		public static readonly global::System.Windows.ResourceKey OperatorContainsImageKey;

		// Token: 0x040004FF RID: 1279
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotContainImageProperty;

		// Token: 0x04000500 RID: 1280
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotContainImageKey;

		// Token: 0x04000501 RID: 1281
		public static readonly global::System.Windows.DependencyProperty OperatorLikeImageProperty;

		// Token: 0x04000502 RID: 1282
		public static readonly global::System.Windows.ResourceKey OperatorLikeImageKey;

		// Token: 0x04000503 RID: 1283
		public static readonly global::System.Windows.DependencyProperty OperatorNotLikeImageProperty;

		// Token: 0x04000504 RID: 1284
		public static readonly global::System.Windows.ResourceKey OperatorNotLikeImageKey;

		// Token: 0x04000505 RID: 1285
		public static readonly global::System.Windows.DependencyProperty OperatorMatchImageProperty;

		// Token: 0x04000506 RID: 1286
		public static readonly global::System.Windows.ResourceKey OperatorMatchImageKey;

		// Token: 0x04000507 RID: 1287
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotMatchImageProperty;

		// Token: 0x04000508 RID: 1288
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotMatchImageKey;

		// Token: 0x04000509 RID: 1289
		public static readonly global::System.Windows.DependencyProperty OperatorStartsWithImageProperty;

		// Token: 0x0400050A RID: 1290
		public static readonly global::System.Windows.ResourceKey OperatorStartsWithImageKey;

		// Token: 0x0400050B RID: 1291
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotStartWithImageProperty;

		// Token: 0x0400050C RID: 1292
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotStartWithImageKey;

		// Token: 0x0400050D RID: 1293
		public static readonly global::System.Windows.DependencyProperty OperatorEndsWithImageProperty;

		// Token: 0x0400050E RID: 1294
		public static readonly global::System.Windows.ResourceKey OperatorEndsWithImageKey;

		// Token: 0x0400050F RID: 1295
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotEndWithImageProperty;

		// Token: 0x04000510 RID: 1296
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotEndWithImageKey;

		// Token: 0x04000511 RID: 1297
		public static readonly global::System.Windows.DependencyProperty OperatorTopImageProperty;

		// Token: 0x04000512 RID: 1298
		public static readonly global::System.Windows.ResourceKey OperatorTopImageKey;

		// Token: 0x04000513 RID: 1299
		public static readonly global::System.Windows.DependencyProperty OperatorBottomImageProperty;

		// Token: 0x04000514 RID: 1300
		public static readonly global::System.Windows.ResourceKey OperatorBottomImageKey;

		// Token: 0x04000515 RID: 1301
		public static readonly global::System.Windows.DependencyProperty OperatorTopPercentileImageProperty;

		// Token: 0x04000516 RID: 1302
		public static readonly global::System.Windows.ResourceKey OperatorTopPercentileImageKey;

		// Token: 0x04000517 RID: 1303
		public static readonly global::System.Windows.DependencyProperty OperatorBottomPercentileImageProperty;

		// Token: 0x04000518 RID: 1304
		public static readonly global::System.Windows.ResourceKey OperatorBottomPercentileImageKey;
	}
}
