using System;
using System.Globalization;
using System.Text;
using NPOI.HSSF.Record.Cont;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000434 RID: 1076
	public class TextObjectRecord : global::NPOI.HSSF.Record.Cont.ContinuableRecord
	{
		// Token: 0x060027B0 RID: 10160 RVA: 0x0007769F File Offset: 0x0007589F
		public TextObjectRecord()
		{
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000776D4 File Offset: 0x000758D4
		public TextObjectRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_options = in1.ReadUShort();
			this.field_2_textOrientation = in1.ReadUShort();
			this.field_3_reserved4 = in1.ReadUShort();
			this.field_4_reserved5 = in1.ReadUShort();
			this.field_5_reserved6 = in1.ReadUShort();
			int num = in1.ReadUShort();
			int num2 = in1.ReadUShort();
			this.field_8_reserved7 = in1.ReadInt();
			if (in1.Remaining > 0)
			{
				if (in1.Remaining < 11)
				{
					throw new global::NPOI.Util.RecordFormatException("Not enough remaining data for a link formula");
				}
				int size = in1.ReadUShort();
				this._unknownPreFormulaInt = in1.ReadInt();
				global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.SS.Formula.PTG.Ptg.ReadTokens(size, in1);
				if (array.Length != 1)
				{
					throw new global::NPOI.Util.RecordFormatException("Read " + array.Length.ToString() + " tokens but expected exactly 1");
				}
				this._linkRefPtg = (global::NPOI.SS.Formula.PTG.OperandPtg)array[0];
				if (in1.Remaining > 0)
				{
					this._unknownPostFormulaByte = new byte?((byte)in1.ReadByte());
				}
				else
				{
					this._unknownPostFormulaByte = null;
				}
			}
			else
			{
				this._linkRefPtg = null;
			}
			if (in1.Remaining > 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Unused " + in1.Remaining.ToString() + " bytes at end of record");
			}
			string str;
			if (num > 0)
			{
				str = global::NPOI.HSSF.Record.TextObjectRecord.ReadRawString(in1, num);
			}
			else
			{
				str = "";
			}
			this._text = new global::NPOI.HSSF.UserModel.HSSFRichTextString(str);
			if (num2 > 0)
			{
				global::NPOI.HSSF.Record.TextObjectRecord.ProcessFontRuns(in1, this._text, num2);
			}
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00077868 File Offset: 0x00075A68
		private static void ProcessFontRuns(global::NPOI.HSSF.Record.RecordInputStream in1, global::NPOI.SS.UserModel.IRichTextString str, int formattingRunDataLength)
		{
			if (formattingRunDataLength % 8 != 0)
			{
				throw new global::NPOI.Util.RecordFormatException("Bad format run data length " + formattingRunDataLength.ToString() + ")");
			}
			int num = formattingRunDataLength / 8;
			for (int i = 0; i < num; i++)
			{
				short startIndex = in1.ReadShort();
				short fontIndex = in1.ReadShort();
				in1.ReadInt();
				str.ApplyFont((int)startIndex, str.Length, fontIndex);
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000778CC File Offset: 0x00075ACC
		private int TrailingRecordsSize
		{
			get
			{
				if (this._text.Length < 1)
				{
					return 0;
				}
				int num = 0;
				int i = this._text.Length * 2;
				while (i > 0)
				{
					int num2 = global::System.Math.Min(8222, i);
					i -= num2;
					num += 4;
					num += 1 + num2;
				}
				int num3 = (this._text.NumFormattingRuns + 1) * 8 + 4;
				return num + num3;
			}
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00077930 File Offset: 0x00075B30
		private static byte[] CreateFormatData(global::NPOI.SS.UserModel.IRichTextString str)
		{
			int numFormattingRuns = str.NumFormattingRuns;
			byte[] array = new byte[(numFormattingRuns + 1) * 8];
			int num = 0;
			for (int i = 0; i < numFormattingRuns; i++)
			{
				global::NPOI.Util.LittleEndian.PutUShort(array, num, str.GetIndexOfFormattingRun(i));
				num += 2;
				int fontOfFormattingRun = (int)((global::NPOI.HSSF.UserModel.HSSFRichTextString)str).GetFontOfFormattingRun(i);
				global::NPOI.Util.LittleEndian.PutUShort(array, num, (fontOfFormattingRun == 0) ? 0 : fontOfFormattingRun);
				num += 2;
				num += 4;
			}
			global::NPOI.Util.LittleEndian.PutUShort(array, num, str.Length);
			num += 2;
			global::NPOI.Util.LittleEndian.PutUShort(array, num, 0);
			num += 2;
			num += 4;
			return array;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000779B7 File Offset: 0x00075BB7
		private void SerializeTrailingRecords(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			out1.WriteContinue();
			out1.WriteStringData(this._text.String);
			out1.WriteContinue();
			this.WriteFormatData(out1, this._text);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x000779E4 File Offset: 0x00075BE4
		private void WriteFormatData(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1, global::NPOI.SS.UserModel.IRichTextString str)
		{
			int numFormattingRuns = str.NumFormattingRuns;
			for (int i = 0; i < numFormattingRuns; i++)
			{
				out1.WriteShort(str.GetIndexOfFormattingRun(i));
				int fontOfFormattingRun = (int)((global::NPOI.HSSF.UserModel.HSSFRichTextString)str).GetFontOfFormattingRun(i);
				out1.WriteShort((fontOfFormattingRun == 0) ? 0 : fontOfFormattingRun);
				out1.WriteInt(0);
			}
			out1.WriteShort(str.Length);
			out1.WriteShort(0);
			out1.WriteInt(0);
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x00077A4C File Offset: 0x00075C4C
		private int FormattingDataLength
		{
			get
			{
				if (this._text.Length < 1)
				{
					return 0;
				}
				return (this._text.NumFormattingRuns + 1) * 8;
			}
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00077A70 File Offset: 0x00075C70
		private void SerializeTXORecord(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			out1.WriteShort(this.field_1_options);
			out1.WriteShort(this.field_2_textOrientation);
			out1.WriteShort(this.field_3_reserved4);
			out1.WriteShort(this.field_4_reserved5);
			out1.WriteShort(this.field_5_reserved6);
			out1.WriteShort(this._text.Length);
			out1.WriteShort(this.FormattingDataLength);
			out1.WriteInt(this.field_8_reserved7);
			if (this._linkRefPtg != null)
			{
				int size = this._linkRefPtg.Size;
				out1.WriteShort(size);
				out1.WriteInt(this._unknownPreFormulaInt);
				this._linkRefPtg.Write(out1);
				if (this._unknownPostFormulaByte != null)
				{
					out1.WriteByte((int)global::System.Convert.ToByte(this._unknownPostFormulaByte, global::System.Globalization.CultureInfo.InvariantCulture));
				}
			}
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00077B3D File Offset: 0x00075D3D
		protected override void Serialize(global::NPOI.HSSF.Record.Cont.ContinuableRecordOutput out1)
		{
			this.SerializeTXORecord(out1);
			if (this._text.String.Length > 0)
			{
				this.SerializeTrailingRecords(out1);
			}
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00077B60 File Offset: 0x00075D60
		private void ProcessFontRuns(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			while (in1.Remaining > 0)
			{
				short startIndex = in1.ReadShort();
				short fontIndex = in1.ReadShort();
				in1.ReadInt();
				this._text.ApplyFont((int)startIndex, this._text.Length, fontIndex);
			}
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00077BA5 File Offset: 0x00075DA5
		private static string ReadRawString(global::NPOI.HSSF.Record.RecordInputStream in1, int textLength)
		{
			if (((byte)in1.ReadByte() & 1) == 0)
			{
				return in1.ReadCompressedUnicode(textLength);
			}
			return in1.ReadUnicodeLEString(textLength);
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x00077BC4 File Offset: 0x00075DC4
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x00077BCC File Offset: 0x00075DCC
		public global::NPOI.SS.UserModel.IRichTextString Str
		{
			get
			{
				return this._text;
			}
			set
			{
				this._text = value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x00077BD5 File Offset: 0x00075DD5
		public override short Sid
		{
			get
			{
				return 438;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x00077BDC File Offset: 0x00075DDC
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00077BE4 File Offset: 0x00075DE4
		public global::NPOI.HSSF.Record.TextOrientation TextOrientation
		{
			get
			{
				return (global::NPOI.HSSF.Record.TextOrientation)this.field_2_textOrientation;
			}
			set
			{
				this.field_2_textOrientation = (int)value;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x00077BED File Offset: 0x00075DED
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00077C00 File Offset: 0x00075E00
		public global::NPOI.HSSF.Record.HorizontalTextAlignment HorizontalTextAlignment
		{
			get
			{
				return (global::NPOI.HSSF.Record.HorizontalTextAlignment)this._HorizontalTextAlignment.GetValue(this.field_1_options);
			}
			set
			{
				this.field_1_options = this._HorizontalTextAlignment.SetValue(this.field_1_options, (int)value);
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x00077C1A File Offset: 0x00075E1A
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00077C2D File Offset: 0x00075E2D
		public global::NPOI.HSSF.Record.VerticalTextAlignment VerticalTextAlignment
		{
			get
			{
				return (global::NPOI.HSSF.Record.VerticalTextAlignment)this._VerticalTextAlignment.GetValue(this.field_1_options);
			}
			set
			{
				this.field_1_options = this._VerticalTextAlignment.SetValue(this.field_1_options, (int)value);
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x00077C47 File Offset: 0x00075E47
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00077C5A File Offset: 0x00075E5A
		public bool IsTextLocked
		{
			get
			{
				return this.textLocked.IsSet(this.field_1_options);
			}
			set
			{
				this.field_1_options = this.textLocked.SetBoolean(this.field_1_options, value);
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x00077C74 File Offset: 0x00075E74
		public global::NPOI.SS.Formula.PTG.Ptg LinkRefPtg
		{
			get
			{
				return this._linkRefPtg;
			}
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00077C7C File Offset: 0x00075E7C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[TXO]\n");
			stringBuilder.Append("    .options        = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_1_options)).Append("\n");
			stringBuilder.Append("         .IsHorizontal = ").Append(this.HorizontalTextAlignment).Append('\n');
			stringBuilder.Append("         .IsVertical   = ").Append(this.VerticalTextAlignment).Append('\n');
			stringBuilder.Append("         .textLocked   = ").Append(this.IsTextLocked).Append('\n');
			stringBuilder.Append("    .textOrientation= ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this.TextOrientation)).Append("\n");
			stringBuilder.Append("    .reserved4      = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_3_reserved4)).Append("\n");
			stringBuilder.Append("    .reserved5      = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_4_reserved5)).Append("\n");
			stringBuilder.Append("    .reserved6      = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.field_5_reserved6)).Append("\n");
			stringBuilder.Append("    .textLength     = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._text.Length)).Append("\n");
			stringBuilder.Append("    .reserved7      = ").Append(global::NPOI.Util.HexDump.IntToHex(this.field_8_reserved7)).Append("\n");
			stringBuilder.Append("    .string = ").Append(this._text).Append('\n');
			for (int i = 0; i < this._text.NumFormattingRuns; i++)
			{
				stringBuilder.Append("    .textrun = ").Append(((global::NPOI.HSSF.UserModel.HSSFRichTextString)this._text).GetFontOfFormattingRun(i)).Append('\n');
			}
			stringBuilder.Append("[/TXO]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00077E80 File Offset: 0x00076080
		public override object Clone()
		{
			global::NPOI.HSSF.Record.TextObjectRecord textObjectRecord = new global::NPOI.HSSF.Record.TextObjectRecord();
			textObjectRecord._text = this._text;
			textObjectRecord.field_1_options = this.field_1_options;
			textObjectRecord.field_2_textOrientation = this.field_2_textOrientation;
			textObjectRecord.field_3_reserved4 = this.field_3_reserved4;
			textObjectRecord.field_4_reserved5 = this.field_4_reserved5;
			textObjectRecord.field_5_reserved6 = this.field_5_reserved6;
			textObjectRecord.field_8_reserved7 = this.field_8_reserved7;
			textObjectRecord._text = this._text;
			if (this._linkRefPtg != null)
			{
				textObjectRecord._unknownPreFormulaInt = this._unknownPreFormulaInt;
				textObjectRecord._linkRefPtg = this._linkRefPtg.Copy();
				textObjectRecord._unknownPostFormulaByte = this._unknownPostFormulaByte;
			}
			return textObjectRecord;
		}

		// Token: 0x040010D4 RID: 4308
		private global::NPOI.SS.UserModel.IRichTextString _text;

		// Token: 0x040010D5 RID: 4309
		public const short sid = 438;

		// Token: 0x040010D6 RID: 4310
		private const int FORMAT_RUN_ENCODED_SIZE = 8;

		// Token: 0x040010D7 RID: 4311
		private global::NPOI.Util.BitField _HorizontalTextAlignment = global::NPOI.Util.BitFieldFactory.GetInstance(14);

		// Token: 0x040010D8 RID: 4312
		private global::NPOI.Util.BitField _VerticalTextAlignment = global::NPOI.Util.BitFieldFactory.GetInstance(112);

		// Token: 0x040010D9 RID: 4313
		private global::NPOI.Util.BitField textLocked = global::NPOI.Util.BitFieldFactory.GetInstance(512);

		// Token: 0x040010DA RID: 4314
		private int field_1_options;

		// Token: 0x040010DB RID: 4315
		private int field_2_textOrientation;

		// Token: 0x040010DC RID: 4316
		private int field_3_reserved4;

		// Token: 0x040010DD RID: 4317
		private int field_4_reserved5;

		// Token: 0x040010DE RID: 4318
		private int field_5_reserved6;

		// Token: 0x040010DF RID: 4319
		private int field_8_reserved7;

		// Token: 0x040010E0 RID: 4320
		private int _unknownPreFormulaInt;

		// Token: 0x040010E1 RID: 4321
		private global::NPOI.SS.Formula.PTG.OperandPtg _linkRefPtg;

		// Token: 0x040010E2 RID: 4322
		private byte? _unknownPostFormulaByte;
	}
}
