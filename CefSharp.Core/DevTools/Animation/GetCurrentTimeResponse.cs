using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x0200037B RID: 891
	[global::System.Runtime.Serialization.DataContract]
	public class GetCurrentTimeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0001C6AE File Offset: 0x0001A8AE
		// (set) Token: 0x06001AE8 RID: 6888 RVA: 0x0001C6B6 File Offset: 0x0001A8B6
		[global::System.Runtime.Serialization.DataMember]
		internal double currentTime { get; set; }

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x0001C6BF File Offset: 0x0001A8BF
		public double CurrentTime
		{
			get
			{
				return this.currentTime;
			}
		}
	}
}
