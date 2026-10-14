using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000FA RID: 250
	public class AreaNPtg : global::NPOI.SS.Formula.PTG.Area2DPtgBase
	{
		// Token: 0x0600085A RID: 2138 RVA: 0x00016E1D File Offset: 0x0001501D
		public AreaNPtg(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00016E26 File Offset: 0x00015026
		protected override byte Sid
		{
			get
			{
				return 45;
			}
		}

		// Token: 0x04000456 RID: 1110
		public const short sid = 45;
	}
}
