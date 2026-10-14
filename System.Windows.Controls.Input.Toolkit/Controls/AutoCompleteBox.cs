using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Properties;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace System.Windows.Controls
{
	// Token: 0x0200000D RID: 13
	[global::System.Windows.TemplatePart(Name = "Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "SelectionAdapter", Type = typeof(global::System.Windows.Controls.ISelectionAdapter))]
	[global::System.Windows.Markup.ContentProperty("ItemsSource")]
	[global::System.Windows.TemplatePart(Name = "Text", Type = typeof(global::System.Windows.Controls.TextBox))]
	[global::System.Windows.StyleTypedProperty(Property = "TextBoxStyle", StyleTargetType = typeof(global::System.Windows.Controls.TextBox))]
	[global::System.Windows.StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(global::System.Windows.Controls.ListBox))]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "Selector", Type = typeof(global::System.Windows.Controls.Primitives.Selector))]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "PopupClosed", GroupName = "PopupStates")]
	[global::System.Windows.TemplateVisualState(Name = "PopupOpened", GroupName = "PopupStates")]
	[global::System.Windows.TemplateVisualState(Name = "Valid", GroupName = "ValidationStates")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidFocused", GroupName = "ValidationStates")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidUnfocused", GroupName = "ValidationStates")]
	public class AutoCompleteBox : global::System.Windows.Controls.Control, global::System.Windows.Controls.IUpdateVisualState
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003A25 File Offset: 0x00001C25
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00003A2D File Offset: 0x00001C2D
		internal global::System.Windows.Controls.InteractionHelper Interaction { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003A36 File Offset: 0x00001C36
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003A48 File Offset: 0x00001C48
		public int MinimumPrefixLength
		{
			get
			{
				return (int)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.MinimumPrefixLengthProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, value);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003A5C File Offset: 0x00001C5C
		private static void OnMinimumPrefixLengthPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			int num = (int)e.NewValue;
			if (num < 0 && num != -1)
			{
				throw new global::System.ArgumentOutOfRangeException("MinimumPrefixLength");
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003A89 File Offset: 0x00001C89
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00003A9B File Offset: 0x00001C9B
		public int MinimumPopulateDelay
		{
			get
			{
				return (int)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.MinimumPopulateDelayProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, value);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003AB0 File Offset: 0x00001CB0
		private static void OnMinimumPopulateDelayPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			if (autoCompleteBox._ignorePropertyChange)
			{
				autoCompleteBox._ignorePropertyChange = false;
				return;
			}
			int num = (int)e.NewValue;
			if (num < 0)
			{
				autoCompleteBox._ignorePropertyChange = true;
				d.SetValue(e.Property, e.OldValue);
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.AutoComplete_OnMinimumPopulateDelayPropertyChanged_InvalidValue, new object[]
				{
					num
				}), "value");
			}
			if (autoCompleteBox._delayTimer != null)
			{
				autoCompleteBox._delayTimer.Stop();
				if (num == 0)
				{
					autoCompleteBox._delayTimer = null;
				}
			}
			if (num > 0 && autoCompleteBox._delayTimer == null)
			{
				autoCompleteBox._delayTimer = new global::System.Windows.Threading.DispatcherTimer();
				autoCompleteBox._delayTimer.Tick += autoCompleteBox.PopulateDropDown;
			}
			if (num > 0 && autoCompleteBox._delayTimer != null)
			{
				autoCompleteBox._delayTimer.Interval = global::System.TimeSpan.FromMilliseconds((double)num);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003B94 File Offset: 0x00001D94
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00003BA6 File Offset: 0x00001DA6
		public bool IsTextCompletionEnabled
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003BB9 File Offset: 0x00001DB9
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00003BCB File Offset: 0x00001DCB
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.ItemTemplateProperty) as global::System.Windows.DataTemplate;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.ItemTemplateProperty, value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003BD9 File Offset: 0x00001DD9
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00003BEB File Offset: 0x00001DEB
		public global::System.Windows.Style ItemContainerStyle
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.ItemContainerStyleProperty) as global::System.Windows.Style;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.ItemContainerStyleProperty, value);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003BF9 File Offset: 0x00001DF9
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00003C0B File Offset: 0x00001E0B
		public global::System.Windows.Style TextBoxStyle
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.TextBoxStyleProperty) as global::System.Windows.Style;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.TextBoxStyleProperty, value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00003C19 File Offset: 0x00001E19
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00003C2B File Offset: 0x00001E2B
		public double MaxDropDownHeight
		{
			get
			{
				return (double)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.MaxDropDownHeightProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.MaxDropDownHeightProperty, value);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003C40 File Offset: 0x00001E40
		private static void OnMaxDropDownHeightPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			if (autoCompleteBox._ignorePropertyChange)
			{
				autoCompleteBox._ignorePropertyChange = false;
				return;
			}
			double num = (double)e.NewValue;
			if (num < 0.0)
			{
				autoCompleteBox._ignorePropertyChange = true;
				autoCompleteBox.SetValue(e.Property, e.OldValue);
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.AutoComplete_OnMaxDropDownHeightPropertyChanged_InvalidValue, new object[]
				{
					e.NewValue
				}), "value");
			}
			autoCompleteBox.OnMaxDropDownHeightChanged(num);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003CCB File Offset: 0x00001ECB
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00003CDD File Offset: 0x00001EDD
		public bool IsDropDownOpen
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.IsDropDownOpenProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.IsDropDownOpenProperty, value);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003CF0 File Offset: 0x00001EF0
		private static void OnIsDropDownOpenPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			if (autoCompleteBox._ignorePropertyChange)
			{
				autoCompleteBox._ignorePropertyChange = false;
				return;
			}
			bool oldValue = (bool)e.OldValue;
			bool flag = (bool)e.NewValue;
			if (flag)
			{
				autoCompleteBox.TextUpdated(autoCompleteBox.Text, true);
			}
			else
			{
				autoCompleteBox.ClosingDropDown(oldValue);
			}
			autoCompleteBox.UpdateVisualState(true);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003D4E File Offset: 0x00001F4E
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00003D60 File Offset: 0x00001F60
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.ItemsSourceProperty) as global::System.Collections.IEnumerable;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.ItemsSourceProperty, value);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003D70 File Offset: 0x00001F70
		private static void OnItemsSourcePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			autoCompleteBox.OnItemsSourceChanged((global::System.Collections.IEnumerable)e.OldValue, (global::System.Collections.IEnumerable)e.NewValue);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003DA2 File Offset: 0x00001FA2
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00003DAF File Offset: 0x00001FAF
		public object SelectedItem
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.SelectedItemProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.SelectedItemProperty, value);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private static void OnSelectedItemPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			if (autoCompleteBox._ignorePropertyChange)
			{
				autoCompleteBox._ignorePropertyChange = false;
				return;
			}
			if (autoCompleteBox._skipSelectedItemTextUpdate)
			{
				autoCompleteBox._skipSelectedItemTextUpdate = false;
			}
			else
			{
				autoCompleteBox.OnSelectedItemChanged(e.NewValue);
			}
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			if (e.OldValue != null)
			{
				list.Add(e.OldValue);
			}
			global::System.Collections.Generic.List<object> list2 = new global::System.Collections.Generic.List<object>();
			if (e.NewValue != null)
			{
				list2.Add(e.NewValue);
			}
			autoCompleteBox.OnSelectionChanged(new global::System.Windows.Controls.SelectionChangedEventArgs(global::System.Windows.Controls.AutoCompleteBox.SelectionChangedEvent, list, list2));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003E4C File Offset: 0x0000204C
		private void OnSelectedItemChanged(object newItem)
		{
			string value;
			if (newItem == null)
			{
				value = this.SearchText;
			}
			else
			{
				value = this.FormatValue(newItem, true);
			}
			this.UpdateTextValue(value);
			if (this.TextBox != null && this.Text != null)
			{
				this.TextBox.SelectionStart = this.Text.Length;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003E9B File Offset: 0x0000209B
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00003EAD File Offset: 0x000020AD
		public string Text
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.TextProperty) as string;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.TextProperty, value);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003EBC File Offset: 0x000020BC
		private static void OnTextPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			autoCompleteBox.TextUpdated((string)e.NewValue, false);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003EE3 File Offset: 0x000020E3
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00003EF8 File Offset: 0x000020F8
		public string SearchText
		{
			get
			{
				return (string)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.SearchTextProperty);
			}
			private set
			{
				try
				{
					this._allowWrite = true;
					base.SetValue(global::System.Windows.Controls.AutoCompleteBox.SearchTextProperty, value);
				}
				finally
				{
					this._allowWrite = false;
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003F34 File Offset: 0x00002134
		private static void OnSearchTextPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			if (autoCompleteBox._ignorePropertyChange)
			{
				autoCompleteBox._ignorePropertyChange = false;
				return;
			}
			if (!autoCompleteBox._allowWrite)
			{
				autoCompleteBox._ignorePropertyChange = true;
				autoCompleteBox.SetValue(e.Property, e.OldValue);
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.AutoComplete_OnSearchTextPropertyChanged_InvalidWrite);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003F86 File Offset: 0x00002186
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00003F98 File Offset: 0x00002198
		public global::System.Windows.Controls.AutoCompleteFilterMode FilterMode
		{
			get
			{
				return (global::System.Windows.Controls.AutoCompleteFilterMode)base.GetValue(global::System.Windows.Controls.AutoCompleteBox.FilterModeProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.FilterModeProperty, value);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003FAC File Offset: 0x000021AC
		private static void OnFilterModePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			global::System.Windows.Controls.AutoCompleteFilterMode autoCompleteFilterMode = (global::System.Windows.Controls.AutoCompleteFilterMode)e.NewValue;
			if (autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.Contains && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.ContainsCaseSensitive && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.ContainsOrdinal && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.ContainsOrdinalCaseSensitive && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.Custom && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.Equals && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.EqualsCaseSensitive && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.EqualsOrdinal && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.EqualsOrdinalCaseSensitive && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.None && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.StartsWith && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithCaseSensitive && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithOrdinal && autoCompleteFilterMode != global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithOrdinalCaseSensitive)
			{
				autoCompleteBox.SetValue(e.Property, e.OldValue);
				throw new global::System.ArgumentException(global::System.Windows.Controls.Properties.Resources.AutoComplete_OnFilterModePropertyChanged_InvalidValue, "value");
			}
			global::System.Windows.Controls.AutoCompleteFilterMode filterMode = (global::System.Windows.Controls.AutoCompleteFilterMode)e.NewValue;
			autoCompleteBox.TextFilter = global::System.Windows.Controls.AutoCompleteSearch.GetFilter(filterMode);
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004046 File Offset: 0x00002246
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00004058 File Offset: 0x00002258
		public global::System.Windows.Controls.AutoCompleteFilterPredicate<object> ItemFilter
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.ItemFilterProperty) as global::System.Windows.Controls.AutoCompleteFilterPredicate<object>;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.ItemFilterProperty, value);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004068 File Offset: 0x00002268
		private static void OnItemFilterPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.AutoCompleteBox autoCompleteBox = d as global::System.Windows.Controls.AutoCompleteBox;
			if (!(e.NewValue is global::System.Windows.Controls.AutoCompleteFilterPredicate<object>))
			{
				autoCompleteBox.FilterMode = global::System.Windows.Controls.AutoCompleteFilterMode.None;
				return;
			}
			autoCompleteBox.FilterMode = global::System.Windows.Controls.AutoCompleteFilterMode.Custom;
			autoCompleteBox.TextFilter = null;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000040A3 File Offset: 0x000022A3
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000040B5 File Offset: 0x000022B5
		public global::System.Windows.Controls.AutoCompleteFilterPredicate<string> TextFilter
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.AutoCompleteBox.TextFilterProperty) as global::System.Windows.Controls.AutoCompleteFilterPredicate<string>;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.TextFilterProperty, value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000040C3 File Offset: 0x000022C3
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000040CB File Offset: 0x000022CB
		private global::System.Windows.Controls.PopupHelper DropDownPopup { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000040D4 File Offset: 0x000022D4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000040DC File Offset: 0x000022DC
		internal global::System.Windows.Controls.TextBox TextBox
		{
			get
			{
				return this._text;
			}
			set
			{
				if (this._text != null)
				{
					this._text.SelectionChanged -= this.OnTextBoxSelectionChanged;
					this._text.TextChanged -= this.OnTextBoxTextChanged;
				}
				this._text = value;
				if (this._text != null)
				{
					this._text.SelectionChanged += this.OnTextBoxSelectionChanged;
					this._text.TextChanged += this.OnTextBoxTextChanged;
					if (this.Text != null)
					{
						this.UpdateTextValue(this.Text);
					}
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004170 File Offset: 0x00002370
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00004178 File Offset: 0x00002378
		protected internal global::System.Windows.Controls.ISelectionAdapter SelectionAdapter
		{
			get
			{
				return this._adapter;
			}
			set
			{
				if (this._adapter != null)
				{
					this._adapter.SelectionChanged -= this.OnAdapterSelectionChanged;
					this._adapter.Commit -= this.OnAdapterSelectionComplete;
					this._adapter.Cancel -= this.OnAdapterSelectionCanceled;
					this._adapter.Cancel -= this.OnAdapterSelectionComplete;
					this._adapter.ItemsSource = null;
				}
				this._adapter = value;
				if (this._adapter != null)
				{
					this._adapter.SelectionChanged += this.OnAdapterSelectionChanged;
					this._adapter.Commit += this.OnAdapterSelectionComplete;
					this._adapter.Cancel += this.OnAdapterSelectionCanceled;
					this._adapter.Cancel += this.OnAdapterSelectionComplete;
					this._adapter.ItemsSource = this._view;
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000B8 RID: 184 RVA: 0x00004271 File Offset: 0x00002471
		// (remove) Token: 0x060000B9 RID: 185 RVA: 0x0000427F File Offset: 0x0000247F
		public event global::System.Windows.RoutedEventHandler TextChanged
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.TextChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.TextChangedEvent, value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000BA RID: 186 RVA: 0x0000428D File Offset: 0x0000248D
		// (remove) Token: 0x060000BB RID: 187 RVA: 0x0000429B File Offset: 0x0000249B
		public event global::System.Windows.Controls.PopulatingEventHandler Populating
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.PopulatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.PopulatingEvent, value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000BC RID: 188 RVA: 0x000042A9 File Offset: 0x000024A9
		// (remove) Token: 0x060000BD RID: 189 RVA: 0x000042B7 File Offset: 0x000024B7
		public event global::System.Windows.Controls.PopulatedEventHandler Populated
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.PopulatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.PopulatedEvent, value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000BE RID: 190 RVA: 0x000042C5 File Offset: 0x000024C5
		// (remove) Token: 0x060000BF RID: 191 RVA: 0x000042D3 File Offset: 0x000024D3
		public event global::System.Windows.Controls.RoutedPropertyChangingEventHandler<bool> DropDownOpening
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.PopulatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.PopulatedEvent, value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000C0 RID: 192 RVA: 0x000042E1 File Offset: 0x000024E1
		// (remove) Token: 0x060000C1 RID: 193 RVA: 0x000042EF File Offset: 0x000024EF
		public event global::System.Windows.RoutedPropertyChangedEventHandler<bool> DropDownOpened
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.DropDownOpenedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.DropDownOpenedEvent, value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060000C2 RID: 194 RVA: 0x000042FD File Offset: 0x000024FD
		// (remove) Token: 0x060000C3 RID: 195 RVA: 0x0000430B File Offset: 0x0000250B
		public event global::System.Windows.Controls.RoutedPropertyChangingEventHandler<bool> DropDownClosing
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.DropDownClosingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.DropDownClosingEvent, value);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060000C4 RID: 196 RVA: 0x00004319 File Offset: 0x00002519
		// (remove) Token: 0x060000C5 RID: 197 RVA: 0x00004327 File Offset: 0x00002527
		public event global::System.Windows.RoutedPropertyChangedEventHandler<bool> DropDownClosed
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.DropDownClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.DropDownClosedEvent, value);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060000C6 RID: 198 RVA: 0x00004335 File Offset: 0x00002535
		// (remove) Token: 0x060000C7 RID: 199 RVA: 0x00004343 File Offset: 0x00002543
		public event global::System.Windows.Controls.SelectionChangedEventHandler SelectionChanged
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.AutoCompleteBox.SelectionChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.AutoCompleteBox.SelectionChangedEvent, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004351 File Offset: 0x00002551
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00004368 File Offset: 0x00002568
		public global::System.Windows.Data.Binding ValueMemberBinding
		{
			get
			{
				if (this._valueBindingEvaluator == null)
				{
					return null;
				}
				return this._valueBindingEvaluator.ValueBinding;
			}
			set
			{
				this._valueBindingEvaluator = new global::System.Windows.Controls.BindingEvaluator<string>(value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00004376 File Offset: 0x00002576
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00004392 File Offset: 0x00002592
		public string ValueMemberPath
		{
			get
			{
				if (this.ValueMemberBinding == null)
				{
					return null;
				}
				return this.ValueMemberBinding.Path.Path;
			}
			set
			{
				this.ValueMemberBinding = ((value == null) ? null : new global::System.Windows.Data.Binding(value));
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000043A8 File Offset: 0x000025A8
		static AutoCompleteBox()
		{
			global::System.Windows.Controls.AutoCompleteBox.TextChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("TextChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.PopulatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Populating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.PopulatingEventHandler), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.PopulatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Populated", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.PopulatedEventHandler), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.DropDownOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.RoutedPropertyChangingEventHandler<bool>), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.DropDownOpenedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownOpened", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<bool>), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.DropDownClosingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownClosing", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.RoutedPropertyChangingEventHandler<bool>), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.DropDownClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropDownClosed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<bool>), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.Controls.AutoCompleteBox.SelectionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectionChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.SelectionChangedEventHandler), typeof(global::System.Windows.Controls.AutoCompleteBox));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.AutoCompleteBox)));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004803 File Offset: 0x00002A03
		public AutoCompleteBox()
		{
			base.IsEnabledChanged += this.ControlIsEnabledChanged;
			this.Interaction = new global::System.Windows.Controls.InteractionHelper(this);
			this.ClearView();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004830 File Offset: 0x00002A30
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.Arrange();
			}
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000485C File Offset: 0x00002A5C
		public override void OnApplyTemplate()
		{
			if (this.TextBox != null)
			{
				this.TextBox.PreviewKeyDown -= this.OnTextBoxPreviewKeyDown;
			}
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.Closed -= this.DropDownPopup_Closed;
				this.DropDownPopup.FocusChanged -= this.OnDropDownFocusChanged;
				this.DropDownPopup.UpdateVisualStates -= this.OnDropDownPopupUpdateVisualStates;
				this.DropDownPopup.BeforeOnApplyTemplate();
				this.DropDownPopup = null;
			}
			base.OnApplyTemplate();
			global::System.Windows.Controls.Primitives.Popup popup = base.GetTemplateChild("Popup") as global::System.Windows.Controls.Primitives.Popup;
			if (popup != null)
			{
				this.DropDownPopup = new global::System.Windows.Controls.PopupHelper(this, popup);
				this.DropDownPopup.MaxDropDownHeight = this.MaxDropDownHeight;
				this.DropDownPopup.AfterOnApplyTemplate();
				this.DropDownPopup.Closed += this.DropDownPopup_Closed;
				this.DropDownPopup.FocusChanged += this.OnDropDownFocusChanged;
				this.DropDownPopup.UpdateVisualStates += this.OnDropDownPopupUpdateVisualStates;
			}
			this.SelectionAdapter = this.GetSelectionAdapterPart();
			this.TextBox = (base.GetTemplateChild("Text") as global::System.Windows.Controls.TextBox);
			if (this.TextBox != null)
			{
				this.TextBox.PreviewKeyDown += this.OnTextBoxPreviewKeyDown;
			}
			this.Interaction.OnApplyTemplateBase();
			if (this.IsDropDownOpen && this.DropDownPopup != null && !this.DropDownPopup.IsOpen)
			{
				this.OpeningDropDown(false);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000049DF File Offset: 0x00002BDF
		private void OnDropDownPopupUpdateVisualStates(object sender, global::System.EventArgs e)
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000049E8 File Offset: 0x00002BE8
		private void OnDropDownFocusChanged(object sender, global::System.EventArgs e)
		{
			this.FocusChanged(this.HasFocus());
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000049F8 File Offset: 0x00002BF8
		private void ClosingDropDown(bool oldValue)
		{
			bool flag = false;
			if (this.DropDownPopup != null)
			{
				flag = this.DropDownPopup.UsesClosingVisualState;
			}
			global::System.Windows.Controls.RoutedPropertyChangingEventArgs<bool> routedPropertyChangingEventArgs = new global::System.Windows.Controls.RoutedPropertyChangingEventArgs<bool>(global::System.Windows.Controls.AutoCompleteBox.IsDropDownOpenProperty, oldValue, false, true, global::System.Windows.Controls.AutoCompleteBox.DropDownClosingEvent);
			this.OnDropDownClosing(routedPropertyChangingEventArgs);
			if (this._view == null || this._view.Count == 0)
			{
				flag = false;
			}
			if (routedPropertyChangingEventArgs.Cancel)
			{
				this._ignorePropertyChange = true;
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.IsDropDownOpenProperty, oldValue);
			}
			else
			{
				this.RaiseExpandCollapseAutomationEvent(oldValue, false);
				if (!flag)
				{
					this.CloseDropDown(oldValue, false);
				}
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004A88 File Offset: 0x00002C88
		private void OpeningDropDown(bool oldValue)
		{
			global::System.Windows.Controls.RoutedPropertyChangingEventArgs<bool> routedPropertyChangingEventArgs = new global::System.Windows.Controls.RoutedPropertyChangingEventArgs<bool>(global::System.Windows.Controls.AutoCompleteBox.IsDropDownOpenProperty, oldValue, true, true, global::System.Windows.Controls.AutoCompleteBox.DropDownOpeningEvent);
			this.OnDropDownOpening(routedPropertyChangingEventArgs);
			if (routedPropertyChangingEventArgs.Cancel)
			{
				this._ignorePropertyChange = true;
				base.SetValue(global::System.Windows.Controls.AutoCompleteBox.IsDropDownOpenProperty, oldValue);
			}
			else
			{
				this.RaiseExpandCollapseAutomationEvent(oldValue, true);
				this.OpenDropDown(oldValue, true);
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004AE8 File Offset: 0x00002CE8
		private void RaiseExpandCollapseAutomationEvent(bool oldValue, bool newValue)
		{
			global::System.Windows.Automation.Peers.AutoCompleteBoxAutomationPeer autoCompleteBoxAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::System.Windows.Automation.Peers.AutoCompleteBoxAutomationPeer;
			if (autoCompleteBoxAutomationPeer != null)
			{
				autoCompleteBoxAutomationPeer.RaiseExpandCollapseAutomationEvent(oldValue, newValue);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004B0C File Offset: 0x00002D0C
		private void OnTextBoxPreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			this.OnKeyDown(e);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004B15 File Offset: 0x00002D15
		private void DropDownPopup_Closed(object sender, global::System.EventArgs e)
		{
			if (this.IsDropDownOpen)
			{
				this.IsDropDownOpen = false;
			}
			if (this._popupHasOpened)
			{
				this.OnDropDownClosed(new global::System.Windows.RoutedPropertyChangedEventArgs<bool>(true, false, global::System.Windows.Controls.AutoCompleteBox.DropDownClosedEvent));
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004B40 File Offset: 0x00002D40
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::System.Windows.Automation.Peers.AutoCompleteBoxAutomationPeer(this);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004B48 File Offset: 0x00002D48
		private void FocusChanged(bool hasFocus)
		{
			if (hasFocus)
			{
				if (this.TextBox != null && this.TextBox.SelectionLength == 0)
				{
					this.TextBox.SelectAll();
					return;
				}
			}
			else
			{
				this.IsDropDownOpen = false;
				this._userCalledPopulate = false;
				if (this.TextBox != null)
				{
					this.TextBox.Select(this.TextBox.Text.Length, 0);
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004BAC File Offset: 0x00002DAC
		protected bool HasFocus()
		{
			global::System.Windows.DependencyObject parent;
			for (global::System.Windows.DependencyObject dependencyObject = base.IsKeyboardFocusWithin ? (global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject) : (global::System.Windows.Input.FocusManager.GetFocusedElement(this) as global::System.Windows.DependencyObject); dependencyObject != null; dependencyObject = parent)
			{
				if (object.ReferenceEquals(dependencyObject, this))
				{
					return true;
				}
				parent = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject);
				if (parent == null)
				{
					global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						parent = frameworkElement.Parent;
					}
				}
			}
			return false;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004C07 File Offset: 0x00002E07
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			this.FocusChanged(this.HasFocus());
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004C1C File Offset: 0x00002E1C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.FocusChanged((bool)e.NewValue);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004C37 File Offset: 0x00002E37
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnLostFocus(e);
			this.FocusChanged(this.HasFocus());
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004C4C File Offset: 0x00002E4C
		private void ControlIsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (!(bool)e.NewValue)
			{
				this.IsDropDownOpen = false;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004C70 File Offset: 0x00002E70
		protected virtual global::System.Windows.Controls.ISelectionAdapter GetSelectionAdapterPart()
		{
			global::System.Windows.Controls.ISelectionAdapter selectionAdapter = null;
			global::System.Windows.Controls.Primitives.Selector selector = base.GetTemplateChild("Selector") as global::System.Windows.Controls.Primitives.Selector;
			if (selector != null)
			{
				selectionAdapter = (selector as global::System.Windows.Controls.ISelectionAdapter);
				if (selectionAdapter == null)
				{
					selectionAdapter = new global::System.Windows.Controls.SelectorSelectionAdapter(selector);
				}
			}
			if (selectionAdapter == null)
			{
				selectionAdapter = (base.GetTemplateChild("SelectionAdapter") as global::System.Windows.Controls.ISelectionAdapter);
			}
			return selectionAdapter;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004CBC File Offset: 0x00002EBC
		private void PopulateDropDown(object sender, global::System.EventArgs e)
		{
			if (this._delayTimer != null)
			{
				this._delayTimer.Stop();
			}
			this.SearchText = this.Text;
			global::System.Windows.Controls.PopulatingEventArgs populatingEventArgs = new global::System.Windows.Controls.PopulatingEventArgs(this.SearchText, global::System.Windows.Controls.AutoCompleteBox.PopulatingEvent);
			this.OnPopulating(populatingEventArgs);
			if (!populatingEventArgs.Cancel)
			{
				this.PopulateComplete();
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004D0E File Offset: 0x00002F0E
		protected virtual void OnPopulating(global::System.Windows.Controls.PopulatingEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004D17 File Offset: 0x00002F17
		protected virtual void OnPopulated(global::System.Windows.Controls.PopulatedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00004D20 File Offset: 0x00002F20
		protected virtual void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004D29 File Offset: 0x00002F29
		protected virtual void OnDropDownOpening(global::System.Windows.Controls.RoutedPropertyChangingEventArgs<bool> e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00004D32 File Offset: 0x00002F32
		protected virtual void OnDropDownOpened(global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00004D3B File Offset: 0x00002F3B
		protected virtual void OnDropDownClosing(global::System.Windows.Controls.RoutedPropertyChangingEventArgs<bool> e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004D44 File Offset: 0x00002F44
		protected virtual void OnDropDownClosed(global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00004D50 File Offset: 0x00002F50
		private string FormatValue(object value, bool clearDataContext)
		{
			string result = this.FormatValue(value);
			if (clearDataContext && this._valueBindingEvaluator != null)
			{
				this._valueBindingEvaluator.ClearDataContext();
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00004D7C File Offset: 0x00002F7C
		protected virtual string FormatValue(object value)
		{
			if (this._valueBindingEvaluator != null)
			{
				return this._valueBindingEvaluator.GetDynamicValue(value) ?? string.Empty;
			}
			if (value != null)
			{
				return value.ToString();
			}
			return string.Empty;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004DAB File Offset: 0x00002FAB
		protected virtual void OnTextChanged(global::System.Windows.RoutedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004DB4 File Offset: 0x00002FB4
		private void OnTextBoxTextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			this.TextUpdated(this._text.Text, true);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004DC8 File Offset: 0x00002FC8
		private void OnTextBoxSelectionChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._ignoreTextSelectionChange)
			{
				return;
			}
			this._textSelectionStart = this._text.SelectionStart;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private void UpdateTextValue(string value)
		{
			this.UpdateTextValue(value, null);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004E04 File Offset: 0x00003004
		private void UpdateTextValue(string value, bool? userInitiated)
		{
			if ((userInitiated == null || userInitiated == true) && this.Text != value)
			{
				this._ignoreTextPropertyChange++;
				this.Text = value;
				this.OnTextChanged(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.AutoCompleteBox.TextChangedEvent));
			}
			if ((userInitiated == null || userInitiated == false) && this.TextBox != null && this.TextBox.Text != value)
			{
				this._ignoreTextPropertyChange++;
				this.TextBox.Text = (value ?? string.Empty);
				if (this.Text == value || this.Text == null)
				{
					this.OnTextChanged(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.AutoCompleteBox.TextChangedEvent));
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00004EE8 File Offset: 0x000030E8
		private void TextUpdated(string newText, bool userInitiated)
		{
			if (this._ignoreTextPropertyChange > 0)
			{
				this._ignoreTextPropertyChange--;
				return;
			}
			if (newText == null)
			{
				newText = string.Empty;
			}
			if (this.IsTextCompletionEnabled && this.TextBox != null && this.TextBox.SelectionLength > 0 && this.TextBox.SelectionStart != this.TextBox.Text.Length)
			{
				return;
			}
			bool flag = newText.Length >= this.MinimumPrefixLength && this.MinimumPrefixLength >= 0;
			this._userCalledPopulate = (flag && userInitiated);
			this.UpdateTextValue(newText, new bool?(userInitiated));
			if (!flag)
			{
				this.SearchText = string.Empty;
				if (this.SelectedItem != null)
				{
					this._skipSelectedItemTextUpdate = true;
				}
				this.SelectedItem = null;
				if (this.IsDropDownOpen)
				{
					this.IsDropDownOpen = false;
				}
				return;
			}
			this._ignoreTextSelectionChange = true;
			if (this._delayTimer != null)
			{
				this._delayTimer.Start();
				return;
			}
			this.PopulateDropDown(this, global::System.EventArgs.Empty);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004FE8 File Offset: 0x000031E8
		public void PopulateComplete()
		{
			this.RefreshView();
			global::System.Windows.Controls.PopulatedEventArgs e = new global::System.Windows.Controls.PopulatedEventArgs(new global::System.Collections.ObjectModel.ReadOnlyCollection<object>(this._view), global::System.Windows.Controls.AutoCompleteBox.PopulatedEvent);
			this.OnPopulated(e);
			if (this.SelectionAdapter != null && this.SelectionAdapter.ItemsSource != this._view)
			{
				this.SelectionAdapter.ItemsSource = this._view;
			}
			bool flag = this._userCalledPopulate && this._view.Count > 0;
			if (flag != this.IsDropDownOpen)
			{
				this._ignorePropertyChange = true;
				this.IsDropDownOpen = flag;
			}
			if (this.IsDropDownOpen)
			{
				this.OpeningDropDown(false);
				if (this.DropDownPopup != null)
				{
					this.DropDownPopup.Arrange();
				}
			}
			else
			{
				this.ClosingDropDown(true);
			}
			this.UpdateTextCompletion(this._userCalledPopulate);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000050AC File Offset: 0x000032AC
		private void UpdateTextCompletion(bool userInitiated)
		{
			object obj = null;
			string text = this.Text;
			if (this._view.Count > 0)
			{
				if (this.IsTextCompletionEnabled && this.TextBox != null && userInitiated)
				{
					int length = this.TextBox.Text.Length;
					int selectionStart = this.TextBox.SelectionStart;
					if (selectionStart == text.Length && selectionStart > this._textSelectionStart)
					{
						object obj2 = (this.FilterMode == global::System.Windows.Controls.AutoCompleteFilterMode.StartsWith || this.FilterMode == global::System.Windows.Controls.AutoCompleteFilterMode.StartsWithCaseSensitive) ? this._view[0] : this.TryGetMatch(text, this._view, global::System.Windows.Controls.AutoCompleteSearch.GetFilter(global::System.Windows.Controls.AutoCompleteFilterMode.StartsWith));
						if (obj2 != null)
						{
							obj = obj2;
							string text2 = this.FormatValue(obj2, true);
							int length2 = global::System.Math.Min(text2.Length, this.Text.Length);
							if (global::System.Windows.Controls.AutoCompleteSearch.Equals(this.Text.Substring(0, length2), text2.Substring(0, length2)))
							{
								this.UpdateTextValue(text2);
								this.TextBox.SelectionStart = length;
								this.TextBox.SelectionLength = text2.Length - length;
							}
						}
					}
				}
				else
				{
					obj = this.TryGetMatch(text, this._view, global::System.Windows.Controls.AutoCompleteSearch.GetFilter(global::System.Windows.Controls.AutoCompleteFilterMode.EqualsCaseSensitive));
				}
			}
			if (this.SelectedItem != obj)
			{
				this._skipSelectedItemTextUpdate = true;
			}
			this.SelectedItem = obj;
			if (this._ignoreTextSelectionChange)
			{
				this._ignoreTextSelectionChange = false;
				if (this.TextBox != null)
				{
					this._textSelectionStart = this.TextBox.SelectionStart;
				}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005224 File Offset: 0x00003424
		private object TryGetMatch(string searchText, global::System.Collections.ObjectModel.ObservableCollection<object> view, global::System.Windows.Controls.AutoCompleteFilterPredicate<string> predicate)
		{
			if (view != null && view.Count > 0)
			{
				foreach (object obj in view)
				{
					if (predicate(searchText, this.FormatValue(obj)))
					{
						return obj;
					}
				}
			}
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00005288 File Offset: 0x00003488
		private void ClearView()
		{
			if (this._view == null)
			{
				this._view = new global::System.Collections.ObjectModel.ObservableCollection<object>();
				return;
			}
			this._view.Clear();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000052AC File Offset: 0x000034AC
		private void RefreshView()
		{
			if (this._items == null)
			{
				this.ClearView();
				return;
			}
			string search = this.Text ?? string.Empty;
			bool flag = this.TextFilter != null;
			bool flag2 = this.FilterMode == global::System.Windows.Controls.AutoCompleteFilterMode.Custom && this.TextFilter == null;
			int num = 0;
			int num2 = this._view.Count;
			global::System.Collections.Generic.List<object> items = this._items;
			foreach (object obj in items)
			{
				bool flag3 = !flag && !flag2;
				if (!flag3)
				{
					flag3 = (flag ? this.TextFilter(search, this.FormatValue(obj)) : this.ItemFilter(search, obj));
				}
				if (num2 > num && flag3 && this._view[num] == obj)
				{
					num++;
				}
				else if (flag3)
				{
					if (num2 > num && this._view[num] != obj)
					{
						this._view.RemoveAt(num);
						this._view.Insert(num, obj);
						num++;
					}
					else
					{
						if (num == num2)
						{
							this._view.Add(obj);
						}
						else
						{
							this._view.Insert(num, obj);
						}
						num++;
						num2++;
					}
				}
				else if (num2 > num && this._view[num] == obj)
				{
					this._view.RemoveAt(num);
					num2--;
				}
			}
			if (this._valueBindingEvaluator != null)
			{
				this._valueBindingEvaluator.ClearDataContext();
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000548C File Offset: 0x0000368C
		private void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = oldValue as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null && this._collectionChangedWeakEventListener != null)
			{
				this._collectionChangedWeakEventListener.Detach();
				this._collectionChangedWeakEventListener = null;
			}
			global::System.Collections.Specialized.INotifyCollectionChanged newValueINotifyCollectionChanged = newValue as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (newValueINotifyCollectionChanged != null)
			{
				this._collectionChangedWeakEventListener = new global::System.Windows.Controls.WeakEventListener<global::System.Windows.Controls.AutoCompleteBox, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs>(this);
				this._collectionChangedWeakEventListener.OnEventAction = delegate(global::System.Windows.Controls.AutoCompleteBox instance, object source, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
				{
					instance.ItemsSourceCollectionChanged(source, eventArgs);
				};
				this._collectionChangedWeakEventListener.OnDetachAction = delegate(global::System.Windows.Controls.WeakEventListener<global::System.Windows.Controls.AutoCompleteBox, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> weakEventListener)
				{
					newValueINotifyCollectionChanged.CollectionChanged -= weakEventListener.OnEvent;
				};
				newValueINotifyCollectionChanged.CollectionChanged += this._collectionChangedWeakEventListener.OnEvent;
			}
			this._items = ((newValue == null) ? null : new global::System.Collections.Generic.List<object>(newValue.Cast<object>().ToList<object>()));
			this.ClearView();
			if (this.SelectionAdapter != null && this.SelectionAdapter.ItemsSource != this._view)
			{
				this.SelectionAdapter.ItemsSource = this._view;
			}
			if (this.IsDropDownOpen)
			{
				this.RefreshView();
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000055A4 File Offset: 0x000037A4
		private void ItemsSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove && e.OldItems != null)
			{
				for (int i = 0; i < e.OldItems.Count; i++)
				{
					this._items.RemoveAt(e.OldStartingIndex);
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add && e.NewItems != null && this._items.Count >= e.NewStartingIndex)
			{
				for (int j = 0; j < e.NewItems.Count; j++)
				{
					this._items.Insert(e.NewStartingIndex + j, e.NewItems[j]);
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace && e.NewItems != null && e.OldItems != null)
			{
				for (int k = 0; k < e.NewItems.Count; k++)
				{
					this._items[e.NewStartingIndex] = e.NewItems[k];
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
			{
				for (int l = 0; l < e.OldItems.Count; l++)
				{
					this._view.Remove(e.OldItems[l]);
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this.ClearView();
				if (this.ItemsSource != null)
				{
					this._items = new global::System.Collections.Generic.List<object>(this.ItemsSource.Cast<object>().ToList<object>());
				}
			}
			this.RefreshView();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005705 File Offset: 0x00003905
		private void OnAdapterSelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			this.SelectedItem = this._adapter.SelectedItem;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005718 File Offset: 0x00003918
		private void OnAdapterSelectionComplete(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.IsDropDownOpen = false;
			this.UpdateTextCompletion(false);
			if (this.TextBox != null)
			{
				this.TextBox.Select(this.TextBox.Text.Length, 0);
			}
			if (this.TextBox != null)
			{
				global::System.Windows.Input.Keyboard.Focus(this.TextBox);
				return;
			}
			base.Focus();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00005773 File Offset: 0x00003973
		private void OnAdapterSelectionCanceled(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.UpdateTextValue(this.SearchText);
			this.UpdateTextCompletion(false);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00005788 File Offset: 0x00003988
		private void OnMaxDropDownHeightChanged(double newValue)
		{
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.MaxDropDownHeight = newValue;
				this.DropDownPopup.Arrange();
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000057B0 File Offset: 0x000039B0
		private void OpenDropDown(bool oldValue, bool newValue)
		{
			if (this.DropDownPopup != null)
			{
				this.DropDownPopup.IsOpen = true;
			}
			this._popupHasOpened = true;
			this.OnDropDownOpened(new global::System.Windows.RoutedPropertyChangedEventArgs<bool>(oldValue, newValue, global::System.Windows.Controls.AutoCompleteBox.DropDownOpenedEvent));
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000057E0 File Offset: 0x000039E0
		private void CloseDropDown(bool oldValue, bool newValue)
		{
			if (this._popupHasOpened)
			{
				if (this.SelectionAdapter != null)
				{
					this.SelectionAdapter.SelectedItem = null;
				}
				if (this.DropDownPopup != null)
				{
					this.DropDownPopup.IsOpen = false;
				}
				this.OnDropDownClosed(new global::System.Windows.RoutedPropertyChangedEventArgs<bool>(oldValue, newValue, global::System.Windows.Controls.AutoCompleteBox.DropDownClosedEvent));
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005830 File Offset: 0x00003A30
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			base.OnKeyDown(e);
			if (e.Handled || !base.IsEnabled)
			{
				return;
			}
			if (this.IsDropDownOpen)
			{
				if (this.SelectionAdapter != null)
				{
					this.SelectionAdapter.HandleKeyDown(e);
					if (e.Handled)
					{
						return;
					}
				}
				if (e.Key == global::System.Windows.Input.Key.Escape)
				{
					this.OnAdapterSelectionCanceled(this, new global::System.Windows.RoutedEventArgs());
					e.Handled = true;
				}
			}
			else if (e.Key == global::System.Windows.Input.Key.Down)
			{
				this.IsDropDownOpen = true;
				e.Handled = true;
			}
			global::System.Windows.Input.Key key = e.Key;
			if (key == global::System.Windows.Input.Key.Return)
			{
				this.OnAdapterSelectionComplete(this, new global::System.Windows.RoutedEventArgs());
				e.Handled = true;
				return;
			}
			if (key != global::System.Windows.Input.Key.F4)
			{
				return;
			}
			this.IsDropDownOpen = !this.IsDropDownOpen;
			e.Handled = true;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000058FA File Offset: 0x00003AFA
		void global::System.Windows.Controls.IUpdateVisualState.UpdateVisualState(bool useTransitions)
		{
			this.UpdateVisualState(useTransitions);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00005903 File Offset: 0x00003B03
		internal virtual void UpdateVisualState(bool useTransitions)
		{
			global::System.Windows.VisualStateManager.GoToState(this, this.IsDropDownOpen ? "PopupOpened" : "PopupClosed", useTransitions);
			this.Interaction.UpdateVisualStateBase(useTransitions);
		}

		// Token: 0x0400001E RID: 30
		private const string ElementSelectionAdapter = "SelectionAdapter";

		// Token: 0x0400001F RID: 31
		private const string ElementSelector = "Selector";

		// Token: 0x04000020 RID: 32
		private const string ElementPopup = "Popup";

		// Token: 0x04000021 RID: 33
		private const string ElementTextBox = "Text";

		// Token: 0x04000022 RID: 34
		private const string ElementTextBoxStyle = "TextBoxStyle";

		// Token: 0x04000023 RID: 35
		private const string ElementItemContainerStyle = "ItemContainerStyle";

		// Token: 0x04000024 RID: 36
		private global::System.Collections.Generic.List<object> _items;

		// Token: 0x04000025 RID: 37
		private global::System.Collections.ObjectModel.ObservableCollection<object> _view;

		// Token: 0x04000026 RID: 38
		private int _ignoreTextPropertyChange;

		// Token: 0x04000027 RID: 39
		private bool _ignorePropertyChange;

		// Token: 0x04000028 RID: 40
		private bool _ignoreTextSelectionChange;

		// Token: 0x04000029 RID: 41
		private bool _skipSelectedItemTextUpdate;

		// Token: 0x0400002A RID: 42
		private int _textSelectionStart;

		// Token: 0x0400002B RID: 43
		private bool _userCalledPopulate;

		// Token: 0x0400002C RID: 44
		private bool _popupHasOpened;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Threading.DispatcherTimer _delayTimer;

		// Token: 0x0400002E RID: 46
		private bool _allowWrite;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Controls.BindingEvaluator<string> _valueBindingEvaluator;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Controls.WeakEventListener<global::System.Windows.Controls.AutoCompleteBox, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> _collectionChangedWeakEventListener;

		// Token: 0x04000031 RID: 49
		public static readonly global::System.Windows.DependencyProperty MinimumPrefixLengthProperty = global::System.Windows.DependencyProperty.Register("MinimumPrefixLength", typeof(int), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnMinimumPrefixLengthPropertyChanged)));

		// Token: 0x04000032 RID: 50
		public static readonly global::System.Windows.DependencyProperty MinimumPopulateDelayProperty = global::System.Windows.DependencyProperty.Register("MinimumPopulateDelay", typeof(int), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnMinimumPopulateDelayPropertyChanged)));

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty IsTextCompletionEnabledProperty = global::System.Windows.DependencyProperty.Register("IsTextCompletionEnabled", typeof(bool), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(false, null));

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty ItemContainerStyleProperty = global::System.Windows.DependencyProperty.Register("ItemContainerStyle", typeof(global::System.Windows.Style), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(null, null));

		// Token: 0x04000036 RID: 54
		public static readonly global::System.Windows.DependencyProperty TextBoxStyleProperty = global::System.Windows.DependencyProperty.Register("TextBoxStyle", typeof(global::System.Windows.Style), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(null));

		// Token: 0x04000037 RID: 55
		public static readonly global::System.Windows.DependencyProperty MaxDropDownHeightProperty = global::System.Windows.DependencyProperty.Register("MaxDropDownHeight", typeof(double), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnMaxDropDownHeightPropertyChanged)));

		// Token: 0x04000038 RID: 56
		public static readonly global::System.Windows.DependencyProperty IsDropDownOpenProperty = global::System.Windows.DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnIsDropDownOpenPropertyChanged)));

		// Token: 0x04000039 RID: 57
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnItemsSourcePropertyChanged)));

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty = global::System.Windows.DependencyProperty.Register("SelectedItem", typeof(object), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnSelectedItemPropertyChanged)));

		// Token: 0x0400003B RID: 59
		public static readonly global::System.Windows.DependencyProperty TextProperty = global::System.Windows.DependencyProperty.Register("Text", typeof(string), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnTextPropertyChanged)));

		// Token: 0x0400003C RID: 60
		public static readonly global::System.Windows.DependencyProperty SearchTextProperty = global::System.Windows.DependencyProperty.Register("SearchText", typeof(string), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnSearchTextPropertyChanged)));

		// Token: 0x0400003D RID: 61
		public static readonly global::System.Windows.DependencyProperty FilterModeProperty = global::System.Windows.DependencyProperty.Register("FilterMode", typeof(global::System.Windows.Controls.AutoCompleteFilterMode), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.AutoCompleteFilterMode.StartsWith, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnFilterModePropertyChanged)));

		// Token: 0x0400003E RID: 62
		public static readonly global::System.Windows.DependencyProperty ItemFilterProperty = global::System.Windows.DependencyProperty.Register("ItemFilter", typeof(global::System.Windows.Controls.AutoCompleteFilterPredicate<object>), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.AutoCompleteBox.OnItemFilterPropertyChanged)));

		// Token: 0x0400003F RID: 63
		public static readonly global::System.Windows.DependencyProperty TextFilterProperty = global::System.Windows.DependencyProperty.Register("TextFilter", typeof(global::System.Windows.Controls.AutoCompleteFilterPredicate<string>), typeof(global::System.Windows.Controls.AutoCompleteBox), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.AutoCompleteSearch.GetFilter(global::System.Windows.Controls.AutoCompleteFilterMode.StartsWith)));

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Controls.TextBox _text;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Controls.ISelectionAdapter _adapter;
	}
}
