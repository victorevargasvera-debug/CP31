using System;
using System.Text;
using System.Windows.Forms;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x020003E4 RID: 996
	[global::System.Serializable]
	internal class RangeData
	{
		// Token: 0x06002C74 RID: 11380 RVA: 0x00095538 File Offset: 0x00093738
		static RangeData()
		{
			global::System.Windows.Forms.DataFormats.GetFormat("SourceGrid.RangeData");
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x00095550 File Offset: 0x00093750
		public global::SourceGrid.Range SourceRange
		{
			get
			{
				return this.mSourceRange;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002C77 RID: 11383 RVA: 0x00095558 File Offset: 0x00093758
		public string[,] SourceValues
		{
			get
			{
				return this.mSourceValues;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x00095560 File Offset: 0x00093760
		public global::SourceGrid.Position StartDragPosition
		{
			get
			{
				return this.mStartDragPosition;
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x00095568 File Offset: 0x00093768
		public global::SourceGrid.GridVirtual SourceGrid
		{
			get
			{
				return this.mSourceGrid;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x00095570 File Offset: 0x00093770
		public global::SourceGrid.CutMode CutMode
		{
			get
			{
				return this.mCutMode;
			}
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00095578 File Offset: 0x00093778
		public void LoadData(global::SourceGrid.GridVirtual sourceGrid, global::SourceGrid.Range sourceRange, global::SourceGrid.Position startDragPosition, global::SourceGrid.CutMode cutMode)
		{
			this.mSourceGrid = sourceGrid;
			this.mCutMode = cutMode;
			this.mStartDragPosition = startDragPosition;
			this.mSourceRange = sourceRange;
			this.mSourceValues = new string[this.mSourceRange.RowsCount, this.mSourceRange.ColumnsCount];
			int num = 0;
			int i = this.mSourceRange.Start.Row;
			while (i <= this.mSourceRange.End.Row)
			{
				int num2 = 0;
				int j = this.mSourceRange.Start.Column;
				while (j <= this.mSourceRange.End.Column)
				{
					global::SourceGrid.Position position = new global::SourceGrid.Position(i, j);
					global::SourceGrid.Cells.ICellVirtual cell = sourceGrid.GetCell(position);
					global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(sourceGrid, position, cell);
					if (cell != null && cell.Editor != null && cell.Editor.IsStringConversionSupported())
					{
						this.mSourceValues[num, num2] = cell.Editor.ValueToString(cell.Model.ValueModel.GetValue(cellContext));
					}
					else if (cell != null)
					{
						this.mSourceValues[num, num2] = cellContext.DisplayText;
					}
					j++;
					num2++;
				}
				i++;
				num++;
			}
			if (this.CutMode == global::SourceGrid.CutMode.CutImmediately && sourceGrid != null)
			{
				sourceGrid.ClearValues(new global::SourceGrid.RangeRegion(sourceRange));
			}
			this.mClipboardDataObject = new global::System.Windows.Forms.DataObject();
			this.mClipboardDataObject.SetData("SourceGrid.RangeData", this);
			this.mClipboardDataObject.SetData(typeof(string), this.DataToString(this.mSourceValues, this.mSourceRange));
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00095738 File Offset: 0x00093938
		public void LoadData(string data)
		{
			this.mSourceGrid = null;
			this.mCutMode = global::SourceGrid.CutMode.None;
			this.mStartDragPosition = new global::SourceGrid.Position(0, 0);
			this.StringToData(data, out this.mSourceRange, out this.mSourceValues);
			this.mClipboardDataObject = new global::System.Windows.Forms.DataObject();
			this.mClipboardDataObject.SetData("SourceGrid.RangeData", this);
			this.mClipboardDataObject.SetData(typeof(string), this.DataToString(this.mSourceValues, this.mSourceRange));
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000957BC File Offset: 0x000939BC
		public void WriteData(global::SourceGrid.GridVirtual destinationGrid, global::SourceGrid.Range destinationRange)
		{
			global::SourceGrid.Range range = this.mSourceRange;
			range.MoveTo(destinationRange.Start);
			if (range.ColumnsCount > destinationRange.ColumnsCount)
			{
				range.ColumnsCount = destinationRange.ColumnsCount;
			}
			if (range.RowsCount > destinationRange.RowsCount)
			{
				range.RowsCount = destinationRange.RowsCount;
			}
			if (this.CutMode == global::SourceGrid.CutMode.CutOnPaste && this.mSourceGrid != null)
			{
				for (int i = this.mSourceRange.Start.Row; i <= this.mSourceRange.End.Row; i++)
				{
					for (int j = this.mSourceRange.Start.Column; j <= this.mSourceRange.End.Column; j++)
					{
						global::SourceGrid.Position pPosition = new global::SourceGrid.Position(i, j);
						global::SourceGrid.Cells.ICellVirtual cell = this.mSourceGrid.GetCell(i, j);
						global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this.mSourceGrid, pPosition, cell);
						if (cell.Editor != null)
						{
							cell.Editor.ClearCell(cellContext);
						}
					}
				}
			}
			int num = 0;
			int k = range.Start.Row;
			while (k <= range.End.Row)
			{
				int num2 = 0;
				int l = range.Start.Column;
				while (l <= range.End.Column)
				{
					global::SourceGrid.Position position = new global::SourceGrid.Position(k, l);
					global::SourceGrid.Cells.ICellVirtual cell2 = destinationGrid.GetCell(position);
					global::SourceGrid.CellContext cellContext2 = new global::SourceGrid.CellContext(destinationGrid, position, cell2);
					if (cell2 != null && cell2.Editor != null && this.mSourceValues[num, num2] != null)
					{
						cell2.Editor.SetCellValue(cellContext2, this.mSourceValues[num, num2]);
					}
					l++;
					num2++;
				}
				k++;
				num++;
			}
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000959D0 File Offset: 0x00093BD0
		protected virtual void StringToData(string data, out global::SourceGrid.Range range, out string[,] values)
		{
			data = data.Replace("\r\n", "\n");
			string[] array = data.Split(new char[]
			{
				'\n',
				'\r'
			});
			int num = array.Length;
			if (num > 0 && (array[num - 1] == null || array[num - 1].Length == 0))
			{
				num--;
			}
			if (num == 0)
			{
				range = global::SourceGrid.Range.Empty;
				values = new string[0, 0];
				return;
			}
			string[] array2 = array[0].Split(new char[]
			{
				'\t'
			});
			int num2 = array2.Length;
			range = new global::SourceGrid.Range(0, 0, num - 1, num2 - 1);
			values = new string[num, num2];
			int num3 = 0;
			int i = range.Start.Row;
			while (i < range.Start.Row + num)
			{
				string text = array[num3];
				string[] array3 = text.Split(new char[]
				{
					'\t'
				});
				int num4 = 0;
				int j = range.Start.Column;
				while (j <= range.End.Column)
				{
					if (num4 < array3.Length)
					{
						values[num3, num4] = array3[num4];
					}
					else
					{
						values[num3, num4] = "";
					}
					j++;
					num4++;
				}
				i++;
				num3++;
			}
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00095B64 File Offset: 0x00093D64
		protected virtual string DataToString(string[,] values, global::SourceGrid.Range range)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			int i = range.Start.Row;
			while (i <= range.End.Row)
			{
				int num2 = 0;
				int j = range.Start.Column;
				while (j <= range.End.Column)
				{
					stringBuilder.Append(values[num, num2]);
					if (j != range.End.Column)
					{
						stringBuilder.Append('\t');
					}
					j++;
					num2++;
				}
				if (i != range.End.Row)
				{
					stringBuilder.Append("\r\n");
				}
				i++;
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x00095C44 File Offset: 0x00093E44
		public global::SourceGrid.Range FindDestinationRange(global::SourceGrid.GridVirtual destinationGrid, global::SourceGrid.Position dropDestination)
		{
			if (dropDestination.IsEmpty())
			{
				return global::SourceGrid.Range.Empty;
			}
			global::SourceGrid.Position position = new global::SourceGrid.Position(dropDestination.Row + (this.mSourceRange.Start.Row - this.mStartDragPosition.Row), dropDestination.Column + (this.mSourceRange.Start.Column - this.mStartDragPosition.Column));
			position = global::SourceGrid.Position.Max(position, new global::SourceGrid.Position(0, 0));
			global::SourceGrid.Range range = this.mSourceRange;
			range.MoveTo(position);
			return range.Intersect(destinationGrid.CompleteRange);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00095CE8 File Offset: 0x00093EE8
		public static void ClipboardSetData(global::SourceGrid.RangeData rangeData)
		{
			if (rangeData.mClipboardDataObject == null)
			{
				throw new global::SourceGrid.SourceGridException("No data loaded, use the LoadData method");
			}
			global::System.Windows.Forms.Clipboard.SetDataObject(rangeData.mClipboardDataObject);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x00095D0C File Offset: 0x00093F0C
		public static global::SourceGrid.RangeData ClipboardGetData()
		{
			global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
			global::SourceGrid.RangeData rangeData = null;
			if (dataObject.GetDataPresent("SourceGrid.RangeData"))
			{
				rangeData = (global::SourceGrid.RangeData)dataObject.GetData("SourceGrid.RangeData");
			}
			else if (dataObject.GetDataPresent(global::System.Windows.Forms.DataFormats.Text, true))
			{
				string data = (string)dataObject.GetData(global::System.Windows.Forms.DataFormats.Text, true);
				rangeData = new global::SourceGrid.RangeData();
				rangeData.LoadData(data);
			}
			return rangeData;
		}

		// Token: 0x04000F1A RID: 3866
		public const string RANGEDATA_FORMAT = "SourceGrid.RangeData";

		// Token: 0x04000F1B RID: 3867
		private global::SourceGrid.Position mStartDragPosition;

		// Token: 0x04000F1C RID: 3868
		private global::SourceGrid.Range mSourceRange;

		// Token: 0x04000F1D RID: 3869
		private string[,] mSourceValues;

		// Token: 0x04000F1E RID: 3870
		[global::System.NonSerialized]
		private global::SourceGrid.GridVirtual mSourceGrid;

		// Token: 0x04000F1F RID: 3871
		private global::SourceGrid.CutMode mCutMode;

		// Token: 0x04000F20 RID: 3872
		[global::System.NonSerialized]
		private global::System.Windows.Forms.DataObject mClipboardDataObject;
	}
}
