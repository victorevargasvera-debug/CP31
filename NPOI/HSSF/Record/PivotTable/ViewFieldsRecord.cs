using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x0200044B RID: 1099
	public class ViewFieldsRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060028A5 RID: 10405 RVA: 0x0007AB18 File Offset: 0x00078D18
		public ViewFieldsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.sxaxis = (int)in1.ReadShort();
			this.cSub = (int)in1.ReadShort();
			this.grbitSub = (int)in1.ReadShort();
			this.cItm = (int)in1.ReadShort();
			int num = in1.ReadUShort();
			if (num != 65535)
			{
				if ((in1.ReadByte() & 1) != 0)
				{
					this._name = in1.ReadUnicodeLEString(num);
					return;
				}
				this._name = in1.ReadCompressedUnicode(num);
			}
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0007AB90 File Offset: 0x00078D90
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.sxaxis);
			out1.WriteShort(this.cSub);
			out1.WriteShort(this.grbitSub);
			out1.WriteShort(this.cItm);
			if (this._name != null)
			{
				global::NPOI.Util.StringUtil.WriteUnicodeString(out1, this._name);
				return;
			}
			out1.WriteShort(65535);
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x0007ABED File Offset: 0x00078DED
		protected override int DataSize
		{
			get
			{
				if (this._name == null)
				{
					return 10;
				}
				return 11 + this._name.Length * (global::NPOI.Util.StringUtil.HasMultibyte(this._name) ? 2 : 1);
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0007AC1A File Offset: 0x00078E1A
		public override short Sid
		{
			get
			{
				return 177;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0007AC24 File Offset: 0x00078E24
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXVD]\n");
			stringBuilder.Append("    .sxaxis    = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.sxaxis)).Append('\n');
			stringBuilder.Append("    .cSub      = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.cSub)).Append('\n');
			stringBuilder.Append("    .grbitSub  = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.grbitSub)).Append('\n');
			stringBuilder.Append("    .cItm      = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.cItm)).Append('\n');
			stringBuilder.Append("    .name      = ").Append(this._name).Append('\n');
			stringBuilder.Append("[/SXVD]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001174 RID: 4468
		public const short sid = 177;

		// Token: 0x04001175 RID: 4469
		private const int STRING_NOT_PRESENT_LEN = 65535;

		// Token: 0x04001176 RID: 4470
		private const int BASE_SIZE = 10;

		// Token: 0x04001177 RID: 4471
		private int sxaxis;

		// Token: 0x04001178 RID: 4472
		private int cSub;

		// Token: 0x04001179 RID: 4473
		private int grbitSub;

		// Token: 0x0400117A RID: 4474
		private int cItm;

		// Token: 0x0400117B RID: 4475
		private string _name;

		// Token: 0x02000618 RID: 1560
		private enum Axis
		{
			// Token: 0x04001A8C RID: 6796
			NoAxis,
			// Token: 0x04001A8D RID: 6797
			Row,
			// Token: 0x04001A8E RID: 6798
			Column,
			// Token: 0x04001A8F RID: 6799
			Page = 4,
			// Token: 0x04001A90 RID: 6800
			Data = 8
		}
	}
}
