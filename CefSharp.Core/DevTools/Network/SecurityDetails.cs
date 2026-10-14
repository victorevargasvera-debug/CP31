using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E7 RID: 487
	[global::System.Runtime.Serialization.DataContract]
	public class SecurityDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00010E81 File Offset: 0x0000F081
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00010E89 File Offset: 0x0000F089
		[global::System.Runtime.Serialization.DataMember(Name = "protocol", IsRequired = true)]
		public string Protocol { get; set; }

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00010E92 File Offset: 0x0000F092
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00010E9A File Offset: 0x0000F09A
		[global::System.Runtime.Serialization.DataMember(Name = "keyExchange", IsRequired = true)]
		public string KeyExchange { get; set; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00010EA3 File Offset: 0x0000F0A3
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00010EAB File Offset: 0x0000F0AB
		[global::System.Runtime.Serialization.DataMember(Name = "keyExchangeGroup", IsRequired = false)]
		public string KeyExchangeGroup { get; set; }

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00010EBC File Offset: 0x0000F0BC
		[global::System.Runtime.Serialization.DataMember(Name = "cipher", IsRequired = true)]
		public string Cipher { get; set; }

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00010EC5 File Offset: 0x0000F0C5
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00010ECD File Offset: 0x0000F0CD
		[global::System.Runtime.Serialization.DataMember(Name = "mac", IsRequired = false)]
		public string Mac { get; set; }

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00010ED6 File Offset: 0x0000F0D6
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00010EDE File Offset: 0x0000F0DE
		[global::System.Runtime.Serialization.DataMember(Name = "certificateId", IsRequired = true)]
		public int CertificateId { get; set; }

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00010EE7 File Offset: 0x0000F0E7
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00010EEF File Offset: 0x0000F0EF
		[global::System.Runtime.Serialization.DataMember(Name = "subjectName", IsRequired = true)]
		public string SubjectName { get; set; }

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00010EF8 File Offset: 0x0000F0F8
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00010F00 File Offset: 0x0000F100
		[global::System.Runtime.Serialization.DataMember(Name = "sanList", IsRequired = true)]
		public string[] SanList { get; set; }

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00010F09 File Offset: 0x0000F109
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00010F11 File Offset: 0x0000F111
		[global::System.Runtime.Serialization.DataMember(Name = "issuer", IsRequired = true)]
		public string Issuer { get; set; }

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00010F1A File Offset: 0x0000F11A
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00010F22 File Offset: 0x0000F122
		[global::System.Runtime.Serialization.DataMember(Name = "validFrom", IsRequired = true)]
		public double ValidFrom { get; set; }

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00010F2B File Offset: 0x0000F12B
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00010F33 File Offset: 0x0000F133
		[global::System.Runtime.Serialization.DataMember(Name = "validTo", IsRequired = true)]
		public double ValidTo { get; set; }

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00010F3C File Offset: 0x0000F13C
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00010F44 File Offset: 0x0000F144
		[global::System.Runtime.Serialization.DataMember(Name = "signedCertificateTimestampList", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.SignedCertificateTimestamp> SignedCertificateTimestampList { get; set; }

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00010F4D File Offset: 0x0000F14D
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00010F69 File Offset: 0x0000F169
		public global::CefSharp.DevTools.Network.CertificateTransparencyCompliance CertificateTransparencyCompliance
		{
			get
			{
				return (global::CefSharp.DevTools.Network.CertificateTransparencyCompliance)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.CertificateTransparencyCompliance), this.certificateTransparencyCompliance);
			}
			set
			{
				this.certificateTransparencyCompliance = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00010F7C File Offset: 0x0000F17C
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00010F84 File Offset: 0x0000F184
		[global::System.Runtime.Serialization.DataMember(Name = "certificateTransparencyCompliance", IsRequired = true)]
		internal string certificateTransparencyCompliance { get; set; }

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00010F8D File Offset: 0x0000F18D
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00010F95 File Offset: 0x0000F195
		[global::System.Runtime.Serialization.DataMember(Name = "serverSignatureAlgorithm", IsRequired = false)]
		public int? ServerSignatureAlgorithm { get; set; }

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00010F9E File Offset: 0x0000F19E
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00010FA6 File Offset: 0x0000F1A6
		[global::System.Runtime.Serialization.DataMember(Name = "encryptedClientHello", IsRequired = true)]
		public bool EncryptedClientHello { get; set; }
	}
}
