using System;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000075 RID: 117
	internal class GroupByAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000644 RID: 1604 RVA: 0x00018C80 File Offset: 0x00016E80
		internal GroupByAction(global::Infragistics.Windows.DataPresenter.Field field) : base(field.DataPresenter)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = null;
			this._field = field;
			this._index = owner.SortedFields.TryGetValue(field, null, out fieldSortDescription);
			if (this._index >= 0)
			{
				this._sortDescription = fieldSortDescription.Clone();
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00018CDB File Offset: 0x00016EDB
		protected internal override bool CanPerform(object context)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._field);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00018CE8 File Offset: 0x00016EE8
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._field.Owner && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.GroupingAndSorting) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00018D08 File Offset: 0x00016F08
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			global::Infragistics.Windows.DataPresenter.GroupByAction result = new global::Infragistics.Windows.DataPresenter.GroupByAction(this._field);
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._field.Owner;
			if (owner == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = owner.DataPresenter;
			if (dataPresenter == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.GroupingHelper groupingHelper = new global::Infragistics.Windows.DataPresenter.GroupingHelper(owner);
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription;
			owner.SortedFields.TryGetValue(this._field, new bool?(true), out fieldSortDescription);
			if (this._sortDescription == null || !this._sortDescription.IsGroupBy)
			{
				if (fieldSortDescription == null || !fieldSortDescription.IsGroupBy)
				{
					return null;
				}
				if (!groupingHelper.ProcessTryUnGroup(this._field))
				{
					return null;
				}
				groupingHelper.ProcessApplyUnGroup(this._field, false);
			}
			else
			{
				int num = this._index;
				if (fieldSortDescription == null || !fieldSortDescription.IsGroupBy)
				{
					num = global::System.Math.Max(0, global::System.Math.Min(groupingHelper.Groups.Count, num));
					if (!groupingHelper.ProcessTryGrouping(this._field, num))
					{
						return null;
					}
					groupingHelper.ProcessApplyGrouping(this._field, num, false);
				}
				else
				{
					num = global::System.Math.Max(0, global::System.Math.Min(groupingHelper.Groups.Count - 1, num));
					if (groupingHelper.Groups[num].Field == this._field)
					{
						return null;
					}
					if (!groupingHelper.ProcessTryReGroup(this._field, num))
					{
						return null;
					}
					groupingHelper.ProcessApplyReGroup(this._field, num, false);
				}
			}
			groupingHelper.RaiseGroupedEventHelper();
			if (this._sortDescription != null && !this._sortDescription.IsGroupBy && !owner.SortedFields.Contains(this._field, new bool?(false)))
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription2 = this._sortDescription.Clone();
				fieldSortDescription2.Seal();
				global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs sortingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs(owner, fieldSortDescription2, false);
				dataPresenter.RaiseSorting(sortingEventArgs);
				if (!sortingEventArgs.Cancel && !owner.SortedFields.Contains(this._field, new bool?(false)))
				{
					int index = global::System.Math.Max(0, global::System.Math.Min(this._index, owner.SortedFields.Count));
					owner.SortedFields.Insert(index, fieldSortDescription2);
					dataPresenter.RaiseSorted(new global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs(owner, fieldSortDescription2));
				}
			}
			dataPresenter.History.FixGroupExpansionHistory(context);
			return result;
		}

		// Token: 0x040001EB RID: 491
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription _sortDescription;

		// Token: 0x040001EC RID: 492
		private int _index;

		// Token: 0x040001ED RID: 493
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
