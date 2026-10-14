using System;
using System.Runtime.Serialization;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008B RID: 139
	internal class DataPresenterClipboardEncoding : global::Infragistics.Windows.DataPresenter.ClipboardEncoding
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x0001B95D File Offset: 0x00019B5D
		internal DataPresenterClipboardEncoding()
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0001B965 File Offset: 0x00019B65
		public override bool Equals(object obj)
		{
			return obj != null && obj.GetType() == base.GetType();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0001B980 File Offset: 0x00019B80
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder[,] GetCellValues(string format, global::System.Windows.IDataObject dataObject)
		{
			global::Infragistics.Windows.DataPresenter.CellValueHolder[,] result = null;
			if (dataObject.GetDataPresent(format))
			{
				global::Infragistics.Windows.DataPresenter.ClipboardData clipboardData = null;
				try
				{
					clipboardData = (dataObject.GetData(format) as global::Infragistics.Windows.DataPresenter.ClipboardData);
				}
				catch (global::System.Runtime.Serialization.SerializationException)
				{
				}
				if (clipboardData != null)
				{
					result = clipboardData.GetCellValues();
				}
			}
			return result;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		public override object GetClipboardData(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeaders)
		{
			return global::Infragistics.Windows.DataPresenter.ClipboardData.Create(cellValues);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0001B9D0 File Offset: 0x00019BD0
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
