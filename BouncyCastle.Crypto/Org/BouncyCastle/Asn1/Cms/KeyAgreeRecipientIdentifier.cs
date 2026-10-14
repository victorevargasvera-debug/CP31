using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000751 RID: 1873
	public class KeyAgreeRecipientIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x060042F8 RID: 17144 RVA: 0x0012CE63 File Offset: 0x0012B063
		public static global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x0012CE74 File Offset: 0x0012B074
		public static global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber.GetInstance(obj));
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj).TagNo == 0)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientIdentifier(global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj, false));
			}
			throw new global::System.ArgumentException("Invalid KeyAgreeRecipientIdentifier: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x0012CEE8 File Offset: 0x0012B0E8
		public KeyAgreeRecipientIdentifier(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerSerial)
		{
			this.issuerSerial = issuerSerial;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x0012CEF7 File Offset: 0x0012B0F7
		public KeyAgreeRecipientIdentifier(global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier rKeyID)
		{
			this.rKeyID = rKeyID;
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0012CF06 File Offset: 0x0012B106
		public global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber IssuerAndSerialNumber
		{
			get
			{
				return this.issuerSerial;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060042FD RID: 17149 RVA: 0x0012CF0E File Offset: 0x0012B10E
		public global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier RKeyID
		{
			get
			{
				return this.rKeyID;
			}
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x0012CF16 File Offset: 0x0012B116
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.issuerSerial != null)
			{
				return this.issuerSerial.ToAsn1Object();
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.rKeyID);
		}

		// Token: 0x04002047 RID: 8263
		private readonly global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerSerial;

		// Token: 0x04002048 RID: 8264
		private readonly global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier rKeyID;
	}
}
