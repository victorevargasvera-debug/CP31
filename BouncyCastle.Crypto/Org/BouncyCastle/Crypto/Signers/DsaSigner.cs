using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x02000398 RID: 920
	public class DsaSigner : global::Org.BouncyCastle.Crypto.IDsaExt, global::Org.BouncyCastle.Crypto.IDsa
	{
		// Token: 0x0600259C RID: 9628 RVA: 0x000A3516 File Offset: 0x000A1716
		public DsaSigner()
		{
			this.kCalculator = new global::Org.BouncyCastle.Crypto.Signers.RandomDsaKCalculator();
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000A3529 File Offset: 0x000A1729
		public DsaSigner(global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator)
		{
			this.kCalculator = kCalculator;
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000A3538 File Offset: 0x000A1738
		public virtual string AlgorithmName
		{
			get
			{
				return "DSA";
			}
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x000A3540 File Offset: 0x000A1740
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
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("DSA private key required for signing");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)parameters;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("DSA public key required for verification");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)parameters;
			}
			this.random = this.InitSecureRandom(forSigning && !this.kCalculator.IsDeterministic, providedRandom);
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000A35CF File Offset: 0x000A17CF
		public virtual global::Org.BouncyCastle.Math.BigInteger Order
		{
			get
			{
				return this.key.Parameters.Q;
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000A35E4 File Offset: 0x000A17E4
		public virtual global::Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
		{
			global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = this.key.Parameters;
			global::Org.BouncyCastle.Math.BigInteger q = parameters.Q;
			global::Org.BouncyCastle.Math.BigInteger i = this.CalculateE(q, message);
			global::Org.BouncyCastle.Math.BigInteger x = ((global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)this.key).X;
			if (this.kCalculator.IsDeterministic)
			{
				this.kCalculator.Init(q, x, message);
			}
			else
			{
				this.kCalculator.Init(q, this.random);
			}
			global::Org.BouncyCastle.Math.BigInteger j = this.kCalculator.NextK();
			global::Org.BouncyCastle.Math.BigInteger r = parameters.G.ModPow(j, parameters.P).Mod(q);
			j = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(q, j).Multiply(i.Add(x.Multiply(r)));
			global::Org.BouncyCastle.Math.BigInteger s = j.Mod(q);
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				r,
				s
			};
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000A36AC File Offset: 0x000A18AC
		public virtual bool VerifySignature(byte[] message, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = this.key.Parameters;
			global::Org.BouncyCastle.Math.BigInteger q = parameters.Q;
			global::Org.BouncyCastle.Math.BigInteger i = this.CalculateE(q, message);
			if (r.SignValue <= 0 || q.CompareTo(r) <= 0)
			{
				return false;
			}
			if (s.SignValue <= 0 || q.CompareTo(s) <= 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger w = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverseVar(q, s);
			global::Org.BouncyCastle.Math.BigInteger u = i.Multiply(w).Mod(q);
			global::Org.BouncyCastle.Math.BigInteger u2 = r.Multiply(w).Mod(q);
			global::Org.BouncyCastle.Math.BigInteger p = parameters.P;
			u = parameters.G.ModPow(u, p);
			u2 = ((global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)this.key).Y.ModPow(u2, p);
			return u.Multiply(u2).Mod(p).Mod(q).Equals(r);
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000A3778 File Offset: 0x000A1978
		protected virtual global::Org.BouncyCastle.Math.BigInteger CalculateE(global::Org.BouncyCastle.Math.BigInteger n, byte[] message)
		{
			int length = global::System.Math.Min(message.Length, n.BitLength / 8);
			return new global::Org.BouncyCastle.Math.BigInteger(1, message, 0, length);
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000A379F File Offset: 0x000A199F
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

		// Token: 0x04000EED RID: 3821
		protected readonly global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator kCalculator;

		// Token: 0x04000EEE RID: 3822
		protected global::Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters key;

		// Token: 0x04000EEF RID: 3823
		protected global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
