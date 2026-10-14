using System;
using System.Text;
using NPOI.HSSF.Record;
using NPOI.SS.Formula;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000014 RID: 20
	public class CellRangeAddress : global::NPOI.SS.Util.CellRangeAddressBase
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00004C97 File Offset: 0x00002E97
		public CellRangeAddress(int firstRow, int lastRow, int firstCol, int lastCol) : base(firstRow, lastRow, firstCol, lastCol)
		{
			if (lastRow < firstRow || lastCol < firstCol)
			{
				throw new global::System.ArgumentException("lastRow < firstRow || lastCol < firstCol");
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public CellRangeAddress(global::NPOI.HSSF.Record.RecordInputStream in1) : base(global::NPOI.SS.Util.CellRangeAddress.ReadUShortAndCheck(in1), in1.ReadUShort(), in1.ReadUShort(), in1.ReadUShort())
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004CD8 File Offset: 0x00002ED8
		private static int ReadUShortAndCheck(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			if (in1.Remaining < 8)
			{
				throw new global::NPOI.Util.RuntimeException("Ran out of data readin1g CellRangeAddress");
			}
			return in1.ReadUShort();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004CF4 File Offset: 0x00002EF4
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(base.FirstRow);
			out1.WriteShort(base.LastRow);
			out1.WriteShort(base.FirstColumn);
			out1.WriteShort(base.LastColumn);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004D26 File Offset: 0x00002F26
		public string FormatAsString()
		{
			return this.FormatAsString(null, false);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004D30 File Offset: 0x00002F30
		public string FormatAsString(string sheetName, bool useAbsoluteAddress)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (sheetName != null)
			{
				stringBuilder.Append(global::NPOI.SS.Formula.SheetNameFormatter.Format(sheetName));
				stringBuilder.Append("!");
			}
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(base.FirstRow, base.FirstColumn, useAbsoluteAddress, useAbsoluteAddress);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(base.LastRow, base.LastColumn, useAbsoluteAddress, useAbsoluteAddress);
			stringBuilder.Append(cellReference.FormatAsString());
			if (!cellReference.Equals(cellReference2) || base.IsFullColumnRange || base.IsFullRowRange)
			{
				stringBuilder.Append(':');
				stringBuilder.Append(cellReference2.FormatAsString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004DC9 File Offset: 0x00002FC9
		public global::NPOI.SS.Util.CellRangeAddress Copy()
		{
			return new global::NPOI.SS.Util.CellRangeAddress(base.FirstRow, base.LastRow, base.FirstColumn, base.LastColumn);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public static int GetEncodedSize(int numberOfItems)
		{
			return numberOfItems * 8;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004DF0 File Offset: 0x00002FF0
		public static global::NPOI.SS.Util.CellRangeAddress ValueOf(string reference)
		{
			int num = reference.IndexOf(":", global::System.StringComparison.Ordinal);
			global::NPOI.SS.Util.CellReference cellReference;
			global::NPOI.SS.Util.CellReference cellReference2;
			if (num == -1)
			{
				cellReference = new global::NPOI.SS.Util.CellReference(reference);
				cellReference2 = cellReference;
			}
			else
			{
				cellReference = new global::NPOI.SS.Util.CellReference(reference.Substring(0, num));
				cellReference2 = new global::NPOI.SS.Util.CellReference(reference.Substring(num + 1));
			}
			return new global::NPOI.SS.Util.CellRangeAddress(cellReference.Row, cellReference2.Row, (int)cellReference.Col, (int)cellReference2.Col);
		}

		// Token: 0x04000031 RID: 49
		public const int ENCODED_SIZE = 8;
	}
}
