using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200075B RID: 1883
	public class PasswordRecipientInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004349 RID: 17225 RVA: 0x0012D937 File Offset: 0x0012BB37
		public PasswordRecipientInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			this.keyEncryptionAlgorithm = keyEncryptionAlgorithm;
			this.encryptedKey = encryptedKey;
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0012D959 File Offset: 0x0012BB59
		public PasswordRecipientInfo(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			this.keyDerivationAlgorithm = keyDerivationAlgorithm;
			this.keyEncryptionAlgorithm = keyEncryptionAlgorithm;
			this.encryptedKey = encryptedKey;
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0012D984 File Offset: 0x0012BB84
		public PasswordRecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[0];
			if (seq[1] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.keyDerivationAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], false);
				this.keyEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[2]);
				this.encryptedKey = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[3];
				return;
			}
			this.keyEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.encryptedKey = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[2];
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x0012DA18 File Offset: 0x0012BC18
		public static global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x0012DA26 File Offset: 0x0012BC26
		public static global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid PasswordRecipientInfo: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x0012DA63 File Offset: 0x0012BC63
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x0012DA6B File Offset: 0x0012BC6B
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyDerivationAlgorithm
		{
			get
			{
				return this.keyDerivationAlgorithm;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x0012DA73 File Offset: 0x0012BC73
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return this.keyEncryptionAlgorithm;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x0012DA7B File Offset: 0x0012BC7B
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey
		{
			get
			{
				return this.encryptedKey;
			}
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x0012DA84 File Offset: 0x0012BC84
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version
			});
			v.AddOptionalTagged(false, 0, this.keyDerivationAlgorithm);
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyEncryptionAlgorithm,
				this.encryptedKey
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002061 RID: 8289
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002062 RID: 8290
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm;

		// Token: 0x04002063 RID: 8291
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm;

		// Token: 0x04002064 RID: 8292
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey;
	}
}
