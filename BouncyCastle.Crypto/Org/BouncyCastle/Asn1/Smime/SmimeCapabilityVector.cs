using System;

namespace Org.BouncyCastle.Asn1.Smime
{
	// Token: 0x020006A2 RID: 1698
	public class SmimeCapabilityVector
	{
		// Token: 0x06003E5C RID: 15964 RVA: 0x0011C80E File Offset: 0x0011AA0E
		public void AddCapability(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capability)
		{
			this.capabilities.Add(new global::Org.BouncyCastle.Asn1.DerSequence(capability));
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0011C821 File Offset: 0x0011AA21
		public void AddCapability(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capability, int value)
		{
			this.capabilities.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				capability,
				new global::Org.BouncyCastle.Asn1.DerInteger(value)
			}));
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x0011C846 File Offset: 0x0011AA46
		public void AddCapability(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capability, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters)
		{
			this.capabilities.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				capability,
				parameters
			}));
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x0011C866 File Offset: 0x0011AA66
		public global::Org.BouncyCastle.Asn1.Asn1EncodableVector ToAsn1EncodableVector()
		{
			return this.capabilities;
		}

		// Token: 0x04001C26 RID: 7206
		private readonly global::Org.BouncyCastle.Asn1.Asn1EncodableVector capabilities = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
	}
}
