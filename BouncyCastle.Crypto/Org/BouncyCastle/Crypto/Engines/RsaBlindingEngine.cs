using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B0 RID: 1200
	public class RsaBlindingEngine : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x06002E5B RID: 11867 RVA: 0x000D23B2 File Offset: 0x000D05B2
		public RsaBlindingEngine() : this(new global::Org.BouncyCastle.Crypto.Engines.RsaCoreEngine())
		{
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000D23BF File Offset: 0x000D05BF
		public RsaBlindingEngine(global::Org.BouncyCastle.Crypto.IRsa rsa)
		{
			this.core = rsa;
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x000D23CE File Offset: 0x000D05CE
		public virtual string AlgorithmName
		{
			get
			{
				return "RSA";
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000D23D8 File Offset: 0x000D05D8
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters param)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaBlindingParameters p;
			if (param is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				p = (global::Org.BouncyCastle.Crypto.Parameters.RsaBlindingParameters)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)param).Parameters;
			}
			else
			{
				p = (global::Org.BouncyCastle.Crypto.Parameters.RsaBlindingParameters)param;
			}
			this.core.Init(forEncryption, p.PublicKey);
			this.forEncryption = forEncryption;
			this.key = p.PublicKey;
			this.blindingFactor = p.BlindingFactor;
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000D2438 File Offset: 0x000D0638
		public virtual int GetInputBlockSize()
		{
			return this.core.GetInputBlockSize();
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000D2445 File Offset: 0x000D0645
		public virtual int GetOutputBlockSize()
		{
			return this.core.GetOutputBlockSize();
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000D2454 File Offset: 0x000D0654
		public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
		{
			global::Org.BouncyCastle.Math.BigInteger msg = this.core.ConvertInput(inBuf, inOff, inLen);
			if (this.forEncryption)
			{
				msg = this.BlindMessage(msg);
			}
			else
			{
				msg = this.UnblindMessage(msg);
			}
			return this.core.ConvertOutput(msg);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000D2498 File Offset: 0x000D0698
		private global::Org.BouncyCastle.Math.BigInteger BlindMessage(global::Org.BouncyCastle.Math.BigInteger msg)
		{
			global::Org.BouncyCastle.Math.BigInteger blindMsg = this.blindingFactor;
			blindMsg = msg.Multiply(blindMsg.ModPow(this.key.Exponent, this.key.Modulus));
			return blindMsg.Mod(this.key.Modulus);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000D24E4 File Offset: 0x000D06E4
		private global::Org.BouncyCastle.Math.BigInteger UnblindMessage(global::Org.BouncyCastle.Math.BigInteger blindedMsg)
		{
			global::Org.BouncyCastle.Math.BigInteger i = this.key.Modulus;
			global::Org.BouncyCastle.Math.BigInteger blindFactorInverse = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(i, this.blindingFactor);
			return blindedMsg.Multiply(blindFactorInverse).Mod(i);
		}

		// Token: 0x040013B1 RID: 5041
		private readonly global::Org.BouncyCastle.Crypto.IRsa core;

		// Token: 0x040013B2 RID: 5042
		private global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key;

		// Token: 0x040013B3 RID: 5043
		private global::Org.BouncyCastle.Math.BigInteger blindingFactor;

		// Token: 0x040013B4 RID: 5044
		private bool forEncryption;
	}
}
