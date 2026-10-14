using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000713 RID: 1811
	public class OtherRevRefs : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600413D RID: 16701 RVA: 0x00127628 File Offset: 0x00125828
		public static global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OtherRevRefs' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00127678 File Offset: 0x00125878
		private OtherRevRefs(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.otherRevRefType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			this.otherRevRefs = seq[1].ToAsn1Object();
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x001276EE File Offset: 0x001258EE
		public OtherRevRefs(global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevRefType, global::Org.BouncyCastle.Asn1.Asn1Encodable otherRevRefs)
		{
			if (otherRevRefType == null)
			{
				throw new global::System.ArgumentNullException("otherRevRefType");
			}
			if (otherRevRefs == null)
			{
				throw new global::System.ArgumentNullException("otherRevRefs");
			}
			this.otherRevRefType = otherRevRefType;
			this.otherRevRefs = otherRevRefs.ToAsn1Object();
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x00127725 File Offset: 0x00125925
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier OtherRevRefType
		{
			get
			{
				return this.otherRevRefType;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x0012772D File Offset: 0x0012592D
		public global::Org.BouncyCastle.Asn1.Asn1Object OtherRevRefsObject
		{
			get
			{
				return this.otherRevRefs;
			}
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x00127735 File Offset: 0x00125935
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.otherRevRefType,
				this.otherRevRefs
			});
		}

		// Token: 0x04001F40 RID: 8000
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevRefType;

		// Token: 0x04001F41 RID: 8001
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object otherRevRefs;
	}
}
