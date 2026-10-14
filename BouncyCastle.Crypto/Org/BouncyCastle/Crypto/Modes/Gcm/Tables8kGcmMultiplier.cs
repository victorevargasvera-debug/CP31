using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x0200044A RID: 1098
	public class Tables8kGcmMultiplier : global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier
	{
		// Token: 0x06002A8C RID: 10892 RVA: 0x000B61DC File Offset: 0x000B43DC
		public void Init(byte[] H)
		{
			if (this.T == null)
			{
				this.T = new ulong[32][];
			}
			else if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.H, H))
			{
				return;
			}
			this.H = global::Org.BouncyCastle.Utilities.Arrays.Clone(H);
			for (int i = 0; i < 32; i++)
			{
				ulong[] t = this.T[i] = new ulong[32];
				if (i == 0)
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(this.H, t, 2);
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP3(t, 2, t, 2);
				}
				else
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP4(this.T[i - 1], 2, t, 2);
				}
				for (int j = 2; j < 16; j += 2)
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.DivideP(t, j, t, j << 1);
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(t, j << 1, t, 2, t, j + 1 << 1);
				}
			}
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000B6294 File Offset: 0x000B4494
		public void MultiplyH(byte[] x)
		{
			ulong z0 = 0UL;
			ulong z = 0UL;
			for (int i = 15; i >= 0; i--)
			{
				ulong[] tu = this.T[i + i + 1];
				ulong[] tv = this.T[i + i];
				int uPos = (int)(x[i] & 15) << 1;
				int vPos = (x[i] & 240) >> 3;
				z0 ^= (tu[uPos] ^ tv[vPos]);
				z ^= (tu[uPos + 1] ^ tv[vPos + 1]);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(z0, x, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(z, x, 8);
		}

		// Token: 0x0400116F RID: 4463
		private byte[] H;

		// Token: 0x04001170 RID: 4464
		private ulong[][] T;
	}
}
