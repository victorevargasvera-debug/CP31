using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x02000514 RID: 1300
	internal class DefaultPKMacResult : global::Org.BouncyCastle.Crypto.IBlockResult
	{
		// Token: 0x060032A9 RID: 12969 RVA: 0x000F2705 File Offset: 0x000F0905
		public DefaultPKMacResult(global::Org.BouncyCastle.Crypto.IMac mac)
		{
			this.mac = mac;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000F2714 File Offset: 0x000F0914
		public byte[] Collect()
		{
			byte[] res = new byte[this.mac.GetMacSize()];
			this.mac.DoFinal(res, 0);
			return res;
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000F2741 File Offset: 0x000F0941
		public int Collect(byte[] sig, int sigOff)
		{
			byte[] array = this.Collect();
			array.CopyTo(sig, sigOff);
			return array.Length;
		}

		// Token: 0x04001682 RID: 5762
		private readonly global::Org.BouncyCastle.Crypto.IMac mac;
	}
}
