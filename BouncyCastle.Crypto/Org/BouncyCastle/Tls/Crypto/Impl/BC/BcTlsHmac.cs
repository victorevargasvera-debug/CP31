using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200017E RID: 382
	internal sealed class BcTlsHmac : global::Org.BouncyCastle.Tls.Crypto.TlsHmac, global::Org.BouncyCastle.Tls.Crypto.TlsMac
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003607C File Offset: 0x0003427C
		internal BcTlsHmac(global::Org.BouncyCastle.Crypto.Macs.HMac hmac)
		{
			this.m_hmac = hmac;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0003608B File Offset: 0x0003428B
		public void SetKey(byte[] key, int keyOff, int keyLen)
		{
			this.m_hmac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, keyOff, keyLen));
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000360A0 File Offset: 0x000342A0
		public void Update(byte[] input, int inOff, int length)
		{
			this.m_hmac.BlockUpdate(input, inOff, length);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000360B0 File Offset: 0x000342B0
		public byte[] CalculateMac()
		{
			byte[] rv = new byte[this.m_hmac.GetMacSize()];
			this.m_hmac.DoFinal(rv, 0);
			return rv;
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000360DD File Offset: 0x000342DD
		public void CalculateMac(byte[] output, int outOff)
		{
			this.m_hmac.DoFinal(output, outOff);
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000360ED File Offset: 0x000342ED
		public int InternalBlockSize
		{
			get
			{
				return this.m_hmac.GetUnderlyingDigest().GetByteLength();
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000360FF File Offset: 0x000342FF
		public int MacLength
		{
			get
			{
				return this.m_hmac.GetMacSize();
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0003610C File Offset: 0x0003430C
		public void Reset()
		{
			this.m_hmac.Reset();
		}

		// Token: 0x0400082E RID: 2094
		private readonly global::Org.BouncyCastle.Crypto.Macs.HMac m_hmac;
	}
}
