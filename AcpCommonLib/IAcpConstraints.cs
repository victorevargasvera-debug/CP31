using System;

namespace AcpCommonLib
{
	// Token: 0x02000023 RID: 35
	public interface IAcpConstraints
	{
		// Token: 0x0600016D RID: 365
		void CalculateValidity();

		// Token: 0x0600016E RID: 366
		void CalculateApplicability();

		// Token: 0x0600016F RID: 367
		void CalculateVisibility();

		// Token: 0x06000170 RID: 368
		void CalculateEditability();

		// Token: 0x06000171 RID: 369
		void CallConstraints();

		// Token: 0x06000172 RID: 370
		void RepairRecRefs();

		// Token: 0x06000173 RID: 371
		void CalculateVisibility(bool allFields);

		// Token: 0x06000174 RID: 372
		void CalculateEditability(bool allFields);
	}
}
