using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Smime
{
	// Token: 0x020006A0 RID: 1696
	public class SmimeCapabilitiesAttribute : global::Org.BouncyCastle.Asn1.X509.AttributeX509
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x0011C6BA File Offset: 0x0011A8BA
		public SmimeCapabilitiesAttribute(global::Org.BouncyCastle.Asn1.Smime.SmimeCapabilityVector capabilities) : base(global::Org.BouncyCastle.Asn1.Smime.SmimeAttributes.SmimeCapabilities, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerSequence(capabilities.ToAsn1EncodableVector())))
		{
		}
	}
}
