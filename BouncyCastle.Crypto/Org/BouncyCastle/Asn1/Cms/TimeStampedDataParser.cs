using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000768 RID: 1896
	public class TimeStampedDataParser
	{
		// Token: 0x060043BB RID: 17339 RVA: 0x0012EEA8 File Offset: 0x0012D0A8
		private TimeStampedDataParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser parser)
		{
			this.parser = parser;
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(parser.ReadObject());
			global::Org.BouncyCastle.Asn1.Asn1Object obj = parser.ReadObject().ToAsn1Object();
			if (obj is global::Org.BouncyCastle.Asn1.DerIA5String)
			{
				this.dataUri = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(obj);
				obj = parser.ReadObject().ToAsn1Object();
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1SequenceParser)
			{
				this.metaData = global::Org.BouncyCastle.Asn1.Cms.MetaData.GetInstance(obj.ToAsn1Object());
				obj = parser.ReadObject().ToAsn1Object();
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)
			{
				this.content = (global::Org.BouncyCastle.Asn1.Asn1OctetStringParser)obj;
			}
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x0012EF38 File Offset: 0x0012D138
		public static global::Org.BouncyCastle.Asn1.Cms.TimeStampedDataParser GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.TimeStampedDataParser(((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj).Parser);
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1SequenceParser)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.TimeStampedDataParser((global::Org.BouncyCastle.Asn1.Asn1SequenceParser)obj);
			}
			return null;
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x0012EF68 File Offset: 0x0012D168
		public virtual global::Org.BouncyCastle.Asn1.DerIA5String DataUri
		{
			get
			{
				return this.dataUri;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060043BE RID: 17342 RVA: 0x0012EF70 File Offset: 0x0012D170
		public virtual global::Org.BouncyCastle.Asn1.Cms.MetaData MetaData
		{
			get
			{
				return this.metaData;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x0012EF78 File Offset: 0x0012D178
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetStringParser Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x0012EF80 File Offset: 0x0012D180
		public virtual global::Org.BouncyCastle.Asn1.Cms.Evidence GetTemporalEvidence()
		{
			if (this.temporalEvidence == null)
			{
				this.temporalEvidence = global::Org.BouncyCastle.Asn1.Cms.Evidence.GetInstance(this.parser.ReadObject().ToAsn1Object());
			}
			return this.temporalEvidence;
		}

		// Token: 0x0400208F RID: 8335
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002090 RID: 8336
		private global::Org.BouncyCastle.Asn1.DerIA5String dataUri;

		// Token: 0x04002091 RID: 8337
		private global::Org.BouncyCastle.Asn1.Cms.MetaData metaData;

		// Token: 0x04002092 RID: 8338
		private global::Org.BouncyCastle.Asn1.Asn1OctetStringParser content;

		// Token: 0x04002093 RID: 8339
		private global::Org.BouncyCastle.Asn1.Cms.Evidence temporalEvidence;

		// Token: 0x04002094 RID: 8340
		private global::Org.BouncyCastle.Asn1.Asn1SequenceParser parser;
	}
}
