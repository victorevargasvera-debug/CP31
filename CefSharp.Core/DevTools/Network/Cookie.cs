using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F8 RID: 504
	[global::System.Runtime.Serialization.DataContract]
	public class Cookie : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000114B0 File Offset: 0x0000F6B0
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x000114B8 File Offset: 0x0000F6B8
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000114C1 File Offset: 0x0000F6C1
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x000114C9 File Offset: 0x0000F6C9
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x000114D2 File Offset: 0x0000F6D2
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x000114DA File Offset: 0x0000F6DA
		[global::System.Runtime.Serialization.DataMember(Name = "domain", IsRequired = true)]
		public string Domain { get; set; }

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000114E3 File Offset: 0x0000F6E3
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x000114EB File Offset: 0x0000F6EB
		[global::System.Runtime.Serialization.DataMember(Name = "path", IsRequired = true)]
		public string Path { get; set; }

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000114F4 File Offset: 0x0000F6F4
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000114FC File Offset: 0x0000F6FC
		[global::System.Runtime.Serialization.DataMember(Name = "expires", IsRequired = true)]
		public double Expires { get; set; }

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00011505 File Offset: 0x0000F705
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x0001150D File Offset: 0x0000F70D
		[global::System.Runtime.Serialization.DataMember(Name = "size", IsRequired = true)]
		public int Size { get; set; }

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00011516 File Offset: 0x0000F716
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x0001151E File Offset: 0x0000F71E
		[global::System.Runtime.Serialization.DataMember(Name = "httpOnly", IsRequired = true)]
		public bool HttpOnly { get; set; }

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00011527 File Offset: 0x0000F727
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x0001152F File Offset: 0x0000F72F
		[global::System.Runtime.Serialization.DataMember(Name = "secure", IsRequired = true)]
		public bool Secure { get; set; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00011538 File Offset: 0x0000F738
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x00011540 File Offset: 0x0000F740
		[global::System.Runtime.Serialization.DataMember(Name = "session", IsRequired = true)]
		public bool Session { get; set; }

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00011549 File Offset: 0x0000F749
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x00011565 File Offset: 0x0000F765
		public global::CefSharp.DevTools.Network.CookieSameSite? SameSite
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CookieSameSite?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CookieSameSite?), this.sameSite);
			}
			set
			{
				this.sameSite = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00011578 File Offset: 0x0000F778
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x00011580 File Offset: 0x0000F780
		[global::System.Runtime.Serialization.DataMember(Name = "sameSite", IsRequired = false)]
		internal string sameSite { get; set; }

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00011589 File Offset: 0x0000F789
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x000115A5 File Offset: 0x0000F7A5
		public global::CefSharp.DevTools.Network.CookiePriority Priority
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CookiePriority)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CookiePriority), this.priority);
			}
			set
			{
				this.priority = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x000115B8 File Offset: 0x0000F7B8
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x000115C0 File Offset: 0x0000F7C0
		[global::System.Runtime.Serialization.DataMember(Name = "priority", IsRequired = true)]
		internal string priority { get; set; }

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000115C9 File Offset: 0x0000F7C9
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x000115D1 File Offset: 0x0000F7D1
		[global::System.Runtime.Serialization.DataMember(Name = "sameParty", IsRequired = true)]
		public bool SameParty { get; set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x000115DA File Offset: 0x0000F7DA
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x000115F6 File Offset: 0x0000F7F6
		public global::CefSharp.DevTools.Network.CookieSourceScheme SourceScheme
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CookieSourceScheme)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CookieSourceScheme), this.sourceScheme);
			}
			set
			{
				this.sourceScheme = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00011609 File Offset: 0x0000F809
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00011611 File Offset: 0x0000F811
		[global::System.Runtime.Serialization.DataMember(Name = "sourceScheme", IsRequired = true)]
		internal string sourceScheme { get; set; }

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x0001161A File Offset: 0x0000F81A
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x00011622 File Offset: 0x0000F822
		[global::System.Runtime.Serialization.DataMember(Name = "sourcePort", IsRequired = true)]
		public int SourcePort { get; set; }

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x0001162B File Offset: 0x0000F82B
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x00011633 File Offset: 0x0000F833
		[global::System.Runtime.Serialization.DataMember(Name = "partitionKey", IsRequired = false)]
		public string PartitionKey { get; set; }

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0001163C File Offset: 0x0000F83C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00011644 File Offset: 0x0000F844
		[global::System.Runtime.Serialization.DataMember(Name = "partitionKeyOpaque", IsRequired = false)]
		public bool? PartitionKeyOpaque { get; set; }
	}
}
