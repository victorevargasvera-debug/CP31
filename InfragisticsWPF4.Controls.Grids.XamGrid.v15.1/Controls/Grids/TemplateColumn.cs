using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000264 RID: 612
	public class TemplateColumn : global::Infragistics.Controls.Grids.EditableColumn
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00049C16 File Offset: 0x00047E16
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00049C28 File Offset: 0x00047E28
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.TemplateColumn.ItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TemplateColumn.ItemTemplateProperty, value);
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00049C38 File Offset: 0x00047E38
		private static void ItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = (global::Infragistics.Controls.Grids.TemplateColumn)obj;
			if (templateColumn.ColumnLayout != null && templateColumn.ColumnLayout.Grid != null && templateColumn.ColumnLayout.Grid.IsLoaded)
			{
				templateColumn.ColumnLayout.Grid.ResetPanelRows(true);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00049C84 File Offset: 0x00047E84
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x00049C96 File Offset: 0x00047E96
		public global::System.Windows.DataTemplate EditorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.TemplateColumn.EditorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TemplateColumn.EditorTemplateProperty, value);
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00049CA4 File Offset: 0x00047EA4
		private static void EditorTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = (global::Infragistics.Controls.Grids.TemplateColumn)obj;
			templateColumn.EditorTemplateDirtyFlag++;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00049CC6 File Offset: 0x00047EC6
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00049CD8 File Offset: 0x00047ED8
		public global::System.Windows.DataTemplate FilterItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.TemplateColumn.FilterItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TemplateColumn.FilterItemTemplateProperty, value);
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00049CE8 File Offset: 0x00047EE8
		private static void FilterItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = (global::Infragistics.Controls.Grids.TemplateColumn)obj;
			templateColumn.OnPropertyChanged("FilterItemTemplate");
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x00049D07 File Offset: 0x00047F07
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00049D19 File Offset: 0x00047F19
		public global::System.Windows.DataTemplate FilterEditorTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.TemplateColumn.FilterEditorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TemplateColumn.FilterEditorTemplateProperty, value);
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00049D28 File Offset: 0x00047F28
		private static void FilterEditorTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TemplateColumn templateColumn = (global::Infragistics.Controls.Grids.TemplateColumn)obj;
			templateColumn.OnPropertyChanged("FilterEditorTemplate");
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00049D47 File Offset: 0x00047F47
		protected override string FilterMenuCustomFilterString
		{
			get
			{
				if (string.IsNullOrEmpty(this._filterMenuCustomFilterString))
				{
					return base.FilterMenuCustomFilterString;
				}
				return global::Infragistics.SRGrid.GetString(this._filterMenuCustomFilterString);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x00049D68 File Offset: 0x00047F68
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00049D70 File Offset: 0x00047F70
		internal int EditorTemplateDirtyFlag { get; set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x00049D79 File Offset: 0x00047F79
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x00049DA1 File Offset: 0x00047FA1
		public override bool IsSortable
		{
			get
			{
				return base.IsSortable && (this.DataType != null || base.SortComparer != null);
			}
			set
			{
				base.IsSortable = value;
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00049DAA File Offset: 0x00047FAA
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.Primitives.TemplateColumnContentProvider();
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00049DB1 File Offset: 0x00047FB1
		protected internal override bool IsEditable
		{
			get
			{
				return !base.IsReadOnly;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00049DBC File Offset: 0x00047FBC
		protected internal override bool UniqueColumnContent
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x00049DBF File Offset: 0x00047FBF
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00049DD1 File Offset: 0x00047FD1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Data.IValueConverter EditorValueConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterProperty, value);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00049DDF File Offset: 0x00047FDF
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00049DEC File Offset: 0x00047FEC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new object EditorValueConverterParameter
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditableColumn.EditorValueConverterParameterProperty, value);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00049DFA File Offset: 0x00047FFA
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x00049E0C File Offset: 0x0004800C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Data.IValueConverter ValueConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Grids.Column.ValueConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.ValueConverterProperty, value);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00049E1A File Offset: 0x0004801A
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x00049E27 File Offset: 0x00048027
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new object ValueConverterParameter
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.Column.ValueConverterParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Column.ValueConverterParameterProperty, value);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00049E35 File Offset: 0x00048035
		protected internal override bool UseReadOnlyFlag
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00049E38 File Offset: 0x00048038
		protected internal override void FillAvailableFilters(global::Infragistics.Controls.Grids.FilterOperandCollection availableFilters)
		{
			base.FillAvailableFilters(availableFilters);
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.ComparisonOperator, global::System.Windows.DataTemplate> filterIcons = base.ColumnLayout.Grid.FilterIcons;
				if (filterIcons != null && this.DataType != null)
				{
					bool isValueType = this.DataType.IsValueType;
					if (this.DataType == typeof(string))
					{
						availableFilters.Add(new global::Infragistics.Controls.Grids.StartsWithOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.ContainsOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.EndsWithOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.DoesNotContainOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.DoesNotStartWithOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.DoesNotEndWithOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						return;
					}
					if (isValueType)
					{
						availableFilters.Add(new global::Infragistics.Controls.Grids.GreaterThanOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.GreaterThanOrEqualOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.LessThanOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
						availableFilters.Add(new global::Infragistics.Controls.Grids.LessThanOrEqualOperand
						{
							XamWebGrid = base.ColumnLayout.Grid
						});
					}
				}
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x0004A000 File Offset: 0x00048200
		protected internal override void FillFilterMenuOptions(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			base.FillFilterMenuOptions(list);
			if (this.DataType != null && base.ColumnLayout != null && base.ColumnLayout.Grid != null && list != null && list.Count > 0)
			{
				global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject = list[0];
				list = filterMenuTrackingObject.Children;
				if (this.DataType == typeof(string))
				{
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
					{
						IsSeparator = true
					});
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.StartsWithOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("StartsWithEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.EndsWithOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("EndsWithEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
					{
						IsSeparator = true
					});
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.ContainsOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("ContainsEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DoesNotContainOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("DoesNotContainEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
					{
						IsSeparator = true
					});
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DoesNotStartWithOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("DoesNotStartWithEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DoesNotEndWithOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("DoesNotEndWithEllipsis")
					}));
					return;
				}
				if ((this.DataType.IsPrimitive || global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(this.DataType)) && this.DataType != typeof(bool) && this.DataType != typeof(bool?) && this.DataType != typeof(global::System.DateTime) && this.DataType != typeof(global::System.DateTime?))
				{
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
					{
						IsSeparator = true
					});
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.GreaterThanOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("GreaterThanEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.GreaterThanOrEqualOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("GreaterThanOrEqualEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.LessThanOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("LessThanEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.LessThanOrEqualOperand
					{
						DisplayName = global::Infragistics.SRGrid.GetString("LessThanOrEqualEllipsis")
					}));
					list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
					{
						Label = global::Infragistics.SRGrid.GetString("BetweenEllipsis"),
						FilterOperands = 
						{
							new global::Infragistics.Controls.Grids.GreaterThanOrEqualOperand(),
							new global::Infragistics.Controls.Grids.LessThanOrEqualOperand()
						}
					});
				}
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0004A30C File Offset: 0x0004850C
		protected override void OnDataTypeChanged()
		{
			bool isPrimitive = this.DataType.IsPrimitive;
			if (this.DataType == typeof(string))
			{
				this._filterMenuCustomFilterString = "StringFilters";
			}
			else if ((isPrimitive || global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(this.DataType)) && this.DataType != typeof(bool) && this.DataType != typeof(bool?) && this.DataType != typeof(global::System.DateTime) && this.DataType != typeof(global::System.DateTime?))
			{
				this._filterMenuCustomFilterString = "NumberFilters";
			}
			else if (this.DataType == typeof(bool) || this.DataType == typeof(bool?))
			{
				this._filterMenuCustomFilterString = "BoolFilters";
			}
			base.OnDataTypeChanged();
		}

		// Token: 0x04000602 RID: 1538
		private string _filterMenuCustomFilterString;

		// Token: 0x04000603 RID: 1539
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.TemplateColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TemplateColumn.ItemTemplateChanged)));

		// Token: 0x04000604 RID: 1540
		public static readonly global::System.Windows.DependencyProperty EditorTemplateProperty = global::System.Windows.DependencyProperty.Register("EditorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.TemplateColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TemplateColumn.EditorTemplateChanged)));

		// Token: 0x04000605 RID: 1541
		public static readonly global::System.Windows.DependencyProperty FilterItemTemplateProperty = global::System.Windows.DependencyProperty.Register("FilterItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.TemplateColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TemplateColumn.FilterItemTemplateChanged)));

		// Token: 0x04000606 RID: 1542
		public static readonly global::System.Windows.DependencyProperty FilterEditorTemplateProperty = global::System.Windows.DependencyProperty.Register("FilterEditorTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.TemplateColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TemplateColumn.FilterEditorTemplateChanged)));
	}
}
