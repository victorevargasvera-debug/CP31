using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000449 RID: 1097
	public class Tables64kGcmMultiplier : global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier
	{
		// Token: 0x06002A89 RID: 10889 RVA: 0x000B60B0 File Offset: 0x000B42B0
		public void Init(byte[] H)
		{
			if (this.T == null)
			{
				this.T = new ulong[16][];
			}
			else if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.H, H))
			{
				return;
			}
			this.H = global::Org.BouncyCastle.Utilities.Arrays.Clone(H);
			for (int i = 0; i < 16; i++)
			{
				ulong[] t = this.T[i] = new ulong[512];
				if (i == 0)
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(this.H, t, 2);
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP7(t, 2, t, 2);
				}
				else
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP8(this.T[i - 1], 2, t, 2);
				}
				for (int j = 2; j < 256; j += 2)
				{
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.DivideP(t, j, t, j << 1);
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(t, j << 1, t, 2, t, j + 1 << 1);
				}
			}
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x000B616C File Offset: 0x000B436C
		public void MultiplyH(byte[] x)
		{
			ulong[] t = this.T[15];
			int tPos = (int)x[15] << 1;
			ulong z0 = t[tPos];
			ulong z = t[tPos + 1];
			for (int i = 14; i >= 0; i--)
			{
				t = this.T[i];
				tPos = (int)x[i] << 1;
				z0 ^= t[tPos];
				z ^= t[tPos + 1];
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(z0, x, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(z, x, 8);
		}

		// Token: 0x0400116D RID: 4461
		private byte[] H;

		// Token: 0x0400116E RID: 4462
		private ulong[][] T;
	}
}
