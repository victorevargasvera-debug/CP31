using System;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Asn1.Smime
{
	// Token: 0x020006A1 RID: 1697
	public class SmimeCapability : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E55 RID: 15957 RVA: 0x0011C6D7 File Offset: 0x0011A8D7
		public SmimeCapability(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.capabilityID = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0].ToAsn1Object();
			if (seq.Count > 1)
			{
				this.parameters = seq[1].ToAsn1Object();
			}
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x0011C711 File Offset: 0x0011A911
		public SmimeCapability(global::Org.BouncyCastle.Asn1.DerObjectIdentifier capabilityID, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters)
		{
			if (capabilityID == null)
			{
				throw new global::System.ArgumentNullException("capabilityID");
			}
			this.capabilityID = capabilityID;
			if (parameters != null)
			{
				this.parameters = parameters.ToAsn1Object();
			}
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0011C73D File Offset: 0x0011A93D
		public static global::Org.BouncyCastle.Asn1.Smime.SmimeCapability GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Smime.SmimeCapability)
			{
				return (global::Org.BouncyCastle.Asn1.Smime.SmimeCapability)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Smime.SmimeCapability((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid SmimeCapability");
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06003E58 RID: 15960 RVA: 0x0011C76F File Offset: 0x0011A96F
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier CapabilityID
		{
			get
			{
				return this.capabilityID;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x0011C777 File Offset: 0x0011A977
		public global::Org.BouncyCastle.Asn1.Asn1Object Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x0011C780 File Offset: 0x0011A980
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.capabilityID
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.parameters
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001C1E RID: 7198
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier PreferSignedData = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PreferSignedData;

		// Token: 0x04001C1F RID: 7199
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CannotDecryptAny = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.CannotDecryptAny;

		// Token: 0x04001C20 RID: 7200
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SmimeCapabilitiesVersions = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.SmimeCapabilitiesVersions;

		// Token: 0x04001C21 RID: 7201
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DesCbc = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.14.3.2.7");

		// Token: 0x04001C22 RID: 7202
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier DesEde3Cbc = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc;

		// Token: 0x04001C23 RID: 7203
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier RC2Cbc = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc;

		// Token: 0x04001C24 RID: 7204
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier capabilityID;

		// Token: 0x04001C25 RID: 7205
		private global::Org.BouncyCastle.Asn1.Asn1Object parameters;
	}
}
