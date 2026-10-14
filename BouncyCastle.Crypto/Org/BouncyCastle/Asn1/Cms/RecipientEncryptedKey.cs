using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200075C RID: 1884
	public class RecipientEncryptedKey : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004353 RID: 17235 RVA: 0x0012DAD8 File Offset: 0x0012BCD8
		private RecipientEncryptedKey(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.identifier = global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier.GetInstance(seq[0]);
			this.encryptedKey = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[1];
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x0012DB04 File Offset: 0x0012BD04
		public static global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x0012DB14 File Offset: 0x0012BD14
		public static global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientEncryptedKey((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid RecipientEncryptedKey: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x0012DB61 File Offset: 0x0012BD61
		public RecipientEncryptedKey(global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier id, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey)
		{
			this.identifier = id;
			this.encryptedKey = encryptedKey;
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x0012DB77 File Offset: 0x0012BD77
		public global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier Identifier
		{
			get
			{
				return this.identifier;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x0012DB7F File Offset: 0x0012BD7F
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey
		{
			get
			{
				return this.encryptedKey;
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0012DB87 File Offset: 0x0012BD87
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.identifier,
				this.encryptedKey
			});
		}

		// Token: 0x04002065 RID: 8293
		private readonly global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier identifier;

		// Token: 0x04002066 RID: 8294
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey;
	}
}
