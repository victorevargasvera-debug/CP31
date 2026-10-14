using System;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000443 RID: 1091
	public class BasicGcmMultiplier : global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier
	{
		// Token: 0x06002A49 RID: 10825 RVA: 0x000B5281 File Offset: 0x000B3481
		public void Init(byte[] H)
		{
			this.H = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(H);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000B528F File Offset: 0x000B348F
		public void MultiplyH(byte[] x)
		{
			ulong[] x2 = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(x);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(x2, this.H);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsBytes(x2, x);
		}

		// Token: 0x04001167 RID: 4455
		private ulong[] H;
	}
}
