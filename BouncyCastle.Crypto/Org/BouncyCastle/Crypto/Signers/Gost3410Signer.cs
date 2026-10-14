using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A3 RID: 931
	public class Gost3410Signer : global::Org.BouncyCastle.Crypto.IDsaExt, global::Org.BouncyCastle.Crypto.IDsa
	{
		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000A4A19 File Offset: 0x000A2C19
		public virtual string AlgorithmName
		{
			get
			{
				return "GOST3410";
			}
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x000A4A20 File Offset: 0x000A2C20
		public virtual void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
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
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("GOST3410 private key required for signing");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters)parameters;
				return;
			}
			else
			{
				if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters))
				{
					throw new global::Org.BouncyCastle.Security.InvalidKeyException("GOST3410 public key required for signing");
				}
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters)parameters;
				return;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x000A4A9F File Offset: 0x000A2C9F
		public virtual global::Org.BouncyCastle.Math.BigInteger Order
		{
			get
			{
				return this.key.Parameters.Q;
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000A4AB4 File Offset: 0x000A2CB4
		public virtual global::Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
		{
			byte[] mRev = global::Org.BouncyCastle.Utilities.Arrays.Reverse(message);
			global::Org.BouncyCastle.Math.BigInteger i = new global::Org.BouncyCastle.Math.BigInteger(1, mRev);
			global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters = this.key.Parameters;
			global::Org.BouncyCastle.Math.BigInteger j;
			do
			{
				j = new global::Org.BouncyCastle.Math.BigInteger(parameters.Q.BitLength, this.random);
			}
			while (j.CompareTo(parameters.Q) >= 0);
			global::Org.BouncyCastle.Math.BigInteger r = parameters.A.ModPow(j, parameters.P).Mod(parameters.Q);
			global::Org.BouncyCastle.Math.BigInteger s = j.Multiply(i).Add(((global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters)this.key).X.Multiply(r)).Mod(parameters.Q);
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				r,
				s
			};
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000A4B64 File Offset: 0x000A2D64
		public virtual bool VerifySignature(byte[] message, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			byte[] mRev = global::Org.BouncyCastle.Utilities.Arrays.Reverse(message);
			global::Org.BouncyCastle.Math.BigInteger i = new global::Org.BouncyCastle.Math.BigInteger(1, mRev);
			global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters = this.key.Parameters;
			if (r.SignValue < 0 || parameters.Q.CompareTo(r) <= 0)
			{
				return false;
			}
			if (s.SignValue < 0 || parameters.Q.CompareTo(s) <= 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger v = i.ModPow(parameters.Q.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two), parameters.Q);
			global::Org.BouncyCastle.Math.BigInteger z = s.Multiply(v).Mod(parameters.Q);
			global::Org.BouncyCastle.Math.BigInteger z2 = parameters.Q.Subtract(r).Multiply(v).Mod(parameters.Q);
			z = parameters.A.ModPow(z, parameters.P);
			z2 = ((global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters)this.key).Y.ModPow(z2, parameters.P);
			return z.Multiply(z2).Mod(parameters.P).Mod(parameters.Q).Equals(r);
		}

		// Token: 0x04000F1A RID: 3866
		private global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters key;

		// Token: 0x04000F1B RID: 3867
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
