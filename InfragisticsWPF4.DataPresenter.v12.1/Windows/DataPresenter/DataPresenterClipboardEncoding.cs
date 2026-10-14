using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000086 RID: 134
	internal class DataPresenterClipboardEncoding : global::Infragistics.Windows.DataPresenter.ClipboardEncoding
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x000193B5 File Offset: 0x000175B5
		internal DataPresenterClipboardEncoding()
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000193BD File Offset: 0x000175BD
		public override bool Equals(object obj)
		{
			return obj != null && obj.GetType() == base.GetType();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x000193D8 File Offset: 0x000175D8
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder[,] GetCellValues(string format, global::System.Windows.IDataObject dataObject)
		{
			global::Infragistics.Windows.DataPresenter.CellValueHolder[,] result = null;
			if (dataObject.GetDataPresent(format))
			{
				global::Infragistics.Windows.DataPresenter.ClipboardData clipboardData = dataObject.GetData(format) as global::Infragistics.Windows.DataPresenter.ClipboardData;
				if (clipboardData != null)
				{
					result = clipboardData.GetCellValues();
				}
			}
			return result;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00019408 File Offset: 0x00017608
		public override object GetClipboardData(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeaders)
		{
			return global::Infragistics.Windows.DataPresenter.ClipboardData.Create(cellValues);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00019410 File Offset: 0x00017610
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
