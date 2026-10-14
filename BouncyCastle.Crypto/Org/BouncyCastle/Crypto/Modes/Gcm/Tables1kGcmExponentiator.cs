using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000447 RID: 1095
	public class Tables1kGcmExponentiator : global::Org.BouncyCastle.Crypto.Modes.Gcm.IGcmExponentiator
	{
		// Token: 0x06002A82 RID: 10882 RVA: 0x000B5E7C File Offset: 0x000B407C
		public void Init(byte[] x)
		{
			ulong[] y = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(x);
			if (this.lookupPowX2 != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(y, (ulong[])this.lookupPowX2[0]))
			{
				return;
			}
			this.lookupPowX2 = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(8);
			this.lookupPowX2.Add(y);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000B5ECC File Offset: 0x000B40CC
		public void ExponentiateX(long pow, byte[] output)
		{
			ulong[] y = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.OneAsUlongs();
			int bit = 0;
			while (pow > 0L)
			{
				if ((pow & 1L) != 0L)
				{
					this.EnsureAvailable(bit);
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(y, (ulong[])this.lookupPowX2[bit]);
				}
				bit++;
				pow >>= 1;
			}
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsBytes(y, output);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x000B5F1C File Offset: 0x000B411C
		private void EnsureAvailable(int bit)
		{
			int count = this.lookupPowX2.Count;
			if (count <= bit)
			{
				ulong[] tmp = (ulong[])this.lookupPowX2[count - 1];
				do
				{
					tmp = global::Org.BouncyCastle.Utilities.Arrays.Clone(tmp);
					global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Square(tmp, tmp);
					this.lookupPowX2.Add(tmp);
				}
				while (++count <= bit);
			}
		}

		// Token: 0x0400116A RID: 4458
		private global::System.Collections.IList lookupPowX2;
	}
}
