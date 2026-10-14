using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B2 RID: 1202
	public class RsaEngine : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x06002E6C RID: 11884 RVA: 0x000D2726 File Offset: 0x000D0926
		public RsaEngine() : this(new global::Org.BouncyCastle.Crypto.Engines.RsaCoreEngine())
		{
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000D2733 File Offset: 0x000D0933
		public RsaEngine(global::Org.BouncyCastle.Crypto.IRsa rsa)
		{
			this.core = rsa;
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06002E6E RID: 11886 RVA: 0x000D2742 File Offset: 0x000D0942
		public virtual string AlgorithmName
		{
			get
			{
				return "RSA";
			}
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000D2749 File Offset: 0x000D0949
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.core.Init(forEncryption, parameters);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000D2758 File Offset: 0x000D0958
		public virtual int GetInputBlockSize()
		{
			return this.core.GetInputBlockSize();
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x000D2765 File Offset: 0x000D0965
		public virtual int GetOutputBlockSize()
		{
			return this.core.GetOutputBlockSize();
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000D2774 File Offset: 0x000D0974
		public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
		{
			global::Org.BouncyCastle.Math.BigInteger input = this.core.ConvertInput(inBuf, inOff, inLen);
			global::Org.BouncyCastle.Math.BigInteger output = this.core.ProcessBlock(input);
			return this.core.ConvertOutput(output);
		}

		// Token: 0x040013B8 RID: 5048
		private readonly global::Org.BouncyCastle.Crypto.IRsa core;
	}
}
