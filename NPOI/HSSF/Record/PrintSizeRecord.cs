using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000409 RID: 1033
	public class PrintSizeRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PrintSizeRecord()
		{
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000711E6 File Offset: 0x0006F3E6
		public PrintSizeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.printSize = in1.ReadShort();
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000711FA File Offset: 0x0006F3FA
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x00071202 File Offset: 0x0006F402
		public short PrintSize
		{
			get
			{
				return this.printSize;
			}
			set
			{
				this.printSize = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0007120B File Offset: 0x0006F40B
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.printSize);
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00071219 File Offset: 0x0006F419
		public override short Sid
		{
			get
			{
				return 51;
			}
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x0007121D File Offset: 0x0006F41D
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.PrintSizeRecord
			{
				printSize = this.printSize
			};
		}

		// Token: 0x04000FD5 RID: 4053
		public const short sid = 51;

		// Token: 0x04000FD6 RID: 4054
		private short printSize;
	}
}
