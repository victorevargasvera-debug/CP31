using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000767 RID: 1895
	public class TimeStampedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043B3 RID: 17331 RVA: 0x0012ED25 File Offset: 0x0012CF25
		public TimeStampedData(global::Org.BouncyCastle.Asn1.DerIA5String dataUri, global::Org.BouncyCastle.Asn1.Cms.MetaData metaData, global::Org.BouncyCastle.Asn1.Asn1OctetString content, global::Org.BouncyCastle.Asn1.Cms.Evidence temporalEvidence)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(1);
			this.dataUri = dataUri;
			this.metaData = metaData;
			this.content = content;
			this.temporalEvidence = temporalEvidence;
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x0012ED58 File Offset: 0x0012CF58
		private TimeStampedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			int index = 1;
			if (seq[index] is global::Org.BouncyCastle.Asn1.DerIA5String)
			{
				this.dataUri = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(seq[index++]);
			}
			if (seq[index] is global::Org.BouncyCastle.Asn1.Cms.MetaData || seq[index] is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				this.metaData = global::Org.BouncyCastle.Asn1.Cms.MetaData.GetInstance(seq[index++]);
			}
			if (seq[index] is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				this.content = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[index++]);
			}
			this.temporalEvidence = global::Org.BouncyCastle.Asn1.Cms.Evidence.GetInstance(seq[index]);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x0012EE0B File Offset: 0x0012D00B
		public static global::Org.BouncyCastle.Asn1.Cms.TimeStampedData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.TimeStampedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.TimeStampedData)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.TimeStampedData(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x0012EE2C File Offset: 0x0012D02C
		public virtual global::Org.BouncyCastle.Asn1.DerIA5String DataUri
		{
			get
			{
				return this.dataUri;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x0012EE34 File Offset: 0x0012D034
		public global::Org.BouncyCastle.Asn1.Cms.MetaData MetaData
		{
			get
			{
				return this.metaData;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x0012EE3C File Offset: 0x0012D03C
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x0012EE44 File Offset: 0x0012D044
		public global::Org.BouncyCastle.Asn1.Cms.Evidence TemporalEvidence
		{
			get
			{
				return this.temporalEvidence;
			}
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x0012EE4C File Offset: 0x0012D04C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.dataUri,
				this.metaData,
				this.content
			});
			v.Add(this.temporalEvidence);
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x0400208A RID: 8330
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x0400208B RID: 8331
		private global::Org.BouncyCastle.Asn1.DerIA5String dataUri;

		// Token: 0x0400208C RID: 8332
		private global::Org.BouncyCastle.Asn1.Cms.MetaData metaData;

		// Token: 0x0400208D RID: 8333
		private global::Org.BouncyCastle.Asn1.Asn1OctetString content;

		// Token: 0x0400208E RID: 8334
		private global::Org.BouncyCastle.Asn1.Cms.Evidence temporalEvidence;
	}
}
