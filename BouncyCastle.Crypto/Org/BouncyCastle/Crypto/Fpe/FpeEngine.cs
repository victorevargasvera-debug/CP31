using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Fpe
{
	// Token: 0x02000486 RID: 1158
	public abstract class FpeEngine
	{
		// Token: 0x06002C50 RID: 11344 RVA: 0x000BF6E1 File Offset: 0x000BD8E1
		protected FpeEngine(global::Org.BouncyCastle.Crypto.IBlockCipher baseCipher)
		{
			this.baseCipher = baseCipher;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x000BF6F0 File Offset: 0x000BD8F0
		public virtual int ProcessBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff)
		{
			if (this.fpeParameters == null)
			{
				throw new global::System.InvalidOperationException("FPE engine not initialized");
			}
			if (length < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "length");
			}
			if (inBuf == null)
			{
				throw new global::System.ArgumentNullException("inBuf");
			}
			if (outBuf == null)
			{
				throw new global::System.ArgumentNullException("outBuf");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(inBuf, inOff, length, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(outBuf, outOff, length, "output buffer too short");
			if (this.forEncryption)
			{
				return this.EncryptBlock(inBuf, inOff, length, outBuf, outOff);
			}
			return this.DecryptBlock(inBuf, inOff, length, outBuf, outOff);
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000BF780 File Offset: 0x000BD980
		protected static bool IsOverrideSet(string propName)
		{
			string propValue = global::Org.BouncyCastle.Utilities.Platform.GetEnvironmentVariable(propName);
			return propValue != null && global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase("true", propValue);
		}

		// Token: 0x06002C53 RID: 11347
		public abstract void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06002C54 RID: 11348
		protected abstract int EncryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff);

		// Token: 0x06002C55 RID: 11349
		protected abstract int DecryptBlock(byte[] inBuf, int inOff, int length, byte[] outBuf, int outOff);

		// Token: 0x0400127B RID: 4731
		protected readonly global::Org.BouncyCastle.Crypto.IBlockCipher baseCipher;

		// Token: 0x0400127C RID: 4732
		protected bool forEncryption;

		// Token: 0x0400127D RID: 4733
		protected global::Org.BouncyCastle.Crypto.Parameters.FpeParameters fpeParameters;
	}
}
