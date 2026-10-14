using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000572 RID: 1394
	public class ECDHPublicBcpgKey : global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey
	{
		// Token: 0x06003537 RID: 13623 RVA: 0x000FDC40 File Offset: 0x000FBE40
		public ECDHPublicBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
			byte[] kdfParameters = new byte[bcpgIn.ReadByte()];
			if (kdfParameters.Length != 3)
			{
				throw new global::System.InvalidOperationException("kdf parameters size of 3 expected.");
			}
			bcpgIn.ReadFully(kdfParameters);
			this.reserved = kdfParameters[0];
			this.hashFunctionId = (global::Org.BouncyCastle.Bcpg.HashAlgorithmTag)kdfParameters[1];
			this.symAlgorithmId = (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)kdfParameters[2];
			this.VerifyHashAlgorithm();
			this.VerifySymmetricKeyAlgorithm();
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x000FDC9F File Offset: 0x000FBE9F
		public ECDHPublicBcpgKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Math.EC.ECPoint point, global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithm, global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag symmetricKeyAlgorithm) : base(oid, point)
		{
			this.reserved = 1;
			this.hashFunctionId = hashAlgorithm;
			this.symAlgorithmId = symmetricKeyAlgorithm;
			this.VerifyHashAlgorithm();
			this.VerifySymmetricKeyAlgorithm();
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x000FDCCB File Offset: 0x000FBECB
		public virtual byte Reserved
		{
			get
			{
				return this.reserved;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x000FDCD3 File Offset: 0x000FBED3
		public virtual global::Org.BouncyCastle.Bcpg.HashAlgorithmTag HashAlgorithm
		{
			get
			{
				return this.hashFunctionId;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x000FDCDB File Offset: 0x000FBEDB
		public virtual global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag SymmetricKeyAlgorithm
		{
			get
			{
				return this.symAlgorithmId;
			}
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x000FDCE3 File Offset: 0x000FBEE3
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			base.Encode(bcpgOut);
			bcpgOut.WriteByte(3);
			bcpgOut.WriteByte(this.reserved);
			bcpgOut.WriteByte((byte)this.hashFunctionId);
			bcpgOut.WriteByte((byte)this.symAlgorithmId);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x000FDD1C File Offset: 0x000FBF1C
		private void VerifyHashAlgorithm()
		{
			global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashAlgorithmTag = this.hashFunctionId;
			if (hashAlgorithmTag - global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha256 > 2)
			{
				throw new global::System.InvalidOperationException("Hash algorithm must be SHA-256 or stronger.");
			}
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000FDD44 File Offset: 0x000FBF44
		private void VerifySymmetricKeyAlgorithm()
		{
			global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag symmetricKeyAlgorithmTag = this.symAlgorithmId;
			if (symmetricKeyAlgorithmTag - global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Aes128 > 2)
			{
				throw new global::System.InvalidOperationException("Symmetric key algorithm must be AES-128 or stronger.");
			}
		}

		// Token: 0x040017D3 RID: 6099
		private byte reserved;

		// Token: 0x040017D4 RID: 6100
		private global::Org.BouncyCastle.Bcpg.HashAlgorithmTag hashFunctionId;

		// Token: 0x040017D5 RID: 6101
		private global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag symAlgorithmId;
	}
}
