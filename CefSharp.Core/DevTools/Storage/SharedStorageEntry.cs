using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000127 RID: 295
	[global::System.Runtime.Serialization.DataContract]
	public class SharedStorageEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0000BC39 File Offset: 0x00009E39
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x0000BC41 File Offset: 0x00009E41
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public string Key { get; set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0000BC4A File Offset: 0x00009E4A
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x0000BC52 File Offset: 0x00009E52
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
