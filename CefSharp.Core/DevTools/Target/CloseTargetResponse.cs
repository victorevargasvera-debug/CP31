using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x0200010B RID: 267
	[global::System.Runtime.Serialization.DataContract]
	public class CloseTargetResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0000AF43 File Offset: 0x00009143
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x0000AF4B File Offset: 0x0000914B
		[global::System.Runtime.Serialization.DataMember]
		internal bool success { get; set; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0000AF54 File Offset: 0x00009154
		public bool Success
		{
			get
			{
				return this.success;
			}
		}
	}
}
