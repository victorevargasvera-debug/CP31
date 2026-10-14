using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C3 RID: 195
	[global::System.Runtime.Serialization.DataContract]
	public class Credential : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000092FC File Offset: 0x000074FC
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00009304 File Offset: 0x00007504
		[global::System.Runtime.Serialization.DataMember(Name = "credentialId", IsRequired = true)]
		public byte[] CredentialId { get; set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0000930D File Offset: 0x0000750D
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00009315 File Offset: 0x00007515
		[global::System.Runtime.Serialization.DataMember(Name = "isResidentCredential", IsRequired = true)]
		public bool IsResidentCredential { get; set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0000931E File Offset: 0x0000751E
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00009326 File Offset: 0x00007526
		[global::System.Runtime.Serialization.DataMember(Name = "rpId", IsRequired = false)]
		public string RpId { get; set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0000932F File Offset: 0x0000752F
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00009337 File Offset: 0x00007537
		[global::System.Runtime.Serialization.DataMember(Name = "privateKey", IsRequired = true)]
		public byte[] PrivateKey { get; set; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00009340 File Offset: 0x00007540
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00009348 File Offset: 0x00007548
		[global::System.Runtime.Serialization.DataMember(Name = "userHandle", IsRequired = false)]
		public byte[] UserHandle { get; set; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00009351 File Offset: 0x00007551
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00009359 File Offset: 0x00007559
		[global::System.Runtime.Serialization.DataMember(Name = "signCount", IsRequired = true)]
		public int SignCount { get; set; }

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00009362 File Offset: 0x00007562
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x0000936A File Offset: 0x0000756A
		[global::System.Runtime.Serialization.DataMember(Name = "largeBlob", IsRequired = false)]
		public byte[] LargeBlob { get; set; }
	}
}
