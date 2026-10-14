using System;

namespace CefSharp
{
	// Token: 0x0200003F RID: 63
	public enum ReferrerPolicy
	{
		// Token: 0x04000211 RID: 529
		ClearReferrerOnTransitionFromSecureToInsecure,
		// Token: 0x04000212 RID: 530
		Default = 0,
		// Token: 0x04000213 RID: 531
		ReduceReferrerGranularityOnTransitionCrossOrigin,
		// Token: 0x04000214 RID: 532
		OriginOnlyOnTransitionCrossOrigin,
		// Token: 0x04000215 RID: 533
		NeverClearReferrer,
		// Token: 0x04000216 RID: 534
		Origin,
		// Token: 0x04000217 RID: 535
		ClearReferrerOnTransitionCrossOrigin,
		// Token: 0x04000218 RID: 536
		OriginClearOnTransitionFromSecureToInsecure,
		// Token: 0x04000219 RID: 537
		NoReferrer,
		// Token: 0x0400021A RID: 538
		LastValue = 7
	}
}
