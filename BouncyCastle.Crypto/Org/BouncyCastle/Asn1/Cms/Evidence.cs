using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200074D RID: 1869
	public class Evidence : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x060042DA RID: 17114 RVA: 0x0012CA3F File Offset: 0x0012AC3F
		public Evidence(global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence tstEvidence)
		{
			this.tstEvidence = tstEvidence;
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x0012CA50 File Offset: 0x0012AC50
		private Evidence(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged)
		{
			if (tagged.TagNo == 0)
			{
				this.tstEvidence = global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence.GetInstance(tagged, false);
				return;
			}
			if (tagged.TagNo == 2)
			{
				this.otherEvidence = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tagged, false);
				return;
			}
			throw new global::System.ArgumentException("unknown tag in Evidence", "tagged");
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x0012CA9F File Offset: 0x0012AC9F
		public static global::Org.BouncyCastle.Asn1.Cms.Evidence GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.Evidence)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.Evidence)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.Evidence(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj));
			}
			throw new global::System.ArgumentException("Unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x0012CADE File Offset: 0x0012ACDE
		public static global::Org.BouncyCastle.Asn1.Cms.Evidence GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.Evidence.GetInstance(obj.GetObject());
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x0012CAEB File Offset: 0x0012ACEB
		public virtual global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence TstEvidence
		{
			get
			{
				return this.tstEvidence;
			}
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x0012CAF3 File Offset: 0x0012ACF3
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.tstEvidence != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.tstEvidence);
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, this.otherEvidence);
		}

		// Token: 0x0400203C RID: 8252
		private global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence tstEvidence;

		// Token: 0x0400203D RID: 8253
		private global::Org.BouncyCastle.Asn1.Asn1Sequence otherEvidence;
	}
}
