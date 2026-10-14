using System;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200015A RID: 346
	public interface IViewPanel
	{
		// Token: 0x0600139E RID: 5022
		global::Infragistics.Windows.DataPresenter.Record GetNavigationTargetRecord(global::Infragistics.Windows.DataPresenter.Record currentRecord, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Type restrictToRecordType);

		// Token: 0x0600139F RID: 5023
		bool EnsureRecordIsVisible(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060013A0 RID: 5024
		bool EnsureCellIsVisible(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060013A1 RID: 5025
		void Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType scrollType);

		// Token: 0x060013A2 RID: 5026
		void OnActiveRecordChanged(global::Infragistics.Windows.DataPresenter.Record record);

		// Token: 0x060013A3 RID: 5027
		void OnSelectedItemsChanged();

		// Token: 0x060013A4 RID: 5028
		global::Infragistics.Windows.DataPresenter.Record GetFirstDisplayedRecord(global::System.Type recordType);

		// Token: 0x060013A5 RID: 5029
		global::Infragistics.Windows.DataPresenter.Record GetLastDisplayedRecord(global::System.Type recordType);

		// Token: 0x060013A6 RID: 5030
		global::Infragistics.Windows.DataPresenter.Record GetFirstOverallRecord(global::System.Type recordType);

		// Token: 0x060013A7 RID: 5031
		global::Infragistics.Windows.DataPresenter.Record GetLastOverallRecord(global::System.Type recordType);

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060013A8 RID: 5032
		global::Infragistics.Windows.DataPresenter.PanelLayoutStyle LayoutStyle { get; }
	}
}
