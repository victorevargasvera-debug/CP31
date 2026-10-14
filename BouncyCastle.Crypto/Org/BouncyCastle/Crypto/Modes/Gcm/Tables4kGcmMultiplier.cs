using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000448 RID: 1096
	public class Tables4kGcmMultiplier : global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier
	{
		// Token: 0x06002A86 RID: 10886 RVA: 0x000B5F78 File Offset: 0x000B4178
		public void Init(byte[] H)
		{
			if (this.T == null)
			{
				this.T = new ulong[512];
			}
			else if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.H, H))
			{
				return;
			}
			this.H = global::Org.BouncyCastle.Utilities.Arrays.Clone(H);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(this.H, this.T, 2);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.MultiplyP7(this.T, 2, this.T, 2);
			for (int i = 2; i < 256; i += 2)
			{
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.DivideP(this.T, i, this.T, i << 1);
				global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Xor(this.T, i << 1, this.T, 2, this.T, i + 1 << 1);
			}
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000B6024 File Offset: 0x000B4224
		public void MultiplyH(byte[] x)
		{
			int pos = (int)x[15] << 1;
			ulong z0 = this.T[pos];
			ulong z = this.T[pos + 1];
			for (int i = 14; i >= 0; i--)
			{
				pos = (int)x[i] << 1;
				ulong c = z << 56;
				z = (this.T[pos + 1] ^ (z >> 8 | z0 << 56));
				z0 = (this.T[pos] ^ z0 >> 8 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(z0, x, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(z, x, 8);
		}

		// Token: 0x0400116B RID: 4459
		private byte[] H;

		// Token: 0x0400116C RID: 4460
		private ulong[] T;
	}
}
