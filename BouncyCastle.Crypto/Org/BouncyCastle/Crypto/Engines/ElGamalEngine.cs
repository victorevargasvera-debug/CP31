using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200049C RID: 1180
	public class ElGamalEngine : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x000CC24A File Offset: 0x000CA44A
		public virtual string AlgorithmName
		{
			get
			{
				return "ElGamal";
			}
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000CC254 File Offset: 0x000CA454
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom p = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters)p.Parameters;
				this.random = p.Random;
			}
			else
			{
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters)parameters;
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
			this.forEncryption = forEncryption;
			this.bitSize = this.key.Parameters.P.BitLength;
			if (forEncryption)
			{
				if (!(this.key is global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters))
				{
					throw new global::System.ArgumentException("ElGamalPublicKeyParameters are required for encryption.");
				}
			}
			else if (!(this.key is global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters))
			{
				throw new global::System.ArgumentException("ElGamalPrivateKeyParameters are required for decryption.");
			}
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000CC2FB File Offset: 0x000CA4FB
		public virtual int GetInputBlockSize()
		{
			if (this.forEncryption)
			{
				return (this.bitSize - 1) / 8;
			}
			return 2 * ((this.bitSize + 7) / 8);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000CC31C File Offset: 0x000CA51C
		public virtual int GetOutputBlockSize()
		{
			if (this.forEncryption)
			{
				return 2 * ((this.bitSize + 7) / 8);
			}
			return (this.bitSize - 1) / 8;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000CC340 File Offset: 0x000CA540
		public virtual byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			if (this.key == null)
			{
				throw new global::System.InvalidOperationException("ElGamal engine not initialised");
			}
			int maxLength = this.forEncryption ? ((this.bitSize - 1 + 7) / 8) : this.GetInputBlockSize();
			if (length > maxLength)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for ElGamal cipher.\n");
			}
			global::Org.BouncyCastle.Math.BigInteger p = this.key.Parameters.P;
			byte[] output;
			if (this.key is global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters)
			{
				int halfLength = length / 2;
				global::Org.BouncyCastle.Math.BigInteger bigInteger = new global::Org.BouncyCastle.Math.BigInteger(1, input, inOff, halfLength);
				global::Org.BouncyCastle.Math.BigInteger phi = new global::Org.BouncyCastle.Math.BigInteger(1, input, inOff + halfLength, halfLength);
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters priv = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters)this.key;
				output = bigInteger.ModPow(p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One).Subtract(priv.X), p).Multiply(phi).Mod(p).ToByteArrayUnsigned();
			}
			else
			{
				global::Org.BouncyCastle.Math.BigInteger tmp = new global::Org.BouncyCastle.Math.BigInteger(1, input, inOff, length);
				if (tmp.BitLength >= p.BitLength)
				{
					throw new global::Org.BouncyCastle.Crypto.DataLengthException("input too large for ElGamal cipher.\n");
				}
				global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters pub = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters)this.key;
				global::Org.BouncyCastle.Math.BigInteger pSub2 = p.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two);
				global::Org.BouncyCastle.Math.BigInteger i;
				do
				{
					i = new global::Org.BouncyCastle.Math.BigInteger(p.BitLength, this.random);
				}
				while (i.SignValue == 0 || i.CompareTo(pSub2) > 0);
				global::Org.BouncyCastle.Math.BigInteger gamma = this.key.Parameters.G.ModPow(i, p);
				global::Org.BouncyCastle.Math.BigInteger bigInteger2 = tmp.Multiply(pub.Y.ModPow(i, p)).Mod(p);
				output = new byte[this.GetOutputBlockSize()];
				byte[] @out = gamma.ToByteArrayUnsigned();
				byte[] out2 = bigInteger2.ToByteArrayUnsigned();
				@out.CopyTo(output, output.Length / 2 - @out.Length);
				out2.CopyTo(output, output.Length - out2.Length);
			}
			return output;
		}

		// Token: 0x04001328 RID: 4904
		private global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters key;

		// Token: 0x04001329 RID: 4905
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x0400132A RID: 4906
		private bool forEncryption;

		// Token: 0x0400132B RID: 4907
		private int bitSize;
	}
}
