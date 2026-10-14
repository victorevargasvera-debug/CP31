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
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E3 RID: 227
		bool IsHorizontalRowLayout { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E4 RID: 228
		bool IsRootLevel { get; }

		// Token: 0x060000E5 RID: 229
		global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060000E6 RID: 230
		global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060000E7 RID: 231
		bool CouldSupportGridPattern();

		// Token: 0x060000E8 RID: 232
		global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetRecordCollection();

		// Token: 0x060000E9 RID: 233
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> GetRecordList();

		// Token: 0x060000EA RID: 234
		int GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060000EB RID: 235
		global::System.Windows.Automation.Peers.AutomationPeer GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060000EC RID: 236
		global::System.Windows.Automation.Provider.IRawElementProviderSimple ProviderFromPeer(global::System.Windows.Automation.Peers.AutomationPeer peer);
	}
}
