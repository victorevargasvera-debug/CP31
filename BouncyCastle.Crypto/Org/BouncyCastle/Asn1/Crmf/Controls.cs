using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200072C RID: 1836
	public class Controls : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041F2 RID: 16882 RVA: 0x0012A032 File Offset: 0x00128232
		private Controls(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x0012A041 File Offset: 0x00128241
		public static global::Org.BouncyCastle.Asn1.Crmf.Controls GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.Controls)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.Controls)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.Controls((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x0012A080 File Offset: 0x00128280
		public Controls(params global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] atvs)
		{
			this.content = new global::Org.BouncyCastle.Asn1.DerSequence(atvs);
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x0012A0A4 File Offset: 0x001282A4
		public virtual global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] ToAttributeTypeAndValueArray()
		{
			global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[] result = new global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Crmf.AttributeTypeAndValue.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x0012A0E5 File Offset: 0x001282E5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x04001FBD RID: 8125
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
