using System;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000364 RID: 868
	internal class EvaluationCycleDetectorManager
	{
		// Token: 0x06001A39 RID: 6713 RVA: 0x00050D02 File Offset: 0x0004EF02
		public static global::NPOI.HSSF.UserModel.EvaluationCycleDetector GetTracker()
		{
			return global::NPOI.HSSF.UserModel.EvaluationCycleDetectorManager.ecd;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0000253E File Offset: 0x0000073E
		private EvaluationCycleDetectorManager()
		{
		}

		// Token: 0x04000B15 RID: 2837
		[global::System.ThreadStatic]
		private static global::NPOI.HSSF.UserModel.EvaluationCycleDetector ecd = new global::NPOI.HSSF.UserModel.EvaluationCycleDetector();
	}
}
