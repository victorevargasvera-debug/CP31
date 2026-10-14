using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004EF RID: 1263
	public class ECDHBasicAgreement : global::Org.BouncyCastle.Crypto.IBasicAgreement
	{
		// Token: 0x060031BD RID: 12733 RVA: 0x000EF28B File Offset: 0x000ED48B
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.privKey = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)parameters;
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000EF2AE File Offset: 0x000ED4AE
		public virtual int GetFieldSize()
		{
			return (this.privKey.Parameters.Curve.FieldSize + 7) / 8;
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000EF2CC File Offset: 0x000ED4CC
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters pubKey)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters pub = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)pubKey;
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dp = this.privKey.Parameters;
			if (!dp.Equals(pub.Parameters))
			{
				throw new global::System.InvalidOperationException("ECDH public key has wrong domain parameters");
			}
			global::Org.BouncyCastle.Math.BigInteger d = this.privKey.D;
			global::Org.BouncyCastle.Math.EC.ECPoint Q = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(dp.Curve, pub.Q);
			if (Q.IsInfinity)
			{
				throw new global::System.InvalidOperationException("Infinity is not a valid public key for ECDH");
			}
			global::Org.BouncyCastle.Math.BigInteger h = dp.H;
			if (!h.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				d = dp.HInv.Multiply(d).Mod(dp.N);
				Q = global::Org.BouncyCastle.Math.EC.ECAlgorithms.ReferenceMultiply(Q, h);
			}
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = Q.Multiply(d).Normalize();
			if (ecpoint.IsInfinity)
			{
				throw new global::System.InvalidOperationException("Infinity is not a valid agreement value for ECDH");
			}
			return ecpoint.AffineXCoord.ToBigInteger();
		}

		// Token: 0x040015E2 RID: 5602
		protected internal global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey;
	}
}
