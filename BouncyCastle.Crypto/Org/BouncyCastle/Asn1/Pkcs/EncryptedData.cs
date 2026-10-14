using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006AF RID: 1711
	public class EncryptedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EB1 RID: 16049 RVA: 0x0011DCAE File Offset: 0x0011BEAE
		public static global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.EncryptedData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x0011DCF0 File Offset: 0x0011BEF0
		private EncryptedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			if (!((global::Org.BouncyCastle.Asn1.DerInteger)seq[0]).HasValue(0))
			{
				throw new global::System.ArgumentException("sequence not version 0");
			}
			this.data = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[1];
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0011DD4D File Offset: 0x0011BF4D
		public EncryptedData(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Encodable content)
		{
			this.data = new global::Org.BouncyCastle.Asn1.BerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				contentType,
				encryptionAlgorithm.ToAsn1Object(),
				new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 0, content)
			});
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x0011DD7E File Offset: 0x0011BF7E
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.data[0];
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x0011DD91 File Offset: 0x0011BF91
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgorithm
		{
			get
			{
				return global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(this.data[1]);
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003EB6 RID: 16054 RVA: 0x0011DDA4 File Offset: 0x0011BFA4
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Content
		{
			get
			{
				if (this.data.Count == 3)
				{
					return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance((global::Org.BouncyCastle.Asn1.DerTaggedObject)this.data[2], false);
				}
				return null;
			}
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0011DDCD File Offset: 0x0011BFCD
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.BerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(0),
				this.data
			});
		}

		// Token: 0x04001C73 RID: 7283
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence data;
	}
}
