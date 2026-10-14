using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B1 RID: 1713
	public class EncryptionScheme : global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier
	{
		// Token: 0x06003EBE RID: 16062 RVA: 0x0011DECA File Offset: 0x0011C0CA
		public EncryptionScheme(global::Org.BouncyCastle.Asn1.DerObjectIdentifier objectID) : base(objectID)
		{
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x0011DED3 File Offset: 0x0011C0D3
		public EncryptionScheme(global::Org.BouncyCastle.Asn1.DerObjectIdentifier objectID, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters) : base(objectID, parameters)
		{
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x0011DEDD File Offset: 0x0011C0DD
		internal EncryptionScheme(global::Org.BouncyCastle.Asn1.Asn1Sequence seq) : this((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0], seq[1])
		{
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x0011DEF8 File Offset: 0x0011C0F8
		public new static global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x0011DF37 File Offset: 0x0011C137
		public global::Org.BouncyCastle.Asn1.Asn1Object Asn1Object
		{
			get
			{
				return this.Parameters.ToAsn1Object();
			}
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0011DF44 File Offset: 0x0011C144
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.Algorithm,
				this.Parameters
			});
		}
	}
}
