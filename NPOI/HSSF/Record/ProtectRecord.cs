using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200040B RID: 1035
	public class ProtectRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060025C0 RID: 9664 RVA: 0x000712FE File Offset: 0x0006F4FE
		public ProtectRecord(short options)
		{
			this._options = options;
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0007130D File Offset: 0x0006F50D
		public ProtectRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : this(in1.ReadShort())
		{
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0007131B File Offset: 0x0006F51B
		public ProtectRecord(bool isProtected) : this(0)
		{
			this.Protect = isProtected;
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060025C3 RID: 9667 RVA: 0x0007132B File Offset: 0x0006F52B
		// (set) Token: 0x060025C4 RID: 9668 RVA: 0x0007133D File Offset: 0x0006F53D
		public bool Protect
		{
			get
			{
				return global::NPOI.HSSF.Record.ProtectRecord.protectFlag.IsSet((int)this._options);
			}
			set
			{
				this._options = (short)global::NPOI.HSSF.Record.ProtectRecord.protectFlag.SetBoolean((int)this._options, value);
			}
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00071358 File Offset: 0x0006F558
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PROTECT]\n");
			stringBuilder.Append("    .options = ").Append(global::NPOI.Util.HexDump.ShortToHex((int)this._options)).Append("\n");
			stringBuilder.Append("[/PROTECT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000713AD File Offset: 0x0006F5AD
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this._options);
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000199E4 File Offset: 0x00017BE4
		public override short Sid
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000713BB File Offset: 0x0006F5BB
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ProtectRecord(this._options);
		}

		// Token: 0x04000FDA RID: 4058
		public const short sid = 18;

		// Token: 0x04000FDB RID: 4059
		private static global::NPOI.Util.BitField protectFlag = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000FDC RID: 4060
		private short _options;
	}
}
