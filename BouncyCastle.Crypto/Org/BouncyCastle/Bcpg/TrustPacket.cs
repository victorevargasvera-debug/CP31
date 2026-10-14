using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000599 RID: 1433
	public class TrustPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x060035F4 RID: 13812 RVA: 0x001000B0 File Offset: 0x000FE2B0
		public TrustPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			int ch;
			while ((ch = bcpgIn.ReadByte()) >= 0)
			{
				bOut.WriteByte((byte)ch);
			}
			this.levelAndTrustAmount = bOut.ToArray();
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x001000EA File Offset: 0x000FE2EA
		public TrustPacket(int trustCode)
		{
			this.levelAndTrustAmount = new byte[]
			{
				(byte)trustCode
			};
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00100103 File Offset: 0x000FE303
		public byte[] GetLevelAndTrustAmount()
		{
			return (byte[])this.levelAndTrustAmount.Clone();
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00100115 File Offset: 0x000FE315
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.Trust, this.levelAndTrustAmount, true);
		}

		// Token: 0x04001894 RID: 6292
		private readonly byte[] levelAndTrustAmount;
	}
}
