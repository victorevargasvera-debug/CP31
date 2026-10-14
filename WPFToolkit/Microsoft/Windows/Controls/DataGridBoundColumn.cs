using System;
using System.Windows;
using System.Windows.Data;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000009 RID: 9
	public abstract class DataGridBoundColumn : global::Microsoft.Windows.Controls.DataGridColumn
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000041D4 File Offset: 0x000023D4
		static DataGridBoundColumn()
		{
			global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridBoundColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridBoundColumn.OnCoerceSortMemberPath)));
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004274 File Offset: 0x00002474
		private static object OnCoerceSortMemberPath(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridBoundColumn dataGridBoundColumn = (global::Microsoft.Windows.Controls.DataGridBoundColumn)d;
			string text = (string)baseValue;
			if (string.IsNullOrEmpty(text))
			{
				text = global::Microsoft.Windows.Controls.DataGridHelper.GetPathFromBinding(dataGridBoundColumn.Binding as global::System.Windows.Data.Binding);
			}
			return text;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000042A9 File Offset: 0x000024A9
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000042D4 File Offset: 0x000024D4
		public virtual global::System.Windows.Data.BindingBase Binding
		{
			get
			{
				if (!this._bindingEnsured)
				{
					if (!base.IsReadOnly)
					{
						global::Microsoft.Windows.Controls.DataGridHelper.EnsureTwoWayIfNotOneWay(this._binding);
					}
					this._bindingEnsured = true;
				}
				return this._binding;
			}
			set
			{
				if (this._binding != value)
				{
					global::System.Windows.Data.BindingBase binding = this._binding;
					this._binding = value;
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty);
					this._bindingEnsured = false;
					this.OnBindingChanged(binding, this._binding);
				}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004322 File Offset: 0x00002522
		protected override bool OnCoerceIsReadOnly(bool baseValue)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.IsOneWay(this._binding) || base.OnCoerceIsReadOnly(baseValue);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000433A File Offset: 0x0000253A
		protected virtual void OnBindingChanged(global::System.Windows.Data.BindingBase oldBinding, global::System.Windows.Data.BindingBase newBinding)
		{
			base.NotifyPropertyChanged("Binding");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004348 File Offset: 0x00002548
		internal void ApplyBinding(global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty property)
		{
			global::System.Windows.Data.BindingBase binding = this.Binding;
			if (binding != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(target, property, binding);
				return;
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(target, property);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004370 File Offset: 0x00002570
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00004382 File Offset: 0x00002582
		public global::System.Windows.Style ElementStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridBoundColumn.ElementStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridBoundColumn.ElementStyleProperty, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004390 File Offset: 0x00002590
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000043A2 File Offset: 0x000025A2
		public global::System.Windows.Style EditingElementStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridBoundColumn.EditingElementStyleProperty, value);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000043B0 File Offset: 0x000025B0
		internal void ApplyStyle(bool isEditing, bool defaultToElementStyle, global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.Style style = this.PickStyle(isEditing, defaultToElementStyle);
			if (style != null)
			{
				element.Style = style;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000043D0 File Offset: 0x000025D0
		private global::System.Windows.Style PickStyle(bool isEditing, bool defaultToElementStyle)
		{
			global::System.Windows.Style style = isEditing ? this.EditingElementStyle : this.ElementStyle;
			if (isEditing && defaultToElementStyle && style == null)
			{
				style = this.ElementStyle;
			}
			return style;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00004400 File Offset: 0x00002600
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00004412 File Offset: 0x00002612
		public override global::System.Windows.Data.BindingBase ClipboardContentBinding
		{
			get
			{
				return base.ClipboardContentBinding ?? this.Binding;
			}
			set
			{
				base.ClipboardContentBinding = value;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000441C File Offset: 0x0000261C
		protected internal override void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = element as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell != null)
			{
				bool isEditing = dataGridCell.IsEditing;
				if (string.Compare(propertyName, "Binding", global::System.StringComparison.Ordinal) == 0 || (string.Compare(propertyName, "ElementStyle", global::System.StringComparison.Ordinal) == 0 && !isEditing) || (string.Compare(propertyName, "EditingElementStyle", global::System.StringComparison.Ordinal) == 0 && isEditing))
				{
					dataGridCell.BuildVisualTree();
					return;
				}
			}
			base.RefreshCellContent(element, propertyName);
		}

		// Token: 0x0400002A RID: 42
		public static readonly global::System.Windows.DependencyProperty ElementStyleProperty = global::System.Windows.DependencyProperty.Register("ElementStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGridBoundColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x0400002B RID: 43
		public static readonly global::System.Windows.DependencyProperty EditingElementStyleProperty = global::System.Windows.DependencyProperty.Register("EditingElementStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGridBoundColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Data.BindingBase _binding;

		// Token: 0x0400002D RID: 45
		private bool _bindingEnsured = true;
	}
}
