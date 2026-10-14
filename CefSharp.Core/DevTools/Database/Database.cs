using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Database
{
	// Token: 0x02000291 RID: 657
	[global::System.Runtime.Serialization.DataContract]
	public class Database : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x000164F9 File Offset: 0x000146F9
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x00016501 File Offset: 0x00014701
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0001650A File Offset: 0x0001470A
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00016512 File Offset: 0x00014712
		[global::System.Runtime.Serialization.DataMember(Name = "domain", IsRequired = true)]
		public string Domain { get; set; }

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0001651B File Offset: 0x0001471B
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00016523 File Offset: 0x00014723
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0001652C File Offset: 0x0001472C
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00016534 File Offset: 0x00014734
		[global::System.Runtime.Serialization.DataMember(Name = "version", IsRequired = true)]
		public string Version { get; set; }
	}
}
