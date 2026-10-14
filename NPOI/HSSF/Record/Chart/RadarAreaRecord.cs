using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000483 RID: 1155
	public class RadarAreaRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AD0 RID: 10960 RVA: 0x0006144D File Offset: 0x0005F64D
		public RadarAreaRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0007FC97 File Offset: 0x0007DE97
		public override short Sid
		{
			get
			{
				return 4160;
			}
		}

		// Token: 0x04001283 RID: 4739
		public const short sid = 4160;
	}
}
