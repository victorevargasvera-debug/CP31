using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x0200044A RID: 1098
	public class ViewDefinitionRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060028A0 RID: 10400 RVA: 0x0007A568 File Offset: 0x00078768
		public ViewDefinitionRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.rwFirst = in1.ReadUShort();
			this.rwLast = in1.ReadUShort();
			this.colFirst = in1.ReadUShort();
			this.colLast = in1.ReadUShort();
			this.rwFirstHead = in1.ReadUShort();
			this.rwFirstData = in1.ReadUShort();
			this.colFirstData = in1.ReadUShort();
			this.iCache = in1.ReadUShort();
			this.reserved = in1.ReadUShort();
			this.sxaxis4Data = in1.ReadUShort();
			this.ipos4Data = in1.ReadUShort();
			this.cDim = in1.ReadUShort();
			this.cDimRw = in1.ReadUShort();
			this.cDimCol = in1.ReadUShort();
			this.cDimPg = in1.ReadUShort();
			this.cDimData = in1.ReadUShort();
			this.cRw = in1.ReadUShort();
			this.cCol = in1.ReadUShort();
			this.grbit = in1.ReadUShort();
			this.itblAutoFmt = in1.ReadUShort();
			int nChars = in1.ReadUShort();
			int nChars2 = in1.ReadUShort();
			this.name = global::NPOI.Util.StringUtil.ReadUnicodeString(in1, nChars);
			this.dataField = global::NPOI.Util.StringUtil.ReadUnicodeString(in1, nChars2);
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0007A694 File Offset: 0x00078894
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.rwFirst);
			out1.WriteShort(this.rwLast);
			out1.WriteShort(this.colFirst);
			out1.WriteShort(this.colLast);
			out1.WriteShort(this.rwFirstHead);
			out1.WriteShort(this.rwFirstData);
			out1.WriteShort(this.colFirstData);
			out1.WriteShort(this.iCache);
			out1.WriteShort(this.reserved);
			out1.WriteShort(this.sxaxis4Data);
			out1.WriteShort(this.ipos4Data);
			out1.WriteShort(this.cDim);
			out1.WriteShort(this.cDimRw);
			out1.WriteShort(this.cDimCol);
			out1.WriteShort(this.cDimPg);
			out1.WriteShort(this.cDimData);
			out1.WriteShort(this.cRw);
			out1.WriteShort(this.cCol);
			out1.WriteShort(this.grbit);
			out1.WriteShort(this.itblAutoFmt);
			out1.WriteShort(this.name.Length);
			out1.WriteShort(this.dataField.Length);
			global::NPOI.Util.StringUtil.WriteUnicodeStringFlagAndData(out1, this.name);
			global::NPOI.Util.StringUtil.WriteUnicodeStringFlagAndData(out1, this.dataField);
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x0007A7CB File Offset: 0x000789CB
		protected override int DataSize
		{
			get
			{
				return 40 + global::NPOI.Util.StringUtil.GetEncodedSize(this.name) + global::NPOI.Util.StringUtil.GetEncodedSize(this.dataField);
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0007A7E7 File Offset: 0x000789E7
		public override short Sid
		{
			get
			{
				return 176;
			}
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0007A7F0 File Offset: 0x000789F0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXVIEW]\n");
			stringBuilder.Append("    .rwFirst      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rwFirst)).Append('\n');
			stringBuilder.Append("    .rwLast       =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rwLast)).Append('\n');
			stringBuilder.Append("    .colFirst     =").Append(global::NPOI.Util.HexDump.ShortToHex(this.colFirst)).Append('\n');
			stringBuilder.Append("    .colLast      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.colLast)).Append('\n');
			stringBuilder.Append("    .rwFirstHead  =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rwFirstHead)).Append('\n');
			stringBuilder.Append("    .rwFirstData  =").Append(global::NPOI.Util.HexDump.ShortToHex(this.rwFirstData)).Append('\n');
			stringBuilder.Append("    .colFirstData =").Append(global::NPOI.Util.HexDump.ShortToHex(this.colFirstData)).Append('\n');
			stringBuilder.Append("    .iCache       =").Append(global::NPOI.Util.HexDump.ShortToHex(this.iCache)).Append('\n');
			stringBuilder.Append("    .reserved     =").Append(global::NPOI.Util.HexDump.ShortToHex(this.reserved)).Append('\n');
			stringBuilder.Append("    .sxaxis4Data  =").Append(global::NPOI.Util.HexDump.ShortToHex(this.sxaxis4Data)).Append('\n');
			stringBuilder.Append("    .ipos4Data    =").Append(global::NPOI.Util.HexDump.ShortToHex(this.ipos4Data)).Append('\n');
			stringBuilder.Append("    .cDim         =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cDim)).Append('\n');
			stringBuilder.Append("    .cDimRw       =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cDimRw)).Append('\n');
			stringBuilder.Append("    .cDimCol      =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cDimCol)).Append('\n');
			stringBuilder.Append("    .cDimPg       =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cDimPg)).Append('\n');
			stringBuilder.Append("    .cDimData     =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cDimData)).Append('\n');
			stringBuilder.Append("    .cRw          =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cRw)).Append('\n');
			stringBuilder.Append("    .cCol         =").Append(global::NPOI.Util.HexDump.ShortToHex(this.cCol)).Append('\n');
			stringBuilder.Append("    .grbit        =").Append(global::NPOI.Util.HexDump.ShortToHex(this.grbit)).Append('\n');
			stringBuilder.Append("    .itblAutoFmt  =").Append(global::NPOI.Util.HexDump.ShortToHex(this.itblAutoFmt)).Append('\n');
			stringBuilder.Append("    .name         =").Append(this.name).Append('\n');
			stringBuilder.Append("    .dataField    =").Append(this.dataField).Append('\n');
			stringBuilder.Append("[/SXVIEW]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400115D RID: 4445
		public const short sid = 176;

		// Token: 0x0400115E RID: 4446
		private int rwFirst;

		// Token: 0x0400115F RID: 4447
		private int rwLast;

		// Token: 0x04001160 RID: 4448
		private int colFirst;

		// Token: 0x04001161 RID: 4449
		private int colLast;

		// Token: 0x04001162 RID: 4450
		private int rwFirstHead;

		// Token: 0x04001163 RID: 4451
		private int rwFirstData;

		// Token: 0x04001164 RID: 4452
		private int colFirstData;

		// Token: 0x04001165 RID: 4453
		private int iCache;

		// Token: 0x04001166 RID: 4454
		private int reserved;

		// Token: 0x04001167 RID: 4455
		private int sxaxis4Data;

		// Token: 0x04001168 RID: 4456
		private int ipos4Data;

		// Token: 0x04001169 RID: 4457
		private int cDim;

		// Token: 0x0400116A RID: 4458
		private int cDimRw;

		// Token: 0x0400116B RID: 4459
		private int cDimCol;

		// Token: 0x0400116C RID: 4460
		private int cDimPg;

		// Token: 0x0400116D RID: 4461
		private int cDimData;

		// Token: 0x0400116E RID: 4462
		private int cRw;

		// Token: 0x0400116F RID: 4463
		private int cCol;

		// Token: 0x04001170 RID: 4464
		private int grbit;

		// Token: 0x04001171 RID: 4465
		private int itblAutoFmt;

		// Token: 0x04001172 RID: 4466
		private string dataField;

		// Token: 0x04001173 RID: 4467
		private string name;
	}
}
