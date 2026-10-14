using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000580 RID: 1408
	public class OnePassSignaturePacket : global::Org.BouncyCastle.Bcpg.ContainedPacket
	{
		// Token: 0x06003576 RID: 13686 RVA: 0x000FE338 File Offset: 0x000FC538
		internal OnePassSignaturePacket(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.version = bcpgIn.ReadByte();
			this.sigType = bcpgIn.ReadByte();
			this.hashAlgorithm = (global::Org.BouncyCastle.Bcpg.HashAlgorithmTag)bcpgIn.ReadByte();
			this.keyAlgorithm = (global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag)bcpgIn.ReadByte();
			this.keyId |= (long)bcpgIn.ReadByte() << 56;
			this.keyId |= (long)bcpgIn.ReadByte() << 48;
			this.keyId |= (long)bcpgIn.ReadByte() << 40;
			this.keyId |= (long)bcpgIn.ReadByte() << 32;
			this.keyId |= (long)bcpgIn.ReadByte() << 24;
			this.keyId |= (long)bcpgIn.ReadByte() << 16;
			this.keyId |= (long)bcpgIn.ReadByte() << 8;
			this.keyId |= (long)((ulong)bcpgIn.ReadByte());
			this.nested = bcpgIn.ReadByte();
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x000FE43B File Offset: 0x000FC63B
		public OnePassSignaturePacket(int sigType, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm, long keyId, bool isNested)
		{
			this.version = 3;
			this.sigType = sigType;
			this.hashAlgorithm = hashAlgorithm;
			this.keyAlgorithm = keyAlgorithm;
			this.keyId = keyId;
			this.nested = (isNested ? 0 : 1);
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06003578 RID: 13688 RVA: 0x000FE475 File Offset: 0x000FC675
		public int SignatureType
		{
			get
			{
				return this.sigType;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06003579 RID: 13689 RVA: 0x000FE47D File Offset: 0x000FC67D
		public global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag KeyAlgorithm
		{
			get
			{
				return this.keyAlgorithm;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x000FE485 File Offset: 0x000FC685
		public global::Org.BouncyCastle.Bcpg.HashAlgorithmTag HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x000FE48D File Offset: 0x000FC68D
		public long KeyId
		{
			get
			{
				return this.keyId;
			}
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x000FE498 File Offset: 0x000FC698
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Bcpg.BcpgOutputStream pOut = new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(bOut);
			pOut.Write(new byte[]
			{
				(byte)this.version,
				(byte)this.sigType,
				(byte)this.hashAlgorithm,
				(byte)this.keyAlgorithm
			});
			pOut.WriteLong(this.keyId);
			pOut.WriteByte((byte)this.nested);
			bcpgOut.WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag.OnePassSignature, bOut.ToArray(), true);
		}

		// Token: 0x040017F2 RID: 6130
		private int version;

		// Token: 0x040017F3 RID: 6131
		private int sigType;

		// Token: 0x040017F4 RID: 6132
		private global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm;

		// Token: 0x040017F5 RID: 6133
		private global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag keyAlgorithm;

		// Token: 0x040017F6 RID: 6134
		private long keyId;

		// Token: 0x040017F7 RID: 6135
		private int nested;
	}
}
