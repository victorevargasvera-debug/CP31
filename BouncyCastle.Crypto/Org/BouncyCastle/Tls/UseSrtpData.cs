using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000133 RID: 307
	public sealed class UseSrtpData
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x00031BDC File Offset: 0x0002FDDC
		public UseSrtpData(int[] protectionProfiles, byte[] mki)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(protectionProfiles) || protectionProfiles.Length >= 32768)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^15 - 1)", "protectionProfiles");
			}
			if (mki == null)
			{
				mki = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			}
			else if (mki.Length > 255)
			{
				throw new global::System.ArgumentException("cannot be longer than 255 bytes", "mki");
			}
			this.m_protectionProfiles = protectionProfiles;
			this.m_mki = mki;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00031C45 File Offset: 0x0002FE45
		public int[] ProtectionProfiles
		{
			get
			{
				return this.m_protectionProfiles;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00031C4D File Offset: 0x0002FE4D
		public byte[] Mki
		{
			get
			{
				return this.m_mki;
			}
		}

		// Token: 0x04000764 RID: 1892
		private readonly int[] m_protectionProfiles;

		// Token: 0x04000765 RID: 1893
		private readonly byte[] m_mki;
	}
}
