using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004AF RID: 1199
	public class RsaBlindedEngine : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x06002E54 RID: 11860 RVA: 0x000D21E8 File Offset: 0x000D03E8
		public RsaBlindedEngine() : this(new global::Org.BouncyCastle.Crypto.Engines.RsaCoreEngine())
		{
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000D21F5 File Offset: 0x000D03F5
		public RsaBlindedEngine(global::Org.BouncyCastle.Crypto.IRsa rsa)
		{
			this.core = rsa;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x000D2204 File Offset: 0x000D0404
		public virtual string AlgorithmName
		{
			get
			{
				return "RSA";
			}
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000D220C File Offset: 0x000D040C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters param)
		{
			this.core.Init(forEncryption, param);
			if (param is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)param;
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)rParam.Parameters;
				if (this.key is global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)
				{
					this.random = rParam.Random;
					return;
				}
				this.random = null;
				return;
			}
			else
			{
				this.key = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)param;
				if (this.key is global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)
				{
					this.random = new global::Org.BouncyCastle.Security.SecureRandom();
					return;
				}
				this.random = null;
				return;
			}
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000D2294 File Offset: 0x000D0494
		public virtual int GetInputBlockSize()
		{
			return this.core.GetInputBlockSize();
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000D22A1 File Offset: 0x000D04A1
		public virtual int GetOutputBlockSize()
		{
			return this.core.GetOutputBlockSize();
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000D22B0 File Offset: 0x000D04B0
		public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
		{
			if (this.key == null)
			{
				throw new global::System.InvalidOperationException("RSA engine not initialised");
			}
			global::Org.BouncyCastle.Math.BigInteger input = this.core.ConvertInput(inBuf, inOff, inLen);
			global::Org.BouncyCastle.Math.BigInteger result;
			if (this.key is global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters i = (global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters)this.key;
				global::Org.BouncyCastle.Math.BigInteger e = i.PublicExponent;
				if (e != null)
				{
					global::Org.BouncyCastle.Math.BigInteger j = i.Modulus;
					global::Org.BouncyCastle.Math.BigInteger r = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Math.BigInteger.One, j.Subtract(global::Org.BouncyCastle.Math.BigInteger.One), this.random);
					global::Org.BouncyCastle.Math.BigInteger blindedInput = r.ModPow(e, j).Multiply(input).Mod(j);
					global::Org.BouncyCastle.Math.BigInteger bigInteger = this.core.ProcessBlock(blindedInput);
					global::Org.BouncyCastle.Math.BigInteger rInv = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(j, r);
					result = bigInteger.Multiply(rInv).Mod(j);
					if (!input.Equals(result.ModPow(e, j)))
					{
						throw new global::System.InvalidOperationException("RSA engine faulty decryption/signing detected");
					}
				}
				else
				{
					result = this.core.ProcessBlock(input);
				}
			}
			else
			{
				result = this.core.ProcessBlock(input);
			}
			return this.core.ConvertOutput(result);
		}

		// Token: 0x040013AE RID: 5038
		private readonly global::Org.BouncyCastle.Crypto.IRsa core;

		// Token: 0x040013AF RID: 5039
		private global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key;

		// Token: 0x040013B0 RID: 5040
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
