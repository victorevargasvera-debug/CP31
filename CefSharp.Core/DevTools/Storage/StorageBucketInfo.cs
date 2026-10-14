using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200012D RID: 301
	[global::System.Runtime.Serialization.DataContract]
	public class StorageBucketInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0000BD71 File Offset: 0x00009F71
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0000BD79 File Offset: 0x00009F79
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; set; }

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0000BD82 File Offset: 0x00009F82
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x0000BD8A File Offset: 0x00009F8A
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0000BD93 File Offset: 0x00009F93
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0000BD9B File Offset: 0x00009F9B
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0000BDAC File Offset: 0x00009FAC
		[global::System.Runtime.Serialization.DataMember(Name = "isDefault", IsRequired = true)]
		public bool IsDefault { get; set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0000BDB5 File Offset: 0x00009FB5
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0000BDBD File Offset: 0x00009FBD
		[global::System.Runtime.Serialization.DataMember(Name = "expiration", IsRequired = true)]
		public double Expiration { get; set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0000BDC6 File Offset: 0x00009FC6
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0000BDCE File Offset: 0x00009FCE
		[global::System.Runtime.Serialization.DataMember(Name = "quota", IsRequired = true)]
		public double Quota { get; set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0000BDD7 File Offset: 0x00009FD7
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0000BDDF File Offset: 0x00009FDF
		[global::System.Runtime.Serialization.DataMember(Name = "persistent", IsRequired = true)]
		public bool Persistent { get; set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0000BE04 File Offset: 0x0000A004
		public global::CefSharp.DevTools.Storage.StorageBucketsDurability Durability
		{
			get
			{
				return (global::CefSharp.DevTools.Storage.StorageBucketsDurability)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Storage.StorageBucketsDurability), this.durability);
			}
			set
			{
				this.durability = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0000BE17 File Offset: 0x0000A017
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x0000BE1F File Offset: 0x0000A01F
		[global::System.Runtime.Serialization.DataMember(Name = "durability", IsRequired = true)]
		internal string durability { get; set; }
	}
}
