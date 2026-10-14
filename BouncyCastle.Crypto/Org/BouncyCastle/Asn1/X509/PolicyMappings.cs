using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000663 RID: 1635
	public class PolicyMappings : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C6D RID: 15469 RVA: 0x00114AD9 File Offset: 0x00112CD9
		public PolicyMappings(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.seq = seq;
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00114AE8 File Offset: 0x00112CE8
		public PolicyMappings(global::System.Collections.Hashtable mappings) : this(mappings)
		{
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x00114AF4 File Offset: 0x00112CF4
		public PolicyMappings(global::System.Collections.IDictionary mappings)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in mappings.Keys)
			{
				string idp = (string)obj;
				string sdp = (string)mappings[idp];
				v.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(idp),
					new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(sdp)
				}));
			}
			this.seq = new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x00114B94 File Offset: 0x00112D94
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x04001AAC RID: 6828
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence seq;
	}
}
