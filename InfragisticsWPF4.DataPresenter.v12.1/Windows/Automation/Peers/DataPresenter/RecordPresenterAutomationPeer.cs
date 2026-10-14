using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002C RID: 44
	public class RecordPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00007079 File Offset: 0x00005279
		public RecordPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordPresenter owner) : base(owner)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007082 File Offset: 0x00005282
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007086 File Offset: 0x00005286
		protected override string GetClassNameCore()
		{
			return "RecordPresenter";
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000708D File Offset: 0x0000528D
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			this._lastPeers = base.GetChildrenCore();
			if (this.IsWithinRecordContainer)
			{
				return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			}
			return this._lastPeers;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000070AF File Offset: 0x000052AF
		protected override bool IsControlElementCore()
		{
			return !this.IsWithinRecordContainer;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000070BC File Offset: 0x000052BC
		internal bool IsWithinRecordContainer
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = base.Owner as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
				return dataPresenter != null && dataPresenter.CurrentViewInternal.RecordPresenterContainerType != null;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000070F2 File Offset: 0x000052F2
		internal global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetActualChildren()
		{
			base.GetChildren();
			return this._lastPeers;
		}

		// Token: 0x04000056 RID: 86
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> _lastPeers;
	}
}
