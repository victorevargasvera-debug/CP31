using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A8 RID: 936
	public class BackupRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002061 RID: 8289 RVA: 0x0005FE49 File Offset: 0x0005E049
		public BackupRecord()
		{
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000639B9 File Offset: 0x00061BB9
		public BackupRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_backup = in1.ReadShort();
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x000639CD File Offset: 0x00061BCD
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x000639D5 File Offset: 0x00061BD5
		public short Backup
		{
			get
			{
				return this.field_1_backup;
			}
			set
			{
				this.field_1_backup = value;
			}
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000639E0 File Offset: 0x00061BE0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[BACKUP]\n");
			stringBuilder.Append("    .backup          = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Backup)).Append("\n");
			stringBuilder.Append("[/BACKUP]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00063A35 File Offset: 0x00061C35
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.Backup);
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x000177BF File Offset: 0x000159BF
		public override short Sid
		{
			get
			{
				return 64;
			}
		}

		// Token: 0x04000C9D RID: 3229
		public const short sid = 64;

		// Token: 0x04000C9E RID: 3230
		private short field_1_backup;
	}
}
