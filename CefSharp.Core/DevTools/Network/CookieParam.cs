using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001FD RID: 509
	[global::System.Runtime.Serialization.DataContract]
	public class CookieParam : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0001170E File Offset: 0x0000F90E
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00011716 File Offset: 0x0000F916
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0001171F File Offset: 0x0000F91F
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00011727 File Offset: 0x0000F927
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x00011730 File Offset: 0x0000F930
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x00011738 File Offset: 0x0000F938
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = false)]
		public string Url { get; set; }

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00011741 File Offset: 0x0000F941
		// (set) Token: 0x06000F95 RID: 3989 RVA: 0x00011749 File Offset: 0x0000F949
		[global::System.Runtime.Serialization.DataMember(Name = "domain", IsRequired = false)]
		public string Domain { get; set; }

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06000F96 RID: 3990 RVA: 0x00011752 File Offset: 0x0000F952
		// (set) Token: 0x06000F97 RID: 3991 RVA: 0x0001175A File Offset: 0x0000F95A
		[global::System.Runtime.Serialization.DataMember(Name = "path", IsRequired = false)]
		public string Path { get; set; }

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00011763 File Offset: 0x0000F963
		// (set) Token: 0x06000F99 RID: 3993 RVA: 0x0001176B File Offset: 0x0000F96B
		[global::System.Runtime.Serialization.DataMember(Name = "secure", IsRequired = false)]
		public bool? Secure { get; set; }

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00011774 File Offset: 0x0000F974
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0001177C File Offset: 0x0000F97C
		[global::System.Runtime.Serialization.DataMember(Name = "httpOnly", IsRequired = false)]
		public bool? HttpOnly { get; set; }

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00011785 File Offset: 0x0000F985
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x000117A1 File Offset: 0x0000F9A1
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

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000117B4 File Offset: 0x0000F9B4
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x000117BC File Offset: 0x0000F9BC
		[global::System.Runtime.Serialization.DataMember(Name = "sameSite", IsRequired = false)]
		internal string sameSite { get; set; }

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x000117C5 File Offset: 0x0000F9C5
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x000117CD File Offset: 0x0000F9CD
		[global::System.Runtime.Serialization.DataMember(Name = "expires", IsRequired = false)]
		public double? Expires { get; set; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x000117D6 File Offset: 0x0000F9D6
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000117F2 File Offset: 0x0000F9F2
		public global::CefSharp.DevTools.Network.CookiePriority? Priority
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CookiePriority?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CookiePriority?), this.priority);
			}
			set
			{
				this.priority = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00011805 File Offset: 0x0000FA05
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x0001180D File Offset: 0x0000FA0D
		[global::System.Runtime.Serialization.DataMember(Name = "priority", IsRequired = false)]
		internal string priority { get; set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00011816 File Offset: 0x0000FA16
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x0001181E File Offset: 0x0000FA1E
		[global::System.Runtime.Serialization.DataMember(Name = "sameParty", IsRequired = false)]
		public bool? SameParty { get; set; }

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00011827 File Offset: 0x0000FA27
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00011843 File Offset: 0x0000FA43
		public global::CefSharp.DevTools.Network.CookieSourceScheme? SourceScheme
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CookieSourceScheme?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CookieSourceScheme?), this.sourceScheme);
			}
			set
			{
				this.sourceScheme = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00011856 File Offset: 0x0000FA56
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0001185E File Offset: 0x0000FA5E
		[global::System.Runtime.Serialization.DataMember(Name = "sourceScheme", IsRequired = false)]
		internal string sourceScheme { get; set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00011867 File Offset: 0x0000FA67
		// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0001186F File Offset: 0x0000FA6F
		[global::System.Runtime.Serialization.DataMember(Name = "sourcePort", IsRequired = false)]
		public int? SourcePort { get; set; }

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00011878 File Offset: 0x0000FA78
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00011880 File Offset: 0x0000FA80
		[global::System.Runtime.Serialization.DataMember(Name = "partitionKey", IsRequired = false)]
		public string PartitionKey { get; set; }
	}
}
