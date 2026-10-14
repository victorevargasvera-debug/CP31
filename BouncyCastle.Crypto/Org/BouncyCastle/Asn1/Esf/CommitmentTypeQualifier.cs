using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000705 RID: 1797
	public class CommitmentTypeQualifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040E4 RID: 16612 RVA: 0x00126215 File Offset: 0x00124415
		public CommitmentTypeQualifier(global::Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeIdentifier) : this(commitmentTypeIdentifier, null)
		{
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x0012621F File Offset: 0x0012441F
		public CommitmentTypeQualifier(global::Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeIdentifier, global::Org.BouncyCastle.Asn1.Asn1Encodable qualifier)
		{
			if (commitmentTypeIdentifier == null)
			{
				throw new global::System.ArgumentNullException("commitmentTypeIdentifier");
			}
			this.commitmentTypeIdentifier = commitmentTypeIdentifier;
			if (qualifier != null)
			{
				this.qualifier = qualifier.ToAsn1Object();
			}
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x0012624C File Offset: 0x0012444C
		public CommitmentTypeQualifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.commitmentTypeIdentifier = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			if (seq.Count > 1)
			{
				this.qualifier = seq[1].ToAsn1Object();
			}
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x001262D4 File Offset: 0x001244D4
		public static global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeQualifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeQualifier)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeQualifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CommitmentTypeQualifier((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CommitmentTypeQualifier' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060040E8 RID: 16616 RVA: 0x00126321 File Offset: 0x00124521
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier CommitmentTypeIdentifier
		{
			get
			{
				return this.commitmentTypeIdentifier;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x00126329 File Offset: 0x00124529
		public global::Org.BouncyCastle.Asn1.Asn1Object Qualifier
		{
			get
			{
				return this.qualifier;
			}
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x00126334 File Offset: 0x00124534
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.commitmentTypeIdentifier
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.qualifier
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F1A RID: 7962
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier commitmentTypeIdentifier;

		// Token: 0x04001F1B RID: 7963
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object qualifier;
	}
}
