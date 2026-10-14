using System;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x0200039B RID: 923
	public class ECNRSigner : global::Org.BouncyCastle.Crypto.IDsaExt, global::Org.BouncyCastle.Crypto.IDsa
	{
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000A3DDE File Offset: 0x000A1FDE
		public virtual string AlgorithmName
		{
			get
			{
				return "ECNR";
			}
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000A3DE8 File Offset: 0x000A1FE8
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x000A3E6E File Offset: 0x000A206E
		public virtual global::Org.BouncyCastle.Math.BigInteger Order
		{
			get
			{
				return this.key.Parameters.N;
			}
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000A3E80 File Offset: 0x000A2080
		public virtual global::Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message)
		{
			if (!this.forSigning)
			{
				throw new global::System.InvalidOperationException("not initialised for signing");
			}
			global::Org.BouncyCastle.Math.BigInteger i = this.Order;
			int nBitLength = i.BitLength;
			global::Org.BouncyCastle.Math.BigInteger e = new global::Org.BouncyCastle.Math.BigInteger(1, message);
			int bitLength = e.BitLength;
			global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)this.key;
			if (bitLength > nBitLength)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for ECNR key.");
			}
			global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair tempPair;
			global::Org.BouncyCastle.Math.BigInteger r;
			do
			{
				global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator eckeyPairGenerator = new global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator();
				eckeyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(privKey.Parameters, this.random));
				tempPair = eckeyPairGenerator.GenerateKeyPair();
				r = ((global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)tempPair.Public).Q.AffineXCoord.ToBigInteger().Add(e).Mod(i);
			}
			while (r.SignValue == 0);
			global::Org.BouncyCastle.Math.BigInteger x = privKey.D;
			global::Org.BouncyCastle.Math.BigInteger s = ((global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)tempPair.Private).D.Subtract(r.Multiply(x)).Mod(i);
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				r,
				s
			};
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000A3F70 File Offset: 0x000A2170
		public virtual bool VerifySignature(byte[] message, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s)
		{
			if (this.forSigning)
			{
				throw new global::System.InvalidOperationException("not initialised for verifying");
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters pubKey = (global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters)this.key;
			global::Org.BouncyCastle.Math.BigInteger i = pubKey.Parameters.N;
			int nBitLength = i.BitLength;
			global::Org.BouncyCastle.Math.BigInteger e = new global::Org.BouncyCastle.Math.BigInteger(1, message);
			if (e.BitLength > nBitLength)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for ECNR key.");
			}
			if (r.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || r.CompareTo(i) >= 0)
			{
				return false;
			}
			if (s.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Zero) < 0 || s.CompareTo(i) >= 0)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.ECPoint G = pubKey.Parameters.G;
			global::Org.BouncyCastle.Math.EC.ECPoint W = pubKey.Q;
			global::Org.BouncyCastle.Math.EC.ECPoint P = global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(G, s, W, r).Normalize();
			if (P.IsInfinity)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.BigInteger x = P.AffineXCoord.ToBigInteger();
			return r.Subtract(x).Mod(i).Equals(e);
		}

		// Token: 0x04000EF7 RID: 3831
		private bool forSigning;

		// Token: 0x04000EF8 RID: 3832
		private global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters key;

		// Token: 0x04000EF9 RID: 3833
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
