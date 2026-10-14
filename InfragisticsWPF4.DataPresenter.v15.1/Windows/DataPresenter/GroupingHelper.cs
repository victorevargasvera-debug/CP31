using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200017E RID: 382
	internal class GroupingHelper
	{
		// Token: 0x06001838 RID: 6200 RVA: 0x00070AD0 File Offset: 0x0006ECD0
		internal GroupingHelper(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			this._fieldLayout = fieldLayout;
			this._sortedFields = fieldLayout.SortedFields;
			this._groups = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription>(this._sortedFields.CountOfGroupByFields + 1);
			for (int i = 0; i < this._sortedFields.CountOfGroupByFields; i++)
			{
				if (this._sortedFields[i].IsGroupBy)
				{
					this._groups.Add(this._sortedFields[i]);
				}
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00070B4E File Offset: 0x0006ED4E
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00070B56 File Offset: 0x0006ED56
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> Groups
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x00070B5E File Offset: 0x0006ED5E
		internal global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection SortedFields
		{
			get
			{
				return this._sortedFields;
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00070B68 File Offset: 0x0006ED68
		private void AddUndoAction(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.FieldLayout.DataPresenter;
			if (dataPresenter != null && dataPresenter.IsUndoEnabled)
			{
				dataPresenter.History.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.GroupByAction(field));
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00070BA0 File Offset: 0x0006EDA0
		internal global::Infragistics.Windows.DataPresenter.FieldSortDescription GetFieldSortDescriptionForField(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldSortDescription> sortedFields)
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in sortedFields)
			{
				if (fieldSortDescription.Field == field)
				{
					return fieldSortDescription;
				}
			}
			return null;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		internal void ProcessApplyReGroup(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex)
		{
			this.ProcessApplyReGroup(field, insertAtIndex, true);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00070C00 File Offset: 0x0006EE00
		internal void ProcessApplyReGroup(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex, bool addToUndo)
		{
			if (addToUndo)
			{
				this.AddUndoAction(field);
			}
			this._sortedFields.BeginUpdate();
			try
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in this._sortedFields)
				{
					if (fieldSortDescription.Field == field)
					{
						this._sortedFields.Remove(fieldSortDescription);
						this._sortedFields.Insert(insertAtIndex, fieldSortDescription);
						break;
					}
				}
			}
			finally
			{
				this._sortedFields.EndUpdate();
			}
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00070C9C File Offset: 0x0006EE9C
		internal void ProcessApplyGrouping(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex)
		{
			this.ProcessApplyGrouping(field, insertAtIndex, true);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00070CA8 File Offset: 0x0006EEA8
		internal void ProcessApplyGrouping(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex, bool addToUndo)
		{
			if (addToUndo)
			{
				this.AddUndoAction(field);
			}
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescriptionForField = this.GetFieldSortDescriptionForField(field, this._sortedFields);
			if (fieldSortDescriptionForField != null)
			{
				this._sortedFields.BeginUpdate();
				this._sortedFields.Remove(fieldSortDescriptionForField);
			}
			try
			{
				global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescriptionForField2 = this.GetFieldSortDescriptionForField(field, this._groups);
				this._sortedFields.Insert(insertAtIndex, fieldSortDescriptionForField2);
			}
			finally
			{
				if (fieldSortDescriptionForField != null)
				{
					this._sortedFields.EndUpdate();
				}
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00070D24 File Offset: 0x0006EF24
		internal void ProcessApplyUnGroup(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.ProcessApplyUnGroup(field, true);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00070D30 File Offset: 0x0006EF30
		internal void ProcessApplyUnGroup(global::Infragistics.Windows.DataPresenter.Field field, bool addToUndo)
		{
			if (addToUndo)
			{
				this.AddUndoAction(field);
			}
			this._sortedFields.BeginUpdate();
			try
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in this._sortedFields)
				{
					if (fieldSortDescription.Field == field)
					{
						this._sortedFields.Remove(fieldSortDescription);
						break;
					}
				}
			}
			finally
			{
				this._sortedFields.EndUpdate();
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00070DC0 File Offset: 0x0006EFC0
		internal bool ProcessTryReGroup(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex)
		{
			foreach (global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription in this._groups)
			{
				if (fieldSortDescription.Field == field)
				{
					this._groups.Remove(fieldSortDescription);
					this._groups.Insert(insertAtIndex, fieldSortDescription);
					break;
				}
			}
			return this.RaiseGroupingEventHelper();
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00070E3C File Offset: 0x0006F03C
		internal bool ProcessTryGrouping(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex)
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescriptionForField = this.GetFieldSortDescriptionForField(field, this._groups);
			if (fieldSortDescriptionForField != null)
			{
				this._groups.Remove(fieldSortDescriptionForField);
			}
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = new global::Infragistics.Windows.DataPresenter.FieldSortDescription();
			fieldSortDescription.Field = field;
			fieldSortDescription.Direction = global::System.ComponentModel.ListSortDirection.Ascending;
			if (this._sortedFields.Contains(fieldSortDescription.Field, new bool?(true)))
			{
				fieldSortDescription.Direction = this._sortedFields[fieldSortDescription.Field, new bool?(true)].Direction;
			}
			fieldSortDescription.IsGroupBy = true;
			this._groups.Insert(insertAtIndex, fieldSortDescription);
			return this.RaiseGroupingEventHelper();
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00070ED8 File Offset: 0x0006F0D8
		internal bool ProcessTryUnGroup(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescriptionForField = this.GetFieldSortDescriptionForField(field, this._groups);
			if (fieldSortDescriptionForField == null)
			{
				return false;
			}
			this._groups.Remove(fieldSortDescriptionForField);
			return this.RaiseGroupingEventHelper();
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00070F10 File Offset: 0x0006F110
		internal bool RaiseGroupingEventHelper()
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription[] array = new global::Infragistics.Windows.DataPresenter.FieldSortDescription[this._groups.Count];
			this._groups.CopyTo(array);
			global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs groupingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs(this._fieldLayout, array);
			this.FieldLayout.DataPresenter.RaiseGrouping(groupingEventArgs);
			return !groupingEventArgs.Cancel;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00070F64 File Offset: 0x0006F164
		internal void RaiseGroupedEventHelper()
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription[] array = new global::Infragistics.Windows.DataPresenter.FieldSortDescription[this._groups.Count];
			this._groups.CopyTo(array);
			global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs(this._fieldLayout, array);
			this.FieldLayout.DataPresenter.RaiseGrouped(args);
		}

		// Token: 0x040009F2 RID: 2546
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040009F3 RID: 2547
		private global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection _sortedFields;

		// Token: 0x040009F4 RID: 2548
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> _groups;
	}
}
