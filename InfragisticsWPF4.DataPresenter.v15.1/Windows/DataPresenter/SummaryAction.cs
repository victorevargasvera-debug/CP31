using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000078 RID: 120
	internal class SummaryAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000651 RID: 1617 RVA: 0x0001967C File Offset: 0x0001787C
		private SummaryAction(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> added, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder> removed, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> summariesShown, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> summariesHidden) : base(field.DataPresenter)
		{
			this._field = field;
			this._added = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(added);
			this._removed = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>(removed);
			this._summariesShown = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(summariesShown);
			this._summariesHidden = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(summariesHidden);
			global::System.Array.Sort<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>(this._removed);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000196D9 File Offset: 0x000178D9
		protected internal override bool CanPerform(object context)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._field);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000196EB File Offset: 0x000178EB
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._field.Owner && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.Summaries) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0001970C File Offset: 0x0001790C
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = this._field.Owner;
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitions = owner.SummaryDefinitions;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> oldDefinitionList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(summaryDefinitions);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition item in this._added)
			{
				int num = summaryDefinitions.IndexOf(item);
				if (num >= 0)
				{
					list2.Add(item);
					summaryDefinitions.RemoveAt(num);
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder summaryDefinitionHolder in this._removed)
			{
				global::Infragistics.Windows.DataPresenter.SummaryDefinition definition = summaryDefinitionHolder.Definition;
				int num2 = summaryDefinitions.IndexOf(definition);
				if (num2 < 0)
				{
					num2 = global::System.Math.Max(0, global::System.Math.Min(summaryDefinitionHolder.Index, summaryDefinitions.Count));
					summaryDefinitions.Insert(num2, definition);
					list.Add(definition);
				}
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> list4 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition in this._summariesShown)
			{
				if (summaryDefinitions.Contains(summaryDefinition))
				{
					summaryDefinition.IsVisible = false;
					list4.Add(summaryDefinition);
				}
			}
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition2 in this._summariesHidden)
			{
				if (summaryDefinitions.Contains(summaryDefinition2))
				{
					summaryDefinition2.IsVisible = true;
					list3.Add(summaryDefinition2);
				}
			}
			return global::Infragistics.Windows.DataPresenter.SummaryAction.Create(this._field, oldDefinitionList, list2, list, list3, list4);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00019890 File Offset: 0x00017A90
		internal static global::Infragistics.Windows.DataPresenter.SummaryAction Create(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> oldDefinitionList, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsRemoved, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsAdded, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsShown, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsHidden)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
			if (dataPresenter == null || !dataPresenter.IsUndoEnabled)
			{
				return null;
			}
			if (definitionsAdded.Count == 0 && definitionsRemoved.Count == 0 && definitionsShown.Count == 0 && definitionsHidden.Count == 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition>();
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition summaryDefinition in definitionsRemoved)
			{
				int index = oldDefinitionList.IndexOf(summaryDefinition);
				list.Add(new global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder(summaryDefinition, index));
			}
			foreach (global::Infragistics.Windows.DataPresenter.SummaryDefinition item in definitionsAdded)
			{
				list2.Add(item);
			}
			return new global::Infragistics.Windows.DataPresenter.SummaryAction(field, list2, list, definitionsShown, definitionsHidden);
		}

		// Token: 0x040001F5 RID: 501
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040001F6 RID: 502
		private global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder[] _removed;

		// Token: 0x040001F7 RID: 503
		private global::Infragistics.Windows.DataPresenter.SummaryDefinition[] _added;

		// Token: 0x040001F8 RID: 504
		private global::Infragistics.Windows.DataPresenter.SummaryDefinition[] _summariesShown;

		// Token: 0x040001F9 RID: 505
		private global::Infragistics.Windows.DataPresenter.SummaryDefinition[] _summariesHidden;

		// Token: 0x02000079 RID: 121
		private class SummaryDefinitionHolder : global::System.IComparable<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>
		{
			// Token: 0x06000656 RID: 1622 RVA: 0x00019980 File Offset: 0x00017B80
			internal SummaryDefinitionHolder(global::Infragistics.Windows.DataPresenter.SummaryDefinition definition, int index)
			{
				this.Definition = definition;
				this.Index = index;
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x00019996 File Offset: 0x00017B96
			int global::System.IComparable<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>.CompareTo(global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder other)
			{
				if (other == null)
				{
					return 1;
				}
				return this.Index.CompareTo(other.Index);
			}

			// Token: 0x040001FA RID: 506
			internal global::Infragistics.Windows.DataPresenter.SummaryDefinition Definition;

			// Token: 0x040001FB RID: 507
			internal int Index;
		}
	}
}
