using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x0200028D RID: 653
	[global::System.Runtime.Serialization.DataContract]
	public class SetVirtualTimePolicyResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x00015C8C File Offset: 0x00013E8C
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00015C94 File Offset: 0x00013E94
		[global::System.Runtime.Serialization.DataMember]
		internal double virtualTimeTicksBase { get; set; }

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00015C9D File Offset: 0x00013E9D
		public double VirtualTimeTicksBase
		{
			get
			{
				return this.virtualTimeTicksBase;
			}
		}
	}
}
