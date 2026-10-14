using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000791 RID: 1937
	public class RevReqContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044CF RID: 17615 RVA: 0x00131C12 File Offset: 0x0012FE12
		private RevReqContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00131C21 File Offset: 0x0012FE21
		public static global::Org.BouncyCastle.Asn1.Cmp.RevReqContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.RevReqContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.RevReqContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.RevReqContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x00131C60 File Offset: 0x0012FE60
		public RevReqContent(params global::Org.BouncyCastle.Asn1.Cmp.RevDetails[] revDetails)
		{
			this.content = new global::Org.BouncyCastle.Asn1.DerSequence(revDetails);
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x00131C84 File Offset: 0x0012FE84
		public virtual global::Org.BouncyCastle.Asn1.Cmp.RevDetails[] ToRevDetailsArray()
		{
			global::Org.BouncyCastle.Asn1.Cmp.RevDetails[] result = new global::Org.BouncyCastle.Asn1.Cmp.RevDetails[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.RevDetails.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x00131CC5 File Offset: 0x0012FEC5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x0400215D RID: 8541
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
