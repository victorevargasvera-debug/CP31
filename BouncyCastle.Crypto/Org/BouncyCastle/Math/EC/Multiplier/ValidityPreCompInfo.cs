using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000232 RID: 562
	internal class ValidityPreCompInfo : global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo
	{
		// Token: 0x060016E1 RID: 5857 RVA: 0x0006FA53 File Offset: 0x0006DC53
		internal bool HasFailed()
		{
			return this.failed;
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0006FA5B File Offset: 0x0006DC5B
		internal void ReportFailed()
		{
			this.failed = true;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0006FA64 File Offset: 0x0006DC64
		internal bool HasCurveEquationPassed()
		{
			return this.curveEquationPassed;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0006FA6C File Offset: 0x0006DC6C
		internal void ReportCurveEquationPassed()
		{
			this.curveEquationPassed = true;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x0006FA75 File Offset: 0x0006DC75
		internal bool HasOrderPassed()
		{
			return this.orderPassed;
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0006FA7D File Offset: 0x0006DC7D
		internal void ReportOrderPassed()
		{
			this.orderPassed = true;
		}

		// Token: 0x040009D8 RID: 2520
		internal static readonly string PRECOMP_NAME = "bc_validity";

		// Token: 0x040009D9 RID: 2521
		private bool failed;

		// Token: 0x040009DA RID: 2522
		private bool curveEquationPassed;

		// Token: 0x040009DB RID: 2523
		private bool orderPassed;
	}
}
