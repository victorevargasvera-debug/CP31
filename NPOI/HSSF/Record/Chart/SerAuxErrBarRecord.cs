using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000487 RID: 1159
	public class SerAuxErrBarRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AE0 RID: 10976 RVA: 0x0006144D File Offset: 0x0005F64D
		public SerAuxErrBarRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x0007FCB3 File Offset: 0x0007DEB3
		public override short Sid
		{
			get
			{
				return 4187;
			}
		}

		// Token: 0x04001287 RID: 4743
		public const short sid = 4187;
	}
}
