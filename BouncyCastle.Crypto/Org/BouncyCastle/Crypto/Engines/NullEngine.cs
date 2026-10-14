using System;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A5 RID: 1189
	public class NullEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002DE0 RID: 11744 RVA: 0x000CEE85 File Offset: 0x000CD085
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.initialised = true;
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002DE1 RID: 11745 RVA: 0x000CEE8E File Offset: 0x000CD08E
		public virtual string AlgorithmName
		{
			get
			{
				return "Null";
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002DE2 RID: 11746 RVA: 0x000CEE95 File Offset: 0x000CD095
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x000CEE98 File Offset: 0x000CD098
		public virtual int GetBlockSize()
		{
			return 1;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x000CEE9C File Offset: 0x000CD09C
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException("Null engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 1, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 1, "output buffer too short");
			for (int i = 0; i < 1; i++)
			{
				output[outOff + i] = input[inOff + i];
			}
			return 1;
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x000CEEEF File Offset: 0x000CD0EF
		public virtual void Reset()
		{
		}

		// Token: 0x04001369 RID: 4969
		private bool initialised;

		// Token: 0x0400136A RID: 4970
		private const int BlockSize = 1;
	}
}
