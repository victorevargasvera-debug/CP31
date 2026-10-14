using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000704 RID: 1796
	public class CommitmentTypeIndication : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040DD RID: 16605 RVA: 0x001260B8 File Offset: 0x001242B8
		public static global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeIndication GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeIndication)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeIndication)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeIndication((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CommitmentTypeIndication' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x00126108 File Offset: 0x00124308
		public CommitmentTypeIndication(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.commitmentTypeId = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			if (seq.Count > 1)
			{
				this.commitmentTypeQualifier = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[1].ToAsn1Object();
			}
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00126195 File Offset: 0x00124395
		public CommitmentTypeIndication(global::Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeId) : this(commitmentTypeId, null)
		{
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x0012619F File Offset: 0x0012439F
		public CommitmentTypeIndication(global::Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeId, global::Org.BouncyCastle.Asn1.Asn1Sequence commitmentTypeQualifier)
		{
			if (commitmentTypeId == null)
			{
				throw new global::System.ArgumentNullException("commitmentTypeId");
			}
			this.commitmentTypeId = commitmentTypeId;
			if (commitmentTypeQualifier != null)
			{
				this.commitmentTypeQualifier = commitmentTypeQualifier;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x001261C6 File Offset: 0x001243C6
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier CommitmentTypeID
		{
			get
			{
				return this.commitmentTypeId;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x001261CE File Offset: 0x001243CE
		public global::Org.BouncyCastle.Asn1.Asn1Sequence CommitmentTypeQualifier
		{
			get
			{
				return this.commitmentTypeQualifier;
			}
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x001261D8 File Offset: 0x001243D8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.commitmentTypeId
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.commitmentTypeQualifier
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F18 RID: 7960
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeId;

		// Token: 0x04001F19 RID: 7961
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence commitmentTypeQualifier;
	}
}
