using System;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003CB RID: 971
	public class DrawingSelectionRecord : global::NPOI.HSSF.Record.AbstractEscherHolderRecord
	{
		// Token: 0x06002221 RID: 8737 RVA: 0x0006739E File Offset: 0x0006559E
		public DrawingSelectionRecord()
		{
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000673A6 File Offset: 0x000655A6
		public DrawingSelectionRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x000676A7 File Offset: 0x000658A7
		protected override string RecordName
		{
			get
			{
				return "MSODRAWINGSELECTION";
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000676AE File Offset: 0x000658AE
		public override short Sid
		{
			get
			{
				return 237;
			}
		}

		// Token: 0x04000D60 RID: 3424
		public const short sid = 237;
	}
}
