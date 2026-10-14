using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001FF RID: 511
	[global::System.Runtime.Serialization.DataContract]
	public class AuthChallenge : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00011891 File Offset: 0x0000FA91
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x000118AD File Offset: 0x0000FAAD
		public global::CefSharp.DevTools.Network.AuthChallengeSource? Source
		{
			get
			{
				return (global::CefSharp.DevTools.Network.AuthChallengeSource?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.AuthChallengeSource?), this.source);
			}
			set
			{
				this.source = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000118C0 File Offset: 0x0000FAC0
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[global::System.Runtime.Serialization.DataMember(Name = "source", IsRequired = false)]
		internal string source { get; set; }

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x000118D1 File Offset: 0x0000FAD1
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x000118D9 File Offset: 0x0000FAD9
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; set; }

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000118E2 File Offset: 0x0000FAE2
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x000118EA File Offset: 0x0000FAEA
		[global::System.Runtime.Serialization.DataMember(Name = "scheme", IsRequired = true)]
		public string Scheme { get; set; }

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000118F3 File Offset: 0x0000FAF3
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x000118FB File Offset: 0x0000FAFB
		[global::System.Runtime.Serialization.DataMember(Name = "realm", IsRequired = true)]
		public string Realm { get; set; }
	}
}
