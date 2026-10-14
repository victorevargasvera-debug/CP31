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
		// Token: 0x060000B2 RID: 178 RVA: 0x00003F9D File Offset: 0x0000219D
		public GroupByAreaBaseAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaBase owner) : base(owner)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003FA6 File Offset: 0x000021A6
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Group;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003FAA File Offset: 0x000021AA
		protected override string GetClassNameCore()
		{
			return "GroupByAreaBase";
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003FB1 File Offset: 0x000021B1
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003FC0 File Offset: 0x000021C0
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

		// Token: 0x060000B7 RID: 183 RVA: 0x00004000 File Offset: 0x00002200
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004040 File Offset: 0x00002240
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
