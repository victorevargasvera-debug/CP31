using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005CE RID: 1486
	public class IssuerKeyId : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060037F4 RID: 14324 RVA: 0x00108564 File Offset: 0x00106764
		protected static byte[] KeyIdToBytes(long keyId)
		{
			return new byte[]
			{
				(byte)(keyId >> 56),
				(byte)(keyId >> 48),
				(byte)(keyId >> 40),
				(byte)(keyId >> 32),
				(byte)(keyId >> 24),
				(byte)(keyId >> 16),
				(byte)(keyId >> 8),
				(byte)keyId
			};
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x001085B3 File Offset: 0x001067B3
		public IssuerKeyId(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId, critical, isLongLength, data)
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x001085C0 File Offset: 0x001067C0
		public IssuerKeyId(bool critical, long keyId) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.IssuerKeyId, critical, false, global::Org.BouncyCastle.Bcpg.Sig.IssuerKeyId.KeyIdToBytes(keyId))
		{
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x001085D4 File Offset: 0x001067D4
		public long KeyId
		{
			get
			{
				return (long)(this.data[0] & byte.MaxValue) << 56 | (long)(this.data[1] & byte.MaxValue) << 48 | (long)(this.data[2] & byte.MaxValue) << 40 | (long)(this.data[3] & byte.MaxValue) << 32 | (long)(this.data[4] & byte.MaxValue) << 24 | (long)(this.data[5] & byte.MaxValue) << 16 | (long)(this.data[6] & byte.MaxValue) << 8 | (long)((ulong)this.data[7] & 255UL);
			}
		}
	}
}
