using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000027 RID: 39
	public class ConditionalFormatProxyCollection : global::Infragistics.FormattingRuleCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000A7CC File Offset: 0x000089CC
		public global::Infragistics.FormattingRuleCollection<global::Infragistics.IRule> GenerateIRuleCollection()
		{
			global::Infragistics.FormattingRuleCollection<global::Infragistics.IRule> formattingRuleCollection = new global::Infragistics.FormattingRuleCollection<global::Infragistics.IRule>();
			foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy item in this.Items)
			{
				formattingRuleCollection.Add(item);
			}
			return formattingRuleCollection;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A820 File Offset: 0x00008A20
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> GetCellScopedConditionsForKey(string key)
		{
			if (!this._proxys.ContainsKey(key))
			{
				this._proxys.Add(key, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>(new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>()));
			}
			return this._proxys[key];
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A854 File Offset: 0x00008A54
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> GetRowScopedConditions()
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>();
			foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy in this.Items)
			{
				if (conditionalFormattingRuleProxy.Parent.StyleScope == global::Infragistics.Controls.Grids.StyleScope.Row)
				{
					list.Add(conditionalFormattingRuleProxy);
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>(list);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A8BC File Offset: 0x00008ABC
		protected override void OnItemAdded(int index, global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy item)
		{
			base.OnItemAdded(index, item);
			if (item.Parent.Column != null)
			{
				string key = item.Parent.Column.Key;
				if (key == null)
				{
					return;
				}
				if (!this._proxys.ContainsKey(key))
				{
					this._proxys.Add(key, null);
				}
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>();
				foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy in this.Items)
				{
					if (conditionalFormattingRuleProxy.Parent.Column.Key == key && conditionalFormattingRuleProxy.Parent.StyleScope == global::Infragistics.Controls.Grids.StyleScope.Cell)
					{
						list.Add(conditionalFormattingRuleProxy);
					}
				}
				this._proxys[key] = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>(list);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A990 File Offset: 0x00008B90
		protected override void OnItemRemoved(int index, global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy item)
		{
			base.OnItemRemoved(index, item);
			string key = item.Parent.Column.Key;
			if (this._proxys.ContainsKey(key))
			{
				this._proxys[key] = null;
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A9D1 File Offset: 0x00008BD1
		public override void Clear()
		{
			base.Clear();
			this._proxys = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>>();
		}

		// Token: 0x0400007B RID: 123
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>> _proxys = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy>>();
	}
}
