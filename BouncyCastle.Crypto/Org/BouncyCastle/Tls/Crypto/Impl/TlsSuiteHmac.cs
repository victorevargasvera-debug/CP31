using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x02000162 RID: 354
	public class TlsSuiteHmac : global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteMac
	{
		// Token: 0x06000DCF RID: 3535 RVA: 0x00033C50 File Offset: 0x00031E50
		protected static int GetMacSize(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.TlsMac mac)
		{
			int macSize = mac.MacLength;
			if (cryptoParams.SecurityParameters.IsTruncatedHmac)
			{
				macSize = global::System.Math.Min(macSize, 10);
			}
			return macSize;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00033C7C File Offset: 0x00031E7C
		public TlsSuiteHmac(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.TlsHmac mac)
		{
			this.m_cryptoParams = cryptoParams;
			this.m_mac = mac;
			this.m_macSize = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac.GetMacSize(cryptoParams, mac);
			this.m_digestBlockSize = mac.InternalBlockSize;
			if (global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsSsl(cryptoParams) && mac.MacLength == 20)
			{
				this.m_digestOverhead = 4;
				return;
			}
			this.m_digestOverhead = this.m_digestBlockSize / 8;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00033CDE File Offset: 0x00031EDE
		public virtual int Size
		{
			get
			{
				return this.m_macSize;
			}
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00033CE8 File Offset: 0x00031EE8
		public virtual byte[] CalculateMac(long seqNo, short type, byte[] msg, int msgOff, int msgLen)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion serverVersion = this.m_cryptoParams.ServerVersion;
			bool isSsl = serverVersion.IsSsl;
			byte[] macHeader = new byte[isSsl ? 11 : 13];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint64(seqNo, macHeader, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(type, macHeader, 8);
			if (!isSsl)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(serverVersion, macHeader, 9);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(msgLen, macHeader, macHeader.Length - 2);
			this.m_mac.Update(macHeader, 0, macHeader.Length);
			this.m_mac.Update(msg, msgOff, msgLen);
			return this.Truncate(this.m_mac.CalculateMac());
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00033D70 File Offset: 0x00031F70
		public virtual byte[] CalculateMacConstantTime(long seqNo, short type, byte[] msg, int msgOff, int msgLen, int fullLength, byte[] dummyData)
		{
			byte[] result = this.CalculateMac(seqNo, type, msg, msgOff, msgLen);
			int headerLength = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsSsl(this.m_cryptoParams) ? 11 : 13;
			int extra = this.GetDigestBlockCount(headerLength + fullLength) - this.GetDigestBlockCount(headerLength + msgLen);
			while (--extra >= 0)
			{
				this.m_mac.Update(dummyData, 0, this.m_digestBlockSize);
			}
			this.m_mac.Update(dummyData, 0, 1);
			this.m_mac.Reset();
			return result;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00033DEE File Offset: 0x00031FEE
		protected virtual int GetDigestBlockCount(int inputLength)
		{
			return (inputLength + this.m_digestOverhead) / this.m_digestBlockSize;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00033DFF File Offset: 0x00031FFF
		protected virtual byte[] Truncate(byte[] bs)
		{
			if (bs.Length <= this.m_macSize)
			{
				return bs;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOf(bs, this.m_macSize);
		}

		// Token: 0x040007FA RID: 2042
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters m_cryptoParams;

		// Token: 0x040007FB RID: 2043
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsHmac m_mac;

		// Token: 0x040007FC RID: 2044
		protected readonly int m_digestBlockSize;

		// Token: 0x040007FD RID: 2045
		protected readonly int m_digestOverhead;

		// Token: 0x040007FE RID: 2046
		protected readonly int m_macSize;
	}
}
