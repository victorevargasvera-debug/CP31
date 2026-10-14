using System;
using NPOI.SS.Formula;
using NPOI.SS.UserModel;
using NPOI.SS.UserModel.Helpers;
using NPOI.Util;

namespace NPOI.HSSF.UserModel.helpers
{
	// Token: 0x02000392 RID: 914
	public class HSSFRowShifter : global::NPOI.SS.UserModel.Helpers.RowShifter
	{
		// Token: 0x06001F22 RID: 7970 RVA: 0x0005FCE4 File Offset: 0x0005DEE4
		public HSSFRowShifter(global::NPOI.HSSF.UserModel.HSSFSheet sh) : base(sh)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0005FCED File Offset: 0x0005DEED
		public override void UpdateNamedRanges(global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			throw new global::System.NotImplementedException("HSSFRowShifter.updateNamedRanges");
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0005FCF9 File Offset: 0x0005DEF9
		public override void UpdateFormulas(global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			throw new global::System.NotImplementedException("updateFormulas");
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0005FD05 File Offset: 0x0005DF05
		public override void UpdateRowFormulas(global::NPOI.SS.UserModel.IRow row, global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			throw new global::System.NotImplementedException("updateRowFormulas");
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0005FD11 File Offset: 0x0005DF11
		public override void UpdateConditionalFormatting(global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			throw new global::System.NotImplementedException("updateConditionalFormatting");
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x0005FD1D File Offset: 0x0005DF1D
		public override void UpdateHyperlinks(global::NPOI.SS.Formula.FormulaShifter Shifter)
		{
			throw new global::System.NotImplementedException("updateHyperlinks");
		}

		// Token: 0x04000BCC RID: 3020
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.UserModel.helpers.HSSFRowShifter));
	}
}
