using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf
{
	// Token: 0x020004FF RID: 1279
	public class ECDHKekGenerator : global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x000F0B9D File Offset: 0x000EED9D
		public ECDHKekGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.kdf = new global::Org.BouncyCastle.Crypto.Generators.Kdf2BytesGenerator(digest);
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000F0BB4 File Offset: 0x000EEDB4
		public virtual void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters param)
		{
			global::Org.BouncyCastle.Crypto.Agreement.Kdf.DHKdfParameters parameters = (global::Org.BouncyCastle.Crypto.Agreement.Kdf.DHKdfParameters)param;
			this.algorithm = parameters.Algorithm;
			this.keySize = parameters.KeySize;
			this.z = parameters.GetZ();
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x000F0BEC File Offset: 0x000EEDEC
		public virtual global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.kdf.Digest;
			}
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x000F0BFC File Offset: 0x000EEDFC
		public virtual int GenerateBytes(byte[] outBytes, int outOff, int len)
		{
			global::Org.BouncyCastle.Asn1.DerSequence s = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(this.algorithm, global::Org.BouncyCastle.Asn1.DerNull.Instance),
				new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)this.keySize)))
			});
			this.kdf.Init(new global::Org.BouncyCastle.Crypto.Parameters.KdfParameters(this.z, s.GetDerEncoded()));
			return this.kdf.GenerateBytes(outBytes, outOff, len);
		}

		// Token: 0x04001633 RID: 5683
		private readonly global::Org.BouncyCastle.Crypto.IDerivationFunction kdf;

		// Token: 0x04001634 RID: 5684
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm;

		// Token: 0x04001635 RID: 5685
		private int keySize;

		// Token: 0x04001636 RID: 5686
		private byte[] z;
	}
}
