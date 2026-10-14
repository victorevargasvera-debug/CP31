using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x020006FA RID: 1786
	public class ContentHints : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600409B RID: 16539 RVA: 0x001252D8 File Offset: 0x001234D8
		public static global::Org.BouncyCastle.Asn1.Ess.ContentHints GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.ContentHints)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.ContentHints)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.ContentHints((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in 'ContentHints' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x00125328 File Offset: 0x00123528
		private ContentHints(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::Org.BouncyCastle.Asn1.IAsn1Convertible field = seq[0];
			if (field.ToAsn1Object() is global::Org.BouncyCastle.Asn1.DerUtf8String)
			{
				this.contentDescription = global::Org.BouncyCastle.Asn1.DerUtf8String.GetInstance(field);
				this.contentType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[1]);
				return;
			}
			this.contentType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x00125381 File Offset: 0x00123581
		public ContentHints(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType)
		{
			this.contentType = contentType;
			this.contentDescription = null;
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x00125397 File Offset: 0x00123597
		public ContentHints(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.DerUtf8String contentDescription)
		{
			this.contentType = contentType;
			this.contentDescription = contentDescription;
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x001253AD File Offset: 0x001235AD
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x001253B5 File Offset: 0x001235B5
		public global::Org.BouncyCastle.Asn1.DerUtf8String ContentDescription
		{
			get
			{
				return this.contentDescription;
			}
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x001253C0 File Offset: 0x001235C0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.contentDescription
			});
			v.Add(this.contentType);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F00 RID: 7936
		private readonly global::Org.BouncyCastle.Asn1.DerUtf8String contentDescription;

		// Token: 0x04001F01 RID: 7937
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;
	}
}
