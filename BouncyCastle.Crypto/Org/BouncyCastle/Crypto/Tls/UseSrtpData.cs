using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000396 RID: 918
	public class UseSrtpData
	{
		// Token: 0x0600258F RID: 9615 RVA: 0x000A3274 File Offset: 0x000A1474
		public UseSrtpData(int[] protectionProfiles, byte[] mki)
		{
			if (protectionProfiles == null || protectionProfiles.Length < 1 || protectionProfiles.Length >= 32768)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^15 - 1)", "protectionProfiles");
			}
			if (mki == null)
			{
				mki = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			}
			else if (mki.Length > 255)
			{
				throw new global::System.ArgumentException("cannot be longer than 255 bytes", "mki");
			}
			this.mProtectionProfiles = protectionProfiles;
			this.mMki = mki;
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000A32DE File Offset: 0x000A14DE
		public virtual int[] ProtectionProfiles
		{
			get
			{
				return this.mProtectionProfiles;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000A32E6 File Offset: 0x000A14E6
		public virtual byte[] Mki
		{
			get
			{
				return this.mMki;
			}
		}

		// Token: 0x04000EE7 RID: 3815
		protected readonly int[] mProtectionProfiles;

		// Token: 0x04000EE8 RID: 3816
		protected readonly byte[] mMki;
	}
}
