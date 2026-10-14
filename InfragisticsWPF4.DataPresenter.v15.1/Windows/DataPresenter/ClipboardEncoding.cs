using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000087 RID: 135
	internal abstract class ClipboardEncoding
	{
		// Token: 0x060006BF RID: 1727 RVA: 0x0001AB35 File Offset: 0x00018D35
		public virtual global::Infragistics.Windows.DataPresenter.CellValueHolder[,] GetCellValues(string format, global::System.Windows.IDataObject dataObject)
		{
			return null;
		}

		// Token: 0x060006C0 RID: 1728
		public abstract object GetClipboardData(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeaders);

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001AB38 File Offset: 0x00018D38
		protected virtual string GetHeaderText(global::Infragistics.Windows.DataPresenter.CellValueHolder cvh)
		{
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(cvh);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001AB40 File Offset: 0x00018D40
		protected virtual string GetCellText(global::Infragistics.Windows.DataPresenter.CellValueHolder cvh)
		{
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(cvh);
		}
	}
}
