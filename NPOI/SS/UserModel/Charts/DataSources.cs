using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000096 RID: 150
	public class DataSources
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0000253E File Offset: 0x0000073E
		private DataSources()
		{
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000D9CF File Offset: 0x0000BBCF
		public static global::NPOI.SS.UserModel.Charts.IChartDataSource<T> FromArray<T>(T[] elements)
		{
			return new global::NPOI.SS.UserModel.Charts.DataSources.ArrayDataSource<T>(elements);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000D9D7 File Offset: 0x0000BBD7
		public static global::NPOI.SS.UserModel.Charts.IChartDataSource<double> FromNumericCellRange(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress cellRangeAddress)
		{
			return new global::NPOI.SS.UserModel.Charts.DataSources.DoubleCellRangeDataSource(sheet, cellRangeAddress);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		public static global::NPOI.SS.UserModel.Charts.IChartDataSource<string> FromStringCellRange(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress cellRangeAddress)
		{
			return new global::NPOI.SS.UserModel.Charts.DataSources.StringCellRangeDataSource(sheet, cellRangeAddress);
		}

		// Token: 0x0200055D RID: 1373
		private class DoubleCellRangeDataSource : global::NPOI.SS.UserModel.Charts.DataSources.AbstractCellRangeDataSource<double>
		{
			// Token: 0x0600339A RID: 13210 RVA: 0x000A135B File Offset: 0x0009F55B
			public DoubleCellRangeDataSource(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress cellRangeAddress) : base(sheet, cellRangeAddress)
			{
			}

			// Token: 0x0600339B RID: 13211 RVA: 0x000A1368 File Offset: 0x0009F568
			public override double GetPointAt(int index)
			{
				global::NPOI.SS.UserModel.CellValue cellValueAt = base.GetCellValueAt(index);
				if (cellValueAt != null && cellValueAt.CellType == global::NPOI.SS.UserModel.CellType.Numeric)
				{
					return cellValueAt.NumberValue;
				}
				return double.NaN;
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x0600339C RID: 13212 RVA: 0x00008875 File Offset: 0x00006A75
			public override bool IsNumeric
			{
				get
				{
					return true;
				}
			}
		}

		// Token: 0x0200055E RID: 1374
		private class StringCellRangeDataSource : global::NPOI.SS.UserModel.Charts.DataSources.AbstractCellRangeDataSource<string>
		{
			// Token: 0x0600339D RID: 13213 RVA: 0x000A1398 File Offset: 0x0009F598
			public StringCellRangeDataSource(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress cellRangeAddress) : base(sheet, cellRangeAddress)
			{
			}

			// Token: 0x0600339E RID: 13214 RVA: 0x000A13A4 File Offset: 0x0009F5A4
			public override string GetPointAt(int index)
			{
				global::NPOI.SS.UserModel.CellValue cellValueAt = base.GetCellValueAt(index);
				if (cellValueAt != null && cellValueAt.CellType == global::NPOI.SS.UserModel.CellType.String)
				{
					return cellValueAt.StringValue;
				}
				return null;
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x0600339F RID: 13215 RVA: 0x00006EB4 File Offset: 0x000050B4
			public override bool IsNumeric
			{
				get
				{
					return false;
				}
			}
		}

		// Token: 0x0200055F RID: 1375
		private class ArrayDataSource<T> : global::NPOI.SS.UserModel.Charts.IChartDataSource<T>
		{
			// Token: 0x060033A0 RID: 13216 RVA: 0x000A13CD File Offset: 0x0009F5CD
			public ArrayDataSource(T[] elements)
			{
				this.elements = (T[])elements.Clone();
			}

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000A13E6 File Offset: 0x0009F5E6
			public int PointCount
			{
				get
				{
					return this.elements.Length;
				}
			}

			// Token: 0x060033A2 RID: 13218 RVA: 0x000A13F0 File Offset: 0x0009F5F0
			public T GetPointAt(int index)
			{
				return this.elements[index];
			}

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00006EB4 File Offset: 0x000050B4
			public bool IsReference
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x060033A4 RID: 13220 RVA: 0x000A1400 File Offset: 0x0009F600
			public bool IsNumeric
			{
				get
				{
					global::System.Type typeFromHandle = typeof(double);
					foreach (T o in this.elements)
					{
						if (!typeFromHandle.IsInstanceOfType(o))
						{
							return false;
						}
					}
					return true;
				}
			}

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x060033A5 RID: 13221 RVA: 0x000A1446 File Offset: 0x0009F646
			public string FormulaString
			{
				get
				{
					throw new global::System.InvalidOperationException("Literal data source can not be expressed by reference.");
				}
			}

			// Token: 0x04001881 RID: 6273
			private T[] elements;
		}

		// Token: 0x02000560 RID: 1376
		private abstract class AbstractCellRangeDataSource<T> : global::NPOI.SS.UserModel.Charts.IChartDataSource<T>
		{
			// Token: 0x060033A6 RID: 13222 RVA: 0x000A1454 File Offset: 0x0009F654
			protected AbstractCellRangeDataSource(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress cellRangeAddress)
			{
				this.sheet = sheet;
				this.cellRangeAddress = cellRangeAddress.Copy();
				this.numOfCells = this.cellRangeAddress.NumberOfCells;
				this.evaluator = sheet.Workbook.GetCreationHelper().CreateFormulaEvaluator();
			}

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x060033A7 RID: 13223 RVA: 0x000A14A1 File Offset: 0x0009F6A1
			public int PointCount
			{
				get
				{
					return this.numOfCells;
				}
			}

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x060033A8 RID: 13224 RVA: 0x00008875 File Offset: 0x00006A75
			public bool IsReference
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060033A9 RID: 13225
			public abstract T GetPointAt(int index);

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x060033AA RID: 13226
			public abstract bool IsNumeric { get; }

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x060033AB RID: 13227 RVA: 0x000A14A9 File Offset: 0x0009F6A9
			public string FormulaString
			{
				get
				{
					return this.cellRangeAddress.FormatAsString(this.sheet.SheetName, true);
				}
			}

			// Token: 0x060033AC RID: 13228 RVA: 0x000A14C4 File Offset: 0x0009F6C4
			protected global::NPOI.SS.UserModel.CellValue GetCellValueAt(int index)
			{
				if (index < 0 || index >= this.numOfCells)
				{
					throw new global::System.IndexOutOfRangeException("Index must be between 0 and " + (this.numOfCells - 1).ToString() + " (inclusive), given: " + index.ToString());
				}
				int firstRow = this.cellRangeAddress.FirstRow;
				int firstColumn = this.cellRangeAddress.FirstColumn;
				int num = this.cellRangeAddress.LastColumn - firstColumn + 1;
				int rownum = firstRow + index / num;
				int cellnum = firstColumn + index % num;
				global::NPOI.SS.UserModel.IRow row = this.sheet.GetRow(rownum);
				if (row != null)
				{
					return this.evaluator.Evaluate(row.GetCell(cellnum));
				}
				return null;
			}

			// Token: 0x04001882 RID: 6274
			private global::NPOI.SS.UserModel.ISheet sheet;

			// Token: 0x04001883 RID: 6275
			private global::NPOI.SS.Util.CellRangeAddress cellRangeAddress;

			// Token: 0x04001884 RID: 6276
			private int numOfCells;

			// Token: 0x04001885 RID: 6277
			private global::NPOI.SS.UserModel.IFormulaEvaluator evaluator;
		}
	}
}
