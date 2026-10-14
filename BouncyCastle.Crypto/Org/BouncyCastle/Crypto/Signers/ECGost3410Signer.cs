using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x0200039A RID: 922
	public class ECGost3410Signer : global::Org.BouncyCastle.Crypto.IDsaExt, global::Org.BouncyCastle.Crypto.IDsa
	{
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x000A3B4C File Offset: 0x000A1D4C
		public virtual string AlgorithmName
		{
			get
			{
				return this.key.AlgorithmName;
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000A3B5C File Offset: 0x000A1D5C
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forSigning = forSigning;
			if (forSigning)
			{
				if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
				{
					global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
					this.random = rParam.Random;
					parameters = rParam.Parameters;
				}
				else
				{
					this.random = new global::Org.BouncyCastle.Security.SecureRandom();
				}
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("EC private key required for signing");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)parameters;
				return;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("EC public key required for verification");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)parameters;
				return;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x000A3BE2 File Offset: 0x000A1DE2
		public virtual global::Org.BouncyCastle.Math.BigInteger Order
		{
			get
			{
				return this.key.Parameters.N;
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000A3BF4 File Offset: 0x000A1DF4
		public virtual global::Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
		{
			if (!this.forSigning)
			{
				throw new global::System.InvalidOperationException("not initialized for signing");
			}
			byte[] mRev = global::Org.BouncyCastle.Utilities.Arrays.Reverse(message);
			global::Org.BouncyCastle.Math.BigInteger e = new global::Org.BouncyCastle.Math.BigInteger(1, mRev);
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ec = this.key.Parameters;
			global::Org.BouncyCastle.Math.BigInteger i = ec.N;
			global::Org.BouncyCastle.Math.BigInteger d = ((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.key).D;
			global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier basePointMultiplier = this.CreateBasePointMultiplier();
			global::Org.BouncyCastle.Math.BigInteger r;
			global::Org.BouncyCastle.Math.BigInteger s;
			for (;;)
			{
				global::Org.BouncyCastle.Math.BigInteger j = new global::Org.BouncyCastle.Math.BigInteger(i.BitLength, this.random);
				if (j.SignValue != 0)
				{
					r = basePointMultiplier.Multiply(ec.G, j).Normalize().AffineXCoord.ToBigInteger().Mod(i);
					if (r.SignValue != 0)
					{
						s = j.Multiply(e).Add(d.Multiply(r)).Mod(i);
						if (s.SignValue != 0)
						{
							break;
						}
					}
				}
			}
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				r,
				s
			};
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000A3CD8 File Offset: 0x000A1ED8
		public virtual bool VerifySignature(byte[] message, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			if (this.forSigning)
			{
				throw new global::System.InvalidOperationException("not initialized for verification");
			}
			byte[] mRev = global::Org.BouncyCastle.Utilities.Arrays.Reverse(message);
			global::Org.BouncyCastle.Math.BigInteger e = new global::Org.BouncyCastle.Math.BigInteger(1, mRev);
			global::Org.BouncyCastle.Math.BigInteger i = this.key.Parameters.N;
			if (r.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || r.CompareTo(i) >= 0)
			{
				return false;
			}
			if (s.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || s.CompareTo(i) >= 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger v = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverseVar(i, e);
			global::Org.BouncyCastle.Math.BigInteger z = s.Multiply(v).Mod(i);
			global::Org.BouncyCastle.Math.BigInteger z2 = i.Subtract(r).Multiply(v).Mod(i);
			global::Org.BouncyCastle.Math.EC.ECPoint g = this.key.Parameters.G;
			global::Org.BouncyCastle.Math.EC.ECPoint Q = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.key).Q;
			global::Org.BouncyCastle.Math.EC.ECPoint point = global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(g, z, Q, z2).Normalize();
			return !point.IsInfinity && point.AffineXCoord.ToBigInteger().Mod(i).Equals(r);
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000A3DCF File Offset: 0x000A1FCF
		protected virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
		}

		// Token: 0x04000EF4 RID: 3828
		private global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key;

		// Token: 0x04000EF5 RID: 3829
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04000EF6 RID: 3830
		private bool forSigning;
	}
}
