using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000204 RID: 516
	[global::System.Runtime.Serialization.DataContract]
	public class SignedExchangeSignature : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00011A0F File Offset: 0x0000FC0F
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00011A17 File Offset: 0x0000FC17
		[global::System.Runtime.Serialization.DataMember(Name = "label", IsRequired = true)]
		public string Label { get; set; }

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00011A20 File Offset: 0x0000FC20
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00011A28 File Offset: 0x0000FC28
		[global::System.Runtime.Serialization.DataMember(Name = "signature", IsRequired = true)]
		public string Signature { get; set; }

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00011A31 File Offset: 0x0000FC31
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00011A39 File Offset: 0x0000FC39
		[global::System.Runtime.Serialization.DataMember(Name = "integrity", IsRequired = true)]
		public string Integrity { get; set; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00011A42 File Offset: 0x0000FC42
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00011A4A File Offset: 0x0000FC4A
		[global::System.Runtime.Serialization.DataMember(Name = "certUrl", IsRequired = false)]
		public string CertUrl { get; set; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00011A53 File Offset: 0x0000FC53
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00011A5B File Offset: 0x0000FC5B
		[global::System.Runtime.Serialization.DataMember(Name = "certSha256", IsRequired = false)]
		public string CertSha256 { get; set; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00011A64 File Offset: 0x0000FC64
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00011A6C File Offset: 0x0000FC6C
		[global::System.Runtime.Serialization.DataMember(Name = "validityUrl", IsRequired = true)]
		public string ValidityUrl { get; set; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00011A75 File Offset: 0x0000FC75
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00011A7D File Offset: 0x0000FC7D
		[global::System.Runtime.Serialization.DataMember(Name = "date", IsRequired = true)]
		public int Date { get; set; }

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00011A86 File Offset: 0x0000FC86
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00011A8E File Offset: 0x0000FC8E
		[global::System.Runtime.Serialization.DataMember(Name = "expires", IsRequired = true)]
		public int Expires { get; set; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00011A97 File Offset: 0x0000FC97
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00011A9F File Offset: 0x0000FC9F
		[global::System.Runtime.Serialization.DataMember(Name = "certificates", IsRequired = false)]
		public string[] Certificates { get; set; }
	}
}
