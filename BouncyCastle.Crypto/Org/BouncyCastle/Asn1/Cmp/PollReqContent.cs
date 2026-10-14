using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000789 RID: 1929
	public class PollReqContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044A2 RID: 17570 RVA: 0x0013147E File Offset: 0x0012F67E
		private PollReqContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.content = seq;
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x0013148D File Offset: 0x0012F68D
		public static global::Org.BouncyCastle.Asn1.Cmp.PollReqContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PollReqContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PollReqContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PollReqContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044A4 RID: 17572 RVA: 0x001314CC File Offset: 0x0012F6CC
		public virtual global::Org.BouncyCastle.Asn1.DerInteger[][] GetCertReqIDs()
		{
			global::Org.BouncyCastle.Asn1.DerInteger[][] result = new global::Org.BouncyCastle.Asn1.DerInteger[this.content.Count][];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.Cmp.PollReqContent.SequenceToDerIntegerArray((global::Org.BouncyCastle.Asn1.Asn1Sequence)this.content[i]);
			}
			return result;
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00131514 File Offset: 0x0012F714
		private static global::Org.BouncyCastle.Asn1.DerInteger[] SequenceToDerIntegerArray(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::Org.BouncyCastle.Asn1.DerInteger[] result = new global::Org.BouncyCastle.Asn1.DerInteger[seq.Count];
			for (int i = 0; i != result.Length; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[i]);
			}
			return result;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x0013154B File Offset: 0x0012F74B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.content;
		}

		// Token: 0x0400214B RID: 8523
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence content;
	}
}
