using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F6 RID: 1014
	public class MMSRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002497 RID: 9367 RVA: 0x0005FE49 File Offset: 0x0005E049
		public MMSRecord()
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x0006DF20 File Offset: 0x0006C120
		public MMSRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			if (in1.Remaining == 0)
			{
				return;
			}
			this.field_1_AddMenuCount = (byte)in1.ReadByte();
			this.field_2_delMenuCount = (byte)in1.ReadByte();
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0006DF4B File Offset: 0x0006C14B
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0006DF53 File Offset: 0x0006C153
		public byte AddMenuCount
		{
			get
			{
				return this.field_1_AddMenuCount;
			}
			set
			{
				this.field_1_AddMenuCount = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0006DF5C File Offset: 0x0006C15C
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0006DF64 File Offset: 0x0006C164
		public byte DelMenuCount
		{
			get
			{
				return this.field_2_delMenuCount;
			}
			set
			{
				this.field_2_delMenuCount = value;
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0006DF70 File Offset: 0x0006C170
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[MMS]\n");
			stringBuilder.Append("    .addMenu        = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.AddMenuCount)).Append("\n");
			stringBuilder.Append("    .delMenu        = ").Append(global::NPOI.Util.StringUtil.ToHexString((short)this.DelMenuCount)).Append("\n");
			stringBuilder.Append("[/MMS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0006DFEB File Offset: 0x0006C1EB
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.AddMenuCount);
			out1.WriteByte((int)this.DelMenuCount);
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0006E005 File Offset: 0x0006C205
		public override short Sid
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x04000F5A RID: 3930
		public const short sid = 193;

		// Token: 0x04000F5B RID: 3931
		private byte field_1_AddMenuCount;

		// Token: 0x04000F5C RID: 3932
		private byte field_2_delMenuCount;
	}
}
