using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000018 RID: 24
	public class GroupByAreaBaseAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00003FC5 File Offset: 0x000021C5
		public GroupByAreaBaseAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaBase owner) : base(owner)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003FCE File Offset: 0x000021CE
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Group;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003FD2 File Offset: 0x000021D2
		protected override string GetClassNameCore()
		{
			return "GroupByAreaBase";
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003FD9 File Offset: 0x000021D9
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003FE8 File Offset: 0x000021E8
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState == global::System.Windows.Automation.ExpandCollapseState.LeafNode)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = (global::Infragistics.Windows.DataPresenter.GroupByAreaBase)base.Owner;
			groupByAreaBase.IsExpanded = false;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004028 File Offset: 0x00002228
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState == global::System.Windows.Automation.ExpandCollapseState.LeafNode)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = (global::Infragistics.Windows.DataPresenter.GroupByAreaBase)base.Owner;
			groupByAreaBase.IsExpanded = true;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004068 File Offset: 0x00002268
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = (global::Infragistics.Windows.DataPresenter.GroupByAreaBase)base.Owner;
				if (groupByAreaBase.IsExpanded)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
			}
		}
	}
}
