using System;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004C0 RID: 1216
	public class VmpcKsa3Engine : global::Org.BouncyCastle.Crypto.Engines.VmpcEngine
	{
		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000DAE39 File Offset: 0x000D9039
		public override string AlgorithmName
		{
			get
			{
				return "VMPC-KSA3";
			}
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x000DAE40 File Offset: 0x000D9040
		protected override void InitKey(byte[] keyBytes, byte[] ivBytes)
		{
			this.s = 0;
			this.P = new byte[256];
			for (int i = 0; i < 256; i++)
			{
				this.P[i] = (byte)i;
			}
			for (int j = 0; j < 768; j++)
			{
				this.s = this.P[(int)(this.s + this.P[j & 255] + keyBytes[j % keyBytes.Length] & byte.MaxValue)];
				byte temp = this.P[j & 255];
				this.P[j & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp;
			}
			for (int k = 0; k < 768; k++)
			{
				this.s = this.P[(int)(this.s + this.P[k & 255] + ivBytes[k % ivBytes.Length] & byte.MaxValue)];
				byte temp2 = this.P[k & 255];
				this.P[k & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp2;
			}
			for (int l = 0; l < 768; l++)
			{
				this.s = this.P[(int)(this.s + this.P[l & 255] + keyBytes[l % keyBytes.Length] & byte.MaxValue)];
				byte temp3 = this.P[l & 255];
				this.P[l & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp3;
			}
			this.n = 0;
		}
	}
}
