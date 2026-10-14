using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x0200010E RID: 270
	[global::System.Runtime.Serialization.DataContract]
	public class CreateTargetResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0000AFA6 File Offset: 0x000091A6
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x0000AFAE File Offset: 0x000091AE
		[global::System.Runtime.Serialization.DataMember]
		internal string targetId { get; set; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0000AFB7 File Offset: 0x000091B7
		public string TargetId
		{
			get
			{
				return this.targetId;
			}
		}
	}
}
