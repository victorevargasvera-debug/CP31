using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000375 RID: 885
	public class TlsMac
	{
		// Token: 0x06002400 RID: 9216 RVA: 0x0009CA5C File Offset: 0x0009AC5C
		public TlsMac(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.IDigest digest, byte[] key, int keyOff, int keyLen)
		{
			this.context = context;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParameter = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key, keyOff, keyLen);
			this.secret = global::Org.BouncyCastle.Utilities.Arrays.Clone(keyParameter.GetKey());
			if (digest is global::Org.BouncyCastle.Crypto.Digests.LongDigest)
			{
				this.digestBlockSize = 128;
				this.digestOverhead = 16;
			}
			else
			{
				this.digestBlockSize = 64;
				this.digestOverhead = 8;
			}
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context))
			{
				this.mac = new global::Org.BouncyCastle.Crypto.Tls.Ssl3Mac(digest);
				if (digest.GetDigestSize() == 20)
				{
					this.digestOverhead = 4;
				}
			}
			else
			{
				this.mac = new global::Org.BouncyCastle.Crypto.Macs.HMac(digest);
			}
			this.mac.Init(keyParameter);
			this.macLength = this.mac.GetMacSize();
			if (context.SecurityParameters.truncatedHMac)
			{
				this.macLength = global::System.Math.Min(this.macLength, 10);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0009CB2E File Offset: 0x0009AD2E
		public virtual byte[] MacSecret
		{
			get
			{
				return this.secret;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0009CB36 File Offset: 0x0009AD36
		public virtual int Size
		{
			get
			{
				return this.macLength;
			}
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0009CB40 File Offset: 0x0009AD40
		public virtual byte[] CalculateMac(long seqNo, byte type, byte[] message, int offset, int length)
		{
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion = this.context.ServerVersion;
			bool isSsl = serverVersion.IsSsl;
			byte[] macHeader = new byte[isSsl ? 11 : 13];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, macHeader, 0);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(type, macHeader, 8);
			if (!isSsl)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(serverVersion, macHeader, 9);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(length, macHeader, macHeader.Length - 2);
			this.mac.BlockUpdate(macHeader, 0, macHeader.Length);
			this.mac.BlockUpdate(message, offset, length);
			return this.Truncate(global::Org.BouncyCastle.Security.MacUtilities.DoFinal(this.mac));
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0009CBC8 File Offset: 0x0009ADC8
		public virtual byte[] CalculateMacConstantTime(long seqNo, byte type, byte[] message, int offset, int length, int fullLength, byte[] dummyData)
		{
			byte[] result = this.CalculateMac(seqNo, type, message, offset, length);
			int headerLength = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.context) ? 11 : 13;
			int extra = this.GetDigestBlockCount(headerLength + fullLength) - this.GetDigestBlockCount(headerLength + length);
			while (--extra >= 0)
			{
				this.mac.BlockUpdate(dummyData, 0, this.digestBlockSize);
			}
			this.mac.Update(dummyData[0]);
			this.mac.Reset();
			return result;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0009CC46 File Offset: 0x0009AE46
		protected virtual int GetDigestBlockCount(int inputLength)
		{
			return (inputLength + this.digestOverhead) / this.digestBlockSize;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0009CC57 File Offset: 0x0009AE57
		protected virtual byte[] Truncate(byte[] bs)
		{
			if (bs.Length <= this.macLength)
			{
				return bs;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOf(bs, this.macLength);
		}

		// Token: 0x04000E6E RID: 3694
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext context;

		// Token: 0x04000E6F RID: 3695
		protected readonly byte[] secret;

		// Token: 0x04000E70 RID: 3696
		protected readonly global::Org.BouncyCastle.Crypto.IMac mac;

		// Token: 0x04000E71 RID: 3697
		protected readonly int digestBlockSize;

		// Token: 0x04000E72 RID: 3698
		protected readonly int digestOverhead;

		// Token: 0x04000E73 RID: 3699
		protected readonly int macLength;
	}
}
