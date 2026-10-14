using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using Infragistics.Collections;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000036 RID: 54
	internal class SelectedDateCollection : global::Infragistics.Collections.DateCollection
	{
		// Token: 0x06000261 RID: 609 RVA: 0x0000CC37 File Offset: 0x0000AE37
		internal SelectedDateCollection(global::Infragistics.Controls.Editors.CalendarBase owner)
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("owner", owner);
			this._owner = owner;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000CC54 File Offset: 0x0000AE54
		protected override global::System.DateTime[] GetAllowedDates(global::Infragistics.DateRange dateRange)
		{
			return this._owner.GetSelectableDates(new global::Infragistics.DateRange(dateRange.Start.Date, dateRange.End.Date));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000CC8F File Offset: 0x0000AE8F
		protected override void OnDatesChanged(global::System.Collections.Generic.IList<global::System.DateTime> added, global::System.Collections.Generic.IList<global::System.DateTime> removed)
		{
			base.OnDatesChanged(added, removed);
			this.RaiseSelectionChanged(added, removed);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			int count = base.Items.Count;
			if (this._owner.SelectedDates == this)
			{
				this._owner.SelectedDate = ((count == 0) ? null : new global::System.DateTime?(base.Items[0]));
			}
			base.OnCollectionChanged(e);
			this.VerifyWeekSelection();
			if (this._owner.SelectedDates == this)
			{
				this._owner.VerifySelectedDayStatesAsync();
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000CD1C File Offset: 0x0000AF1C
		protected override void VerifyNewDateCount(ref int newItemCount, bool validate)
		{
			int maxSelectedDatesResolved = this._owner.MaxSelectedDatesResolved;
			if (newItemCount > maxSelectedDatesResolved)
			{
				if (validate)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.CalendarUtilities.GetString("LE_MaxSelectedDatesExceeded", new object[]
					{
						base.Count + 1,
						this._owner.MaxSelectedDatesResolved
					}));
				}
				newItemCount = maxSelectedDatesResolved;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000CD7B File Offset: 0x0000AF7B
		internal bool ContainsSelection(global::System.DateTime start, global::System.DateTime end)
		{
			return base.IntersectsWith(new global::Infragistics.DateRange(start, end));
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		internal void EnsureWithinMinMax()
		{
			if (base.Count > 0)
			{
				global::System.DateTime minDateResolved = this._owner.MinDateResolved;
				global::System.DateTime maxDateResolved = this._owner.MaxDateResolved;
				base.AllowedRange = new global::Infragistics.DateRange(minDateResolved, maxDateResolved);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000CDC7 File Offset: 0x0000AFC7
		internal bool IsSelected(global::System.DateTime date)
		{
			return base.ContainsDate(date);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
		internal bool IsSelected(global::Infragistics.DateRange range)
		{
			range.Normalize();
			range.RemoveTime();
			global::System.DateTime dateTime = range.Start;
			global::System.DateTime end = range.End;
			if (!base.ContainsDate(end))
			{
				return false;
			}
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = this._owner.CalendarManager;
			while (dateTime < end)
			{
				if (!base.ContainsDate(dateTime))
				{
					return false;
				}
				dateTime = calendarManager.AddDays(dateTime, 1);
			}
			return true;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000CE32 File Offset: 0x0000B032
		private void RaiseSelectionChanged(global::System.Collections.Generic.IList<global::System.DateTime> selected, global::System.Collections.Generic.IList<global::System.DateTime> unselected)
		{
			this._owner.OnSelectedStateChanged(selected, unselected);
			this._owner.RaiseSelectedDatesChanged(unselected, selected, false);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000CE50 File Offset: 0x0000B050
		internal void VerifyWeekSelection()
		{
			int count = base.Items.Count;
			if (count > 6 && this._owner.SupportsWeekSelectionMode && this._owner.SelectedDatesInternal == this)
			{
				global::System.Globalization.CalendarWeekRule? weekRuleInternal = this._owner.WeekRuleInternal;
				global::System.DayOfWeek? firstDayOfWeekInternal = this._owner.FirstDayOfWeekInternal;
				global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>(base.Items);
				list.Sort();
				int num = -1;
				for (int i = 0; i < count; i++)
				{
					global::System.DateTime date = list[i];
					int num2;
					int weekNumberForDate = this._owner.CalendarManager.GetWeekNumberForDate(date, weekRuleInternal, firstDayOfWeekInternal, out num2);
					if (weekNumberForDate != num)
					{
						num = weekNumberForDate;
						global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber weekNumber = this._owner.GetWeekNumber(date);
						if (weekNumber != null)
						{
							weekNumber.VerifyIsSelected();
						}
					}
				}
			}
		}

		// Token: 0x04000177 RID: 375
		private global::Infragistics.Controls.Editors.CalendarBase _owner;
	}
}
