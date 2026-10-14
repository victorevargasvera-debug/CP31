using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003FD RID: 1021
	public class ObjectProtectRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600250E RID: 9486 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ObjectProtectRecord()
		{
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0006F437 File Offset: 0x0006D637
		public ObjectProtectRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_protect = in1.ReadShort();
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x0006F44B File Offset: 0x0006D64B
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x0006F456 File Offset: 0x0006D656
		public bool Protect
		{
			get
			{
				return this.field_1_protect == 1;
			}
			set
			{
				if (value)
				{
					this.field_1_protect = 1;
					return;
				}
				this.field_1_protect = 0;
			}
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x0006F46C File Offset: 0x0006D66C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SCENARIOPROTECT]\n");
			stringBuilder.Append("    .protect         = ").Append(this.Protect).Append("\n");
			stringBuilder.Append("[/SCENARIOPROTECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0006F4BC File Offset: 0x0006D6BC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_protect);
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0006F4CA File Offset: 0x0006D6CA
		public override short Sid
		{
			get
			{
				return 99;
			}
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x0006F4CE File Offset: 0x0006D6CE
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ObjectProtectRecord
			{
				field_1_protect = this.field_1_protect
			};
		}

		// Token: 0x04000F96 RID: 3990
		public const short sid = 99;

		// Token: 0x04000F97 RID: 3991
		private short field_1_protect;
	}
}
