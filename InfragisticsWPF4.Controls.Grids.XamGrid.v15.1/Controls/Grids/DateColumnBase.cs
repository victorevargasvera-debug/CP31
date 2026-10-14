using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000249 RID: 585
	public abstract class DateColumnBase : global::Infragistics.Controls.Grids.CustomDisplayEditableColumn
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00044ADA File Offset: 0x00042CDA
		protected internal override string FormatStringResolved
		{
			get
			{
				return "{0:d}";
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00044AE1 File Offset: 0x00042CE1
		protected override string FilterMenuCustomFilterString
		{
			get
			{
				return global::Infragistics.SRGrid.GetString("DateFilters");
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00044AED File Offset: 0x00042CED
		protected internal override global::Infragistics.Controls.Grids.Primitives.SelectionControl GenerateFilterSelectionControl()
		{
			return new global::Infragistics.Controls.Grids.Primitives.DateFilterSelectionControl();
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00044AF4 File Offset: 0x00042CF4
		protected internal override void FillAvailableFilters(global::Infragistics.Controls.Grids.FilterOperandCollection availableFilters)
		{
			base.FillAvailableFilters(availableFilters);
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
			{
				global::System.Collections.Generic.Dictionary<global::Infragistics.ComparisonOperator, global::System.Windows.DataTemplate> filterIcons = base.ColumnLayout.Grid.FilterIcons;
				if (filterIcons != null && this.DataType != null)
				{
					availableFilters.Add(new global::Infragistics.Controls.Grids.GreaterThanOrEqualOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.LessThanOrEqualOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeAfterFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeBeforeFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeTodayFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeTomorrowFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeYesterdayFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeThisWeekFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeLastWeekFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeNextWeekFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeThisMonthFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeLastMonthFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeNextMonthFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeThisYearFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeLastYearFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeNextYearFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeThisQuarterFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeLastQuarterFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeNextQuarterFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeYearToDateFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeQuarter1FilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeQuarter2FilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeQuarter3FilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeQuarter4FilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeJanuaryFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeFebruaryFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeMarchFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeAprilFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeMayFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeJuneFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeJulyFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeAugustFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeSeptemberFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeOctoberFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeNovemberFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
					availableFilters.Add(new global::Infragistics.Controls.Grids.DateTimeDecemberFilterOperand
					{
						XamWebGrid = base.ColumnLayout.Grid
					});
				}
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00044FE8 File Offset: 0x000431E8
		protected internal override void FillFilterMenuOptions(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> list)
		{
			base.FillFilterMenuOptions(list);
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && list != null && list.Count > 0)
			{
				global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject = list[0];
				list = filterMenuTrackingObject.Children;
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeBeforeFilterOperand
				{
					DisplayName = global::Infragistics.SRGrid.GetString("BeforeEllipsis")
				}));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeAfterFilterOperand
				{
					DisplayName = global::Infragistics.SRGrid.GetString("AfterEllipsis")
				}));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeTomorrowFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeTodayFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeYesterdayFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeNextWeekFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeThisWeekFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeLastWeekFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeNextMonthFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeThisMonthFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeLastMonthFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeNextQuarterFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeThisQuarterFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeLastQuarterFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeNextYearFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeThisYearFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeLastYearFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeYearToDateFilterOperand()));
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				global::Infragistics.Controls.Grids.FilterMenuTrackingObject filterMenuTrackingObject2 = new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					Label = global::Infragistics.SRGrid.GetString("AllDatesInPeriod")
				};
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeQuarter1FilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeQuarter2FilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeQuarter3FilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeQuarter4FilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeJanuaryFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeFebruaryFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeMarchFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeAprilFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeMayFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeJuneFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeJulyFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeAugustFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeSeptemberFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeOctoberFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeNovemberFilterOperand()));
				filterMenuTrackingObject2.Children.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.DateTimeDecemberFilterOperand()));
				list.Add(filterMenuTrackingObject2);
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject
				{
					IsSeparator = true
				});
				string displayName = string.IsNullOrEmpty(base.FilterColumnSettings.FilterMenuTypeSpecificFiltersString) ? global::Infragistics.SRGrid.GetString("CustomFiltersWithoutTypeEllipsis") : base.FilterColumnSettings.FilterMenuTypeSpecificFiltersString;
				list.Add(new global::Infragistics.Controls.Grids.FilterMenuTrackingObject(new global::Infragistics.Controls.Grids.EqualsOperand
				{
					DisplayName = displayName
				})
				{
					IsCustomOption = true
				});
			}
		}

		// Token: 0x040005D1 RID: 1489
		private const string _filterMenuCustomFilterString = "DateFilters";
	}
}
