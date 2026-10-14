using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000073 RID: 115
	internal class SummaryAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x000171F1 File Offset: 0x000153F1
		private SummaryAction(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> added, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder> removed) : base(field.DataPresenter)
		{
			this._field = field;
			this._added = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryDefinition>(added);
			this._removed = global::Infragistics.Windows.DataPresenter.GridUtilities.ToArray<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>(removed);
			global::System.Array.Sort<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>(this._removed);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00017229 File Offset: 0x00015429
		protected internal override bool CanPerform(object context)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._field);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001723B File Offset: 0x0001543B
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (fieldLayout == this._field.Owner && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.Summaries) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001725C File Offset: 0x0001545C
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
			return global::Infragistics.Windows.DataPresenter.SummaryAction.Create(this._field, oldDefinitionList, list2, list);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00017354 File Offset: 0x00015554
		internal static global::Infragistics.Windows.DataPresenter.SummaryAction Create(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.SummaryDefinition> oldDefinitionList, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsRemoved, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.SummaryDefinition> definitionsAdded)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.DataPresenter;
			if (dataPresenter == null || !dataPresenter.IsUndoEnabled)
			{
				return null;
			}
			if (definitionsAdded.Count == 0 && definitionsRemoved.Count == 0)
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
			return new global::Infragistics.Windows.DataPresenter.SummaryAction(field, list2, list);
		}

		// Token: 0x040001BB RID: 443
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040001BC RID: 444
		private global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder[] _removed;

		// Token: 0x040001BD RID: 445
		private global::Infragistics.Windows.DataPresenter.SummaryDefinition[] _added;

		// Token: 0x02000074 RID: 116
		private class SummaryDefinitionHolder : global::System.IComparable<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>
		{
			// Token: 0x060005DB RID: 1499 RVA: 0x00017430 File Offset: 0x00015630
			internal SummaryDefinitionHolder(global::Infragistics.Windows.DataPresenter.SummaryDefinition definition, int index)
			{
				this.Definition = definition;
				this.Index = index;
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x00017446 File Offset: 0x00015646
			int global::System.IComparable<global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder>.CompareTo(global::Infragistics.Windows.DataPresenter.SummaryAction.SummaryDefinitionHolder other)
			{
				if (other == null)
				{
					return 1;
				}
				return this.Index.CompareTo(other.Index);
			}

			// Token: 0x040001BE RID: 446
			internal global::Infragistics.Windows.DataPresenter.SummaryDefinition Definition;

			// Token: 0x040001BF RID: 447
			internal int Index;
		}
	}
}
