using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Agreement.Kdf;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F3 RID: 1267
	public class ECMqvWithKdfBasicAgreement : global::Org.BouncyCastle.Crypto.Agreement.ECMqvBasicAgreement
	{
		// Token: 0x060031CD RID: 12749 RVA: 0x000EF70D File Offset: 0x000ED90D
		public ECMqvWithKdfBasicAgreement(string algorithm, global::Org.BouncyCastle.Crypto.IDerivationFunction kdf)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			if (kdf == null)
			{
				throw new global::System.ArgumentNullException("kdf");
			}
			this.algorithm = algorithm;
			this.kdf = kdf;
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000EF740 File Offset: 0x000ED940
		public override global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters pubKey)
		{
			global::Org.BouncyCastle.Math.BigInteger result = base.CalculateAgreement(pubKey);
			int keySize = global::Org.BouncyCastle.Security.GeneratorUtilities.GetDefaultKeySize(this.algorithm);
			global::Org.BouncyCastle.Crypto.Agreement.Kdf.DHKdfParameters dhKdfParams = new global::Org.BouncyCastle.Crypto.Agreement.Kdf.DHKdfParameters(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this.algorithm), keySize, this.BigIntToBytes(result));
			this.kdf.Init(dhKdfParams);
			byte[] keyBytes = new byte[keySize / 8];
			this.kdf.GenerateBytes(keyBytes, 0, keyBytes.Length);
			return new global::Org.BouncyCastle.Math.BigInteger(1, keyBytes);
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x000EF7A8 File Offset: 0x000ED9A8
		private byte[] BigIntToBytes(global::Org.BouncyCastle.Math.BigInteger r)
		{
			int byteLength = global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.GetByteLength(this.privParams.StaticPrivateKey.Parameters.Curve);
			return global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.IntegerToBytes(r, byteLength);
		}

		// Token: 0x040015E7 RID: 5607
		private readonly string algorithm;

		// Token: 0x040015E8 RID: 5608
		private readonly global::Org.BouncyCastle.Crypto.IDerivationFunction kdf;
	}
}
