using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Pluralization;

namespace System.Data.Entity.ModelConfiguration.Design.PluralizationServices
{
	// Token: 0x0200021A RID: 538
	internal class StringBidirectionalDictionary : global::System.Data.Entity.Infrastructure.Pluralization.BidirectionalDictionary<string, string>
	{
		// Token: 0x06001C4D RID: 7245 RVA: 0x00050372 File Offset: 0x0004E572
		internal StringBidirectionalDictionary()
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0005037A File Offset: 0x0004E57A
		internal StringBidirectionalDictionary(global::System.Collections.Generic.Dictionary<string, string> firstToSecondDictionary) : base(firstToSecondDictionary)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00050383 File Offset: 0x0004E583
		internal override bool ExistsInFirst(string value)
		{
			return base.ExistsInFirst(value.ToLowerInvariant());
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00050391 File Offset: 0x0004E591
		internal override bool ExistsInSecond(string value)
		{
			return base.ExistsInSecond(value.ToLowerInvariant());
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0005039F File Offset: 0x0004E59F
		internal override string GetFirstValue(string value)
		{
			return base.GetFirstValue(value.ToLowerInvariant());
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000503AD File Offset: 0x0004E5AD
		internal override string GetSecondValue(string value)
		{
			return base.GetSecondValue(value.ToLowerInvariant());
		}
	}
}
