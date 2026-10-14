using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002EB RID: 747
	public class SimpleBlockResult : global::Org.BouncyCastle.Crypto.IBlockResult
	{
		// Token: 0x06001FFA RID: 8186 RVA: 0x00090287 File Offset: 0x0008E487
		public SimpleBlockResult(byte[] result)
		{
			this.result = result;
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00090296 File Offset: 0x0008E496
		public int Length
		{
			get
			{
				return this.result.Length;
			}
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x000902A0 File Offset: 0x0008E4A0
		public byte[] Collect()
		{
			return this.result;
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x000902A8 File Offset: 0x0008E4A8
		public int Collect(byte[] destination, int offset)
		{
			global::System.Array.Copy(this.result, 0, destination, offset, this.result.Length);
			return this.result.Length;
		}

		// Token: 0x04000B34 RID: 2868
		private readonly byte[] result;
	}
}
