using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Database
{
	// Token: 0x02000295 RID: 661
	[global::System.Runtime.Serialization.DataContract]
	public class GetDatabaseTableNamesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x000165DB File Offset: 0x000147DB
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x000165E3 File Offset: 0x000147E3
		[global::System.Runtime.Serialization.DataMember]
		internal string[] tableNames { get; set; }

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x000165EC File Offset: 0x000147EC
		public string[] TableNames
		{
			get
			{
				return this.tableNames;
			}
		}
	}
}
