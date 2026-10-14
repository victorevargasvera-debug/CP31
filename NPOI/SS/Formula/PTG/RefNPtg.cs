using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000124 RID: 292
	public class RefNPtg : global::NPOI.SS.Formula.PTG.Ref2DPtgBase
	{
		// Token: 0x060009A6 RID: 2470 RVA: 0x00019459 File Offset: 0x00017659
		public RefNPtg(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00019462 File Offset: 0x00017662
		protected override byte Sid
		{
			get
			{
				return 44;
			}
		}

		// Token: 0x040004E5 RID: 1253
		public const byte sid = 44;
	}
}
