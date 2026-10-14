using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IO
{
	// Token: 0x0200002E RID: 46
	[global::System.Runtime.Serialization.DataContract]
	public class ResolveBlobResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00004FAD File Offset: 0x000031AD
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00004FB5 File Offset: 0x000031B5
		[global::System.Runtime.Serialization.DataMember]
		internal string uuid { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00004FBE File Offset: 0x000031BE
		public string Uuid
		{
			get
			{
				return this.uuid;
			}
		}
	}
}
