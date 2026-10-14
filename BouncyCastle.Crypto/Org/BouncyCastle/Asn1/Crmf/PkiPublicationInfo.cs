using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000733 RID: 1843
	public class PkiPublicationInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004221 RID: 16929 RVA: 0x0012A79C File Offset: 0x0012899C
		private PkiPublicationInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.action = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.pubInfos = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0012A7C8 File Offset: 0x001289C8
		public static global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x0012A807 File Offset: 0x00128A07
		public virtual global::Org.BouncyCastle.Asn1.DerInteger Action
		{
			get
			{
				return this.action;
			}
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x0012A810 File Offset: 0x00128A10
		public virtual global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo[] GetPubInfos()
		{
			if (this.pubInfos == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo[] results = new global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo[this.pubInfos.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Crmf.SinglePubInfo.GetInstance(this.pubInfos[i]);
			}
			return results;
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x0012A85B File Offset: 0x00128A5B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.action,
				this.pubInfos
			});
		}

		// Token: 0x04001FD6 RID: 8150
		private readonly global::Org.BouncyCastle.Asn1.DerInteger action;

		// Token: 0x04001FD7 RID: 8151
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence pubInfos;
	}
}
