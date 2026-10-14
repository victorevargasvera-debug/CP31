using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000BE RID: 190
	internal sealed class DtlsReplayWindow
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x0001E914 File Offset: 0x0001CB14
		internal bool ShouldDiscard(long seq)
		{
			if ((seq & 281474976710655L) != seq)
			{
				return true;
			}
			if (seq <= this.m_latestConfirmedSeq)
			{
				long diff = this.m_latestConfirmedSeq - seq;
				if (diff >= 64L)
				{
					return true;
				}
				if ((this.m_bitmap & 1UL << (int)diff) != 0UL)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0001E960 File Offset: 0x0001CB60
		internal void ReportAuthenticated(long seq)
		{
			if ((seq & 281474976710655L) != seq)
			{
				throw new global::System.ArgumentException("out of range", "seq");
			}
			if (seq <= this.m_latestConfirmedSeq)
			{
				long diff = this.m_latestConfirmedSeq - seq;
				if (diff < 64L)
				{
					this.m_bitmap |= 1UL << (int)diff;
					return;
				}
			}
			else
			{
				long diff2 = seq - this.m_latestConfirmedSeq;
				if (diff2 >= 64L)
				{
					this.m_bitmap = 1UL;
				}
				else
				{
					this.m_bitmap <<= (int)diff2;
					this.m_bitmap |= 1UL;
				}
				this.m_latestConfirmedSeq = seq;
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0001E9FA File Offset: 0x0001CBFA
		internal void Reset(long seq)
		{
			if ((seq & 281474976710655L) != seq)
			{
				throw new global::System.ArgumentException("out of range", "seq");
			}
			this.m_latestConfirmedSeq = seq;
			this.m_bitmap = ulong.MaxValue >> (int)global::System.Math.Max(0L, 63L - seq);
		}

		// Token: 0x0400050E RID: 1294
		private const long ValidSeqMask = 281474976710655L;

		// Token: 0x0400050F RID: 1295
		private const long WindowSize = 64L;

		// Token: 0x04000510 RID: 1296
		private long m_latestConfirmedSeq = -1L;

		// Token: 0x04000511 RID: 1297
		private ulong m_bitmap;
	}
}
