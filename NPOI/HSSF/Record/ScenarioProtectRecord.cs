using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200041A RID: 1050
	public class ScenarioProtectRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600267C RID: 9852 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ScenarioProtectRecord()
		{
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00073CF1 File Offset: 0x00071EF1
		public ScenarioProtectRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_protect = in1.ReadShort();
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x00073D05 File Offset: 0x00071F05
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x00073D10 File Offset: 0x00071F10
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

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x00073D24 File Offset: 0x00071F24
		public override short Sid
		{
			get
			{
				return 221;
			}
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00073D2C File Offset: 0x00071F2C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SCENARIOPROTECT]\n");
			stringBuilder.Append("    .protect         = ").Append(this.Protect).Append("\n");
			stringBuilder.Append("[/SCENARIOPROTECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00073D7C File Offset: 0x00071F7C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_protect);
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00073D8A File Offset: 0x00071F8A
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ScenarioProtectRecord
			{
				field_1_protect = this.field_1_protect
			};
		}

		// Token: 0x0400101E RID: 4126
		public const short sid = 221;

		// Token: 0x0400101F RID: 4127
		private short field_1_protect;
	}
}
