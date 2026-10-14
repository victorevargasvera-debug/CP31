using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000128 RID: 296
	[global::System.Runtime.Serialization.DataContract]
	public class SharedStorageMetadata : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x0000BC63 File Offset: 0x00009E63
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0000BC6B File Offset: 0x00009E6B
		[global::System.Runtime.Serialization.DataMember(Name = "creationTime", IsRequired = true)]
		public double CreationTime { get; set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0000BC74 File Offset: 0x00009E74
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x0000BC7C File Offset: 0x00009E7C
		[global::System.Runtime.Serialization.DataMember(Name = "length", IsRequired = true)]
		public int Length { get; set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0000BC85 File Offset: 0x00009E85
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0000BC8D File Offset: 0x00009E8D
		[global::System.Runtime.Serialization.DataMember(Name = "remainingBudget", IsRequired = true)]
		public double RemainingBudget { get; set; }
	}
}
