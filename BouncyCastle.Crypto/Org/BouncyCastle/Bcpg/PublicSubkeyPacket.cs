using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000587 RID: 1415
	public class PublicSubkeyPacket : global::Org.BouncyCastle.Bcpg.PublicKeyPacket
	{
		// Token: 0x06003591 RID: 13713 RVA: 0x000FE960 File Offset: 0x000FCB60
		internal PublicSubkeyPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x000FE969 File Offset: 0x000FCB69
		public PublicSubkeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::System.DateTime time, global::Org.BouncyCastle.Bcpg.IBcpgKey key) : base(algorithm, time, key)
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x000FE974 File Offset: 0x000FCB74
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.PublicSubkey, this.GetEncodedContents(), true);
		}
	}
}
