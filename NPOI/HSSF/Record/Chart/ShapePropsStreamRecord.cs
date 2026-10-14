using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200048C RID: 1164
	public class ShapePropsStreamRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AF9 RID: 11001 RVA: 0x0006144D File Offset: 0x0005F64D
		public ShapePropsStreamRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x0007FD9D File Offset: 0x0007DF9D
		public override short Sid
		{
			get
			{
				return 2212;
			}
		}

		// Token: 0x0400128D RID: 4749
		public const short sid = 2212;
	}
}
