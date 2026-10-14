using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x02000399 RID: 921
	public class ECDsaSigner : global::Org.BouncyCastle.Crypto.IDsaExt, global::Org.BouncyCastle.Crypto.IDsa
	{
		// Token: 0x060025A5 RID: 9637 RVA: 0x000A37B0 File Offset: 0x000A19B0
		public ECDsaSigner()
		{
			this.kCalculator = new global::Org.BouncyCastle.Crypto.Signers.RandomDsaKCalculator();
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000A37C3 File Offset: 0x000A19C3
		public ECDsaSigner(global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator)
		{
			this.kCalculator = kCalculator;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000A37D2 File Offset: 0x000A19D2
		public virtual string AlgorithmName
		{
			get
			{
				return "ECDSA";
			}
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x000A37DC File Offset: 0x000A19DC
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Security.SecureRandom providedRandom = null;
			if (forSigning)
			{
				if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
				{
					global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom parametersWithRandom = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
					providedRandom = parametersWithRandom.Random;
					parameters = parametersWithRandom.Parameters;
				}
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("EC private key required for signing");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)parameters;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("EC public key required for verification");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)parameters;
			}
			this.random = this.InitSecureRandom(forSigning && !this.kCalculator.IsDeterministic, providedRandom);
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000A386B File Offset: 0x000A1A6B
		public virtual global::Org.BouncyCastle.Math.BigInteger Order
		{
			get
			{
				return this.key.Parameters.N;
			}
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000A3880 File Offset: 0x000A1A80
		public virtual global::Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ec = this.key.Parameters;
			global::Org.BouncyCastle.Math.BigInteger i = ec.N;
			global::Org.BouncyCastle.Math.BigInteger e = this.CalculateE(i, message);
			global::Org.BouncyCastle.Math.BigInteger d = ((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.key).D;
			if (this.kCalculator.IsDeterministic)
			{
				this.kCalculator.Init(i, d, message);
			}
			else
			{
				this.kCalculator.Init(i, this.random);
			}
			global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier basePointMultiplier = this.CreateBasePointMultiplier();
			global::Org.BouncyCastle.Math.BigInteger r;
			global::Org.BouncyCastle.Math.BigInteger s;
			for (;;)
			{
				global::Org.BouncyCastle.Math.BigInteger j = this.kCalculator.NextK();
				r = basePointMultiplier.Multiply(ec.G, j).Normalize().AffineXCoord.ToBigInteger().Mod(i);
				if (r.SignValue != 0)
				{
					s = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(i, j).Multiply(e.Add(d.Multiply(r))).Mod(i);
					if (s.SignValue != 0)
					{
						break;
					}
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				r,
				s
			};
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000A396C File Offset: 0x000A1B6C
		public virtual bool VerifySignature(byte[] message, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			global::Org.BouncyCastle.Math.BigInteger i = this.key.Parameters.N;
			if (r.SignValue < 1 || s.SignValue < 1 || r.CompareTo(i) >= 0 || s.CompareTo(i) >= 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger bigInteger = this.CalculateE(i, message);
			global::Org.BouncyCastle.Math.BigInteger c = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverseVar(i, s);
			global::Org.BouncyCastle.Math.BigInteger u = bigInteger.Multiply(c).Mod(i);
			global::Org.BouncyCastle.Math.BigInteger u2 = r.Multiply(c).Mod(i);
			global::Org.BouncyCastle.Math.EC.ECPoint g = this.key.Parameters.G;
			global::Org.BouncyCastle.Math.EC.ECPoint Q = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.key).Q;
			global::Org.BouncyCastle.Math.EC.ECPoint point = global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(g, u, Q, u2);
			if (point.IsInfinity)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = point.Curve;
			if (curve != null)
			{
				global::Org.BouncyCastle.Math.BigInteger cofactor = curve.Cofactor;
				if (cofactor != null && cofactor.CompareTo(global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner.Eight) <= 0)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement D = this.GetDenominator(curve.CoordinateSystem, point);
					if (D != null && !D.IsZero)
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement X = point.XCoord;
						while (curve.IsValidFieldElement(r))
						{
							if (curve.FromBigInteger(r).Multiply(D).Equals(X))
							{
								return true;
							}
							r = r.Add(i);
						}
						return false;
					}
				}
			}
			return point.Normalize().AffineXCoord.ToBigInteger().Mod(i).Equals(r);
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x000A3AB4 File Offset: 0x000A1CB4
		protected virtual global::Org.BouncyCastle.Math.BigInteger CalculateE(global::Org.BouncyCastle.Math.BigInteger n, byte[] message)
		{
			int messageBitLength = message.Length * 8;
			global::Org.BouncyCastle.Math.BigInteger trunc = new global::Org.BouncyCastle.Math.BigInteger(1, message);
			if (n.BitLength < messageBitLength)
			{
				trunc = trunc.ShiftRight(messageBitLength - n.BitLength);
			}
			return trunc;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x000A3AE8 File Offset: 0x000A1CE8
		protected virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x000A3AEF File Offset: 0x000A1CEF
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement GetDenominator(int coordinateSystem, global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			switch (coordinateSystem)
			{
			case 1:
			case 6:
			case 7:
				return p.GetZCoord(0);
			case 2:
			case 3:
			case 4:
				return p.GetZCoord(0).Square();
			}
			return null;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000A3B2D File Offset: 0x000A1D2D
		protected virtual global::Org.BouncyCastle.Security.SecureRandom InitSecureRandom(bool needed, global::Org.BouncyCastle.Security.SecureRandom provided)
		{
			if (!needed)
			{
				return null;
			}
			if (provided == null)
			{
				return new global::Org.BouncyCastle.Security.SecureRandom();
			}
			return provided;
		}

		// Token: 0x04000EF0 RID: 3824
		private static readonly global::Org.BouncyCastle.Math.BigInteger Eight = global::Org.BouncyCastle.Math.BigInteger.ValueOf(8L);

		// Token: 0x04000EF1 RID: 3825
		protected readonly global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator;

		// Token: 0x04000EF2 RID: 3826
		protected global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key;

		// Token: 0x04000EF3 RID: 3827
		protected global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
