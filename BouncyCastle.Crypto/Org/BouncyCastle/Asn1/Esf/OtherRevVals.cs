using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000714 RID: 1812
	public class OtherRevVals : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004143 RID: 16707 RVA: 0x00127754 File Offset: 0x00125954
		public static global::Org.BouncyCastle.Asn1.Esf.OtherRevVals GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OtherRevVals)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OtherRevVals)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OtherRevVals((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OtherRevVals' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x001277A4 File Offset: 0x001259A4
		private OtherRevVals(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.otherRevValType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			this.otherRevVals = seq[1].ToAsn1Object();
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x0012781A File Offset: 0x00125A1A
		public OtherRevVals(global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevValType, global::Org.BouncyCastle.Asn1.Asn1Encodable otherRevVals)
		{
			if (otherRevValType == null)
			{
				throw new global::System.ArgumentNullException("otherRevValType");
			}
			if (otherRevVals == null)
			{
				throw new global::System.ArgumentNullException("otherRevVals");
			}
			this.otherRevValType = otherRevValType;
			this.otherRevVals = otherRevVals.ToAsn1Object();
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x00127851 File Offset: 0x00125A51
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier OtherRevValType
		{
			get
			{
				return this.otherRevValType;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x00127859 File Offset: 0x00125A59
		public global::Org.BouncyCastle.Asn1.Asn1Object OtherRevValsObject
		{
			get
			{
				return this.otherRevVals;
			}
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00127861 File Offset: 0x00125A61
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.otherRevValType,
				this.otherRevVals
			});
		}

		// Token: 0x04001F42 RID: 8002
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevValType;

		// Token: 0x04001F43 RID: 8003
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object otherRevVals;
	}
}
