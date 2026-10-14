using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200065E RID: 1630
	public class NameConstraints : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C46 RID: 15430 RVA: 0x0011444C File Offset: 0x0011264C
		public static global::Org.BouncyCastle.Asn1.X509.NameConstraints GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.NameConstraints)
			{
				return (global::Org.BouncyCastle.Asn1.X509.NameConstraints)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.NameConstraints((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x0011449C File Offset: 0x0011269C
		public NameConstraints(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				int tagNo = o.TagNo;
				if (tagNo != 0)
				{
					if (tagNo == 1)
					{
						this.excluded = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o, false);
					}
				}
				else
				{
					this.permitted = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o, false);
				}
			}
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x0011451C File Offset: 0x0011271C
		public NameConstraints(global::System.Collections.ArrayList permitted, global::System.Collections.ArrayList excluded) : this(permitted, excluded)
		{
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00114526 File Offset: 0x00112726
		public NameConstraints(global::System.Collections.IList permitted, global::System.Collections.IList excluded)
		{
			if (permitted != null)
			{
				this.permitted = this.CreateSequence(permitted);
			}
			if (excluded != null)
			{
				this.excluded = this.CreateSequence(excluded);
			}
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00114550 File Offset: 0x00112750
		private global::Org.BouncyCastle.Asn1.DerSequence CreateSequence(global::System.Collections.IList subtrees)
		{
			global::Org.BouncyCastle.Asn1.X509.GeneralSubtree[] gsts = new global::Org.BouncyCastle.Asn1.X509.GeneralSubtree[subtrees.Count];
			for (int i = 0; i < subtrees.Count; i++)
			{
				gsts[i] = (global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)subtrees[i];
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = gsts;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x00114591 File Offset: 0x00112791
		public global::Org.BouncyCastle.Asn1.Asn1Sequence PermittedSubtrees
		{
			get
			{
				return this.permitted;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x00114599 File Offset: 0x00112799
		public global::Org.BouncyCastle.Asn1.Asn1Sequence ExcludedSubtrees
		{
			get
			{
				return this.excluded;
			}
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x001145A1 File Offset: 0x001127A1
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(false, 0, this.permitted);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.excluded);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001A9D RID: 6813
		private global::Org.BouncyCastle.Asn1.Asn1Sequence permitted;

		// Token: 0x04001A9E RID: 6814
		private global::Org.BouncyCastle.Asn1.Asn1Sequence excluded;
	}
}
