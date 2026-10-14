using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B1 RID: 1201
	public class RsaCoreEngine : global::Org.BouncyCastle.Crypto.IRsa
	{
		// Token: 0x06002E64 RID: 11876 RVA: 0x000D2517 File Offset: 0x000D0717
		private void CheckInitialised()
		{
			if (this.key == null)
			{
				throw new global::System.InvalidOperationException("RSA engine not initialised");
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000D252C File Offset: 0x000D072C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters))
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Not an RSA key");
			}
			this.key = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)parameters;
			this.forEncryption = forEncryption;
			this.bitSize = this.key.Modulus.BitLength;
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000D258A File Offset: 0x000D078A
		public virtual int GetInputBlockSize()
		{
			this.CheckInitialised();
			if (this.forEncryption)
			{
				return (this.bitSize - 1) / 8;
			}
			return (this.bitSize + 7) / 8;
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000D25AF File Offset: 0x000D07AF
		public virtual int GetOutputBlockSize()
		{
			this.CheckInitialised();
			if (this.forEncryption)
			{
				return (this.bitSize + 7) / 8;
			}
			return (this.bitSize - 1) / 8;
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000D25D4 File Offset: 0x000D07D4
		public virtual global::Org.BouncyCastle.Math.BigInteger ConvertInput(byte[] inBuf, int inOff, int inLen)
		{
			this.CheckInitialised();
			int maxLength = (this.bitSize + 7) / 8;
			if (inLen > maxLength)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for RSA cipher.");
			}
			global::Org.BouncyCastle.Math.BigInteger bigInteger = new global::Org.BouncyCastle.Math.BigInteger(1, inBuf, inOff, inLen);
			if (bigInteger.CompareTo(this.key.Modulus) >= 0)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for RSA cipher.");
			}
			return bigInteger;
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000D262C File Offset: 0x000D082C
		public virtual byte[] ConvertOutput(global::Org.BouncyCastle.Math.BigInteger result)
		{
			this.CheckInitialised();
			byte[] output = result.ToByteArrayUnsigned();
			if (this.forEncryption)
			{
				int outSize = this.GetOutputBlockSize();
				if (output.Length < outSize)
				{
					byte[] tmp = new byte[outSize];
					output.CopyTo(tmp, tmp.Length - output.Length);
					output = tmp;
				}
			}
			return output;
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000D2674 File Offset: 0x000D0874
		public virtual global::Org.BouncyCastle.Math.BigInteger ProcessBlock(global::Org.BouncyCastle.Math.BigInteger input)
		{
			this.CheckInitialised();
			if (this.key is global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters = (global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)this.key;
				global::Org.BouncyCastle.Math.BigInteger p = rsaPrivateCrtKeyParameters.P;
				global::Org.BouncyCastle.Math.BigInteger q = rsaPrivateCrtKeyParameters.Q;
				global::Org.BouncyCastle.Math.BigInteger dP = rsaPrivateCrtKeyParameters.DP;
				global::Org.BouncyCastle.Math.BigInteger dQ = rsaPrivateCrtKeyParameters.DQ;
				global::Org.BouncyCastle.Math.BigInteger qInv = rsaPrivateCrtKeyParameters.QInv;
				global::Org.BouncyCastle.Math.BigInteger bigInteger = input.Remainder(p).ModPow(dP, p);
				global::Org.BouncyCastle.Math.BigInteger mQ = input.Remainder(q).ModPow(dQ, q);
				return bigInteger.Subtract(mQ).Multiply(qInv).Mod(p).Multiply(q).Add(mQ);
			}
			return input.ModPow(this.key.Exponent, this.key.Modulus);
		}

		// Token: 0x040013B5 RID: 5045
		private global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key;

		// Token: 0x040013B6 RID: 5046
		private bool forEncryption;

		// Token: 0x040013B7 RID: 5047
		private int bitSize;
	}
}
