using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x0200030A RID: 778
	public class MessageDigest
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x00042F9F File Offset: 0x0004119F
		internal static global::NPOI.POIFS.Crypt.MessageDigest GetInstance(string jceId, string v)
		{
			return global::NPOI.POIFS.Crypt.MessageDigest.GetInstance(jceId);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00042FA7 File Offset: 0x000411A7
		internal static global::NPOI.POIFS.Crypt.MessageDigest GetInstance(string jceId)
		{
			return new global::NPOI.POIFS.Crypt.MessageDigest
			{
				digestImpl = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(jceId)
			};
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00042FBA File Offset: 0x000411BA
		internal void Update(byte[] passwordHash)
		{
			this.Update(passwordHash, 0, passwordHash.Length);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00042FC7 File Offset: 0x000411C7
		internal void Reset()
		{
			this.digestImpl.Reset();
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00042FD4 File Offset: 0x000411D4
		internal int Digest(byte[] buf, int offset, int len)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("No output buffer given");
			}
			if (buf.Length - offset < len)
			{
				throw new global::System.ArgumentOutOfRangeException("Output buffer too small for specified offset and length");
			}
			byte[] array = this.Digest();
			if (len < array.Length)
			{
				throw new global::System.Exception("partial digests not returned");
			}
			if (buf.Length - offset < array.Length)
			{
				throw new global::System.Exception("insufficient space in the output buffer to store the digest");
			}
			global::System.Array.Copy(array, 0, buf, offset, array.Length);
			return array.Length;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00043040 File Offset: 0x00041240
		internal byte[] Digest()
		{
			byte[] array = new byte[this.digestImpl.GetDigestSize()];
			this.digestImpl.DoFinal(array, 0);
			return array;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0004306D File Offset: 0x0004126D
		internal void Update(byte[] hash, int v1, int v2)
		{
			this.digestImpl.BlockUpdate(hash, v1, v2);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00043080 File Offset: 0x00041280
		public byte[] Digest(byte[] input)
		{
			byte[] array = new byte[this.digestImpl.GetDigestSize()];
			this.digestImpl.BlockUpdate(input, 0, input.Length);
			this.digestImpl.DoFinal(array, 0);
			return array;
		}

		// Token: 0x0400094C RID: 2380
		private global::Org.BouncyCastle.Crypto.IDigest digestImpl;
	}
}
