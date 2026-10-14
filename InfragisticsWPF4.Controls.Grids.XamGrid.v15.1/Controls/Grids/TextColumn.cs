using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200025D RID: 605
	public class TextColumn : global::Infragistics.Controls.Grids.EditableColumn
	{
		// Token: 0x06001364 RID: 4964 RVA: 0x00048CD2 File Offset: 0x00046ED2
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.Primitives.TextColumnContentProvider();
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00048CDC File Offset: 0x00046EDC
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
					if ((isValueType || global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(this.DataType)) && this.DataType != typeof(bool) && this.DataType != typeof(bool?) && this.DataType != typeof(global::System.DateTime) && this.DataType != typeof(global::System.DateTime?))
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

		// Token: 0x06001366 RID: 4966 RVA: 0x00048F1C File Offset: 0x0004711C
		protected internal override void FillFilterMenuOptions(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			base.FillFilterMenuOptions(list);
			if (this.DataType != null && base.ColumnLayout != null && base.ColumnLayout.Grid != null)
			{
				bool isPrimitive = this.DataType.IsPrimitive;
				if (list != null && list.Count > 0)
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
					if ((isPrimitive || global::Infragistics.Controls.Grids.Primitives.FilterRow.IsNullableValueType(this.DataType)) && this.DataType != typeof(bool) && this.DataType != typeof(bool?) && this.DataType != typeof(global::System.DateTime) && this.DataType != typeof(global::System.DateTime?))
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
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0004922C File Offset: 0x0004742C
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

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x00049324 File Offset: 0x00047524
		protected internal override global::Infragistics.Controls.Grids.FilterOperand DefaultFilterOperand
		{
			get
			{
				if (this.DataType == typeof(string))
				{
					if (this._defaultFilterOperand == null)
					{
						this._defaultFilterOperand = new global::Infragistics.Controls.Grids.StartsWithOperand();
					}
					return this._defaultFilterOperand;
				}
				return base.DefaultFilterOperand;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x0004935D File Offset: 0x0004755D
		protected internal override string FormatStringResolved
		{
			get
			{
				return this.FormatString;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x00049365 File Offset: 0x00047565
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

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00049386 File Offset: 0x00047586
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x0004938E File Offset: 0x0004758E
		public global::System.Windows.Style TextBlockStyle
		{
			get
			{
				return this._textBlockStyle;
			}
			set
			{
				if (this._textBlockStyle != value)
				{
					this._textBlockStyle = value;
					this.OnPropertyChanged("TextBlockStyle");
				}
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000493AB File Offset: 0x000475AB
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x000493BD File Offset: 0x000475BD
		public global::System.Windows.TextWrapping TextWrapping
		{
			get
			{
				return (global::System.Windows.TextWrapping)base.GetValue(global::Infragistics.Controls.Grids.TextColumn.TextWrappingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TextColumn.TextWrappingProperty, value);
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x000493D0 File Offset: 0x000475D0
		private static void TextWrappingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TextColumn textColumn = (global::Infragistics.Controls.Grids.TextColumn)obj;
			textColumn.OnPropertyChanged("TextWrapping");
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000493EF File Offset: 0x000475EF
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00049401 File Offset: 0x00047601
		public string FormatString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.TextColumn.FormatStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.TextColumn.FormatStringProperty, value);
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00049410 File Offset: 0x00047610
		private static void FormatStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.TextColumn textColumn = (global::Infragistics.Controls.Grids.TextColumn)obj;
			textColumn.OnPropertyChanged("FormatString");
			if (textColumn.ColumnLayout != null && textColumn.ColumnLayout.Grid != null)
			{
				textColumn.ColumnLayout.Grid.ResetPanelRows();
			}
		}

		// Token: 0x040005F5 RID: 1525
		private global::Infragistics.Controls.Grids.FilterOperand _defaultFilterOperand;

		// Token: 0x040005F6 RID: 1526
		private global::System.Windows.Style _textBlockStyle;

		// Token: 0x040005F7 RID: 1527
		private string _filterMenuCustomFilterString;

		// Token: 0x040005F8 RID: 1528
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty = global::System.Windows.DependencyProperty.Register("TextWrapping", typeof(global::System.Windows.TextWrapping), typeof(global::Infragistics.Controls.Grids.TextColumn), new global::System.Windows.PropertyMetadata(global::System.Windows.TextWrapping.NoWrap, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TextColumn.TextWrappingChanged)));

		// Token: 0x040005F9 RID: 1529
		public static readonly global::System.Windows.DependencyProperty FormatStringProperty = global::System.Windows.DependencyProperty.Register("FormatString", typeof(string), typeof(global::Infragistics.Controls.Grids.TextColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.TextColumn.FormatStringChanged)));
	}
}
