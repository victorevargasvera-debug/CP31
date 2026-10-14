using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000784 RID: 1924
	public class PkiMessages : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004485 RID: 17541 RVA: 0x0013102F File Offset: 0x0012F22F
		private PkiMessages(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x0013103E File Offset: 0x0012F23E
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiMessages GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiMessages)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiMessages)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiMessages((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x00131080 File Offset: 0x0012F280
		public PkiMessages(params global::Org.BouncyCastle.Asn1.Cmp.PkiMessage[] msgs)
		{
			this.content = new global::Org.BouncyCastle.Asn1.DerSequence(msgs);
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x001310A4 File Offset: 0x0012F2A4
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiMessage[] ToPkiMessageArray()
		{
			global::Org.BouncyCastle.Asn1.Cmp.PkiMessage[] result = new global::Org.BouncyCastle.Asn1.Cmp.PkiMessage[this.content.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.PkiMessage.GetInstance(this.content[i]);
			}
			return result;
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x001310E5 File Offset: 0x0012F2E5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x04002134 RID: 8500
		private global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
