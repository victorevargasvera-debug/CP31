using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000328 RID: 808
	internal class DtlsReplayWindow
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x000965C0 File Offset: 0x000947C0
		internal bool ShouldDiscard(long seq)
		{
			if ((seq & 281474976710655L) != seq)
			{
				return true;
			}
			if (seq <= this.mLatestConfirmedSeq)
			{
				long diff = this.mLatestConfirmedSeq - seq;
				if (diff >= 64L)
				{
					return true;
				}
				if ((this.mBitmap & 1L << (int)diff) != 0L)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0009660C File Offset: 0x0009480C
		internal void ReportAuthenticated(long seq)
		{
			if ((seq & 281474976710655L) != seq)
			{
				throw new global::System.ArgumentException("out of range", "seq");
			}
			if (seq <= this.mLatestConfirmedSeq)
			{
				long diff = this.mLatestConfirmedSeq - seq;
				if (diff < 64L)
				{
					this.mBitmap |= 1L << (int)diff;
					return;
				}
			}
			else
			{
				long diff2 = seq - this.mLatestConfirmedSeq;
				if (diff2 >= 64L)
				{
					this.mBitmap = 1L;
				}
				else
				{
					this.mBitmap <<= (int)diff2;
					this.mBitmap |= 1L;
				}
				this.mLatestConfirmedSeq = seq;
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x000966A6 File Offset: 0x000948A6
		internal void Reset()
		{
			this.mLatestConfirmedSeq = -1L;
			this.mBitmap = 0L;
		}

		// Token: 0x04000D10 RID: 3344
		private const long VALID_SEQ_MASK = 281474976710655L;

		// Token: 0x04000D11 RID: 3345
		private const long WINDOW_SIZE = 64L;

		// Token: 0x04000D12 RID: 3346
		private long mLatestConfirmedSeq = -1L;

		// Token: 0x04000D13 RID: 3347
		private long mBitmap;
	}
}
