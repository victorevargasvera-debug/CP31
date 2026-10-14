using System;
using System.Collections.Generic;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B0 RID: 944
	public class BoundSheetRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060020B0 RID: 8368 RVA: 0x00064304 File Offset: 0x00062504
		public BoundSheetRecord(string sheetname)
		{
			this.field_2_option_flags = 0;
			this.Sheetname = sheetname;
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x0006431C File Offset: 0x0006251C
		public BoundSheetRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_position_of_BOF = in1.ReadInt();
			this.field_2_option_flags = (int)in1.ReadShort();
			int requestedLength = in1.ReadUByte();
			this.field_4_isMultibyteUnicode = (int)((byte)in1.ReadByte());
			if (this.IsMultibyte)
			{
				this.field_5_sheetname = in1.ReadUnicodeLEString(requestedLength);
				return;
			}
			this.field_5_sheetname = in1.ReadCompressedUnicode(requestedLength);
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x0006437E File Offset: 0x0006257E
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x00064386 File Offset: 0x00062586
		public int PositionOfBof
		{
			get
			{
				return this.field_1_position_of_BOF;
			}
			set
			{
				this.field_1_position_of_BOF = value;
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0006438F File Offset: 0x0006258F
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x000643A1 File Offset: 0x000625A1
		public bool IsVeryHidden
		{
			get
			{
				return global::NPOI.HSSF.Record.BoundSheetRecord.veryHiddenFlag.IsSet(this.field_2_option_flags);
			}
			set
			{
				this.field_2_option_flags = global::NPOI.HSSF.Record.BoundSheetRecord.veryHiddenFlag.SetBoolean(this.field_2_option_flags, value);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000643BA File Offset: 0x000625BA
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x000643C2 File Offset: 0x000625C2
		public string Sheetname
		{
			get
			{
				return this.field_5_sheetname;
			}
			set
			{
				global::NPOI.SS.Util.WorkbookUtil.ValidateSheetName(value);
				this.field_5_sheetname = value;
				this.field_4_isMultibyteUnicode = (global::NPOI.Util.StringUtil.HasMultibyte(value) ? 1 : 0);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000643E3 File Offset: 0x000625E3
		private bool IsMultibyte
		{
			get
			{
				return (this.field_4_isMultibyteUnicode & 1) != 0;
			}
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x000643F0 File Offset: 0x000625F0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BOUNDSHEET]\n");
			stringBuilder.Append("    .bof        = ").Append(global::NPOI.Util.HexDump.IntToHex(this.PositionOfBof)).Append("\n");
			stringBuilder.Append("    .options    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_2_option_flags)).Append("\n");
			stringBuilder.Append("    .unicodeflag= ").Append(global::NPOI.Util.HexDump.ByteToHex(this.field_4_isMultibyteUnicode)).Append("\n");
			stringBuilder.Append("    .sheetname  = ").Append(this.field_5_sheetname).Append("\n");
			stringBuilder.Append("[/BOUNDSHEET]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x000644B2 File Offset: 0x000626B2
		protected override int DataSize
		{
			get
			{
				return 8 + this.field_5_sheetname.Length * (this.IsMultibyte ? 2 : 1);
			}
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x000644D0 File Offset: 0x000626D0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.PositionOfBof);
			out1.WriteShort(this.field_2_option_flags);
			string text = this.field_5_sheetname;
			out1.WriteByte(text.Length);
			out1.WriteByte(this.field_4_isMultibyteUnicode);
			if (this.IsMultibyte)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(text, out1);
				return;
			}
			global::NPOI.Util.StringUtil.PutCompressedUnicode(text, out1);
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x00061F9A File Offset: 0x0006019A
		public override short Sid
		{
			get
			{
				return 133;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0006452B File Offset: 0x0006272B
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x0006453D File Offset: 0x0006273D
		public bool IsHidden
		{
			get
			{
				return global::NPOI.HSSF.Record.BoundSheetRecord.hiddenFlag.IsSet(this.field_2_option_flags);
			}
			set
			{
				this.field_2_option_flags = global::NPOI.HSSF.Record.BoundSheetRecord.hiddenFlag.SetBoolean(this.field_2_option_flags, value);
			}
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00064556 File Offset: 0x00062756
		public static global::NPOI.HSSF.Record.BoundSheetRecord[] OrderByBofPosition(global::System.Collections.Generic.List<global::NPOI.HSSF.Record.BoundSheetRecord> boundSheetRecords)
		{
			global::NPOI.HSSF.Record.BoundSheetRecord[] array = boundSheetRecords.ToArray();
			global::System.Array.Sort<global::NPOI.HSSF.Record.BoundSheetRecord>(array, new global::NPOI.HSSF.Record.BoundSheetRecord.BOFComparator());
			return array;
		}

		// Token: 0x04000CC0 RID: 3264
		public const short sid = 133;

		// Token: 0x04000CC1 RID: 3265
		private static global::NPOI.Util.BitField hiddenFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000CC2 RID: 3266
		private static global::NPOI.Util.BitField veryHiddenFlag = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000CC3 RID: 3267
		private int field_1_position_of_BOF;

		// Token: 0x04000CC4 RID: 3268
		private int field_2_option_flags;

		// Token: 0x04000CC5 RID: 3269
		private int field_4_isMultibyteUnicode;

		// Token: 0x04000CC6 RID: 3270
		private string field_5_sheetname;

		// Token: 0x0200060B RID: 1547
		private class BOFComparator : global::System.Collections.Generic.IComparer<global::NPOI.HSSF.Record.BoundSheetRecord>
		{
			// Token: 0x06003667 RID: 13927 RVA: 0x000A65A8 File Offset: 0x000A47A8
			public int Compare(global::NPOI.HSSF.Record.BoundSheetRecord bsr1, global::NPOI.HSSF.Record.BoundSheetRecord bsr2)
			{
				return bsr1.PositionOfBof - bsr2.PositionOfBof;
			}
		}
	}
}
