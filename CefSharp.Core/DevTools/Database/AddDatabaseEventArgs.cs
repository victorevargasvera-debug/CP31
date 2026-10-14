using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Database
{
	// Token: 0x02000293 RID: 659
	[global::System.Runtime.Serialization.DataContract]
	public class AddDatabaseEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0001656F File Offset: 0x0001476F
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00016577 File Offset: 0x00014777
		[global::System.Runtime.Serialization.DataMember(Name = "database", IsRequired = true)]
		public global::CefSharp.DevTools.Database.Database Database { get; private set; }
	}
}
