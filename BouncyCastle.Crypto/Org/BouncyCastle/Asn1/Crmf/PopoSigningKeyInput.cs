using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000737 RID: 1847
	public class PopoSigningKeyInput : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600423C RID: 16956 RVA: 0x0012AB84 File Offset: 0x00128D84
		private PopoSigningKeyInput(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable authInfo = seq[0];
			if (authInfo is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)authInfo;
				if (tagObj.TagNo != 0)
				{
					throw new global::System.ArgumentException("Unknown authInfo tag: " + tagObj.TagNo.ToString(), "seq");
				}
				this.sender = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(tagObj.GetObject());
			}
			else
			{
				this.publicKeyMac = global::Org.BouncyCastle.Asn1.Crmf.PKMacValue.GetInstance(authInfo);
			}
			this.publicKey = global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(seq[1]);
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x0012AC0A File Offset: 0x00128E0A
		public static global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKeyInput((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x0012AC49 File Offset: 0x00128E49
		public PopoSigningKeyInput(global::Org.BouncyCastle.Asn1.X509.GeneralName sender, global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki)
		{
			this.sender = sender;
			this.publicKey = spki;
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x0012AC5F File Offset: 0x00128E5F
		public PopoSigningKeyInput(global::Org.BouncyCastle.Asn1.Crmf.PKMacValue pkmac, global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo spki)
		{
			this.publicKeyMac = pkmac;
			this.publicKey = spki;
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06004240 RID: 16960 RVA: 0x0012AC75 File Offset: 0x00128E75
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName Sender
		{
			get
			{
				return this.sender;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06004241 RID: 16961 RVA: 0x0012AC7D File Offset: 0x00128E7D
		public virtual global::Org.BouncyCastle.Asn1.Crmf.PKMacValue PublicKeyMac
		{
			get
			{
				return this.publicKeyMac;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06004242 RID: 16962 RVA: 0x0012AC85 File Offset: 0x00128E85
		public virtual global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo PublicKey
		{
			get
			{
				return this.publicKey;
			}
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x0012AC90 File Offset: 0x00128E90
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.sender != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.sender));
			}
			else
			{
				v.Add(this.publicKeyMac);
			}
			v.Add(this.publicKey);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001FE4 RID: 8164
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName sender;

		// Token: 0x04001FE5 RID: 8165
		private readonly global::Org.BouncyCastle.Asn1.Crmf.PKMacValue publicKeyMac;

		// Token: 0x04001FE6 RID: 8166
		private readonly global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey;
	}
}
