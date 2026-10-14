using System;

namespace Org.BouncyCastle.Asn1.TeleTrust
{
	// Token: 0x0200069D RID: 1693
	public sealed class TeleTrusTObjectIdentifiers
	{
		// Token: 0x06003E49 RID: 15945 RVA: 0x0011C08F File Offset: 0x0011A28F
		private TeleTrusTObjectIdentifiers()
		{
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x0011C098 File Offset: 0x0011A298
		// Note: this type is marked as 'beforefieldinit'.
		static TeleTrusTObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTAlgorithm = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTAlgorithm != null) ? teleTrusTAlgorithm.ToString() : null) + ".2.1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTAlgorithm2 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTAlgorithm2 != null) ? teleTrusTAlgorithm2.ToString() : null) + ".2.2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTAlgorithm3 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTAlgorithm3 != null) ? teleTrusTAlgorithm3.ToString() : null) + ".2.3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTAlgorithm4 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTRsaSignatureAlgorithm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTAlgorithm4 != null) ? teleTrusTAlgorithm4.ToString() : null) + ".3.1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTRsaSignatureAlgorithm = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTRsaSignatureAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTRsaSignatureAlgorithm != null) ? teleTrusTRsaSignatureAlgorithm.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTRsaSignatureAlgorithm2 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTRsaSignatureAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTRsaSignatureAlgorithm2 != null) ? teleTrusTRsaSignatureAlgorithm2.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTRsaSignatureAlgorithm3 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTRsaSignatureAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTRsaSignatureAlgorithm3 != null) ? teleTrusTRsaSignatureAlgorithm3.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTAlgorithm5 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSign = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTAlgorithm5 != null) ? teleTrusTAlgorithm5.ToString() : null) + ".3.2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecsign = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSign;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithSha1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ecsign != null) ? ecsign.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ecsign2 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSign;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithRipeMD160 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ecsign2 != null) ? ecsign2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier teleTrusTAlgorithm6 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.TeleTrusTAlgorithm;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.EccBrainpool = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((teleTrusTAlgorithm6 != null) ? teleTrusTAlgorithm6.ToString() : null) + ".3.2.8");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier eccBrainpool = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.EccBrainpool;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.EllipticCurve = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((eccBrainpool != null) ? eccBrainpool.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier ellipticCurve = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.EllipticCurve;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((ellipticCurve != null) ? ellipticCurve.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne != null) ? versionOne.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne2 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP160T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne2 != null) ? versionOne2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne3 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne3 != null) ? versionOne3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne4 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP192T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne4 != null) ? versionOne4.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne5 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne5 != null) ? versionOne5.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne6 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP224T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne6 != null) ? versionOne6.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne7 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne7 != null) ? versionOne7.ToString() : null) + ".7");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne8 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP256T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne8 != null) ? versionOne8.ToString() : null) + ".8");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne9 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne9 != null) ? versionOne9.ToString() : null) + ".9");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne10 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP320T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne10 != null) ? versionOne10.ToString() : null) + ".10");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne11 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne11 != null) ? versionOne11.ToString() : null) + ".11");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne12 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP384T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne12 != null) ? versionOne12.ToString() : null) + ".12");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne13 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512R1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne13 != null) ? versionOne13.ToString() : null) + ".13");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier versionOne14 = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.VersionOne;
			global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.BrainpoolP512T1 = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((versionOne14 != null) ? versionOne14.ToString() : null) + ".14");
		}

		// Token: 0x04001BF4 RID: 7156
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier TeleTrusTAlgorithm = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.36.3");

		// Token: 0x04001BF5 RID: 7157
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD160;

		// Token: 0x04001BF6 RID: 7158
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD128;

		// Token: 0x04001BF7 RID: 7159
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RipeMD256;

		// Token: 0x04001BF8 RID: 7160
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier TeleTrusTRsaSignatureAlgorithm;

		// Token: 0x04001BF9 RID: 7161
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RsaSignatureWithRipeMD160;

		// Token: 0x04001BFA RID: 7162
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RsaSignatureWithRipeMD128;

		// Token: 0x04001BFB RID: 7163
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RsaSignatureWithRipeMD256;

		// Token: 0x04001BFC RID: 7164
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECSign;

		// Token: 0x04001BFD RID: 7165
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECSignWithSha1;

		// Token: 0x04001BFE RID: 7166
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ECSignWithRipeMD160;

		// Token: 0x04001BFF RID: 7167
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EccBrainpool;

		// Token: 0x04001C00 RID: 7168
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier EllipticCurve;

		// Token: 0x04001C01 RID: 7169
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VersionOne;

		// Token: 0x04001C02 RID: 7170
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP160R1;

		// Token: 0x04001C03 RID: 7171
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP160T1;

		// Token: 0x04001C04 RID: 7172
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP192R1;

		// Token: 0x04001C05 RID: 7173
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP192T1;

		// Token: 0x04001C06 RID: 7174
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP224R1;

		// Token: 0x04001C07 RID: 7175
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP224T1;

		// Token: 0x04001C08 RID: 7176
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP256R1;

		// Token: 0x04001C09 RID: 7177
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP256T1;

		// Token: 0x04001C0A RID: 7178
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP320R1;

		// Token: 0x04001C0B RID: 7179
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP320T1;

		// Token: 0x04001C0C RID: 7180
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP384R1;

		// Token: 0x04001C0D RID: 7181
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP384T1;

		// Token: 0x04001C0E RID: 7182
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP512R1;

		// Token: 0x04001C0F RID: 7183
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier BrainpoolP512T1;
	}
}
