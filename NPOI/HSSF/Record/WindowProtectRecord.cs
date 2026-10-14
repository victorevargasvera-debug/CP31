using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200043E RID: 1086
	public class WindowProtectRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x00078FDD File Offset: 0x000771DD
		public WindowProtectRecord(int options)
		{
			this._options = options;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00078FEC File Offset: 0x000771EC
		public WindowProtectRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : this(in1.ReadUShort())
		{
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00078FFA File Offset: 0x000771FA
		public WindowProtectRecord(bool protect) : this(0)
		{
			this.Protect = protect;
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x0007900A File Offset: 0x0007720A
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0007901C File Offset: 0x0007721C
		public bool Protect
		{
			get
			{
				return global::NPOI.HSSF.Record.WindowProtectRecord.settingsProtectedFlag.IsSet(this._options);
			}
			set
			{
				this._options = global::NPOI.HSSF.Record.WindowProtectRecord.settingsProtectedFlag.SetBoolean(this._options, value);
			}
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00079038 File Offset: 0x00077238
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[WINDOWPROTECT]\n");
			stringBuilder.Append("    .protect         = ").Append(this.Protect).Append("\n");
			stringBuilder.Append("[/WINDOWPROTECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00079088 File Offset: 0x00077288
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._options);
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x00079096 File Offset: 0x00077296
		public override short Sid
		{
			get
			{
				return 25;
			}
		}

		// Token: 0x0400110F RID: 4367
		public const short sid = 25;

		// Token: 0x04001110 RID: 4368
		private static global::NPOI.Util.BitField settingsProtectedFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001111 RID: 4369
		private int _options;
	}
}
