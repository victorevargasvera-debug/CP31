using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200076F RID: 1903
	public class CertRepMessage : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043E8 RID: 17384 RVA: 0x0012F55C File Offset: 0x0012D75C
		private CertRepMessage(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			if (seq.Count > 1)
			{
				this.caPubs = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index++], true);
			}
			this.response = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[index]);
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x0012F5A8 File Offset: 0x0012D7A8
		public static global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CertRepMessage((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x0012F5E8 File Offset: 0x0012D7E8
		public CertRepMessage(global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] caPubs, global::Org.BouncyCastle.Asn1.Cmp.CertResponse[] response)
		{
			if (response == null)
			{
				throw new global::System.ArgumentNullException("response");
			}
			if (caPubs != null)
			{
				this.caPubs = new global::Org.BouncyCastle.Asn1.DerSequence(caPubs);
			}
			this.response = new global::Org.BouncyCastle.Asn1.DerSequence(response);
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x0012F628 File Offset: 0x0012D828
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] GetCAPubs()
		{
			if (this.caPubs == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] results = new global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[this.caPubs.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(this.caPubs[i]);
			}
			return results;
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x0012F674 File Offset: 0x0012D874
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CertResponse[] GetResponse()
		{
			global::Org.BouncyCastle.Asn1.Cmp.CertResponse[] results = new global::Org.BouncyCastle.Asn1.Cmp.CertResponse[this.response.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.CertResponse.GetInstance(this.response[i]);
			}
			return results;
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x0012F6B5 File Offset: 0x0012D8B5
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 1, this.caPubs);
			asn1EncodableVector.Add(this.response);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x040020A1 RID: 8353
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence caPubs;

		// Token: 0x040020A2 RID: 8354
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence response;
	}
}
