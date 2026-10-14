using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200065C RID: 1628
	public sealed class KeyPurposeID : global::Org.BouncyCastle.Asn1.DerObjectIdentifier
	{
		// Token: 0x06003C3F RID: 15423 RVA: 0x0011429C File Offset: 0x0011249C
		private KeyPurposeID(string id) : base(id)
		{
		}

		// Token: 0x04001A87 RID: 6791
		private const string IdKP = "1.3.6.1.5.5.7.3";

		// Token: 0x04001A88 RID: 6792
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID AnyExtendedKeyUsage = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID(global::Org.BouncyCastle.Asn1.X509.X509Extensions.ExtendedKeyUsage.Id + ".0");

		// Token: 0x04001A89 RID: 6793
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPServerAuth = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.1");

		// Token: 0x04001A8A RID: 6794
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPClientAuth = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.2");

		// Token: 0x04001A8B RID: 6795
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPCodeSigning = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.3");

		// Token: 0x04001A8C RID: 6796
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPEmailProtection = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.4");

		// Token: 0x04001A8D RID: 6797
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPIpsecEndSystem = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.5");

		// Token: 0x04001A8E RID: 6798
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPIpsecTunnel = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.6");

		// Token: 0x04001A8F RID: 6799
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPIpsecUser = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.7");

		// Token: 0x04001A90 RID: 6800
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPTimeStamping = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.8");

		// Token: 0x04001A91 RID: 6801
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPOcspSigning = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.5.5.7.3.9");

		// Token: 0x04001A92 RID: 6802
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPSmartCardLogon = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.4.1.311.20.2.2");

		// Token: 0x04001A93 RID: 6803
		public static readonly global::Org.BouncyCastle.Asn1.X509.KeyPurposeID IdKPMacAddress = new global::Org.BouncyCastle.Asn1.X509.KeyPurposeID("1.3.6.1.1.1.1.22");
	}
}
