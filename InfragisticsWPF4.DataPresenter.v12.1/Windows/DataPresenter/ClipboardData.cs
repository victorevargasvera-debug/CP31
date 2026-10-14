using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000081 RID: 129
	[global::System.Serializable]
	internal class ClipboardData
	{
		// Token: 0x0600063F RID: 1599 RVA: 0x000183FC File Offset: 0x000165FC
		private ClipboardData()
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00018404 File Offset: 0x00016604
		internal static object Create(global::Infragistics.Windows.DataPresenter.CellValueHolderCollection cellValues)
		{
			int num = cellValues.RecordCount * cellValues.FieldCount;
			object[] array = new object[num];
			string[] array2 = new string[num];
			bool[] array3 = new bool[num];
			int num2 = 0;
			int recordCount = cellValues.RecordCount;
			int fieldCount = cellValues.FieldCount;
			for (int i = 0; i < recordCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = cellValues.GetRecord(i);
				for (int j = 0; j < fieldCount; j++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = cellValues.GetField(j);
					global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
					object cellValue = record.GetCellValue(field, true);
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsSerializable(cellValue))
					{
						array[num2] = cellValue;
						array3[num2] = true;
					}
					array2[num2] = cachedConverter.ConvertCellValue(cellValue);
					num2++;
				}
			}
			return new global::Infragistics.Windows.DataPresenter.ClipboardData
			{
				_cellValues = array,
				_displayTexts = array2,
				_columnCount = cellValues.FieldCount,
				_hasOriginalValues = array3
			};
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000184E8 File Offset: 0x000166E8
		internal global::Infragistics.Windows.DataPresenter.CellValueHolder[,] GetCellValues()
		{
			global::Infragistics.Windows.DataPresenter.CellValueHolder[,] array = null;
			if (this._cellValues != null && this._columnCount > 0)
			{
				int num = this._cellValues.Length / this._columnCount;
				array = new global::Infragistics.Windows.DataPresenter.CellValueHolder[num, this._columnCount];
				for (int i = 0; i < this._cellValues.Length; i++)
				{
					int num2 = i / this._columnCount;
					int num3 = i % this._columnCount;
					global::Infragistics.Windows.DataPresenter.CellValueHolder cellValueHolder;
					if (this._hasOriginalValues[i])
					{
						cellValueHolder = new global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder(this._displayTexts[i], true, this._cellValues[i], this._displayTexts[i]);
					}
					else
					{
						cellValueHolder = new global::Infragistics.Windows.DataPresenter.CellValueHolder(this._displayTexts[i], true);
					}
					array[num2, num3] = cellValueHolder;
				}
			}
			return array;
		}

		// Token: 0x040001DE RID: 478
		private object[] _cellValues;

		// Token: 0x040001DF RID: 479
		private string[] _displayTexts;

		// Token: 0x040001E0 RID: 480
		private int _columnCount;

		// Token: 0x040001E1 RID: 481
		private bool[] _hasOriginalValues;
	}
}
