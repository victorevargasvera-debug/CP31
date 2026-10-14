using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000114 RID: 276
	public class MissingArgPtg : global::NPOI.SS.Formula.PTG.ScalarConstantPtg
	{
		// Token: 0x0600092A RID: 2346 RVA: 0x00018829 File Offset: 0x00016A29
		private MissingArgPtg()
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00018831 File Offset: 0x00016A31
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)(22 + base.PtgClass));
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0001853E File Offset: 0x0001673E
		public override string ToFormulaString()
		{
			return " ";
		}

		// Token: 0x040004B5 RID: 1205
		private const int SIZE = 1;

		// Token: 0x040004B6 RID: 1206
		public const byte sid = 22;

		// Token: 0x040004B7 RID: 1207
		public static global::NPOI.SS.Formula.PTG.Ptg instance = new global::NPOI.SS.Formula.PTG.MissingArgPtg();
	}
}
