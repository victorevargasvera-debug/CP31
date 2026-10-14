using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000162 RID: 354
	public enum AdFrameExplanation
	{
		// Token: 0x040004FC RID: 1276
		[global::System.Runtime.Serialization.EnumMember(Value = "ParentIsAd")]
		ParentIsAd,
		// Token: 0x040004FD RID: 1277
		[global::System.Runtime.Serialization.EnumMember(Value = "CreatedByAdScript")]
		CreatedByAdScript,
		// Token: 0x040004FE RID: 1278
		[global::System.Runtime.Serialization.EnumMember(Value = "MatchedBlockingRule")]
		MatchedBlockingRule
	}
}
