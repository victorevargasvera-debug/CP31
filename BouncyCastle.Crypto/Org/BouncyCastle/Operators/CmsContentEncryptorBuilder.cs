using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Operators
{
	// Token: 0x020002B2 RID: 690
	public class CmsContentEncryptorBuilder
	{
		// Token: 0x06001EDE RID: 7902 RVA: 0x0008EFFC File Offset: 0x0008D1FC
		static CmsContentEncryptorBuilder()
		{
			global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc] = 128;
			global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc] = 192;
			global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc] = 256;
			global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc] = 128;
			global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc] = 192;
			global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc] = 256;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0008F0A9 File Offset: 0x0008D2A9
		private static int GetKeySize(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			if (global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes.Contains(oid))
			{
				return (int)global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.KeySizes[oid];
			}
			return -1;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0008F0CA File Offset: 0x0008D2CA
		public CmsContentEncryptorBuilder(global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID) : this(encryptionOID, global::Org.BouncyCastle.Operators.CmsContentEncryptorBuilder.GetKeySize(encryptionOID))
		{
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0008F0D9 File Offset: 0x0008D2D9
		public CmsContentEncryptorBuilder(global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID, int keySize)
		{
			this.encryptionOID = encryptionOID;
			this.keySize = keySize;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0008F0FA File Offset: 0x0008D2FA
		public global::Org.BouncyCastle.Crypto.ICipherBuilderWithKey Build()
		{
			return new global::Org.BouncyCastle.Crypto.Operators.Asn1CipherBuilderWithKey(this.encryptionOID, this.keySize, null);
		}

		// Token: 0x04000B16 RID: 2838
		private static readonly global::System.Collections.IDictionary KeySizes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04000B17 RID: 2839
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID;

		// Token: 0x04000B18 RID: 2840
		private readonly int keySize;

		// Token: 0x04000B19 RID: 2841
		private readonly global::Org.BouncyCastle.Cms.EnvelopedDataHelper helper = new global::Org.BouncyCastle.Cms.EnvelopedDataHelper();
	}
}
