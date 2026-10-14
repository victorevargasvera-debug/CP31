using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200000C RID: 12
	public class DataGridComboBoxColumn : global::Microsoft.Windows.Controls.DataGridColumn
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00004BE4 File Offset: 0x00002DE4
		static DataGridComboBoxColumn()
		{
			global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.OnCoerceSortMemberPath)));
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004CE8 File Offset: 0x00002EE8
		private static object OnCoerceSortMemberPath(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridComboBoxColumn dataGridComboBoxColumn = (global::Microsoft.Windows.Controls.DataGridComboBoxColumn)d;
			string text = (string)baseValue;
			if (string.IsNullOrEmpty(text))
			{
				text = global::Microsoft.Windows.Controls.DataGridHelper.GetPathFromBinding(dataGridComboBoxColumn.EffectiveBinding as global::System.Windows.Data.Binding);
			}
			return text;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004D1D File Offset: 0x00002F1D
		private global::System.Windows.Data.BindingBase EffectiveBinding
		{
			get
			{
				if (this.SelectedItemBinding != null)
				{
					return this.SelectedItemBinding;
				}
				if (this.SelectedValueBinding != null)
				{
					return this.SelectedValueBinding;
				}
				return this.TextBinding;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00004D43 File Offset: 0x00002F43
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00004D70 File Offset: 0x00002F70
		public virtual global::System.Windows.Data.BindingBase SelectedValueBinding
		{
			get
			{
				if (!this._selectedValueBindingEnsured)
				{
					if (!base.IsReadOnly)
					{
						global::Microsoft.Windows.Controls.DataGridHelper.EnsureTwoWayIfNotOneWay(this._selectedValueBinding);
					}
					this._selectedValueBindingEnsured = true;
				}
				return this._selectedValueBinding;
			}
			set
			{
				if (this._selectedValueBinding != value)
				{
					global::System.Windows.Data.BindingBase selectedValueBinding = this._selectedValueBinding;
					this._selectedValueBinding = value;
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty);
					this._selectedValueBindingEnsured = false;
					this.OnSelectedValueBindingChanged(selectedValueBinding, this._selectedValueBinding);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004DBE File Offset: 0x00002FBE
		protected override bool OnCoerceIsReadOnly(bool baseValue)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.IsOneWay(this.EffectiveBinding) || base.OnCoerceIsReadOnly(baseValue);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004DD6 File Offset: 0x00002FD6
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00004E00 File Offset: 0x00003000
		public virtual global::System.Windows.Data.BindingBase SelectedItemBinding
		{
			get
			{
				if (!this._selectedItemBindingEnsured)
				{
					if (!base.IsReadOnly)
					{
						global::Microsoft.Windows.Controls.DataGridHelper.EnsureTwoWayIfNotOneWay(this._selectedItemBinding);
					}
					this._selectedItemBindingEnsured = true;
				}
				return this._selectedItemBinding;
			}
			set
			{
				if (this._selectedItemBinding != value)
				{
					global::System.Windows.Data.BindingBase selectedItemBinding = this._selectedItemBinding;
					this._selectedItemBinding = value;
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty);
					this._selectedItemBindingEnsured = false;
					this.OnSelectedItemBindingChanged(selectedItemBinding, this._selectedItemBinding);
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00004E4E File Offset: 0x0000304E
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00004E78 File Offset: 0x00003078
		public virtual global::System.Windows.Data.BindingBase TextBinding
		{
			get
			{
				if (!this._textBindingEnsured)
				{
					if (!base.IsReadOnly)
					{
						global::Microsoft.Windows.Controls.DataGridHelper.EnsureTwoWayIfNotOneWay(this._textBinding);
					}
					this._textBindingEnsured = true;
				}
				return this._textBinding;
			}
			set
			{
				if (this._textBinding != value)
				{
					global::System.Windows.Data.BindingBase textBinding = this._textBinding;
					this._textBinding = value;
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty);
					this._textBindingEnsured = false;
					this.OnTextBindingChanged(textBinding, this._textBinding);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004EC6 File Offset: 0x000030C6
		protected virtual void OnSelectedValueBindingChanged(global::System.Windows.Data.BindingBase oldBinding, global::System.Windows.Data.BindingBase newBinding)
		{
			base.NotifyPropertyChanged("SelectedValueBinding");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004ED3 File Offset: 0x000030D3
		protected virtual void OnSelectedItemBindingChanged(global::System.Windows.Data.BindingBase oldBinding, global::System.Windows.Data.BindingBase newBinding)
		{
			base.NotifyPropertyChanged("SelectedItemBinding");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004EE0 File Offset: 0x000030E0
		protected virtual void OnTextBindingChanged(global::System.Windows.Data.BindingBase oldBinding, global::System.Windows.Data.BindingBase newBinding)
		{
			base.NotifyPropertyChanged("TextBinding");
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004EF0 File Offset: 0x000030F0
		public static global::System.Windows.Style DefaultElementStyle
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGridComboBoxColumn._defaultElementStyle == null)
				{
					global::System.Windows.Style style = new global::System.Windows.Style(typeof(global::System.Windows.Controls.ComboBox));
					style.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty, false));
					style.Seal();
					global::Microsoft.Windows.Controls.DataGridComboBoxColumn._defaultElementStyle = style;
				}
				return global::Microsoft.Windows.Controls.DataGridComboBoxColumn._defaultElementStyle;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004F40 File Offset: 0x00003140
		public static global::System.Windows.Style DefaultEditingElementStyle
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DefaultElementStyle;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004F47 File Offset: 0x00003147
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00004F59 File Offset: 0x00003159
		public global::System.Windows.Style ElementStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ElementStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ElementStyleProperty, value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004F67 File Offset: 0x00003167
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00004F79 File Offset: 0x00003179
		public global::System.Windows.Style EditingElementStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.EditingElementStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.EditingElementStyleProperty, value);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00004F88 File Offset: 0x00003188
		private void ApplyStyle(bool isEditing, bool defaultToElementStyle, global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.Style style = this.PickStyle(isEditing, defaultToElementStyle);
			if (style != null)
			{
				element.Style = style;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004FA8 File Offset: 0x000031A8
		internal void ApplyStyle(bool isEditing, bool defaultToElementStyle, global::System.Windows.FrameworkContentElement element)
		{
			global::System.Windows.Style style = this.PickStyle(isEditing, defaultToElementStyle);
			if (style != null)
			{
				element.Style = style;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004FC8 File Offset: 0x000031C8
		private global::System.Windows.Style PickStyle(bool isEditing, bool defaultToElementStyle)
		{
			global::System.Windows.Style style = isEditing ? this.EditingElementStyle : this.ElementStyle;
			if (isEditing && defaultToElementStyle && style == null)
			{
				style = this.ElementStyle;
			}
			return style;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004FF8 File Offset: 0x000031F8
		private static void ApplyBinding(global::System.Windows.Data.BindingBase binding, global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty property)
		{
			if (binding != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(target, property, binding);
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(target, property);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000500E File Offset: 0x0000320E
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00005020 File Offset: 0x00003220
		public override global::System.Windows.Data.BindingBase ClipboardContentBinding
		{
			get
			{
				return base.ClipboardContentBinding ?? this.EffectiveBinding;
			}
			set
			{
				base.ClipboardContentBinding = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00005029 File Offset: 0x00003229
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000503B File Offset: 0x0000323B
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ItemsSourceProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ItemsSourceProperty, value);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00005049 File Offset: 0x00003249
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000505B File Offset: 0x0000325B
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00005069 File Offset: 0x00003269
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000507B File Offset: 0x0000327B
		public string SelectedValuePath
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.SelectedValuePathProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.SelectedValuePathProperty, value);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000508C File Offset: 0x0000328C
		protected internal override void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = element as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell == null)
			{
				base.RefreshCellContent(element, propertyName);
				return;
			}
			bool isEditing = dataGridCell.IsEditing;
			if ((string.Compare(propertyName, "ElementStyle", global::System.StringComparison.Ordinal) == 0 && !isEditing) || (string.Compare(propertyName, "EditingElementStyle", global::System.StringComparison.Ordinal) == 0 && isEditing))
			{
				dataGridCell.BuildVisualTree();
				return;
			}
			global::System.Windows.Controls.ComboBox comboBox = dataGridCell.Content as global::System.Windows.Controls.ComboBox;
			switch (propertyName)
			{
			case "SelectedItemBinding":
				global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(this.SelectedItemBinding, comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
				return;
			case "SelectedValueBinding":
				global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(this.SelectedValueBinding, comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
				return;
			case "TextBinding":
				global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(this.TextBinding, comboBox, global::System.Windows.Controls.ComboBox.TextProperty);
				return;
			case "SelectedValuePath":
				global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty, global::Microsoft.Windows.Controls.DataGridComboBoxColumn.SelectedValuePathProperty);
				return;
			case "DisplayMemberPath":
				global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, comboBox, global::System.Windows.Controls.ItemsControl.DisplayMemberPathProperty, global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DisplayMemberPathProperty);
				return;
			case "ItemsSource":
				global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, comboBox, global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ItemsSourceProperty);
				return;
			}
			base.RefreshCellContent(element, propertyName);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000051FA File Offset: 0x000033FA
		private object GetComboBoxSelectionValue(global::System.Windows.Controls.ComboBox comboBox)
		{
			if (this.SelectedItemBinding != null)
			{
				return comboBox.SelectedItem;
			}
			if (this.SelectedValueBinding != null)
			{
				return comboBox.SelectedValue;
			}
			return comboBox.Text;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005220 File Offset: 0x00003420
		protected override global::System.Windows.FrameworkElement GenerateElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox textBlockComboBox = new global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox();
			this.ApplyStyle(false, false, textBlockComboBox);
			this.ApplyColumnProperties(textBlockComboBox);
			return textBlockComboBox;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005244 File Offset: 0x00003444
		protected override global::System.Windows.FrameworkElement GenerateEditingElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			global::System.Windows.Controls.ComboBox comboBox = new global::System.Windows.Controls.ComboBox();
			this.ApplyStyle(true, false, comboBox);
			this.ApplyColumnProperties(comboBox);
			return comboBox;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005268 File Offset: 0x00003468
		private void ApplyColumnProperties(global::System.Windows.Controls.ComboBox comboBox)
		{
			global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(this.SelectedItemBinding, comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
			global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(this.SelectedValueBinding, comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
			global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(this.TextBinding, comboBox, global::System.Windows.Controls.ComboBox.TextProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty, global::Microsoft.Windows.Controls.DataGridComboBoxColumn.SelectedValuePathProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, comboBox, global::System.Windows.Controls.ItemsControl.DisplayMemberPathProperty, global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DisplayMemberPathProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.SyncColumnProperty(this, comboBox, global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ItemsSourceProperty);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000052DC File Offset: 0x000034DC
		protected override object PrepareCellForEdit(global::System.Windows.FrameworkElement editingElement, global::System.Windows.RoutedEventArgs editingEventArgs)
		{
			global::System.Windows.Controls.ComboBox comboBox = editingElement as global::System.Windows.Controls.ComboBox;
			if (comboBox != null)
			{
				comboBox.Focus();
				object comboBoxSelectionValue = this.GetComboBoxSelectionValue(comboBox);
				if (global::Microsoft.Windows.Controls.DataGridComboBoxColumn.IsComboBoxOpeningInputEvent(editingEventArgs))
				{
					comboBox.IsDropDownOpen = true;
				}
				return comboBoxSelectionValue;
			}
			return null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005314 File Offset: 0x00003514
		protected override bool CommitCellEdit(global::System.Windows.FrameworkElement editingElement)
		{
			global::System.Windows.Controls.ComboBox comboBox = editingElement as global::System.Windows.Controls.ComboBox;
			if (comboBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateSource(comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateSource(comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateSource(comboBox, global::System.Windows.Controls.ComboBox.TextProperty);
				return !global::System.Windows.Controls.Validation.GetHasError(comboBox);
			}
			return true;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00005358 File Offset: 0x00003558
		protected override void CancelCellEdit(global::System.Windows.FrameworkElement editingElement, object uneditedValue)
		{
			global::System.Windows.Controls.ComboBox comboBox = editingElement as global::System.Windows.Controls.ComboBox;
			if (comboBox != null)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateTarget(comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateTarget(comboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
				global::Microsoft.Windows.Controls.DataGridHelper.UpdateTarget(comboBox, global::System.Windows.Controls.ComboBox.TextProperty);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005390 File Offset: 0x00003590
		internal override void OnInput(global::System.Windows.Input.InputEventArgs e)
		{
			if (global::Microsoft.Windows.Controls.DataGridComboBoxColumn.IsComboBoxOpeningInputEvent(e))
			{
				base.BeginEdit(e);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000053A4 File Offset: 0x000035A4
		private static bool IsComboBoxOpeningInputEvent(global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Input.KeyEventArgs keyEventArgs = e as global::System.Windows.Input.KeyEventArgs;
			if (keyEventArgs != null && (byte)(keyEventArgs.KeyStates & global::System.Windows.Input.KeyStates.Down) == 1)
			{
				bool flag = (keyEventArgs.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Alt) == global::System.Windows.Input.ModifierKeys.Alt;
				global::System.Windows.Input.Key key = keyEventArgs.Key;
				if (key == global::System.Windows.Input.Key.System)
				{
					key = keyEventArgs.SystemKey;
				}
				return (key == global::System.Windows.Input.Key.F4 && !flag) || ((key == global::System.Windows.Input.Key.Up || key == global::System.Windows.Input.Key.Down) && flag);
			}
			return false;
		}

		// Token: 0x04000030 RID: 48
		public static readonly global::System.Windows.DependencyProperty ElementStyleProperty = global::Microsoft.Windows.Controls.DataGridBoundColumn.ElementStyleProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DefaultElementStyle));

		// Token: 0x04000031 RID: 49
		public static readonly global::System.Windows.DependencyProperty EditingElementStyleProperty = global::Microsoft.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.DefaultEditingElementStyle));

		// Token: 0x04000032 RID: 50
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.Controls.ItemsControl.ItemsSourceProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty = global::System.Windows.Controls.ItemsControl.DisplayMemberPathProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x04000034 RID: 52
		public static readonly global::System.Windows.DependencyProperty SelectedValuePathProperty = global::System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x04000035 RID: 53
		private static global::System.Windows.Style _defaultElementStyle;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Data.BindingBase _selectedValueBinding;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Data.BindingBase _selectedItemBinding;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Data.BindingBase _textBinding;

		// Token: 0x04000039 RID: 57
		private bool _selectedValueBindingEnsured = true;

		// Token: 0x0400003A RID: 58
		private bool _selectedItemBindingEnsured = true;

		// Token: 0x0400003B RID: 59
		private bool _textBindingEnsured = true;

		// Token: 0x0200000D RID: 13
		internal class TextBlockComboBox : global::System.Windows.Controls.ComboBox
		{
			// Token: 0x06000124 RID: 292 RVA: 0x00005424 File Offset: 0x00003624
			static TextBlockComboBox()
			{
				global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox)));
				global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox), new global::System.Windows.FrameworkPropertyMetadata(false));
				global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox.OnDataContextPropertyChanged)));
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00005498 File Offset: 0x00003698
			private static void OnDataContextPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox textBlockComboBox = (global::Microsoft.Windows.Controls.DataGridComboBoxColumn.TextBlockComboBox)d;
				bool flag = global::System.Windows.DependencyPropertyHelper.GetValueSource(textBlockComboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty).BaseValueSource == global::System.Windows.BaseValueSource.Local;
				if (flag)
				{
					global::System.Windows.Data.BindingBase bindingBase = global::System.Windows.Data.BindingOperations.GetBindingBase(textBlockComboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
					if (bindingBase != null)
					{
						textBlockComboBox.ClearValue(global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
						global::Microsoft.Windows.Controls.DataGridComboBoxColumn.ApplyBinding(bindingBase, textBlockComboBox, global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
						return;
					}
				}
				else
				{
					textBlockComboBox.SelectedItem = null;
					textBlockComboBox.ClearValue(global::System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
				}
			}
		}
	}
}
