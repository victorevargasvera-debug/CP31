using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200057E RID: 1406
	public class ModDetectionCodePacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x0600356D RID: 13677 RVA: 0x000FE1F2 File Offset: 0x000FC3F2
		internal ModDetectionCodePacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			if (bcpgIn == null)
			{
				throw new global::System.ArgumentNullException("bcpgIn");
			}
			this.digest = new byte[20];
			bcpgIn.ReadFully(this.digest);
		}

		// Token: 0x0600356E RID: 13678 RVA: 0x000FE221 File Offset: 0x000FC421
		public ModDetectionCodePacket(byte[] digest)
		{
			if (digest == null)
			{
				throw new global::System.ArgumentNullException("digest");
			}
			this.digest = (byte[])digest.Clone();
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x000FE248 File Offset: 0x000FC448
		public byte[] GetDigest()
		{
			return (byte[])this.digest.Clone();
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x000FE25A File Offset: 0x000FC45A
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.ModificationDetectionCode, this.digest, false);
		}

		// Token: 0x040017F0 RID: 6128
		private readonly byte[] digest;
	}
}
