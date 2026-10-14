using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B6 RID: 1718
	public class PbeS2Parameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EDA RID: 16090 RVA: 0x0011E2B8 File Offset: 0x0011C4B8
		public static global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters existing = obj as global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters;
			if (existing != null)
			{
				return existing;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0011E2E1 File Offset: 0x0011C4E1
		public PbeS2Parameters(global::Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc keyDevFunc, global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme encScheme)
		{
			this.func = keyDevFunc;
			this.scheme = encScheme;
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0011E2F8 File Offset: 0x0011C4F8
		[global::System.Obsolete("Use GetInstance() instead")]
		public PbeS2Parameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			global::Org.BouncyCastle.Asn1.Asn1Sequence funcSeq = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[0].ToAsn1Object();
			if (funcSeq[0].Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbkdf2))
			{
				this.func = new global::Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbkdf2, global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params.GetInstance(funcSeq[1]));
			}
			else
			{
				this.func = new global::Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc(funcSeq);
			}
			this.scheme = global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme.GetInstance(seq[1].ToAsn1Object());
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x0011E38A File Offset: 0x0011C58A
		public global::Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc KeyDerivationFunc
		{
			get
			{
				return this.func;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x0011E392 File Offset: 0x0011C592
		public global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme EncryptionScheme
		{
			get
			{
				return this.scheme;
			}
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0011E39A File Offset: 0x0011C59A
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.func,
				this.scheme
			});
		}

		// Token: 0x04001C7D RID: 7293
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc func;

		// Token: 0x04001C7E RID: 7294
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme scheme;
	}
}
