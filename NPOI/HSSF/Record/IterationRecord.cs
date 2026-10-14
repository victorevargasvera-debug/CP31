using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003EF RID: 1007
	public class IterationRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002453 RID: 9299 RVA: 0x0006D702 File Offset: 0x0006B902
		public IterationRecord(bool iterateOn)
		{
			this._flags = global::NPOI.HSSF.Record.IterationRecord.iterationOn.SetBoolean(0, iterateOn);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0006D71C File Offset: 0x0006B91C
		public IterationRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._flags = (int)in1.ReadShort();
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x0006D730 File Offset: 0x0006B930
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0006D742 File Offset: 0x0006B942
		public bool Iteration
		{
			get
			{
				return global::NPOI.HSSF.Record.IterationRecord.iterationOn.IsSet(this._flags);
			}
			set
			{
				this._flags = global::NPOI.HSSF.Record.IterationRecord.iterationOn.SetBoolean(this._flags, value);
			}
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0006D75C File Offset: 0x0006B95C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[ITERATION]\n");
			stringBuilder.Append("    .flags      = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._flags)).Append("\n");
			stringBuilder.Append("[/ITERATION]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0006D7B1 File Offset: 0x0006B9B1
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._flags);
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x0006D7BF File Offset: 0x0006B9BF
		public override short Sid
		{
			get
			{
				return 17;
			}
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0006D7C3 File Offset: 0x0006B9C3
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.IterationRecord(this.Iteration);
		}

		// Token: 0x04000F46 RID: 3910
		public const short sid = 17;

		// Token: 0x04000F47 RID: 3911
		private static global::NPOI.Util.BitField iterationOn = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000F48 RID: 3912
		private int _flags;
	}
}
