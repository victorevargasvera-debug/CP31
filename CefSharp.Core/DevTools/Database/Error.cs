using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Database
{
	// Token: 0x02000292 RID: 658
	[global::System.Runtime.Serialization.DataContract]
	public class Error : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x00016545 File Offset: 0x00014745
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0001654D File Offset: 0x0001474D
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; set; }

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00016556 File Offset: 0x00014756
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x0001655E File Offset: 0x0001475E
		[global::System.Runtime.Serialization.DataMember(Name = "code", IsRequired = true)]
		public int Code { get; set; }
	}
}
