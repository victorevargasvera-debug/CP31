using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000237 RID: 567
	[global::System.Runtime.Serialization.DataContract]
	public class GetCertificateResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00012A54 File Offset: 0x00010C54
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x00012A5C File Offset: 0x00010C5C
		[global::System.Runtime.Serialization.DataMember]
		internal string[] tableNames { get; set; }

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00012A65 File Offset: 0x00010C65
		public string[] TableNames
		{
			get
			{
				return this.tableNames;
			}
		}
	}
}
