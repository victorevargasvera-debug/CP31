using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200078A RID: 1930
	public class PopoDecKeyChallContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044A7 RID: 17575 RVA: 0x00131553 File Offset: 0x0012F753
		private PopoDecKeyChallContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00131562 File Offset: 0x0012F762
		public static global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyChallContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyChallContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyChallContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PopoDecKeyChallContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x001315A4 File Offset: 0x0012F7A4
		public virtual global::Org.BouncyCastle.Asn1.Cmp.Challenge[] ToChallengeArray()
		{
			global::Org.BouncyCastle.Asn1.Cmp.Challenge[] result = new global::Org.BouncyCastle.Asn1.Cmp.Challenge[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.Challenge.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x001315E5 File Offset: 0x0012F7E5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x0400214C RID: 8524
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
