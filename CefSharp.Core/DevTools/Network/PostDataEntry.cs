using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E3 RID: 483
	[global::System.Runtime.Serialization.DataContract]
	public class PostDataEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00010C66 File Offset: 0x0000EE66
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x00010C6E File Offset: 0x0000EE6E
		[global::System.Runtime.Serialization.DataMember(Name = "bytes", IsRequired = false)]
		public byte[] Bytes { get; set; }
	}
}
