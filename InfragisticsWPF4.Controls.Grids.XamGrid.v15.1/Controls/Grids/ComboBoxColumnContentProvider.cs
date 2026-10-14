using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000245 RID: 581
	public class ComboBoxColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x00043FF8 File Offset: 0x000421F8
		public ComboBoxColumnContentProvider()
		{
			this._comboEditor = new global::System.Windows.Controls.ComboBox();
			this._comboDisplay = new global::System.Windows.Controls.ComboBox();
			this._displayElement = new global::System.Windows.Controls.TextBlock
			{
				VerticalAlignment = global::System.Windows.VerticalAlignment.Center
			};
			this._comboValueHolder = new global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder();
			this._cellObj = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
			this._isSelectedValueBoundToComboDisplay = false;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00044054 File Offset: 0x00042254
		private void SetupComboBox(global::System.Windows.Controls.ComboBox comboBox, global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)cell.Column;
			if (comboBox.ItemTemplate != comboBoxColumn.ItemTemplate)
			{
				if (comboBoxColumn.ItemTemplate == null)
				{
					comboBox.ClearValue(global::System.Windows.Controls.ItemsControl.ItemTemplateProperty);
				}
				else
				{
					comboBox.ItemTemplate = comboBoxColumn.ItemTemplate;
				}
			}
			if (comboBox.SelectedValuePath != comboBoxColumn.SelectedValuePath)
			{
				if (comboBoxColumn.SelectedValuePath == null)
				{
					comboBox.ClearValue(global::System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty);
				}
				else
				{
					comboBox.SelectedValuePath = comboBoxColumn.SelectedValuePath;
				}
			}
			if (comboBox.DisplayMemberPath != comboBoxColumn.DisplayMemberPath)
			{
				if (comboBoxColumn.DisplayMemberPath == null)
				{
					comboBox.ClearValue(global::System.Windows.Controls.ItemsControl.DisplayMemberPathProperty);
				}
				else
				{
					comboBox.DisplayMemberPath = comboBoxColumn.DisplayMemberPath;
				}
			}
			if (comboBox.ItemsSource != comboBoxColumn.ItemsSource)
			{
				comboBox.ItemsSource = comboBoxColumn.ItemsSource;
			}
			global::System.Windows.Style editorStyleResolved = cell.EditorStyleResolved;
			if (editorStyleResolved != comboBox.Style)
			{
				if (editorStyleResolved == null)
				{
					comboBox.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
					return;
				}
				comboBox.Style = editorStyleResolved;
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00044144 File Offset: 0x00042344
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)cell.Column;
			this._useItemTemplate = (cell.EnableCustomEditorBehaviors && comboBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode && comboBoxColumn.DisplayMemberPath == null && comboBoxColumn.ItemTemplate != null);
			if (!cell.EnableCustomEditorBehaviors || comboBoxColumn.EditorDisplayBehavior != global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode)
			{
				this._comboDisplay.IsEnabled = cell.IsEditable;
				this.SetupComboBox(this._comboDisplay, cell, cellBinding);
				bool flag = false;
				if (cell.EnableCustomEditorBehaviors)
				{
					flag = (comboBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.Always);
				}
				this._comboDisplay.IsHitTestVisible = flag;
				this._comboDisplay.Focusable = flag;
				this._cellBinding = cellBinding;
				this.ApplyBindingToDisplayElement(cell, cellBinding);
				return this._comboDisplay;
			}
			if (this._useItemTemplate)
			{
				if (this._templatedDisplayElement == null)
				{
					this._templatedDisplayElement = (comboBoxColumn.ItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
				}
				if (!base.IsToolTip)
				{
					if (cell.Control != null && cell.Control.Content != this._templatedDisplayElement)
					{
						cell.Control.Content = this._templatedDisplayElement;
					}
					if (cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.AddNewRow && cellBinding == null && cell.GetType() == typeof(global::Infragistics.Controls.Grids.Cell))
					{
						cell.RaiseCellControlAttachedEvent();
					}
				}
			}
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			if (this._useItemTemplate)
			{
				return this._templatedDisplayElement;
			}
			return this._displayElement;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x000442AC File Offset: 0x000424AC
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding binding)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)cell.Column;
			if (this._comboDisplay.DisplayMemberPath != comboBoxColumn.DisplayMemberPath)
			{
				if (comboBoxColumn.DisplayMemberPath == null)
				{
					this._comboDisplay.ClearValue(global::System.Windows.Controls.ItemsControl.DisplayMemberPathProperty);
				}
				else
				{
					this._comboDisplay.DisplayMemberPath = comboBoxColumn.DisplayMemberPath;
				}
			}
			if (binding != null)
			{
				if (comboBoxColumn.EditorDisplayBehavior == global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode && cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					if (this._useItemTemplate)
					{
						if (base.IsToolTip && cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.AddNewRow && cell.Row.RowType != global::Infragistics.Controls.Grids.RowType.FilterRow)
						{
							this._cellObj.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
						}
					}
					else
					{
						global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ComboBoxColumnValueConverter converter = new global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ComboBoxColumnValueConverter(comboBoxColumn, binding.Converter);
						binding.Converter = converter;
						this._displayElement.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, binding);
						global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding();
						if (!string.IsNullOrEmpty(comboBoxColumn.DisplayMemberPath))
						{
							binding2.Path = new global::System.Windows.PropertyPath(comboBoxColumn.DisplayMemberPath, new object[0]);
						}
						else if (this._comboValueHolder.Value == null)
						{
							binding2.Path = binding.Path;
							this._displayElement.SetBinding(global::System.Windows.FrameworkElement.DataContextProperty, new global::System.Windows.Data.Binding
							{
								Path = new global::System.Windows.PropertyPath("DataContext", new object[0]),
								Source = cell.Control
							});
						}
						this._displayElement.SetBinding(global::System.Windows.Controls.TextBlock.TextProperty, binding2);
					}
				}
				else
				{
					this._comboDisplay.SetBinding(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty, binding);
				}
				global::System.Windows.Data.Binding binding3 = new global::System.Windows.Data.Binding();
				if (!string.IsNullOrEmpty(comboBoxColumn.SelectedValuePath))
				{
					binding3.Path = new global::System.Windows.PropertyPath(comboBoxColumn.SelectedValuePath, new object[0]);
				}
				binding3.Mode = global::System.Windows.Data.BindingMode.OneWay;
				this._comboValueHolder.SetBinding(global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder.ValueProperty, binding3);
				return;
			}
			this._comboDisplay.ClearValue(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
			this._isSelectedValueBoundToComboDisplay = false;
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x000444A0 File Offset: 0x000426A0
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			this._comboEditor.IsHitTestVisible = true;
			this._comboEditor.Focusable = true;
			this.SetupComboBox(this._comboEditor, cell, editorBinding);
			if (editorBinding != null)
			{
				this._comboEditor.SetBinding(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty, editorBinding);
			}
			else
			{
				this._comboEditor.ClearValue(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
			}
			this._comboEditor.SelectionChanged += this.ComboEditor_SelectionChanged;
			this._comboValueHolder.DataContext = this._comboEditor.SelectedItem;
			if (cell.IsEditing)
			{
				this._comboEditor.Focus();
			}
			return this._comboEditor;
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00044544 File Offset: 0x00042744
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return this._comboValueHolder.Value;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00044551 File Offset: 0x00042751
		public override void EditorRemoved()
		{
			base.EditorRemoved();
			this._comboEditor.SelectionChanged -= this.ComboEditor_SelectionChanged;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00044570 File Offset: 0x00042770
		public override void AdjustDisplayElement(global::Infragistics.Controls.Grids.Cell cell)
		{
			global::Infragistics.Controls.Grids.ComboBoxColumn comboBoxColumn = (global::Infragistics.Controls.Grids.ComboBoxColumn)cell.Column;
			if (this._comboDisplay.ItemsSource != comboBoxColumn.ItemsSource)
			{
				this._comboDisplay.ItemsSource = comboBoxColumn.ItemsSource;
			}
			global::System.Windows.Style editorStyleResolved = cell.EditorStyleResolved;
			if (editorStyleResolved != this._comboDisplay.Style)
			{
				if (editorStyleResolved == null)
				{
					this._comboDisplay.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
				}
				else
				{
					this._comboDisplay.Style = editorStyleResolved;
				}
			}
			if (this._useItemTemplate)
			{
				if (cell.Control != null)
				{
					if (this._justReleased && this._cellObj.DataContext == cell.Control.DataContext)
					{
						this._cellObj.DataContext = null;
					}
					this._cellObj.DataContext = cell.Control.DataContext;
				}
				if (this._justReleased && this._cellBinding == null && cell.GetType() == typeof(global::Infragistics.Controls.Grids.Cell))
				{
					cell.RaiseCellControlAttachedEvent();
				}
				this._justReleased = false;
			}
			else if (this._comboDisplay.GetBindingExpression(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty) == null && this._cellBinding != null && cell.EnableCustomEditorBehaviors && comboBoxColumn.EditorDisplayBehavior != global::Infragistics.Controls.Grids.EditorDisplayBehaviors.EditMode)
			{
				this._comboDisplay.SetBinding(global::System.Windows.Controls.Primitives.Selector.SelectedValueProperty, this._cellBinding);
				this._isSelectedValueBoundToComboDisplay = true;
			}
			base.AdjustDisplayElement(cell);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000446C0 File Offset: 0x000428C0
		protected internal override void FocusEditor()
		{
			if (this._comboEditor != null)
			{
				this._comboEditor.Focus();
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000446D8 File Offset: 0x000428D8
		protected internal override global::System.Windows.Data.Binding ResolveBinding(global::Infragistics.Controls.Grids.Cell cell)
		{
			return base.ResolveBinding(cell);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000446EE File Offset: 0x000428EE
		public override void ResetContent()
		{
			this._justReleased = true;
			if (this._cellObj != null)
			{
				this._cellObj.DataContext = null;
			}
			base.ResetContent();
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00044714 File Offset: 0x00042914
		private void ComboEditor_SelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			this._comboValueHolder.DataContext = this._comboEditor.SelectedItem;
			object value = null;
			if (e.AddedItems != null && e.AddedItems.Count > 0)
			{
				if (!string.IsNullOrEmpty(this._comboEditor.SelectedValuePath))
				{
					value = this._comboEditor.SelectedValue;
				}
				else
				{
					value = e.AddedItems[0];
				}
			}
			base.NotifyEditorValueChanged(value);
		}

		// Token: 0x040005C0 RID: 1472
		private global::System.Windows.Controls.ComboBox _comboEditor;

		// Token: 0x040005C1 RID: 1473
		private global::System.Windows.Controls.ComboBox _comboDisplay;

		// Token: 0x040005C2 RID: 1474
		private global::System.Windows.Data.Binding _cellBinding;

		// Token: 0x040005C3 RID: 1475
		private global::System.Windows.Controls.TextBlock _displayElement;

		// Token: 0x040005C4 RID: 1476
		private global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder _comboValueHolder;

		// Token: 0x040005C5 RID: 1477
		private bool _isSelectedValueBoundToComboDisplay;

		// Token: 0x040005C6 RID: 1478
		private bool _useItemTemplate;

		// Token: 0x040005C7 RID: 1479
		private global::System.Windows.FrameworkElement _templatedDisplayElement;

		// Token: 0x040005C8 RID: 1480
		private global::Infragistics.Controls.Grids.Cell.CellValueObject _cellObj;

		// Token: 0x040005C9 RID: 1481
		private bool _justReleased;

		// Token: 0x02000246 RID: 582
		private class ValueHolder : global::System.Windows.FrameworkElement, global::System.ComponentModel.INotifyPropertyChanged
		{
			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x0600125B RID: 4699 RVA: 0x00044783 File Offset: 0x00042983
			// (set) Token: 0x0600125C RID: 4700 RVA: 0x00044790 File Offset: 0x00042990
			public object Value
			{
				get
				{
					return base.GetValue(global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder.ValueProperty, value);
				}
			}

			// Token: 0x0600125D RID: 4701 RVA: 0x000447A0 File Offset: 0x000429A0
			private static void ValueChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder valueHolder = obj as global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder;
				if (valueHolder != null)
				{
					valueHolder.OnPropertyChanged("Value");
				}
			}

			// Token: 0x0600125E RID: 4702 RVA: 0x000447C4 File Offset: 0x000429C4
			private void OnPropertyChanged(string prop)
			{
				global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(prop));
				}
			}

			// Token: 0x1400001C RID: 28
			// (add) Token: 0x0600125F RID: 4703 RVA: 0x000447E8 File Offset: 0x000429E8
			// (remove) Token: 0x06001260 RID: 4704 RVA: 0x00044820 File Offset: 0x00042A20
			public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

			// Token: 0x040005CA RID: 1482
			public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ValueHolder.ValueChanged)));
		}

		// Token: 0x02000247 RID: 583
		private class ComboBoxColumnValueConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001263 RID: 4707 RVA: 0x00044893 File Offset: 0x00042A93
			public ComboBoxColumnValueConverter(global::Infragistics.Controls.Grids.ComboBoxColumn column, global::System.Windows.Data.IValueConverter wrappedConverter)
			{
				this._column = column;
				this._selectedValuePath = column.SelectedValuePath;
				this._wrappedConverter = wrappedConverter;
			}

			// Token: 0x06001264 RID: 4708 RVA: 0x000448B8 File Offset: 0x00042AB8
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				object value2 = this.ApplyConvertion(value, targetType, parameter, culture);
				return this.ResolveValueBack(value2);
			}

			// Token: 0x06001265 RID: 4709 RVA: 0x000448DC File Offset: 0x00042ADC
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				object value2 = this.ApplyBackConvertion(value, targetType, parameter, culture);
				return this.ResolveValue(value2);
			}

			// Token: 0x06001266 RID: 4710 RVA: 0x000448FE File Offset: 0x00042AFE
			private object ResolveValue(object value)
			{
				if (!string.IsNullOrEmpty(this._selectedValuePath) && value != null)
				{
					return global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(this._selectedValuePath, value);
				}
				return value;
			}

			// Token: 0x06001267 RID: 4711 RVA: 0x00044920 File Offset: 0x00042B20
			private object ResolveValueBack(object value)
			{
				object result = value;
				if (!string.IsNullOrEmpty(this._selectedValuePath) && value != null)
				{
					if (!this._column.DataType.IsAssignableFrom(value.GetType()))
					{
						return null;
					}
					object filterValue = this.ResolveValue(value);
					global::Infragistics.DataManagerBase dataManagerBase = global::Infragistics.DataManagerBase.CreateDataManager(this._column.ItemsSource);
					if (dataManagerBase != null)
					{
						global::System.Type fieldType = null;
						try
						{
							fieldType = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(this._selectedValuePath, dataManagerBase.CachedTypedInfo);
						}
						catch
						{
							return null;
						}
						global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ComboBoxItemsFilter comboBoxItemsFilter = new global::Infragistics.Controls.Grids.ComboBoxColumnContentProvider.ComboBoxItemsFilter(dataManagerBase.CachedType, dataManagerBase.CachedTypedInfo, this._selectedValuePath, fieldType);
						global::Infragistics.ComparisonCondition item = new global::Infragistics.ComparisonCondition
						{
							Operator = global::Infragistics.ComparisonOperator.Equals,
							FilterValue = filterValue
						};
						comboBoxItemsFilter.Conditions.Add(item);
						dataManagerBase.Filters = new global::Infragistics.RecordFilterCollection
						{
							comboBoxItemsFilter
						};
						if (dataManagerBase.RecordCount > 0)
						{
							result = dataManagerBase.GetRecord(0);
						}
						else
						{
							result = null;
						}
						dataManagerBase.DataSource = null;
						return result;
					}
				}
				return result;
			}

			// Token: 0x06001268 RID: 4712 RVA: 0x00044A28 File Offset: 0x00042C28
			private object ApplyConvertion(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				if (this._wrappedConverter != null)
				{
					return this._wrappedConverter.Convert(value, targetType, parameter, culture);
				}
				return value;
			}

			// Token: 0x06001269 RID: 4713 RVA: 0x00044A44 File Offset: 0x00042C44
			private object ApplyBackConvertion(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				if (this._wrappedConverter != null)
				{
					return this._wrappedConverter.ConvertBack(value, targetType, parameter, culture);
				}
				return value;
			}

			// Token: 0x040005CC RID: 1484
			private readonly string _selectedValuePath;

			// Token: 0x040005CD RID: 1485
			private readonly global::System.Windows.Data.IValueConverter _wrappedConverter;

			// Token: 0x040005CE RID: 1486
			private readonly global::Infragistics.Controls.Grids.ComboBoxColumn _column;
		}

		// Token: 0x02000248 RID: 584
		private class ComboBoxItemsFilter : global::Infragistics.Controls.Grids.RowsFilter
		{
			// Token: 0x0600126A RID: 4714 RVA: 0x00044A60 File Offset: 0x00042C60
			public ComboBoxItemsFilter(global::System.Type objectType, global::Infragistics.CachedTypedInfo typeInfo, string fieldName, global::System.Type fieldType)
			{
				this._fieldName = fieldName;
				this._fieldType = fieldType;
				base.ObjectType = objectType;
				base.ObjectTypedInfo = typeInfo;
			}

			// Token: 0x0600126B RID: 4715 RVA: 0x00044A88 File Offset: 0x00042C88
			protected override global::System.Linq.Expressions.Expression GetCurrentExpression()
			{
				global::System.Linq.Expressions.Expression result = null;
				if (base.ObjectTypedInfo != null && this.FieldType != null)
				{
					global::Infragistics.FilterContext context = global::Infragistics.FilterContext.CreateGenericFilter(base.ObjectTypedInfo, this.FieldType, false, false);
					result = this.GetCurrentExpression(context);
				}
				return result;
			}

			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x0600126C RID: 4716 RVA: 0x00044ACA File Offset: 0x00042CCA
			public override string FieldName
			{
				get
				{
					return this._fieldName;
				}
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x0600126D RID: 4717 RVA: 0x00044AD2 File Offset: 0x00042CD2
			public override global::System.Type FieldType
			{
				get
				{
					return this._fieldType;
				}
			}

			// Token: 0x040005CF RID: 1487
			private readonly string _fieldName;

			// Token: 0x040005D0 RID: 1488
			private readonly global::System.Type _fieldType;
		}
	}
}
