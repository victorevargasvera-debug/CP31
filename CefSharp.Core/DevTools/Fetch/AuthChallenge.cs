using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000E7 RID: 231
	[global::System.Runtime.Serialization.DataContract]
	public class AuthChallenge : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x0000A073 File Offset: 0x00008273
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x0000A08F File Offset: 0x0000828F
		public global::CefSharp.DevTools.Fetch.AuthChallengeSource? Source
		{
			get
			{
				return (global::CefSharp.DevTools.Fetch.AuthChallengeSource?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Fetch.AuthChallengeSource?), this.source);
			}
			set
			{
				this.source = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x0000A0A2 File Offset: 0x000082A2
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x0000A0AA File Offset: 0x000082AA
		[global::System.Runtime.Serialization.DataMember(Name = "source", IsRequired = false)]
		internal string source { get; set; }

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0000A0B3 File Offset: 0x000082B3
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x0000A0BB File Offset: 0x000082BB
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0000A0C4 File Offset: 0x000082C4
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x0000A0CC File Offset: 0x000082CC
		[global::System.Runtime.Serialization.DataMember(Name = "scheme", IsRequired = true)]
		public string Scheme { get; set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0000A0D5 File Offset: 0x000082D5
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x0000A0DD File Offset: 0x000082DD
		[global::System.Runtime.Serialization.DataMember(Name = "realm", IsRequired = true)]
		public string Realm { get; set; }
	}
}
