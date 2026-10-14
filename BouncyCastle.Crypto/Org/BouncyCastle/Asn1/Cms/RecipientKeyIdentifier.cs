using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200075F RID: 1887
	public class RecipientKeyIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600436D RID: 17261 RVA: 0x0012DEA0 File Offset: 0x0012C0A0
		public RecipientKeyIdentifier(global::Org.BouncyCastle.Asn1.Asn1OctetString subjectKeyIdentifier, global::Org.BouncyCastle.Asn1.DerGeneralizedTime date, global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other)
		{
			this.subjectKeyIdentifier = subjectKeyIdentifier;
			this.date = date;
			this.other = other;
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x0012DEBD File Offset: 0x0012C0BD
		public RecipientKeyIdentifier(byte[] subjectKeyIdentifier) : this(subjectKeyIdentifier, null, null)
		{
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x0012DEC8 File Offset: 0x0012C0C8
		public RecipientKeyIdentifier(byte[] subjectKeyIdentifier, global::Org.BouncyCastle.Asn1.DerGeneralizedTime date, global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other)
		{
			this.subjectKeyIdentifier = new global::Org.BouncyCastle.Asn1.DerOctetString(subjectKeyIdentifier);
			this.date = date;
			this.other = other;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x0012DEEC File Offset: 0x0012C0EC
		public RecipientKeyIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.subjectKeyIdentifier = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]);
			switch (seq.Count)
			{
			case 1:
				return;
			case 2:
				if (seq[1] is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
				{
					this.date = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[1];
					return;
				}
				this.other = global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute.GetInstance(seq[2]);
				return;
			case 3:
				this.date = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[1];
				this.other = global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute.GetInstance(seq[2]);
				return;
			default:
				throw new global::System.ArgumentException("Invalid RecipientKeyIdentifier");
			}
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x0012DF92 File Offset: 0x0012C192
		public static global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject ato, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(ato, explicitly));
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x0012DFA0 File Offset: 0x0012C1A0
		public static global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid RecipientKeyIdentifier: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06004373 RID: 17267 RVA: 0x0012DFDD File Offset: 0x0012C1DD
		public global::Org.BouncyCastle.Asn1.Asn1OctetString SubjectKeyIdentifier
		{
			get
			{
				return this.subjectKeyIdentifier;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x0012DFE5 File Offset: 0x0012C1E5
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime Date
		{
			get
			{
				return this.date;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06004375 RID: 17269 RVA: 0x0012DFED File Offset: 0x0012C1ED
		public global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute OtherKeyAttribute
		{
			get
			{
				return this.other;
			}
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x0012DFF8 File Offset: 0x0012C1F8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.subjectKeyIdentifier
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.date,
				this.other
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002069 RID: 8297
		private global::Org.BouncyCastle.Asn1.Asn1OctetString subjectKeyIdentifier;

		// Token: 0x0400206A RID: 8298
		private global::Org.BouncyCastle.Asn1.DerGeneralizedTime date;

		// Token: 0x0400206B RID: 8299
		private global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other;
	}
}
