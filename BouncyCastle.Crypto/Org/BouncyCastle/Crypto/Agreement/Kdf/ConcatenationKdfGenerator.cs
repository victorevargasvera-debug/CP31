using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf
{
	// Token: 0x020004FC RID: 1276
	public class ConcatenationKdfGenerator : global::Org.BouncyCastle.Crypto.IDerivationFunction
	{
		// Token: 0x0600320E RID: 12814 RVA: 0x000F07D8 File Offset: 0x000EE9D8
		public ConcatenationKdfGenerator(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.mDigest = digest;
			this.mHLen = digest.GetDigestSize();
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000F07F4 File Offset: 0x000EE9F4
		public virtual void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters param)
		{
			if (!(param is global::Org.BouncyCastle.Crypto.Parameters.KdfParameters))
			{
				throw new global::System.ArgumentException("KDF parameters required for ConcatenationKdfGenerator");
			}
			global::Org.BouncyCastle.Crypto.Parameters.KdfParameters p = (global::Org.BouncyCastle.Crypto.Parameters.KdfParameters)param;
			this.mShared = p.GetSharedSecret();
			this.mOtherInfo = p.GetIV();
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x000F0833 File Offset: 0x000EEA33
		public virtual global::Org.BouncyCastle.Crypto.IDigest Digest
		{
			get
			{
				return this.mDigest;
			}
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000F083C File Offset: 0x000EEA3C
		public virtual int GenerateBytes(byte[] outBytes, int outOff, int len)
		{
			if (outBytes.Length - len < outOff)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too small");
			}
			byte[] hashBuf = new byte[this.mHLen];
			byte[] C = new byte[4];
			uint counter = 1U;
			int outputLen = 0;
			this.mDigest.Reset();
			if (len > this.mHLen)
			{
				do
				{
					global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(counter, C);
					this.mDigest.BlockUpdate(C, 0, C.Length);
					this.mDigest.BlockUpdate(this.mShared, 0, this.mShared.Length);
					this.mDigest.BlockUpdate(this.mOtherInfo, 0, this.mOtherInfo.Length);
					this.mDigest.DoFinal(hashBuf, 0);
					global::System.Array.Copy(hashBuf, 0, outBytes, outOff + outputLen, this.mHLen);
					outputLen += this.mHLen;
				}
				while ((ulong)counter++ < (ulong)((long)(len / this.mHLen)));
			}
			if (outputLen < len)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(counter, C);
				this.mDigest.BlockUpdate(C, 0, C.Length);
				this.mDigest.BlockUpdate(this.mShared, 0, this.mShared.Length);
				this.mDigest.BlockUpdate(this.mOtherInfo, 0, this.mOtherInfo.Length);
				this.mDigest.DoFinal(hashBuf, 0);
				global::System.Array.Copy(hashBuf, 0, outBytes, outOff + outputLen, len - outputLen);
			}
			return len;
		}

		// Token: 0x04001626 RID: 5670
		private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;

		// Token: 0x04001627 RID: 5671
		private byte[] mShared;

		// Token: 0x04001628 RID: 5672
		private byte[] mOtherInfo;

		// Token: 0x04001629 RID: 5673
		private int mHLen;
	}
}
