using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D6 RID: 1494
	public class SignatureExpirationTime : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x06003817 RID: 14359 RVA: 0x00108B1C File Offset: 0x00106D1C
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

		// Token: 0x06003818 RID: 14360 RVA: 0x00108B40 File Offset: 0x00106D40
		public SignatureExpirationTime(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.ExpireTime, critical, isLongLength, data)
		{
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x00108B4C File Offset: 0x00106D4C
		public SignatureExpirationTime(bool critical, long seconds) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.ExpireTime, critical, false, global::Org.BouncyCastle.Bcpg.Sig.SignatureExpirationTime.TimeToBytes(seconds))
		{
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600381A RID: 14362 RVA: 0x00108B60 File Offset: 0x00106D60
		public long Time
		{
			get
			{
				return (long)(this.data[0] & byte.MaxValue) << 24 | (long)(this.data[1] & byte.MaxValue) << 16 | (long)(this.data[2] & byte.MaxValue) << 8 | (long)((ulong)this.data[3] & 255UL);
			}
		}
	}
}
