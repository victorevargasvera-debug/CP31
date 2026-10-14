using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000168 RID: 360
	internal class BcSsl3Hmac : global::Org.BouncyCastle.Tls.Crypto.TlsHmac, global::Org.BouncyCastle.Tls.Crypto.TlsMac
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00034430 File Offset: 0x00032630
		internal BcSsl3Hmac(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.m_digest = digest;
			if (digest.GetDigestSize() == 20)
			{
				this.m_padLength = 40;
				return;
			}
			this.m_padLength = 48;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0003445A File Offset: 0x0003265A
		public virtual void SetKey(byte[] key, int keyOff, int keyLen)
		{
			this.m_secret = global::Org.BouncyCastle.Tls.TlsUtilities.CopyOfRangeExact(key, keyOff, keyOff + keyLen);
			this.Reset();
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00034472 File Offset: 0x00032672
		public virtual void Update(byte[] input, int inOff, int len)
		{
			this.m_digest.BlockUpdate(input, inOff, len);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00034484 File Offset: 0x00032684
		public virtual byte[] CalculateMac()
		{
			byte[] result = new byte[this.m_digest.GetDigestSize()];
			this.DoFinal(result, 0);
			return result;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000344AB File Offset: 0x000326AB
		public virtual void CalculateMac(byte[] output, int outOff)
		{
			this.DoFinal(output, outOff);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x000344B5 File Offset: 0x000326B5
		public virtual int InternalBlockSize
		{
			get
			{
				return this.m_digest.GetByteLength();
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x000344C2 File Offset: 0x000326C2
		public virtual int MacLength
		{
			get
			{
				return this.m_digest.GetDigestSize();
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000344CF File Offset: 0x000326CF
		public virtual void Reset()
		{
			this.m_digest.Reset();
			this.m_digest.BlockUpdate(this.m_secret, 0, this.m_secret.Length);
			this.m_digest.BlockUpdate(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac.IPAD, 0, this.m_padLength);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00034510 File Offset: 0x00032710
		private void DoFinal(byte[] output, int outOff)
		{
			byte[] tmp = new byte[this.m_digest.GetDigestSize()];
			this.m_digest.DoFinal(tmp, 0);
			this.m_digest.BlockUpdate(this.m_secret, 0, this.m_secret.Length);
			this.m_digest.BlockUpdate(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac.OPAD, 0, this.m_padLength);
			this.m_digest.BlockUpdate(tmp, 0, tmp.Length);
			this.m_digest.DoFinal(output, outOff);
			this.Reset();
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00034591 File Offset: 0x00032791
		private static byte[] GenPad(byte b, int count)
		{
			byte[] array = new byte[count];
			global::Org.BouncyCastle.Utilities.Arrays.Fill(array, b);
			return array;
		}

		// Token: 0x04000808 RID: 2056
		private const byte IPAD_BYTE = 54;

		// Token: 0x04000809 RID: 2057
		private const byte OPAD_BYTE = 92;

		// Token: 0x0400080A RID: 2058
		private static readonly byte[] IPAD = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac.GenPad(54, 48);

		// Token: 0x0400080B RID: 2059
		private static readonly byte[] OPAD = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac.GenPad(92, 48);

		// Token: 0x0400080C RID: 2060
		private readonly global::Org.BouncyCastle.Crypto.IDigest m_digest;

		// Token: 0x0400080D RID: 2061
		private readonly int m_padLength;

		// Token: 0x0400080E RID: 2062
		private byte[] m_secret;
	}
}
