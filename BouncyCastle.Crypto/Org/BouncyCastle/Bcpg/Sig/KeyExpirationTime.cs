using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005CF RID: 1487
	public class KeyExpirationTime : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060037F8 RID: 14328 RVA: 0x00108675 File Offset: 0x00106875
		protected static byte[] TimeToBytes(long t)
		{
			return new byte[]
			{
				(byte)(t >> 24),
				(byte)(t >> 16),
				(byte)(t >> 8),
				(byte)t
			};
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00108699 File Offset: 0x00106899
		public KeyExpirationTime(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyExpireTime, critical, isLongLength, data)
		{
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x001086A6 File Offset: 0x001068A6
		public KeyExpirationTime(bool critical, long seconds) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyExpireTime, critical, false, global::Org.BouncyCastle.Bcpg.Sig.KeyExpirationTime.TimeToBytes(seconds))
		{
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x001086B8 File Offset: 0x001068B8
		public long Time
		{
			get
			{
				return (long)(this.data[0] & byte.MaxValue) << 24 | (long)(this.data[1] & byte.MaxValue) << 16 | (long)(this.data[2] & byte.MaxValue) << 8 | (long)((ulong)this.data[3] & 255UL);
			}
		}
	}
}
