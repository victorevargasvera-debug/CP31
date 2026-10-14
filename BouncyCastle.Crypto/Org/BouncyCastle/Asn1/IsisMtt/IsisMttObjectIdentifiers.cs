using System;

namespace Org.BouncyCastle.Asn1.IsisMtt
{
	// Token: 0x020006E5 RID: 1765
	public abstract class IsisMttObjectIdentifiers
	{
		// Token: 0x06004018 RID: 16408 RVA: 0x00122BD4 File Offset: 0x00120DD4
		// Note: this type is marked as 'beforefieldinit'.
		static IsisMttObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMtt = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMtt;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttCP = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMtt != null) ? idIsisMtt.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttCP = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttCP;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttCPAccredited = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttCP != null) ? idIsisMttCP.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMtt2 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMtt;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMtt2 != null) ? idIsisMtt2.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATDateOfCertGen = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT != null) ? idIsisMttAT.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT2 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATProcuration = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT2 != null) ? idIsisMttAT2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT3 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATAdmission = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT3 != null) ? idIsisMttAT3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT4 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATMonetaryLimit = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT4 != null) ? idIsisMttAT4.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT5 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATDeclarationOfMajority = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT5 != null) ? idIsisMttAT5.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT6 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATIccsn = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT6 != null) ? idIsisMttAT6.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT7 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATPKReference = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT7 != null) ? idIsisMttAT7.ToString() : null) + ".7");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT8 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATRestriction = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT8 != null) ? idIsisMttAT8.ToString() : null) + ".8");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT9 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATRetrieveIfAllowed = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT9 != null) ? idIsisMttAT9.ToString() : null) + ".9");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT10 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATRequestedCertificate = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT10 != null) ? idIsisMttAT10.ToString() : null) + ".10");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT11 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATNamingAuthorities = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT11 != null) ? idIsisMttAT11.ToString() : null) + ".11");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT12 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATCertInDirSince = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT12 != null) ? idIsisMttAT12.ToString() : null) + ".12");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT13 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATCertHash = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT13 != null) ? idIsisMttAT13.ToString() : null) + ".13");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT14 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATNameAtBirth = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT14 != null) ? idIsisMttAT14.ToString() : null) + ".14");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttAT15 = global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttAT;
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATAdditionalInformation = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttAT15 != null) ? idIsisMttAT15.ToString() : null) + ".15");
			global::Org.BouncyCastle.Asn1.IsisMtt.IsisMttObjectIdentifiers.IdIsisMttATLiabilityLimitationFlag = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("0.2.262.1.10.12.0");
		}

		// Token: 0x04001E45 RID: 7749
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMtt = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.36.8");

		// Token: 0x04001E46 RID: 7750
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttCP;

		// Token: 0x04001E47 RID: 7751
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttCPAccredited;

		// Token: 0x04001E48 RID: 7752
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttAT;

		// Token: 0x04001E49 RID: 7753
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATDateOfCertGen;

		// Token: 0x04001E4A RID: 7754
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATProcuration;

		// Token: 0x04001E4B RID: 7755
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATAdmission;

		// Token: 0x04001E4C RID: 7756
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATMonetaryLimit;

		// Token: 0x04001E4D RID: 7757
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATDeclarationOfMajority;

		// Token: 0x04001E4E RID: 7758
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATIccsn;

		// Token: 0x04001E4F RID: 7759
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATPKReference;

		// Token: 0x04001E50 RID: 7760
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATRestriction;

		// Token: 0x04001E51 RID: 7761
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATRetrieveIfAllowed;

		// Token: 0x04001E52 RID: 7762
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATRequestedCertificate;

		// Token: 0x04001E53 RID: 7763
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATNamingAuthorities;

		// Token: 0x04001E54 RID: 7764
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATCertInDirSince;

		// Token: 0x04001E55 RID: 7765
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATCertHash;

		// Token: 0x04001E56 RID: 7766
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATNameAtBirth;

		// Token: 0x04001E57 RID: 7767
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATAdditionalInformation;

		// Token: 0x04001E58 RID: 7768
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdIsisMttATLiabilityLimitationFlag;
	}
}
