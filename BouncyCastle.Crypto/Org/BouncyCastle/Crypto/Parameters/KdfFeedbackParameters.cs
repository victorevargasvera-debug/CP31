using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F5 RID: 1013
	public class KdfFeedbackParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x0600282A RID: 10282 RVA: 0x000AC4C4 File Offset: 0x000AA6C4
		private KdfFeedbackParameters(byte[] ki, byte[] iv, byte[] fixedInputData, int r, bool useCounter)
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
			this.r = r;
			if (iv == null)
			{
				this.iv = new byte[0];
			}
			else
			{
				this.iv = global::Org.BouncyCastle.Utilities.Arrays.Clone(iv);
			}
			this.useCounter = useCounter;
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000AC53B File Offset: 0x000AA73B
		public static global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters CreateWithCounter(byte[] ki, byte[] iv, byte[] fixedInputData, int r)
		{
			if (r != 8 && r != 16 && r != 24 && r != 32)
			{
				throw new global::System.ArgumentException("Length of counter should be 8, 16, 24 or 32");
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters(ki, iv, fixedInputData, r, true);
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x000AC565 File Offset: 0x000AA765
		public static global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters CreateWithoutCounter(byte[] ki, byte[] iv, byte[] fixedInputData)
		{
			return new global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters(ki, iv, fixedInputData, global::Org.BouncyCastle.Crypto.Parameters.KdfFeedbackParameters.UNUSED_R, false);
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000AC575 File Offset: 0x000AA775
		public byte[] Ki
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.ki);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x000AC582 File Offset: 0x000AA782
		public byte[] Iv
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.iv);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x000AC58F File Offset: 0x000AA78F
		public bool UseCounter
		{
			get
			{
				return this.useCounter;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x000AC597 File Offset: 0x000AA797
		public int R
		{
			get
			{
				return this.r;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x000AC59F File Offset: 0x000AA79F
		public byte[] FixedInputData
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.fixedInputData);
			}
		}

		// Token: 0x04001046 RID: 4166
		private static readonly int UNUSED_R = -1;

		// Token: 0x04001047 RID: 4167
		private readonly byte[] ki;

		// Token: 0x04001048 RID: 4168
		private readonly byte[] iv;

		// Token: 0x04001049 RID: 4169
		private readonly bool useCounter;

		// Token: 0x0400104A RID: 4170
		private readonly int r;

		// Token: 0x0400104B RID: 4171
		private readonly byte[] fixedInputData;
	}
}
