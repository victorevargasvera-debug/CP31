using System;

namespace Org.BouncyCastle.Asn1.X509.SigI
{
	// Token: 0x02000686 RID: 1670
	public sealed class SigIObjectIdentifiers
	{
		// Token: 0x06003DA6 RID: 15782 RVA: 0x00119673 File Offset: 0x00117873
		private SigIObjectIdentifiers()
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x0011967C File Offset: 0x0011787C
		// Note: this type is marked as 'beforefieldinit'.
		static SigIObjectIdentifiers()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idSigI = global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigI;
			global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigIKP = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idSigI != null) ? idSigI.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idSigI2 = global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigI;
			global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigICP = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idSigI2 != null) ? idSigI2.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idSigI3 = global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigI;
			global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigION = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idSigI3 != null) ? idSigI3.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idSigIKP = global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigIKP;
			global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigIKPDirectoryService = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idSigIKP != null) ? idSigIKP.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idSigION = global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigION;
			global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigIONPersonalData = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idSigION != null) ? idSigION.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idSigICP = global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigICP;
			global::Org.BouncyCastle.Asn1.X509.SigI.SigIObjectIdentifiers.IdSigICPSigConform = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idSigICP != null) ? idSigICP.ToString() : null) + ".1");
		}

		// Token: 0x04001B86 RID: 7046
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigI = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.36.8");

		// Token: 0x04001B87 RID: 7047
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigIKP;

		// Token: 0x04001B88 RID: 7048
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigICP;

		// Token: 0x04001B89 RID: 7049
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigION;

		// Token: 0x04001B8A RID: 7050
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigIKPDirectoryService;

		// Token: 0x04001B8B RID: 7051
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigIONPersonalData;

		// Token: 0x04001B8C RID: 7052
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdSigICPSigConform;
	}
}
