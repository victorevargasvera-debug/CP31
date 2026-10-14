using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.PivotTable
{
	// Token: 0x02000447 RID: 1095
	public class ExtendedPivotTableViewFieldsRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002891 RID: 10385 RVA: 0x0007A130 File Offset: 0x00078330
		public ExtendedPivotTableViewFieldsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.grbit1 = in1.ReadInt();
			this.grbit2 = in1.ReadUByte();
			this.citmShow = in1.ReadUByte();
			this.isxdiSort = in1.ReadUShort();
			this.isxdiShow = in1.ReadUShort();
			int remaining = in1.Remaining;
			if (remaining == 0)
			{
				this.reserved1 = 0;
				this.reserved2 = 0;
				this.subName = null;
				return;
			}
			if (remaining != 10)
			{
				throw new global::NPOI.Util.RecordFormatException("Unexpected remaining size (" + in1.Remaining.ToString() + ")");
			}
			int num = in1.ReadUShort();
			this.reserved1 = in1.ReadInt();
			this.reserved2 = in1.ReadInt();
			if (num != 65535)
			{
				this.subName = in1.ReadUnicodeLEString(num);
			}
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0007A200 File Offset: 0x00078400
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.grbit1);
			out1.WriteByte(this.grbit2);
			out1.WriteByte(this.citmShow);
			out1.WriteShort(this.isxdiSort);
			out1.WriteShort(this.isxdiShow);
			if (this.subName == null)
			{
				out1.WriteShort(65535);
			}
			else
			{
				out1.WriteShort(this.subName.Length);
			}
			out1.WriteInt(this.reserved1);
			out1.WriteInt(this.reserved2);
			if (this.subName != null)
			{
				global::NPOI.Util.StringUtil.PutUnicodeLE(this.subName, out1);
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x0007A29B File Offset: 0x0007849B
		protected override int DataSize
		{
			get
			{
				return 20 + ((this.subName == null) ? 0 : (2 * this.subName.Length));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x0007A2B8 File Offset: 0x000784B8
		public override short Sid
		{
			get
			{
				return 256;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0007A2C0 File Offset: 0x000784C0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SXVDEX]\n");
			stringBuilder.Append("    .grbit1 =").Append(global::NPOI.Util.HexDump.IntToHex(this.grbit1)).Append("\n");
			stringBuilder.Append("    .grbit2 =").Append(global::NPOI.Util.HexDump.ByteToHex(this.grbit2)).Append("\n");
			stringBuilder.Append("    .citmShow =").Append(global::NPOI.Util.HexDump.ByteToHex(this.citmShow)).Append("\n");
			stringBuilder.Append("    .isxdiSort =").Append(global::NPOI.Util.HexDump.ShortToHex(this.isxdiSort)).Append("\n");
			stringBuilder.Append("    .isxdiShow =").Append(global::NPOI.Util.HexDump.ShortToHex(this.isxdiShow)).Append("\n");
			stringBuilder.Append("    .subName =").Append(this.subName).Append("\n");
			stringBuilder.Append("[/SXVDEX]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0400114F RID: 4431
		public const short sid = 256;

		// Token: 0x04001150 RID: 4432
		private const int STRING_NOT_PRESENT_LEN = 65535;

		// Token: 0x04001151 RID: 4433
		private int grbit1;

		// Token: 0x04001152 RID: 4434
		private int grbit2;

		// Token: 0x04001153 RID: 4435
		private int citmShow;

		// Token: 0x04001154 RID: 4436
		private int isxdiSort;

		// Token: 0x04001155 RID: 4437
		private int isxdiShow;

		// Token: 0x04001156 RID: 4438
		private int reserved1;

		// Token: 0x04001157 RID: 4439
		private int reserved2;

		// Token: 0x04001158 RID: 4440
		private string subName;
	}
}
