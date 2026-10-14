using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F4 RID: 1012
	public class KdfDoublePipelineIterationParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x06002822 RID: 10274 RVA: 0x000AC400 File Offset: 0x000AA600
		private KdfDoublePipelineIterationParameters(byte[] ki, byte[] fixedInputData, int r, bool useCounter)
		{
			if (ki == null)
			{
				throw new global::System.ArgumentException("A KDF requires Ki (a seed) as input");
			}
			this.ki = global::Org.BouncyCastle.Utilities.Arrays.Clone(ki);
			if (fixedInputData == null)
			{
				this.fixedInputData = new byte[0];
			}
			else
			{
				this.fixedInputData = global::Org.BouncyCastle.Utilities.Arrays.Clone(fixedInputData);
			}
			if (r != 8 && r != 16 && r != 24 && r != 32)
			{
				throw new global::System.ArgumentException("Length of counter should be 8, 16, 24 or 32");
			}
			this.r = r;
			this.useCounter = useCounter;
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000AC477 File Offset: 0x000AA677
		public static global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters CreateWithCounter(byte[] ki, byte[] fixedInputData, int r)
		{
			return new global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters(ki, fixedInputData, r, true);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000AC482 File Offset: 0x000AA682
		public static global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters CreateWithoutCounter(byte[] ki, byte[] fixedInputData)
		{
			return new global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters(ki, fixedInputData, global::Org.BouncyCastle.Crypto.Parameters.KdfDoublePipelineIterationParameters.UNUSED_R, false);
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000AC491 File Offset: 0x000AA691
		public byte[] Ki
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.ki);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x000AC49E File Offset: 0x000AA69E
		public bool UseCounter
		{
			get
			{
				return this.useCounter;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x000AC4A6 File Offset: 0x000AA6A6
		public int R
		{
			get
			{
				return this.r;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x000AC4AE File Offset: 0x000AA6AE
		public byte[] FixedInputData
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.fixedInputData);
			}
		}

		// Token: 0x04001041 RID: 4161
		private static readonly int UNUSED_R = 32;

		// Token: 0x04001042 RID: 4162
		private readonly byte[] ki;

		// Token: 0x04001043 RID: 4163
		private readonly bool useCounter;

		// Token: 0x04001044 RID: 4164
		private readonly int r;

		// Token: 0x04001045 RID: 4165
		private readonly byte[] fixedInputData;
	}
}
