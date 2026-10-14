using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F2 RID: 1266
	public class ECMqvBasicAgreement : global::Org.BouncyCastle.Crypto.IBasicAgreement
	{
		// Token: 0x060031C8 RID: 12744 RVA: 0x000EF552 File Offset: 0x000ED752
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			this.privParams = (global::Org.BouncyCastle.Crypto.Parameters.MqvPrivateParameters)parameters;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000EF575 File Offset: 0x000ED775
		public virtual int GetFieldSize()
		{
			return (this.privParams.StaticPrivateKey.Parameters.Curve.FieldSize + 7) / 8;
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000EF598 File Offset: 0x000ED798
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters pubKey)
		{
			global::Org.BouncyCastle.Crypto.Parameters.MqvPublicParameters pubParams = (global::Org.BouncyCastle.Crypto.Parameters.MqvPublicParameters)pubKey;
			global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters staticPrivateKey = this.privParams.StaticPrivateKey;
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters = staticPrivateKey.Parameters;
			if (!parameters.Equals(pubParams.StaticPublicKey.Parameters))
			{
				throw new global::System.InvalidOperationException("ECMQV public key components have wrong domain parameters");
			}
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = global::Org.BouncyCastle.Crypto.Agreement.ECMqvBasicAgreement.CalculateMqvAgreement(parameters, staticPrivateKey, this.privParams.EphemeralPrivateKey, this.privParams.EphemeralPublicKey, pubParams.StaticPublicKey, pubParams.EphemeralPublicKey).Normalize();
			if (ecpoint.IsInfinity)
			{
				throw new global::System.InvalidOperationException("Infinity is not a valid agreement value for MQV");
			}
			return ecpoint.AffineXCoord.ToBigInteger();
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000EF628 File Offset: 0x000ED828
		private static global::Org.BouncyCastle.Math.EC.ECPoint CalculateMqvAgreement(global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters d1U, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters d2U, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters Q2U, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters Q1V, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters Q2V)
		{
			global::Org.BouncyCastle.Math.BigInteger i = parameters.N;
			int e = (i.BitLength + 1) / 2;
			global::Org.BouncyCastle.Math.BigInteger powE = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(e);
			global::Org.BouncyCastle.Math.EC.ECCurve curve = parameters.Curve;
			global::Org.BouncyCastle.Math.EC.ECPoint q2u = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(curve, Q2U.Q);
			global::Org.BouncyCastle.Math.EC.ECPoint q1v = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(curve, Q1V.Q);
			global::Org.BouncyCastle.Math.EC.ECPoint q2v = global::Org.BouncyCastle.Math.EC.ECAlgorithms.CleanPoint(curve, Q2V.Q);
			global::Org.BouncyCastle.Math.BigInteger Q2UBar = q2u.AffineXCoord.ToBigInteger().Mod(powE).SetBit(e);
			global::Org.BouncyCastle.Math.BigInteger s = d1U.D.Multiply(Q2UBar).Add(d2U.D).Mod(i);
			global::Org.BouncyCastle.Math.BigInteger Q2VBar = q2v.AffineXCoord.ToBigInteger().Mod(powE).SetBit(e);
			global::Org.BouncyCastle.Math.BigInteger hs = parameters.H.Multiply(s).Mod(i);
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(q1v, Q2VBar.Multiply(hs).Mod(i), q2v, hs);
		}

		// Token: 0x040015E6 RID: 5606
		protected internal global::Org.BouncyCastle.Crypto.Parameters.MqvPrivateParameters privParams;
	}
}
