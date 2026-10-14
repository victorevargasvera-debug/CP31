using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000322 RID: 802
	internal class DtlsEpoch
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x00095278 File Offset: 0x00093478
		internal DtlsEpoch(int epoch, global::Org.BouncyCastle.Crypto.Tls.TlsCipher cipher)
		{
			if (epoch < 0)
			{
				throw new global::System.ArgumentException("must be >= 0", "epoch");
			}
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			this.mEpoch = epoch;
			this.mCipher = cipher;
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x000952C8 File Offset: 0x000934C8
		internal long AllocateSequenceNumber()
		{
			long num;
			lock (this)
			{
				if (this.mSequenceNumber >= 281474976710656L)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				num = this.mSequenceNumber;
				this.mSequenceNumber = num + 1L;
				num = num;
			}
			return num;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x0009532C File Offset: 0x0009352C
		internal global::Org.BouncyCastle.Crypto.Tls.TlsCipher Cipher
		{
			get
			{
				return this.mCipher;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x00095334 File Offset: 0x00093534
		internal int Epoch
		{
			get
			{
				return this.mEpoch;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x0009533C File Offset: 0x0009353C
		internal global::Org.BouncyCastle.Crypto.Tls.DtlsReplayWindow ReplayWindow
		{
			get
			{
				return this.mReplayWindow;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00095344 File Offset: 0x00093544
		internal long SequenceNumber
		{
			get
			{
				long result;
				lock (this)
				{
					result = this.mSequenceNumber;
				}
				return result;
			}
		}

		// Token: 0x04000CE5 RID: 3301
		private readonly global::Org.BouncyCastle.Crypto.Tls.DtlsReplayWindow mReplayWindow = new global::Org.BouncyCastle.Crypto.Tls.DtlsReplayWindow();

		// Token: 0x04000CE6 RID: 3302
		private readonly int mEpoch;

		// Token: 0x04000CE7 RID: 3303
		private readonly global::Org.BouncyCastle.Crypto.Tls.TlsCipher mCipher;

		// Token: 0x04000CE8 RID: 3304
		private long mSequenceNumber;
	}
}
