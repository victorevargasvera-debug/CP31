using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.AutoFilter
{
	// Token: 0x02000457 RID: 1111
	public class AutoFilterInfoRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600291E RID: 10526 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AutoFilterInfoRecord()
		{
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0007C23B File Offset: 0x0007A43B
		public AutoFilterInfoRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_cEntries = in1.ReadShort();
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x0007C24F File Offset: 0x0007A44F
		public override short Sid
		{
			get
			{
				return 157;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x0007C256 File Offset: 0x0007A456
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x0007C25E File Offset: 0x0007A45E
		public short NumEntries
		{
			get
			{
				return this.field_1_cEntries;
			}
			set
			{
				this.field_1_cEntries = value;
			}
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x0007C268 File Offset: 0x0007A468
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AUTOFILTERINFO]\n");
			stringBuilder.Append("    .numEntries          = ").Append(this.field_1_cEntries).Append("\n");
			stringBuilder.Append("[/AUTOFILTERINFO]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x0007C2B8 File Offset: 0x0007A4B8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_cEntries);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x0007C2C6 File Offset: 0x0007A4C6
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord
			{
				field_1_cEntries = this.field_1_cEntries
			};
		}

		// Token: 0x040011AA RID: 4522
		private short field_1_cEntries;

		// Token: 0x040011AB RID: 4523
		public const short sid = 157;
	}
}
