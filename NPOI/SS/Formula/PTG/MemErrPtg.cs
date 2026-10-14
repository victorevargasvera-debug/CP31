using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000112 RID: 274
	public class MemErrPtg : global::NPOI.SS.Formula.PTG.MemAreaPtg
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x000187AE File Offset: 0x000169AE
		public MemErrPtg(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000187B7 File Offset: 0x000169B7
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(39 + base.PtgClass));
			out1.WriteInt(this.field_1_reserved);
			out1.WriteShort((int)this.field_2_subex_len);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000187E0 File Offset: 0x000169E0
		public override string ToFormulaString()
		{
			return "ERR#";
		}

		// Token: 0x040004B0 RID: 1200
		public new const short sid = 39;

		// Token: 0x040004B1 RID: 1201
		private int field_1_reserved;

		// Token: 0x040004B2 RID: 1202
		private short field_2_subex_len;
	}
}
