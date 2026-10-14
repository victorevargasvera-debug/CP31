using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000769 RID: 1897
	public class TimeStampTokenEvidence : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043C1 RID: 17345 RVA: 0x0012EFAB File Offset: 0x0012D1AB
		public TimeStampTokenEvidence(global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[] timeStampAndCrls)
		{
			this.timeStampAndCrls = timeStampAndCrls;
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x0012EFBA File Offset: 0x0012D1BA
		public TimeStampTokenEvidence(global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl timeStampAndCrl)
		{
			this.timeStampAndCrls = new global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[]
			{
				timeStampAndCrl
			};
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x0012EFD4 File Offset: 0x0012D1D4
		private TimeStampTokenEvidence(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.timeStampAndCrls = new global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[seq.Count];
			int count = 0;
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
				this.timeStampAndCrls[count++] = global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl.GetInstance(ae.ToAsn1Object());
			}
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x0012F054 File Offset: 0x0012D254
		public static global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tagged, isExplicit));
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x0012F062 File Offset: 0x0012D262
		public static global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.TimeStampTokenEvidence(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x0012F083 File Offset: 0x0012D283
		public virtual global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[] ToTimeStampAndCrlArray()
		{
			return (global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[])this.timeStampAndCrls.Clone();
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0012F098 File Offset: 0x0012D298
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.timeStampAndCrls;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x04002095 RID: 8341
		private global::Org.BouncyCastle.Asn1.Cms.TimeStampAndCrl[] timeStampAndCrls;
	}
}
