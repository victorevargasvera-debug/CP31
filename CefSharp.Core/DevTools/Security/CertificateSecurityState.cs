using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x0200014B RID: 331
	[global::System.Runtime.Serialization.DataContract]
	public class CertificateSecurityState : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0000CE9C File Offset: 0x0000B09C
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
		[global::System.Runtime.Serialization.DataMember(Name = "protocol", IsRequired = true)]
		public string Protocol { get; set; }

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0000CEAD File Offset: 0x0000B0AD
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
		[global::System.Runtime.Serialization.DataMember(Name = "keyExchange", IsRequired = true)]
		public string KeyExchange { get; set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x0000CEBE File Offset: 0x0000B0BE
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x0000CEC6 File Offset: 0x0000B0C6
		[global::System.Runtime.Serialization.DataMember(Name = "keyExchangeGroup", IsRequired = false)]
		public string KeyExchangeGroup { get; set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x0000CECF File Offset: 0x0000B0CF
		// (set) Token: 0x06000A4D RID: 2637 RVA: 0x0000CED7 File Offset: 0x0000B0D7
		[global::System.Runtime.Serialization.DataMember(Name = "cipher", IsRequired = true)]
		public string Cipher { get; set; }

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[global::System.Runtime.Serialization.DataMember(Name = "mac", IsRequired = false)]
		public string Mac { get; set; }

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x0000CEF9 File Offset: 0x0000B0F9
		[global::System.Runtime.Serialization.DataMember(Name = "certificate", IsRequired = true)]
		public string[] Certificate { get; set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0000CF02 File Offset: 0x0000B102
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x0000CF0A File Offset: 0x0000B10A
		[global::System.Runtime.Serialization.DataMember(Name = "subjectName", IsRequired = true)]
		public string SubjectName { get; set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0000CF13 File Offset: 0x0000B113
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x0000CF1B File Offset: 0x0000B11B
		[global::System.Runtime.Serialization.DataMember(Name = "issuer", IsRequired = true)]
		public string Issuer { get; set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0000CF24 File Offset: 0x0000B124
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0000CF2C File Offset: 0x0000B12C
		[global::System.Runtime.Serialization.DataMember(Name = "validFrom", IsRequired = true)]
		public double ValidFrom { get; set; }

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0000CF35 File Offset: 0x0000B135
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x0000CF3D File Offset: 0x0000B13D
		[global::System.Runtime.Serialization.DataMember(Name = "validTo", IsRequired = true)]
		public double ValidTo { get; set; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0000CF46 File Offset: 0x0000B146
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x0000CF4E File Offset: 0x0000B14E
		[global::System.Runtime.Serialization.DataMember(Name = "certificateNetworkError", IsRequired = false)]
		public string CertificateNetworkError { get; set; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0000CF57 File Offset: 0x0000B157
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0000CF5F File Offset: 0x0000B15F
		[global::System.Runtime.Serialization.DataMember(Name = "certificateHasWeakSignature", IsRequired = true)]
		public bool CertificateHasWeakSignature { get; set; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0000CF68 File Offset: 0x0000B168
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0000CF70 File Offset: 0x0000B170
		[global::System.Runtime.Serialization.DataMember(Name = "certificateHasSha1Signature", IsRequired = true)]
		public bool CertificateHasSha1Signature { get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0000CF79 File Offset: 0x0000B179
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0000CF81 File Offset: 0x0000B181
		[global::System.Runtime.Serialization.DataMember(Name = "modernSSL", IsRequired = true)]
		public bool ModernSSL { get; set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0000CF8A File Offset: 0x0000B18A
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0000CF92 File Offset: 0x0000B192
		[global::System.Runtime.Serialization.DataMember(Name = "obsoleteSslProtocol", IsRequired = true)]
		public bool ObsoleteSslProtocol { get; set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0000CF9B File Offset: 0x0000B19B
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0000CFA3 File Offset: 0x0000B1A3
		[global::System.Runtime.Serialization.DataMember(Name = "obsoleteSslKeyExchange", IsRequired = true)]
		public bool ObsoleteSslKeyExchange { get; set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		[global::System.Runtime.Serialization.DataMember(Name = "obsoleteSslCipher", IsRequired = true)]
		public bool ObsoleteSslCipher { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0000CFBD File Offset: 0x0000B1BD
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x0000CFC5 File Offset: 0x0000B1C5
		[global::System.Runtime.Serialization.DataMember(Name = "obsoleteSslSignature", IsRequired = true)]
		public bool ObsoleteSslSignature { get; set; }
	}
}
