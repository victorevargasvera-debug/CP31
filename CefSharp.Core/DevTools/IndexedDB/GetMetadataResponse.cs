using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x0200027B RID: 635
	[global::System.Runtime.Serialization.DataContract]
	public class GetMetadataResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00015589 File Offset: 0x00013789
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x00015591 File Offset: 0x00013791
		[global::System.Runtime.Serialization.DataMember]
		internal double entriesCount { get; set; }

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0001559A File Offset: 0x0001379A
		public double EntriesCount
		{
			get
			{
				return this.entriesCount;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x000155A2 File Offset: 0x000137A2
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x000155AA File Offset: 0x000137AA
		[global::System.Runtime.Serialization.DataMember]
		internal double keyGeneratorValue { get; set; }

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000155B3 File Offset: 0x000137B3
		public double KeyGeneratorValue
		{
			get
			{
				return this.keyGeneratorValue;
			}
		}
	}
}
