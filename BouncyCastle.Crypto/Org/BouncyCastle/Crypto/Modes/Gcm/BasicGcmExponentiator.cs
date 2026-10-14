using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000442 RID: 1090
	public class BasicGcmExponentiator : global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmExponentiator
	{
		// Token: 0x06002A46 RID: 10822 RVA: 0x000B521F File Offset: 0x000B341F
		public void Init(byte[] x)
		{
			this.x = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(x);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000B5230 File Offset: 0x000B3430
		public void ExponentiateX(long pow, byte[] output)
		{
			ulong[] y = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.OneAsUlongs();
			if (pow > 0L)
			{
				ulong[] powX = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.x);
				do
				{
					if ((pow & 1L) != 0L)
					{
						global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(y, powX);
					}
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Square(powX, powX);
					pow >>= 1;
				}
				while (pow > 0L);
			}
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsBytes(y, output);
		}

		// Token: 0x04001166 RID: 4454
		private ulong[] x;
	}
}
