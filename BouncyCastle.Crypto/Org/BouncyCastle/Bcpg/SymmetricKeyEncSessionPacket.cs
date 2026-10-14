using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000598 RID: 1432
	public class SymmetricKeyEncSessionPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x060035ED RID: 13805 RVA: 0x000FFFBF File Offset: 0x000FE1BF
		public SymmetricKeyEncSessionPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.version = bcpgIn.ReadByte();
			this.encAlgorithm = (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)bcpgIn.ReadByte();
			this.s2k = new global::Org.BouncyCastle.Bcpg.S2k(bcpgIn);
			this.secKeyData = bcpgIn.ReadAll();
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x000FFFF7 File Offset: 0x000FE1F7
		public SymmetricKeyEncSessionPacket(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] secKeyData)
		{
			this.version = 4;
			this.encAlgorithm = encAlgorithm;
			this.s2k = s2k;
			this.secKeyData = secKeyData;
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x0010001B File Offset: 0x000FE21B
		public global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag EncAlgorithm
		{
			get
			{
				return this.encAlgorithm;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x00100023 File Offset: 0x000FE223
		public global::Org.BouncyCastle.Bcpg.S2k S2k
		{
			get
			{
				return this.s2k;
			}
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0010002B File Offset: 0x000FE22B
		public byte[] GetSecKeyData()
		{
			return this.secKeyData;
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x00100033 File Offset: 0x000FE233
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0010003C File Offset: 0x000FE23C
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(bOut);
			pOut.Write(new byte[]
			{
				(byte)this.version,
				(byte)this.encAlgorithm
			});
			pOut.WriteObject(this.s2k);
			if (this.secKeyData != null && this.secKeyData.Length != 0)
			{
				pOut.Write(this.secKeyData);
			}
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.SymmetricKeyEncryptedSessionKey, bOut.ToArray(), true);
		}

		// Token: 0x04001890 RID: 6288
		private int version;

		// Token: 0x04001891 RID: 6289
		private global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm;

		// Token: 0x04001892 RID: 6290
		private global::Org.BouncyCastle.Bcpg.S2k s2k;

		// Token: 0x04001893 RID: 6291
		private readonly byte[] secKeyData;
	}
}
