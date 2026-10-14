using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000578 RID: 1400
	public class ExperimentalPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x0600355F RID: 13663 RVA: 0x000FE09A File Offset: 0x000FC29A
		internal ExperimentalPacket(global::Org.BouncyCastle.Bcpg.PacketTag tag, global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.tag = tag;
			this.contents = bcpgIn.ReadAll();
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x000FE0B5 File Offset: 0x000FC2B5
		public global::Org.BouncyCastle.Bcpg.PacketTag Tag
		{
			get
			{
				return this.tag;
			}
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x000FE0BD File Offset: 0x000FC2BD
		public byte[] GetContents()
		{
			return (byte[])this.contents.Clone();
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000FE0CF File Offset: 0x000FC2CF
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(this.tag, this.contents, true);
		}

		// Token: 0x040017DD RID: 6109
		private readonly global::Org.BouncyCastle.Bcpg.PacketTag tag;

		// Token: 0x040017DE RID: 6110
		private readonly byte[] contents;
	}
}
