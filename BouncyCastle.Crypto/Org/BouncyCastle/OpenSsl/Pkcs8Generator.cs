using System;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

namespace Org.BouncyCastle.OpenSsl
{
	// Token: 0x020001BD RID: 445
	public class Pkcs8Generator : global::Org.BouncyCastle.Utilities.IO.Pem.PemObjectGenerator
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x000441CE File Offset: 0x000423CE
		public Pkcs8Generator(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey)
		{
			this.privKey = privKey;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000441DD File Offset: 0x000423DD
		public Pkcs8Generator(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey, string algorithm)
		{
			this.privKey = privKey;
			this.algorithm = algorithm;
			this.iterationCount = 2048;
		}

		// Token: 0x1700023B RID: 571
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x000441FE File Offset: 0x000423FE
		public global::Org.BouncyCastle.Security.SecureRandom SecureRandom
		{
			set
			{
				this.random = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00044207 File Offset: 0x00042407
		public char[] Password
		{
			set
			{
				this.password = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x00044210 File Offset: 0x00042410
		public int IterationCount
		{
			set
			{
				this.iterationCount = value;
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0004421C File Offset: 0x0004241C
		public global::Org.BouncyCastle.Utilities.IO.Pem.PemObject Generate()
		{
			if (this.algorithm == null)
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo pki = global::Org.BouncyCastle.Pkcs.PrivateKeyInfoFactory.CreatePrivateKeyInfo(this.privKey);
				return new global::Org.BouncyCastle.Utilities.IO.Pem.PemObject("PRIVATE KEY", pki.GetEncoded());
			}
			byte[] salt = new byte[20];
			if (this.random == null)
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			this.random.NextBytes(salt);
			global::Org.BouncyCastle.Utilities.IO.Pem.PemObject result;
			try
			{
				global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo epki = global::Org.BouncyCastle.Pkcs.EncryptedPrivateKeyInfoFactory.CreateEncryptedPrivateKeyInfo(this.algorithm, this.password, salt, this.iterationCount, this.privKey);
				result = new global::Org.BouncyCastle.Utilities.IO.Pem.PemObject("ENCRYPTED PRIVATE KEY", epki.GetEncoded());
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Utilities.IO.Pem.PemGenerationException("Couldn't encrypt private key", e);
			}
			return result;
		}

		// Token: 0x040008BC RID: 2236
		public static readonly string PbeSha1_RC4_128 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC4.Id;

		// Token: 0x040008BD RID: 2237
		public static readonly string PbeSha1_RC4_40 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd40BitRC4.Id;

		// Token: 0x040008BE RID: 2238
		public static readonly string PbeSha1_3DES = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc.Id;

		// Token: 0x040008BF RID: 2239
		public static readonly string PbeSha1_2DES = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd2KeyTripleDesCbc.Id;

		// Token: 0x040008C0 RID: 2240
		public static readonly string PbeSha1_RC2_128 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC2Cbc.Id;

		// Token: 0x040008C1 RID: 2241
		public static readonly string PbeSha1_RC2_40 = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc.Id;

		// Token: 0x040008C2 RID: 2242
		private char[] password;

		// Token: 0x040008C3 RID: 2243
		private string algorithm;

		// Token: 0x040008C4 RID: 2244
		private int iterationCount;

		// Token: 0x040008C5 RID: 2245
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey;

		// Token: 0x040008C6 RID: 2246
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
