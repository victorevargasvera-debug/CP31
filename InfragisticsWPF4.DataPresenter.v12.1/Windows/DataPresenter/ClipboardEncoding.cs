using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000082 RID: 130
	internal abstract class ClipboardEncoding
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x000185A1 File Offset: 0x000167A1
		public virtual global::Infragistics.Windows.DataPresenter.CellValueHolder[,] GetCellValues(string format, global::System.Windows.IDataObject dataObject)
		{
			return null;
		}

		// Token: 0x06000644 RID: 1604
		public abstract object GetClipboardData(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeaders);

		// Token: 0x06000645 RID: 1605 RVA: 0x000185A4 File Offset: 0x000167A4
		protected virtual string GetHeaderText(global::Infragistics.Windows.DataPresenter.CellValueHolder cvh)
		{
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(cvh);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000185AC File Offset: 0x000167AC
		protected virtual string GetCellText(global::Infragistics.Windows.DataPresenter.CellValueHolder cvh)
		{
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(cvh);
		}
	}
}
