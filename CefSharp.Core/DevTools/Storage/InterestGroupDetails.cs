using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000125 RID: 293
	[global::System.Runtime.Serialization.DataContract]
	public class InterestGroupDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0000BB65 File Offset: 0x00009D65
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0000BB6D File Offset: 0x00009D6D
		[global::System.Runtime.Serialization.DataMember(Name = "ownerOrigin", IsRequired = true)]
		public string OwnerOrigin { get; set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0000BB76 File Offset: 0x00009D76
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x0000BB7E File Offset: 0x00009D7E
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0000BB87 File Offset: 0x00009D87
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x0000BB8F File Offset: 0x00009D8F
		[global::System.Runtime.Serialization.DataMember(Name = "expirationTime", IsRequired = true)]
		public double ExpirationTime { get; set; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0000BB98 File Offset: 0x00009D98
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		[global::System.Runtime.Serialization.DataMember(Name = "joiningOrigin", IsRequired = true)]
		public string JoiningOrigin { get; set; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0000BBA9 File Offset: 0x00009DA9
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x0000BBB1 File Offset: 0x00009DB1
		[global::System.Runtime.Serialization.DataMember(Name = "biddingUrl", IsRequired = false)]
		public string BiddingUrl { get; set; }

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0000BBBA File Offset: 0x00009DBA
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x0000BBC2 File Offset: 0x00009DC2
		[global::System.Runtime.Serialization.DataMember(Name = "biddingWasmHelperUrl", IsRequired = false)]
		public string BiddingWasmHelperUrl { get; set; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0000BBCB File Offset: 0x00009DCB
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x0000BBD3 File Offset: 0x00009DD3
		[global::System.Runtime.Serialization.DataMember(Name = "updateUrl", IsRequired = false)]
		public string UpdateUrl { get; set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0000BBDC File Offset: 0x00009DDC
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		[global::System.Runtime.Serialization.DataMember(Name = "trustedBiddingSignalsUrl", IsRequired = false)]
		public string TrustedBiddingSignalsUrl { get; set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0000BBED File Offset: 0x00009DED
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x0000BBF5 File Offset: 0x00009DF5
		[global::System.Runtime.Serialization.DataMember(Name = "trustedBiddingSignalsKeys", IsRequired = true)]
		public string[] TrustedBiddingSignalsKeys { get; set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0000BBFE File Offset: 0x00009DFE
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x0000BC06 File Offset: 0x00009E06
		[global::System.Runtime.Serialization.DataMember(Name = "userBiddingSignals", IsRequired = false)]
		public string UserBiddingSignals { get; set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0000BC0F File Offset: 0x00009E0F
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x0000BC17 File Offset: 0x00009E17
		[global::System.Runtime.Serialization.DataMember(Name = "ads", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.InterestGroupAd> Ads { get; set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0000BC20 File Offset: 0x00009E20
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x0000BC28 File Offset: 0x00009E28
		[global::System.Runtime.Serialization.DataMember(Name = "adComponents", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.InterestGroupAd> AdComponents { get; set; }
	}
}
