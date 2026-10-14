using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000772 RID: 1906
	public class Challenge : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043FE RID: 17406 RVA: 0x0012F9AC File Offset: 0x0012DBAC
		private Challenge(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			if (seq.Count == 3)
			{
				this.owf = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[index++]);
			}
			this.witness = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[index++]);
			this.challenge = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[index]);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x0012FA08 File Offset: 0x0012DC08
		public static global::Org.BouncyCastle.Asn1.Cmp.Challenge GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.Challenge)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.Challenge)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.Challenge((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06004400 RID: 17408 RVA: 0x0012FA47 File Offset: 0x0012DC47
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Owf
		{
			get
			{
				return this.owf;
			}
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x0012FA50 File Offset: 0x0012DC50
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.owf
			});
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.witness,
				this.challenge
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040020AA RID: 8362
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier owf;

		// Token: 0x040020AB RID: 8363
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString witness;

		// Token: 0x040020AC RID: 8364
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString challenge;
	}
}
