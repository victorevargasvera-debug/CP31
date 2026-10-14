using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000480 RID: 1152
	public class LegendExceptionRecord : global::NPOI.HSSF.Record.RowDataRecord
	{
		// Token: 0x06002AB2 RID: 10930 RVA: 0x0006144D File Offset: 0x0005F64D
		public LegendExceptionRecord(global::NPOI.HSSF.Record.RecordInputStream ris) : base(ris)
		{
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x00061456 File Offset: 0x0005F656
		protected override int DataSize
		{
			get
			{
				return base.DataSize;
			}
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0006145E File Offset: 0x0005F65E
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002AB5 RID: 10933 RVA: 0x0007F975 File Offset: 0x0007DB75
		public override short Sid
		{
			get
			{
				return 4163;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x00008C75 File Offset: 0x00006E75
		// (set) Token: 0x06002AB7 RID: 10935 RVA: 0x00008C75 File Offset: 0x00006E75
		public short LegendEntry
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x04001271 RID: 4721
		public const short sid = 4163;
	}
}
