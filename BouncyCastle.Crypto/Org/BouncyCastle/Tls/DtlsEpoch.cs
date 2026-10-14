using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B8 RID: 184
	internal sealed class DtlsEpoch
	{
		// Token: 0x060006F4 RID: 1780 RVA: 0x0001CEEC File Offset: 0x0001B0EC
		internal DtlsEpoch(int epoch, global::Org.BouncyCastle.Tls.Crypto.TlsCipher cipher)
		{
			if (epoch < 0)
			{
				throw new global::System.ArgumentException("must be >= 0", "epoch");
			}
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			this.m_epoch = epoch;
			this.m_cipher = cipher;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001CF3C File Offset: 0x0001B13C
		internal long AllocateSequenceNumber()
		{
			long num;
			lock (this)
			{
				if (this.m_sequenceNumber >= 281474976710656L)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				num = this.m_sequenceNumber;
				this.m_sequenceNumber = num + 1L;
				num = num;
			}
			return num;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
		internal global::Org.BouncyCastle.Tls.Crypto.TlsCipher Cipher
		{
			get
			{
				return this.m_cipher;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0001CFA8 File Offset: 0x0001B1A8
		internal int Epoch
		{
			get
			{
				return this.m_epoch;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		internal global::Org.BouncyCastle.Tls.DtlsReplayWindow ReplayWindow
		{
			get
			{
				return this.m_replayWindow;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		internal long SequenceNumber
		{
			get
			{
				long sequenceNumber;
				lock (this)
				{
					sequenceNumber = this.m_sequenceNumber;
				}
				return sequenceNumber;
			}
			set
			{
				lock (this)
				{
					this.m_sequenceNumber = value;
				}
			}
		}

		// Token: 0x040004DC RID: 1244
		private readonly global::Org.BouncyCastle.Tls.DtlsReplayWindow m_replayWindow = new global::Org.BouncyCastle.Tls.DtlsReplayWindow();

		// Token: 0x040004DD RID: 1245
		private readonly int m_epoch;

		// Token: 0x040004DE RID: 1246
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsCipher m_cipher;

		// Token: 0x040004DF RID: 1247
		private long m_sequenceNumber;
	}
}
