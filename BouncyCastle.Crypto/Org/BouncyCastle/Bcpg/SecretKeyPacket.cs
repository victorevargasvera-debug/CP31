using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200058B RID: 1419
	public class SecretKeyPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x060035B2 RID: 13746 RVA: 0x000FEE5C File Offset: 0x000FD05C
		internal SecretKeyPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			if (this is global::Org.BouncyCastle.Bcpg.SecretSubkeyPacket)
			{
				this.pubKeyPacket = new global::Org.BouncyCastle.Bcpg.PublicSubkeyPacket(bcpgIn);
			}
			else
			{
				this.pubKeyPacket = new global::Org.BouncyCastle.Bcpg.PublicKeyPacket(bcpgIn);
			}
			this.s2kUsage = bcpgIn.ReadByte();
			if (this.s2kUsage == 255 || this.s2kUsage == 254)
			{
				this.encAlgorithm = (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)bcpgIn.ReadByte();
				this.s2k = new global::Org.BouncyCastle.Bcpg.S2k(bcpgIn);
			}
			else
			{
				this.encAlgorithm = (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)this.s2kUsage;
			}
			if ((this.s2k == null || this.s2k.Type != 101 || this.s2k.ProtectionMode != 1) && this.s2kUsage != 0)
			{
				if (this.encAlgorithm < global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128)
				{
					this.iv = new byte[8];
				}
				else
				{
					this.iv = new byte[16];
				}
				bcpgIn.ReadFully(this.iv);
			}
			this.secKeyData = bcpgIn.ReadAll();
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x000FEF48 File Offset: 0x000FD148
		public SecretKeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyPacket, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] iv, byte[] secKeyData)
		{
			this.pubKeyPacket = pubKeyPacket;
			this.encAlgorithm = encAlgorithm;
			if (encAlgorithm != global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null)
			{
				this.s2kUsage = 255;
			}
			else
			{
				this.s2kUsage = 0;
			}
			this.s2k = s2k;
			this.iv = global::Org.BouncyCastle.Utilities.Arrays.Clone(iv);
			this.secKeyData = secKeyData;
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x000FEF9C File Offset: 0x000FD19C
		public SecretKeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyPacket, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm, int s2kUsage, global::Org.BouncyCastle.Bcpg.S2k s2k, byte[] iv, byte[] secKeyData)
		{
			this.pubKeyPacket = pubKeyPacket;
			this.encAlgorithm = encAlgorithm;
			this.s2kUsage = s2kUsage;
			this.s2k = s2k;
			this.iv = global::Org.BouncyCastle.Utilities.Arrays.Clone(iv);
			this.secKeyData = secKeyData;
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x000FEFD6 File Offset: 0x000FD1D6
		public global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag EncAlgorithm
		{
			get
			{
				return this.encAlgorithm;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000FEFDE File Offset: 0x000FD1DE
		public int S2kUsage
		{
			get
			{
				return this.s2kUsage;
			}
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x000FEFE6 File Offset: 0x000FD1E6
		public byte[] GetIV()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.iv);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000FEFF3 File Offset: 0x000FD1F3
		public global::Org.BouncyCastle.Bcpg.S2k S2k
		{
			get
			{
				return this.s2k;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x000FEFFB File Offset: 0x000FD1FB
		public global::Org.BouncyCastle.Bcpg.PublicKeyPacket PublicKeyPacket
		{
			get
			{
				return this.pubKeyPacket;
			}
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x000FF003 File Offset: 0x000FD203
		public byte[] GetSecretKeyData()
		{
			return this.secKeyData;
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x000FF00C File Offset: 0x000FD20C
		public byte[] GetEncodedContents()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(memoryStream);
			pOut.Write(this.pubKeyPacket.GetEncodedContents());
			pOut.WriteByte((byte)this.s2kUsage);
			if (this.s2kUsage == 255 || this.s2kUsage == 254)
			{
				pOut.WriteByte((byte)this.encAlgorithm);
				pOut.WriteObject(this.s2k);
			}
			if (this.iv != null)
			{
				pOut.Write(this.iv);
			}
			if (this.secKeyData != null && this.secKeyData.Length != 0)
			{
				pOut.Write(this.secKeyData);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x000FF0AC File Offset: 0x000FD2AC
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.SecretKey, this.GetEncodedContents(), true);
		}

		// Token: 0x04001845 RID: 6213
		public const int UsageNone = 0;

		// Token: 0x04001846 RID: 6214
		public const int UsageChecksum = 255;

		// Token: 0x04001847 RID: 6215
		public const int UsageSha1 = 254;

		// Token: 0x04001848 RID: 6216
		private global::Org.BouncyCastle.Bcpg.PublicKeyPacket pubKeyPacket;

		// Token: 0x04001849 RID: 6217
		private readonly byte[] secKeyData;

		// Token: 0x0400184A RID: 6218
		private int s2kUsage;

		// Token: 0x0400184B RID: 6219
		private global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag encAlgorithm;

		// Token: 0x0400184C RID: 6220
		private global::Org.BouncyCastle.Bcpg.S2k s2k;

		// Token: 0x0400184D RID: 6221
		private byte[] iv;
	}
}
