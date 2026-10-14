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
	// Token: 0x0200015F RID: 351
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_ComboBox", Type = typeof(global::System.Windows.Controls.ComboBox))]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "FocusedDropDown", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	public class ComparisonOperatorSelector : global::System.Windows.Controls.Control
	{
		// Token: 0x06000BC5 RID: 3013 RVA: 0x00026F28 File Offset: 0x00025128
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
			base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectorPropertyKey, this);
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00026FF4 File Offset: 0x000251F4
		static ComparisonOperatorSelector()
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedOperatorChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.SelectedOperatorChangedEventArgs>), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SelectedOperatorInfo", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorListItem), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoProperty = global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorInfoPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectorPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("Selector", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits | global::System.Windows.FrameworkPropertyMetadataOptions.OverridesInheritanceBehavior));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectorProperty = global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectorPropertyKey.DependencyProperty;
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
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorInImageProperty = global::System.Windows.DependencyProperty.Register("OperatorInImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorInImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorInImageKey");
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotInImageProperty = global::System.Windows.DependencyProperty.Register("OperatorNotInImage", typeof(global::System.Windows.Media.ImageSource), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotInImageKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "OperatorNotInImageKey");
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

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000277F0 File Offset: 0x000259F0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0002780B File Offset: 0x00025A0B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.ComparisonOperatorSelectorAutomationPeer(this);
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00027813 File Offset: 0x00025A13
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00027822 File Offset: 0x00025A22
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00027831 File Offset: 0x00025A31
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00027840 File Offset: 0x00025A40
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

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0002797C File Offset: 0x00025B7C
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0002798E File Offset: 0x00025B8E
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

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000279A1 File Offset: 0x00025BA1
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000279B3 File Offset: 0x00025BB3
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

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000279C1 File Offset: 0x00025BC1
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000279D3 File Offset: 0x00025BD3
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

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x000279E6 File Offset: 0x00025BE6
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.ComparisonOperatorListItemCollection Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000279F0 File Offset: 0x00025BF0
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

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00027A43 File Offset: 0x00025C43
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00027A4B File Offset: 0x00025C4B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00027A60 File Offset: 0x00025C60
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

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00027B9C File Offset: 0x00025D9C
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00027BA4 File Offset: 0x00025DA4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000BDA RID: 3034 RVA: 0x00027BB8 File Offset: 0x00025DB8
		protected virtual void OnSelectedOperatorChanged(global::Infragistics.Windows.Controls.ComparisonOperator? previousValue, global::Infragistics.Windows.Controls.ComparisonOperator? currentValue)
		{
			base.RaiseEvent(new global::Infragistics.Windows.Controls.Events.SelectedOperatorChangedEventArgs(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectedOperatorChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000BDB RID: 3035 RVA: 0x00027BE6 File Offset: 0x00025DE6
		// (remove) Token: 0x06000BDC RID: 3036 RVA: 0x00027BF4 File Offset: 0x00025DF4
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00027C02 File Offset: 0x00025E02
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

		// Token: 0x06000BDE RID: 3038 RVA: 0x00027C14 File Offset: 0x00025E14
		public static global::Infragistics.Windows.Controls.ComparisonOperatorSelector GetSelector(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Controls.ComparisonOperatorSelector)d.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.SelectorProperty);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00027C26 File Offset: 0x00025E26
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00027C38 File Offset: 0x00025E38
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

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00027C46 File Offset: 0x00025E46
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00027C58 File Offset: 0x00025E58
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

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00027C66 File Offset: 0x00025E66
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00027C78 File Offset: 0x00025E78
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

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00027C86 File Offset: 0x00025E86
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x00027C98 File Offset: 0x00025E98
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

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00027CA6 File Offset: 0x00025EA6
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x00027CB8 File Offset: 0x00025EB8
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00027CC6 File Offset: 0x00025EC6
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00027CD8 File Offset: 0x00025ED8
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

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00027CE6 File Offset: 0x00025EE6
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00027CF8 File Offset: 0x00025EF8
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

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00027D06 File Offset: 0x00025F06
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00027D18 File Offset: 0x00025F18
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00027D26 File Offset: 0x00025F26
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x00027D38 File Offset: 0x00025F38
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorInImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorInImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorInImageProperty, value);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00027D46 File Offset: 0x00025F46
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00027D58 File Offset: 0x00025F58
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.ImageSource OperatorNotInImage
		{
			get
			{
				return (global::System.Windows.Media.ImageSource)base.GetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotInImageProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OperatorNotInImageProperty, value);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00027D66 File Offset: 0x00025F66
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00027D78 File Offset: 0x00025F78
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

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00027D86 File Offset: 0x00025F86
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00027D98 File Offset: 0x00025F98
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00027DA6 File Offset: 0x00025FA6
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00027DB8 File Offset: 0x00025FB8
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

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00027DC6 File Offset: 0x00025FC6
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00027DD8 File Offset: 0x00025FD8
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00027DE6 File Offset: 0x00025FE6
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00027DF8 File Offset: 0x00025FF8
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

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00027E06 File Offset: 0x00026006
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00027E18 File Offset: 0x00026018
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

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00027E26 File Offset: 0x00026026
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00027E38 File Offset: 0x00026038
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

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00027E46 File Offset: 0x00026046
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00027E58 File Offset: 0x00026058
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

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00027E66 File Offset: 0x00026066
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x00027E78 File Offset: 0x00026078
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x00027E86 File Offset: 0x00026086
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00027E98 File Offset: 0x00026098
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

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00027EA6 File Offset: 0x000260A6
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x00027EB8 File Offset: 0x000260B8
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00027EC6 File Offset: 0x000260C6
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00027ED8 File Offset: 0x000260D8
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

		// Token: 0x06000C0B RID: 3083 RVA: 0x00027EE8 File Offset: 0x000260E8
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

		// Token: 0x06000C0C RID: 3084 RVA: 0x00027FA0 File Offset: 0x000261A0
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorSelector comparisonOperatorSelector = target as global::Infragistics.Windows.Controls.ComparisonOperatorSelector;
			comparisonOperatorSelector.UpdateVisualStates();
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00027FBA File Offset: 0x000261BA
		private void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00027FC3 File Offset: 0x000261C3
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x00027FE0 File Offset: 0x000261E0
		private global::Infragistics.Windows.Controls.ComparisonOperatorListItem CreateOperatorListItem(global::Infragistics.Windows.Controls.ComparisonOperator oper)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorListItem comparisonOperatorListItem = new global::Infragistics.Windows.Controls.ComparisonOperatorListItem(oper);
			global::System.Windows.Data.BindingOperations.SetBinding(comparisonOperatorListItem, global::Infragistics.Windows.Controls.ComparisonOperatorListItem.ImageProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Operator" + oper.ToString() + "Image", global::System.Windows.Data.BindingMode.OneWay, this));
			return comparisonOperatorListItem;
		}

		// Token: 0x04000594 RID: 1428
		private global::Infragistics.Windows.Controls.ComparisonOperatorListItemCollection _items;

		// Token: 0x04000595 RID: 1429
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.ComparisonOperatorListItem> _allOperatorList;

		// Token: 0x04000596 RID: 1430
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Controls.ComparisonOperatorListItem> _filteredList;

		// Token: 0x04000597 RID: 1431
		private bool _hasVisualStateGroups;

		// Token: 0x04000598 RID: 1432
		public static readonly global::System.Windows.DependencyProperty AllowableOperatorsProperty = global::System.Windows.DependencyProperty.Register("AllowableOperators", typeof(global::Infragistics.Windows.Controls.ComparisonOperatorFlags), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ComparisonOperatorFlags.All, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnAllowableOperatorsChanged)));

		// Token: 0x04000599 RID: 1433
		public static readonly global::System.Windows.DependencyProperty DropDownButtonStyleProperty = global::System.Windows.DependencyProperty.Register("DropDownButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400059A RID: 1434
		public static readonly global::System.Windows.ResourceKey DropDownButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), "DropDownButtonStyleKey");

		// Token: 0x0400059B RID: 1435
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnVisualStatePropertyChanged)));

		// Token: 0x0400059C RID: 1436
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty = global::System.Windows.DependencyProperty.Register("SelectedIndex", typeof(int), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnSelectedIndexChanged)));

		// Token: 0x0400059D RID: 1437
		private int _cachedSelectedIndex = -1;

		// Token: 0x0400059E RID: 1438
		public static readonly global::System.Windows.DependencyProperty SelectedOperatorProperty = global::System.Windows.DependencyProperty.Register("SelectedOperator", typeof(global::Infragistics.Windows.Controls.ComparisonOperator?), typeof(global::Infragistics.Windows.Controls.ComparisonOperatorSelector), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.ComparisonOperatorSelector.OnSelectedOperatorChanged)));

		// Token: 0x040005A0 RID: 1440
		private global::Infragistics.Windows.Controls.ComparisonOperator? _cachedSelectedOperator = null;

		// Token: 0x040005A1 RID: 1441
		private static readonly global::System.Windows.DependencyPropertyKey SelectedOperatorInfoPropertyKey;

		// Token: 0x040005A2 RID: 1442
		public static readonly global::System.Windows.DependencyProperty SelectedOperatorInfoProperty;

		// Token: 0x040005A3 RID: 1443
		private static readonly global::System.Windows.DependencyPropertyKey SelectorPropertyKey;

		// Token: 0x040005A4 RID: 1444
		public static readonly global::System.Windows.DependencyProperty SelectorProperty;

		// Token: 0x040005A5 RID: 1445
		public static readonly global::System.Windows.DependencyProperty OperatorEqualsImageProperty;

		// Token: 0x040005A6 RID: 1446
		public static readonly global::System.Windows.ResourceKey OperatorEqualsImageKey;

		// Token: 0x040005A7 RID: 1447
		public static readonly global::System.Windows.DependencyProperty OperatorNotEqualsImageProperty;

		// Token: 0x040005A8 RID: 1448
		public static readonly global::System.Windows.ResourceKey OperatorNotEqualsImageKey;

		// Token: 0x040005A9 RID: 1449
		public static readonly global::System.Windows.DependencyProperty OperatorLessThanImageProperty;

		// Token: 0x040005AA RID: 1450
		public static readonly global::System.Windows.ResourceKey OperatorLessThanImageKey;

		// Token: 0x040005AB RID: 1451
		public static readonly global::System.Windows.DependencyProperty OperatorLessThanOrEqualToImageProperty;

		// Token: 0x040005AC RID: 1452
		public static readonly global::System.Windows.ResourceKey OperatorLessThanOrEqualToImageKey;

		// Token: 0x040005AD RID: 1453
		public static readonly global::System.Windows.DependencyProperty OperatorGreaterThanImageProperty;

		// Token: 0x040005AE RID: 1454
		public static readonly global::System.Windows.ResourceKey OperatorGreaterThanImageKey;

		// Token: 0x040005AF RID: 1455
		public static readonly global::System.Windows.DependencyProperty OperatorGreaterThanOrEqualToImageProperty;

		// Token: 0x040005B0 RID: 1456
		public static readonly global::System.Windows.ResourceKey OperatorGreaterThanOrEqualToImageKey;

		// Token: 0x040005B1 RID: 1457
		public static readonly global::System.Windows.DependencyProperty OperatorContainsImageProperty;

		// Token: 0x040005B2 RID: 1458
		public static readonly global::System.Windows.ResourceKey OperatorContainsImageKey;

		// Token: 0x040005B3 RID: 1459
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotContainImageProperty;

		// Token: 0x040005B4 RID: 1460
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotContainImageKey;

		// Token: 0x040005B5 RID: 1461
		public static readonly global::System.Windows.DependencyProperty OperatorInImageProperty;

		// Token: 0x040005B6 RID: 1462
		public static readonly global::System.Windows.ResourceKey OperatorInImageKey;

		// Token: 0x040005B7 RID: 1463
		public static readonly global::System.Windows.DependencyProperty OperatorNotInImageProperty;

		// Token: 0x040005B8 RID: 1464
		public static readonly global::System.Windows.ResourceKey OperatorNotInImageKey;

		// Token: 0x040005B9 RID: 1465
		public static readonly global::System.Windows.DependencyProperty OperatorLikeImageProperty;

		// Token: 0x040005BA RID: 1466
		public static readonly global::System.Windows.ResourceKey OperatorLikeImageKey;

		// Token: 0x040005BB RID: 1467
		public static readonly global::System.Windows.DependencyProperty OperatorNotLikeImageProperty;

		// Token: 0x040005BC RID: 1468
		public static readonly global::System.Windows.ResourceKey OperatorNotLikeImageKey;

		// Token: 0x040005BD RID: 1469
		public static readonly global::System.Windows.DependencyProperty OperatorMatchImageProperty;

		// Token: 0x040005BE RID: 1470
		public static readonly global::System.Windows.ResourceKey OperatorMatchImageKey;

		// Token: 0x040005BF RID: 1471
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotMatchImageProperty;

		// Token: 0x040005C0 RID: 1472
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotMatchImageKey;

		// Token: 0x040005C1 RID: 1473
		public static readonly global::System.Windows.DependencyProperty OperatorStartsWithImageProperty;

		// Token: 0x040005C2 RID: 1474
		public static readonly global::System.Windows.ResourceKey OperatorStartsWithImageKey;

		// Token: 0x040005C3 RID: 1475
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotStartWithImageProperty;

		// Token: 0x040005C4 RID: 1476
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotStartWithImageKey;

		// Token: 0x040005C5 RID: 1477
		public static readonly global::System.Windows.DependencyProperty OperatorEndsWithImageProperty;

		// Token: 0x040005C6 RID: 1478
		public static readonly global::System.Windows.ResourceKey OperatorEndsWithImageKey;

		// Token: 0x040005C7 RID: 1479
		public static readonly global::System.Windows.DependencyProperty OperatorDoesNotEndWithImageProperty;

		// Token: 0x040005C8 RID: 1480
		public static readonly global::System.Windows.ResourceKey OperatorDoesNotEndWithImageKey;

		// Token: 0x040005C9 RID: 1481
		public static readonly global::System.Windows.DependencyProperty OperatorTopImageProperty;

		// Token: 0x040005CA RID: 1482
		public static readonly global::System.Windows.ResourceKey OperatorTopImageKey;

		// Token: 0x040005CB RID: 1483
		public static readonly global::System.Windows.DependencyProperty OperatorBottomImageProperty;

		// Token: 0x040005CC RID: 1484
		public static readonly global::System.Windows.ResourceKey OperatorBottomImageKey;

		// Token: 0x040005CD RID: 1485
		public static readonly global::System.Windows.DependencyProperty OperatorTopPercentileImageProperty;

		// Token: 0x040005CE RID: 1486
		public static readonly global::System.Windows.ResourceKey OperatorTopPercentileImageKey;

		// Token: 0x040005CF RID: 1487
		public static readonly global::System.Windows.DependencyProperty OperatorBottomPercentileImageProperty;

		// Token: 0x040005D0 RID: 1488
		public static readonly global::System.Windows.ResourceKey OperatorBottomPercentileImageKey;
	}
}
