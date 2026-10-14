using System;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000015 RID: 21
	public class CellRangeAddress8Bit : global::NPOI.SS.Util.CellRangeAddressBase
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00004E53 File Offset: 0x00003053
		public CellRangeAddress8Bit(int firstRow, int lastRow, int firstCol, int lastCol) : base(firstRow, lastRow, firstCol, lastCol)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004E60 File Offset: 0x00003060
		public CellRangeAddress8Bit(global::NPOI.HSSF.Record.RecordInputStream in1) : base(global::NPOI.SS.Util.CellRangeAddress8Bit.ReadUShortAndCheck(in1), in1.ReadUShort(), in1.ReadUByte(), in1.ReadUByte())
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004E80 File Offset: 0x00003080
		private static int ReadUShortAndCheck(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			if (in1.Remaining < 6)
			{
				throw new global::System.Exception("Ran out of data reading CellRangeAddress");
			}
			return in1.ReadUShort();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004E9C File Offset: 0x0000309C
		public int Serialize(int offset, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutUShort(data, offset, base.FirstRow);
			global::NPOI.Util.LittleEndian.PutUShort(data, offset + 2, base.LastRow);
			global::NPOI.Util.LittleEndian.PutByte(data, offset + 4, base.FirstColumn);
			global::NPOI.Util.LittleEndian.PutByte(data, offset + 5, base.LastColumn);
			return 6;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004ED9 File Offset: 0x000030D9
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(base.FirstRow);
			out1.WriteShort(base.LastRow);
			out1.WriteByte(base.FirstColumn);
			out1.WriteByte(base.LastColumn);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004F0B File Offset: 0x0000310B
		public global::NPOI.SS.Util.CellRangeAddress8Bit Copy()
		{
			return new global::NPOI.SS.Util.CellRangeAddress8Bit(base.FirstRow, base.LastRow, base.FirstColumn, base.LastColumn);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004F2A File Offset: 0x0000312A
		public static int GetEncodedSize(int numberOfItems)
		{
			return numberOfItems * 6;
		}

		// Token: 0x04000032 RID: 50
		public const int ENCODED_SIZE = 6;
	}
}
