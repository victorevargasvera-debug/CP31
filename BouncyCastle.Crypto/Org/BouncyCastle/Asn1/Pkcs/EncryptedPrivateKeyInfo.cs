using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B0 RID: 1712
	public class EncryptedPrivateKeyInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EB8 RID: 16056 RVA: 0x0011DDEC File Offset: 0x0011BFEC
		private EncryptedPrivateKeyInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.algId = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.data = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]);
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0011DE3C File Offset: 0x0011C03C
		public EncryptedPrivateKeyInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, byte[] encoding)
		{
			this.algId = algId;
			this.data = new global::Org.BouncyCastle.Asn1.DerOctetString(encoding);
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x0011DE57 File Offset: 0x0011C057
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.EncryptedPrivateKeyInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003EBB RID: 16059 RVA: 0x0011DE96 File Offset: 0x0011C096
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgorithm
		{
			get
			{
				return this.algId;
			}
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0011DE9E File Offset: 0x0011C09E
		public byte[] GetEncryptedData()
		{
			return this.data.GetOctets();
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0011DEAB File Offset: 0x0011C0AB
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.algId,
				this.data
			});
		}

		// Token: 0x04001C74 RID: 7284
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId;

		// Token: 0x04001C75 RID: 7285
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString data;
	}
}
