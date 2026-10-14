using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000110 RID: 272
	[global::System.Runtime.Serialization.DataContract]
	public class GetTargetsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0000AFE8 File Offset: 0x000091E8
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x0000AFF0 File Offset: 0x000091F0
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.TargetInfo> targetInfos { get; set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0000AFF9 File Offset: 0x000091F9
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Target.TargetInfo> TargetInfos
		{
			get
			{
				return this.targetInfos;
			}
		}
	}
}
