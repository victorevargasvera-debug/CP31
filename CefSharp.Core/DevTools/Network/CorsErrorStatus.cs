using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001EB RID: 491
	[global::System.Runtime.Serialization.DataContract]
	public class CorsErrorStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00010FB7 File Offset: 0x0000F1B7
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00010FD3 File Offset: 0x0000F1D3
		public global::CefSharp.DevTools.Network.CorsError CorsError
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CorsError)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CorsError), this.corsError);
			}
			set
			{
				this.corsError = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00010FE6 File Offset: 0x0000F1E6
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00010FEE File Offset: 0x0000F1EE
		[global::System.Runtime.Serialization.DataMember(Name = "corsError", IsRequired = true)]
		internal string corsError { get; set; }

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00010FF7 File Offset: 0x0000F1F7
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00010FFF File Offset: 0x0000F1FF
		[global::System.Runtime.Serialization.DataMember(Name = "failedParameter", IsRequired = true)]
		public string FailedParameter { get; set; }
	}
}
