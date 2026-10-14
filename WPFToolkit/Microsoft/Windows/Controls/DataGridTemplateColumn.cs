using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000036 RID: 54
	public class DataGridTemplateColumn : global::Microsoft.Windows.Controls.DataGridColumn
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x0000AD94 File Offset: 0x00008F94
		static DataGridTemplateColumn()
		{
			global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridTemplateColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridTemplateColumn.OnCoerceTemplateColumnCanUserSort)));
			global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridTemplateColumn), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridTemplateColumn.OnTemplateColumnSortMemberPathChanged)));
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000AEC0 File Offset: 0x000090C0
		private static void OnTemplateColumnSortMemberPathChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridTemplateColumn dataGridTemplateColumn = (global::Microsoft.Windows.Controls.DataGridTemplateColumn)d;
			dataGridTemplateColumn.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000AEE0 File Offset: 0x000090E0
		private static object OnCoerceTemplateColumnCanUserSort(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridTemplateColumn dataGridTemplateColumn = (global::Microsoft.Windows.Controls.DataGridTemplateColumn)d;
			if (string.IsNullOrEmpty(dataGridTemplateColumn.SortMemberPath))
			{
				return false;
			}
			return global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceCanUserSort(d, baseValue);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000AF0F File Offset: 0x0000910F
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0000AF21 File Offset: 0x00009121
		public global::System.Windows.DataTemplate CellTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellTemplateProperty, value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000AF2F File Offset: 0x0000912F
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0000AF41 File Offset: 0x00009141
		public global::System.Windows.Controls.DataTemplateSelector CellTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellTemplateSelectorProperty, value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000AF4F File Offset: 0x0000914F
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0000AF61 File Offset: 0x00009161
		public global::System.Windows.DataTemplate CellEditingTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellEditingTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellEditingTemplateProperty, value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000AF6F File Offset: 0x0000916F
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0000AF81 File Offset: 0x00009181
		public global::System.Windows.Controls.DataTemplateSelector CellEditingTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellEditingTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridTemplateColumn.CellEditingTemplateSelectorProperty, value);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000AF90 File Offset: 0x00009190
		private global::System.Windows.DataTemplate ChooseCellTemplate(bool isEditing)
		{
			global::System.Windows.DataTemplate dataTemplate = null;
			if (isEditing)
			{
				dataTemplate = this.CellEditingTemplate;
			}
			if (dataTemplate == null)
			{
				dataTemplate = this.CellTemplate;
			}
			return dataTemplate;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000AFB4 File Offset: 0x000091B4
		private global::System.Windows.Controls.DataTemplateSelector ChooseCellTemplateSelector(bool isEditing)
		{
			global::System.Windows.Controls.DataTemplateSelector dataTemplateSelector = null;
			if (isEditing)
			{
				dataTemplateSelector = this.CellEditingTemplateSelector;
			}
			if (dataTemplateSelector == null)
			{
				dataTemplateSelector = this.CellTemplateSelector;
			}
			return dataTemplateSelector;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000AFD8 File Offset: 0x000091D8
		private global::System.Windows.FrameworkElement LoadTemplateContent(bool isEditing, object dataItem, global::Microsoft.Windows.Controls.DataGridCell cell)
		{
			global::System.Windows.DataTemplate dataTemplate = this.ChooseCellTemplate(isEditing);
			global::System.Windows.Controls.DataTemplateSelector dataTemplateSelector = this.ChooseCellTemplateSelector(isEditing);
			if (dataTemplate != null || dataTemplateSelector != null)
			{
				global::System.Windows.Controls.ContentPresenter contentPresenter = new global::System.Windows.Controls.ContentPresenter();
				global::System.Windows.Data.BindingOperations.SetBinding(contentPresenter, global::System.Windows.Controls.ContentPresenter.ContentProperty, new global::System.Windows.Data.Binding());
				contentPresenter.ContentTemplate = dataTemplate;
				contentPresenter.ContentTemplateSelector = dataTemplateSelector;
				return contentPresenter;
			}
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B023 File Offset: 0x00009223
		protected override global::System.Windows.FrameworkElement GenerateElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			return this.LoadTemplateContent(false, dataItem, cell);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B02E File Offset: 0x0000922E
		protected override global::System.Windows.FrameworkElement GenerateEditingElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem)
		{
			return this.LoadTemplateContent(true, dataItem, cell);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B03C File Offset: 0x0000923C
		protected internal override void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = element as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell != null)
			{
				bool isEditing = dataGridCell.IsEditing;
				if ((!isEditing && (string.Compare(propertyName, "CellTemplate", global::System.StringComparison.Ordinal) == 0 || string.Compare(propertyName, "CellTemplateSelector", global::System.StringComparison.Ordinal) == 0)) || (isEditing && (string.Compare(propertyName, "CellEditingTemplate", global::System.StringComparison.Ordinal) == 0 || string.Compare(propertyName, "CellEditingTemplateSelector", global::System.StringComparison.Ordinal) == 0)))
				{
					dataGridCell.BuildVisualTree();
					return;
				}
			}
			base.RefreshCellContent(element, propertyName);
		}

		// Token: 0x040000CD RID: 205
		public static readonly global::System.Windows.DependencyProperty CellTemplateProperty = global::System.Windows.DependencyProperty.Register("CellTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGridTemplateColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040000CE RID: 206
		public static readonly global::System.Windows.DependencyProperty CellTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("CellTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGridTemplateColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040000CF RID: 207
		public static readonly global::System.Windows.DependencyProperty CellEditingTemplateProperty = global::System.Windows.DependencyProperty.Register("CellEditingTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGridTemplateColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));

		// Token: 0x040000D0 RID: 208
		public static readonly global::System.Windows.DependencyProperty CellEditingTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("CellEditingTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGridTemplateColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.NotifyPropertyChangeForRefreshContent)));
	}
}
