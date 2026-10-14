using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000402 RID: 1026
	public class ParametersWithSBox : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002863 RID: 10339 RVA: 0x000ACA0D File Offset: 0x000AAC0D
		public ParametersWithSBox(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] sBox)
		{
			this.parameters = parameters;
			this.sBox = sBox;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000ACA23 File Offset: 0x000AAC23
		public byte[] GetSBox()
		{
			return this.sBox;
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x000ACA2B File Offset: 0x000AAC2B
		public global::Org.BouncyCastle.Crypto.ICipherParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x04001064 RID: 4196
		private global::Org.BouncyCastle.Crypto.ICipherParameters parameters;

		// Token: 0x04001065 RID: 4197
		private byte[] sBox;
	}
}
