using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001F RID: 31
	public interface IRecordListAutomationPeer
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D8 RID: 216
		bool IsHorizontalRowLayout { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D9 RID: 217
		bool IsRootLevel { get; }

		// Token: 0x060000DA RID: 218
		global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060000DB RID: 219
		global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060000DC RID: 220
		bool CouldSupportGridPattern();

		// Token: 0x060000DD RID: 221
		global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetRecordCollection();

		// Token: 0x060000DE RID: 222
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> GetRecordList();

		// Token: 0x060000DF RID: 223
		int GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060000E0 RID: 224
		global::System.Windows.Automation.Peers.AutomationPeer GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060000E1 RID: 225
		global::System.Windows.Automation.Provider.IRawElementProviderSimple ProviderFromPeer(global::System.Windows.Automation.Peers.AutomationPeer peer);
	}
}
