using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002CF RID: 719
	[global::System.Runtime.Serialization.DataContract]
	public class GetContentQuadsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00017CBB File Offset: 0x00015EBB
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00017CC3 File Offset: 0x00015EC3
		[global::System.Runtime.Serialization.DataMember]
		internal double[] quads { get; set; }

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00017CCC File Offset: 0x00015ECC
		public double[] Quads
		{
			get
			{
				return this.quads;
			}
		}
	}
}
