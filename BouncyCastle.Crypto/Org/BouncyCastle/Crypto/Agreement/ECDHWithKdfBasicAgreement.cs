using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Agreement.Kdf;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F1 RID: 1265
	public class ECDHWithKdfBasicAgreement : global::Org.BouncyCastle.Crypto.Agreement.ECDHBasicAgreement
	{
		// Token: 0x060031C5 RID: 12741 RVA: 0x000EF48B File Offset: 0x000ED68B
		public ECDHWithKdfBasicAgreement(string algorithm, global::Org.BouncyCastle.Crypto.IDerivationFunction kdf)
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

		// Token: 0x060031C6 RID: 12742 RVA: 0x000EF4C0 File Offset: 0x000ED6C0
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

		// Token: 0x060031C7 RID: 12743 RVA: 0x000EF528 File Offset: 0x000ED728
		private byte[] BigIntToBytes(global::Org.BouncyCastle.Math.BigInteger r)
		{
			int byteLength = global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.GetByteLength(this.privKey.Parameters.Curve);
			return global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.IntegerToBytes(r, byteLength);
		}

		// Token: 0x040015E4 RID: 5604
		private readonly string algorithm;

		// Token: 0x040015E5 RID: 5605
		private readonly global::Org.BouncyCastle.Crypto.IDerivationFunction kdf;
	}
}
