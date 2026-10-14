using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x0200010F RID: 271
	[global::System.Runtime.Serialization.DataContract]
	public class GetTargetInfoResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x0000AFC7 File Offset: 0x000091C7
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0000AFCF File Offset: 0x000091CF
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Target.TargetInfo targetInfo { get; set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000AFD8 File Offset: 0x000091D8
		public global::CefSharp.DevTools.Target.TargetInfo TargetInfo
		{
			get
			{
				return this.targetInfo;
			}
		}
	}
}
