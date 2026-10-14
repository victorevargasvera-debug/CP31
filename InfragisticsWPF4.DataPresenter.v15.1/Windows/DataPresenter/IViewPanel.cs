using System;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000176 RID: 374
	public interface IViewPanel
	{
		// Token: 0x06001716 RID: 5910
		global::Infragistics.Windows.DataPresenter.Record GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType);

		// Token: 0x06001717 RID: 5911
		bool EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x06001718 RID: 5912
		bool EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x06001719 RID: 5913
		void Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType scrollType);

		// Token: 0x0600171A RID: 5914
		void OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x0600171B RID: 5915
		void OnSelectedItemsChanged();

		// Token: 0x0600171C RID: 5916
		global::Infragistics.Windows.DataPresenter.Record GetFirstDisplayedRecord(global::System.Type recordType);

		// Token: 0x0600171D RID: 5917
		global::Infragistics.Windows.DataPresenter.Record GetLastDisplayedRecord(global::System.Type recordType);

		// Token: 0x0600171E RID: 5918
		global::Infragistics.Windows.DataPresenter.Record GetFirstOverallRecord(global::System.Type recordType);

		// Token: 0x0600171F RID: 5919
		global::Infragistics.Windows.DataPresenter.Record GetLastOverallRecord(global::System.Type recordType);

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001720 RID: 5920
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle LayoutStyle { get; }
	}
}
