using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200056C RID: 1388
	public class CompressedDataPacket : global::Org.BouncyCastle.Bcpg.InputStreamPacket
	{
		// Token: 0x0600351E RID: 13598 RVA: 0x000FD9F3 File Offset: 0x000FBBF3
		internal CompressedDataPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
			this.algorithm = (global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag)bcpgIn.ReadByte();
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600351F RID: 13599 RVA: 0x000FDA08 File Offset: 0x000FBC08
		public global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x040017C5 RID: 6085
		private readonly global::Org.BouncyCastle.Bcpg.CompressionAlgorithmTag algorithm;
	}
}
