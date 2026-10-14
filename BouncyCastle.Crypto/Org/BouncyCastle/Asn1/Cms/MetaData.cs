using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000754 RID: 1876
	public class MetaData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004311 RID: 17169 RVA: 0x0012D219 File Offset: 0x0012B419
		public MetaData(global::Org.BouncyCastle.Asn1.DerBoolean hashProtected, global::Org.BouncyCastle.Asn1.DerUtf8String fileName, global::Org.BouncyCastle.Asn1.DerIA5String mediaType, global::Org.BouncyCastle.Asn1.Cms.Attributes otherMetaData)
		{
			this.hashProtected = hashProtected;
			this.fileName = fileName;
			this.mediaType = mediaType;
			this.otherMetaData = otherMetaData;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x0012D240 File Offset: 0x0012B440
		private MetaData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.hashProtected = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(seq[0]);
			int index = 1;
			if (index < seq.Count && seq[index] is global::Org.BouncyCastle.Asn1.DerUtf8String)
			{
				this.fileName = global::Org.BouncyCastle.Asn1.DerUtf8String.GetInstance(seq[index++]);
			}
			if (index < seq.Count && seq[index] is global::Org.BouncyCastle.Asn1.DerIA5String)
			{
				this.mediaType = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(seq[index++]);
			}
			if (index < seq.Count)
			{
				this.otherMetaData = global::Org.BouncyCastle.Asn1.Cms.Attributes.GetInstance(seq[index++]);
			}
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x0012D2E0 File Offset: 0x0012B4E0
		public static global::Org.BouncyCastle.Asn1.Cms.MetaData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.MetaData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.MetaData)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.MetaData(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x0012D304 File Offset: 0x0012B504
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.hashProtected
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.fileName,
				this.mediaType,
				this.otherMetaData
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06004315 RID: 17173 RVA: 0x0012D353 File Offset: 0x0012B553
		public virtual bool IsHashProtected
		{
			get
			{
				return this.hashProtected.IsTrue;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x0012D360 File Offset: 0x0012B560
		public virtual global::Org.BouncyCastle.Asn1.DerUtf8String FileName
		{
			get
			{
				return this.fileName;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06004317 RID: 17175 RVA: 0x0012D368 File Offset: 0x0012B568
		public virtual global::Org.BouncyCastle.Asn1.DerIA5String MediaType
		{
			get
			{
				return this.mediaType;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x0012D370 File Offset: 0x0012B570
		public virtual global::Org.BouncyCastle.Asn1.Cms.Attributes OtherMetaData
		{
			get
			{
				return this.otherMetaData;
			}
		}

		// Token: 0x04002052 RID: 8274
		private global::Org.BouncyCastle.Asn1.DerBoolean hashProtected;

		// Token: 0x04002053 RID: 8275
		private global::Org.BouncyCastle.Asn1.DerUtf8String fileName;

		// Token: 0x04002054 RID: 8276
		private global::Org.BouncyCastle.Asn1.DerIA5String mediaType;

		// Token: 0x04002055 RID: 8277
		private global::Org.BouncyCastle.Asn1.Cms.Attributes otherMetaData;
	}
}
