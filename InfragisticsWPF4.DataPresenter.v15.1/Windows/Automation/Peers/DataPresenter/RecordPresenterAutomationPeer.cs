using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002C RID: 44
	public class RecordPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x0000749D File Offset: 0x0000569D
		public RecordPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordPresenter owner) : base(owner)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000074A6 File Offset: 0x000056A6
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000074AA File Offset: 0x000056AA
		protected override string GetClassNameCore()
		{
			return "RecordPresenter";
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000074B1 File Offset: 0x000056B1
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			this._lastPeers = base.GetChildrenCore();
			if (this.IsWithinRecordContainer)
			{
				return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			}
			return this._lastPeers;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000074D3 File Offset: 0x000056D3
		protected override bool IsControlElementCore()
		{
			return !this.IsWithinRecordContainer;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000074E0 File Offset: 0x000056E0
		internal bool IsWithinRecordContainer
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = base.Owner as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
				return dataPresenter != null && dataPresenter.CurrentViewInternal.RecordPresenterContainerType != null;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00007516 File Offset: 0x00005716
		internal global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetActualChildren()
		{
			base.GetChildren();
			return this._lastPeers;
		}

		// Token: 0x04000066 RID: 102
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> _lastPeers;
	}
}
