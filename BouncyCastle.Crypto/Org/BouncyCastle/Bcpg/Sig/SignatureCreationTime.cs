using System;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D5 RID: 1493
	public class SignatureCreationTime : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x06003813 RID: 14355 RVA: 0x00108A88 File Offset: 0x00106C88
		protected static byte[] TimeToBytes(global::System.DateTime time)
		{
			long t = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(time) / 1000L;
			return new byte[]
			{
				(byte)(t >> 24),
				(byte)(t >> 16),
				(byte)(t >> 8),
				(byte)t
			};
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00108AC5 File Offset: 0x00106CC5
		public SignatureCreationTime(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime, critical, isLongLength, data)
		{
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00108AD1 File Offset: 0x00106CD1
		public SignatureCreationTime(bool critical, global::System.DateTime date) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.CreationTime, critical, false, global::Org.BouncyCastle.Bcpg.Sig.SignatureCreationTime.TimeToBytes(date))
		{
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x00108AE2 File Offset: 0x00106CE2
		public global::System.DateTime GetTime()
		{
			return global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixMsToDateTime((long)((ulong)((int)this.data[0] << 24 | (int)this.data[1] << 16 | (int)this.data[2] << 8 | (int)this.data[3]) * 1000UL));
		}
	}
}
