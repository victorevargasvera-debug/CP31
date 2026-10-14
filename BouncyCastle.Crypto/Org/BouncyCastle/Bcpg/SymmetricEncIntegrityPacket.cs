using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000596 RID: 1430
	public class SymmetricEncIntegrityPacket : global::Org.BouncyCastle.Bcpg.InputStreamPacket
	{
		// Token: 0x060035EC RID: 13804 RVA: 0x000FFFAA File Offset: 0x000FE1AA
		internal SymmetricEncIntegrityPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
			this.version = bcpgIn.ReadByte();
		}

		// Token: 0x04001880 RID: 6272
		internal readonly int version;
	}
}
