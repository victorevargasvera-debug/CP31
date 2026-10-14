using System;
using NPOI.SS.Formula.Atp;
using NPOI.SS.Formula.Functions;

namespace NPOI.SS.Formula.UDF
{
	// Token: 0x020000EB RID: 235
	public abstract class UDFFinder
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x00015F39 File Offset: 0x00014139
		public static global::NPOI.SS.Formula.UDF.UDFFinder GetDefault()
		{
			return new global::NPOI.SS.Formula.UDF.AggregatingUDFFinder(new global::NPOI.SS.Formula.UDF.UDFFinder[]
			{
				global::NPOI.SS.Formula.Atp.AnalysisToolPak.instance
			});
		}

		// Token: 0x060007E3 RID: 2019
		public abstract global::NPOI.SS.Formula.Functions.FreeRefFunction FindFunction(string name);
	}
}
