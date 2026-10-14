using System;
using System.IO;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000586 RID: 1414
	public class PublicKeyPacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x06003588 RID: 13704 RVA: 0x000FE794 File Offset: 0x000FC994
		internal PublicKeyPacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.version = bcpgIn.ReadByte();
			this.time = (long)((ulong)(bcpgIn.ReadByte() << 24 | bcpgIn.ReadByte() << 16 | bcpgIn.ReadByte() << 8 | bcpgIn.ReadByte()));
			if (this.version <= 3)
			{
				this.validDays = (bcpgIn.ReadByte() << 8 | bcpgIn.ReadByte());
			}
			this.algorithm = (global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag)bcpgIn.ReadByte();
			global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag publicKeyAlgorithmTag = this.algorithm;
			if (publicKeyAlgorithmTag - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral <= 2)
			{
				this.key = new global::Org.BouncyCastle.Bcpg.RsaPublicBcpgKey(bcpgIn);
				return;
			}
			switch (publicKeyAlgorithmTag)
			{
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt:
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral:
				this.key = new global::Org.BouncyCastle.Bcpg.ElGamalPublicBcpgKey(bcpgIn);
				return;
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.Dsa:
				this.key = new global::Org.BouncyCastle.Bcpg.DsaPublicBcpgKey(bcpgIn);
				return;
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC:
				this.key = new global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey(bcpgIn);
				return;
			case global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ECDsa:
				this.key = new global::Org.BouncyCastle.Bcpg.ECDsaPublicBcpgKey(bcpgIn);
				return;
			default:
				throw new global::System.IO.IOException("unknown PGP public key algorithm encountered");
			}
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x000FE87E File Offset: 0x000FCA7E
		public PublicKeyPacket(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::System.DateTime time, global::Org.BouncyCastle.Bcpg.IBcpgKey key)
		{
			this.version = 4;
			this.time = global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(time) / 1000L;
			this.algorithm = algorithm;
			this.key = key;
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600358A RID: 13706 RVA: 0x000FE8AE File Offset: 0x000FCAAE
		public virtual int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x000FE8B6 File Offset: 0x000FCAB6
		public virtual global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600358C RID: 13708 RVA: 0x000FE8BE File Offset: 0x000FCABE
		public virtual int ValidDays
		{
			get
			{
				return this.validDays;
			}
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x000FE8C6 File Offset: 0x000FCAC6
		public virtual global::System.DateTime GetTime()
		{
			return global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixMsToDateTime(this.time * 1000L);
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600358E RID: 13710 RVA: 0x000FE8DA File Offset: 0x000FCADA
		public virtual global::Org.BouncyCastle.Bcpg.IBcpgKey Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x000FE8E4 File Offset: 0x000FCAE4
		public virtual byte[] GetEncodedContents()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(memoryStream);
			pOut.WriteByte((byte)this.version);
			pOut.WriteInt((int)this.time);
			if (this.version <= 3)
			{
				pOut.WriteShort((short)this.validDays);
			}
			pOut.WriteByte((byte)this.algorithm);
			pOut.WriteObject((global::Org.BouncyCastle.Bcpg.BcpgObject)this.key);
			return memoryStream.ToArray();
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x000FE950 File Offset: 0x000FCB50
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.PublicKey, this.GetEncodedContents(), true);
		}

		// Token: 0x0400182B RID: 6187
		private int version;

		// Token: 0x0400182C RID: 6188
		private long time;

		// Token: 0x0400182D RID: 6189
		private int validDays;

		// Token: 0x0400182E RID: 6190
		private global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm;

		// Token: 0x0400182F RID: 6191
		private global::Org.BouncyCastle.Bcpg.IBcpgKey key;
	}
}
