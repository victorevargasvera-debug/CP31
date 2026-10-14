using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F0 RID: 1264
	public class ECDHCBasicAgreement : global::Org.BouncyCastle.Crypto.IBasicAgreement
	{
		// Token: 0x060031C1 RID: 12737 RVA: 0x000EF39E File Offset: 0x000ED59E
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.privKey = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)parameters;
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x000EF3C1 File Offset: 0x000ED5C1
		public virtual int GetFieldSize()
		{
			return (this.privKey.Parameters.Curve.FieldSize + 7) / 8;
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000EF3DC File Offset: 0x000ED5DC
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters pubKey)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters pub = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)pubKey;
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dp = this.privKey.Parameters;
			if (!dp.Equals(pub.Parameters))
			{
				throw new global::System.InvalidOperationException("ECDHC public key has wrong domain parameters");
			}
			global::Org.BouncyCastle.Math.BigInteger hd = dp.H.Multiply(this.privKey.D).Mod(dp.N);
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(dp.Curve, pub.Q);
			if (ecpoint.IsInfinity)
			{
				throw new global::System.InvalidOperationException("Infinity is not a valid public key for ECDHC");
			}
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint2 = ecpoint.Multiply(hd).Normalize();
			if (ecpoint2.IsInfinity)
			{
				throw new global::System.InvalidOperationException("Infinity is not a valid agreement value for ECDHC");
			}
			return ecpoint2.AffineXCoord.ToBigInteger();
		}

		// Token: 0x040015E3 RID: 5603
		private global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey;
	}
}
