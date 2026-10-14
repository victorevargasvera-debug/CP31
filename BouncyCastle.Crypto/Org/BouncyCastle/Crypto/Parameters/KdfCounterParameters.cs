using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F3 RID: 1011
	public class KdfCounterParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x0600281B RID: 10267 RVA: 0x000AC32A File Offset: 0x000AA52A
		public KdfCounterParameters(byte[] ki, byte[] fixedInputDataCounterSuffix, int r) : this(ki, null, fixedInputDataCounterSuffix, r)
		{
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000AC338 File Offset: 0x000AA538
		public KdfCounterParameters(byte[] ki, byte[] fixedInputDataCounterPrefix, byte[] fixedInputDataCounterSuffix, int r)
		{
			if (ki == null)
			{
				throw new global::System.ArgumentException("A KDF requires Ki (a seed) as input");
			}
			this.ki = global::Org.BouncyCastle.Utilities.Arrays.Clone(ki);
			if (fixedInputDataCounterPrefix == null)
			{
				this.fixedInputDataCounterPrefix = new byte[0];
			}
			else
			{
				this.fixedInputDataCounterPrefix = global::Org.BouncyCastle.Utilities.Arrays.Clone(fixedInputDataCounterPrefix);
			}
			if (fixedInputDataCounterSuffix == null)
			{
				this.fixedInputDataCounterSuffix = new byte[0];
			}
			else
			{
				this.fixedInputDataCounterSuffix = global::Org.BouncyCastle.Utilities.Arrays.Clone(fixedInputDataCounterSuffix);
			}
			if (r != 8 && r != 16 && r != 24 && r != 32)
			{
				throw new global::System.ArgumentException("Length of counter should be 8, 16, 24 or 32");
			}
			this.r = r;
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000AC3C9 File Offset: 0x000AA5C9
		public byte[] Ki
		{
			get
			{
				return this.ki;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x000AC3D1 File Offset: 0x000AA5D1
		public byte[] FixedInputData
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.fixedInputDataCounterSuffix);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000AC3DE File Offset: 0x000AA5DE
		public byte[] FixedInputDataCounterPrefix
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.fixedInputDataCounterPrefix);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x000AC3EB File Offset: 0x000AA5EB
		public byte[] FixedInputDataCounterSuffix
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.fixedInputDataCounterSuffix);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000AC3F8 File Offset: 0x000AA5F8
		public int R
		{
			get
			{
				return this.r;
			}
		}

		// Token: 0x0400103D RID: 4157
		private byte[] ki;

		// Token: 0x0400103E RID: 4158
		private byte[] fixedInputDataCounterPrefix;

		// Token: 0x0400103F RID: 4159
		private byte[] fixedInputDataCounterSuffix;

		// Token: 0x04001040 RID: 4160
		private int r;
	}
}
