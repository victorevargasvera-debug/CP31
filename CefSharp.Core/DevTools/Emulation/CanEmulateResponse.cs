using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x0200028C RID: 652
	[global::System.Runtime.Serialization.DataContract]
	public class CanEmulateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00015C6B File Offset: 0x00013E6B
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x00015C73 File Offset: 0x00013E73
		[global::System.Runtime.Serialization.DataMember]
		internal bool result { get; set; }

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x00015C7C File Offset: 0x00013E7C
		public bool Result
		{
			get
			{
				return this.result;
			}
		}
	}
}
