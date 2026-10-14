using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000162 RID: 354
	internal class GroupingHelper
	{
		// Token: 0x060014BF RID: 5311 RVA: 0x0005EB38 File Offset: 0x0005CD38
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0005EBB6 File Offset: 0x0005CDB6
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0005EBBE File Offset: 0x0005CDBE
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> Groups
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0005EBC6 File Offset: 0x0005CDC6
		internal global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection SortedFields
		{
			get
			{
				return this._sortedFields;
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0005EBD0 File Offset: 0x0005CDD0
		private void AddUndoAction(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.FieldLayout.DataPresenter;
			if (dataPresenter != null && dataPresenter.IsUndoEnabled)
			{
				dataPresenter.History.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.GroupByAction(field));
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0005EC08 File Offset: 0x0005CE08
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

		// Token: 0x060014C5 RID: 5317 RVA: 0x0005EC5C File Offset: 0x0005CE5C
		internal void ProcessApplyReGroup(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex)
		{
			this.ProcessApplyReGroup(field, insertAtIndex, true);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0005EC68 File Offset: 0x0005CE68
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

		// Token: 0x060014C7 RID: 5319 RVA: 0x0005ED04 File Offset: 0x0005CF04
		internal void ProcessApplyGrouping(global::Infragistics.Windows.DataPresenter.Field field, int insertAtIndex)
		{
			this.ProcessApplyGrouping(field, insertAtIndex, true);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0005ED10 File Offset: 0x0005CF10
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

		// Token: 0x060014C9 RID: 5321 RVA: 0x0005ED8C File Offset: 0x0005CF8C
		internal void ProcessApplyUnGroup(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.ProcessApplyUnGroup(field, true);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0005ED98 File Offset: 0x0005CF98
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

		// Token: 0x060014CB RID: 5323 RVA: 0x0005EE28 File Offset: 0x0005D028
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

		// Token: 0x060014CC RID: 5324 RVA: 0x0005EEA4 File Offset: 0x0005D0A4
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
			if (this._sortedFields.Contains(fieldSortDescription.Field))
			{
				fieldSortDescription.Direction = this._sortedFields[fieldSortDescription.Field].Direction;
			}
			fieldSortDescription.IsGroupBy = true;
			this._groups.Insert(insertAtIndex, fieldSortDescription);
			return this.RaiseGroupingEventHelper();
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0005EF34 File Offset: 0x0005D134
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

		// Token: 0x060014CE RID: 5326 RVA: 0x0005EF6C File Offset: 0x0005D16C
		internal bool RaiseGroupingEventHelper()
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription[] array = new global::Infragistics.Windows.DataPresenter.FieldSortDescription[this._groups.Count];
			this._groups.CopyTo(array);
			global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs groupingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs(this._fieldLayout, array);
			this.FieldLayout.DataPresenter.RaiseGrouping(groupingEventArgs);
			return !groupingEventArgs.Cancel;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
		internal void RaiseGroupedEventHelper()
		{
			global::Infragistics.Windows.DataPresenter.FieldSortDescription[] array = new global::Infragistics.Windows.DataPresenter.FieldSortDescription[this._groups.Count];
			this._groups.CopyTo(array);
			global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs(this._fieldLayout, array);
			this.FieldLayout.DataPresenter.RaiseGrouped(args);
		}

		// Token: 0x0400083D RID: 2109
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400083E RID: 2110
		private global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection _sortedFields;

		// Token: 0x0400083F RID: 2111
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldSortDescription> _groups;
	}
}
