using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200040A RID: 1034
	public class ProtectionRev4Record : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060025B6 RID: 9654 RVA: 0x00071230 File Offset: 0x0006F430
		public ProtectionRev4Record(short options)
		{
			this._options = options;
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0007123F File Offset: 0x0006F43F
		public ProtectionRev4Record(bool protect) : this(0)
		{
			this.Protect = protect;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0007124F File Offset: 0x0006F44F
		public ProtectionRev4Record(global::NPOI.HSSF.Record.RecordInputStream in1) : this(in1.ReadShort())
		{
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x0007125D File Offset: 0x0006F45D
		// (set) Token: 0x060025BA RID: 9658 RVA: 0x0007126F File Offset: 0x0006F46F
		public bool Protect
		{
			get
			{
				return global::NPOI.HSSF.Record.ProtectionRev4Record.protectedFlag.IsSet((int)this._options);
			}
			set
			{
				this._options = (short)global::NPOI.HSSF.Record.ProtectionRev4Record.protectedFlag.SetBoolean((int)this._options, value);
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x0007128C File Offset: 0x0006F48C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PROT4REV]\n");
			stringBuilder.Append("    .protect         = ").Append(this.Protect).Append("\n");
			stringBuilder.Append("[/PROT4REV]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000712DC File Offset: 0x0006F4DC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this._options);
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060025BD RID: 9661 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060025BE RID: 9662 RVA: 0x000712EA File Offset: 0x0006F4EA
		public override short Sid
		{
			get
			{
				return 431;
			}
		}

		// Token: 0x04000FD7 RID: 4055
		public const short sid = 431;

		// Token: 0x04000FD8 RID: 4056
		private static global::NPOI.Util.BitField protectedFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000FD9 RID: 4057
		private short _options;
	}
}
