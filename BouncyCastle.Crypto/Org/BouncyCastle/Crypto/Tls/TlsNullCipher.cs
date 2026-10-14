using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000377 RID: 887
	public class TlsNullCipher : global::Org.BouncyCastle.Crypto.Tls.TlsCipher
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x0009CC7F File Offset: 0x0009AE7F
		public TlsNullCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			this.context = context;
			this.writeMac = null;
			this.readMac = null;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0009CC9C File Offset: 0x0009AE9C
		public TlsNullCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.IDigest clientWriteDigest, global::Org.BouncyCastle.Crypto.IDigest serverWriteDigest)
		{
			if (clientWriteDigest == null != (serverWriteDigest == null))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.context = context;
			global::Org.BouncyCastle.Crypto.Tls.TlsMac clientWriteMac = null;
			global::Org.BouncyCastle.Crypto.Tls.TlsMac serverWriteMac = null;
			if (clientWriteDigest != null)
			{
				int key_block_size = clientWriteDigest.GetDigestSize() + serverWriteDigest.GetDigestSize();
				byte[] key_block = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context, key_block_size);
				int offset = 0;
				clientWriteMac = new global::Org.BouncyCastle.Crypto.Tls.TlsMac(context, clientWriteDigest, key_block, offset, clientWriteDigest.GetDigestSize());
				offset += clientWriteDigest.GetDigestSize();
				serverWriteMac = new global::Org.BouncyCastle.Crypto.Tls.TlsMac(context, serverWriteDigest, key_block, offset, serverWriteDigest.GetDigestSize());
				offset += serverWriteDigest.GetDigestSize();
				if (offset != key_block_size)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
			}
			if (context.IsServer)
			{
				this.writeMac = serverWriteMac;
				this.readMac = clientWriteMac;
				return;
			}
			this.writeMac = clientWriteMac;
			this.readMac = serverWriteMac;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0009CD54 File Offset: 0x0009AF54
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			int result = ciphertextLimit;
			if (this.writeMac != null)
			{
				result -= this.writeMac.Size;
			}
			return result;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0009CD7C File Offset: 0x0009AF7C
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			if (this.writeMac == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(plaintext, offset, offset + len);
			}
			byte[] mac = this.writeMac.CalculateMac(seqNo, type, plaintext, offset, len);
			byte[] ciphertext = new byte[len + mac.Length];
			global::System.Array.Copy(plaintext, offset, ciphertext, 0, len);
			global::System.Array.Copy(mac, 0, ciphertext, len, mac.Length);
			return ciphertext;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0009CDD8 File Offset: 0x0009AFD8
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			if (this.readMac == null)
			{
				return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, offset, offset + len);
			}
			int macSize = this.readMac.Size;
			if (len < macSize)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int macInputLen = len - macSize;
			byte[] a = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, offset + macInputLen, offset + len);
			byte[] computedMac = this.readMac.CalculateMac(seqNo, type, ciphertext, offset, macInputLen);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a, computedMac))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(20);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, offset, offset + macInputLen);
		}

		// Token: 0x04000E74 RID: 3700
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext context;

		// Token: 0x04000E75 RID: 3701
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsMac writeMac;

		// Token: 0x04000E76 RID: 3702
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsMac readMac;
	}
}
