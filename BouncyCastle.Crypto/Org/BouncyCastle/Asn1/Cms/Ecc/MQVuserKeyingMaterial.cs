using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms.Ecc
{
	// Token: 0x0200076A RID: 1898
	public class MQVuserKeyingMaterial : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043C8 RID: 17352 RVA: 0x0012F0B2 File Offset: 0x0012D2B2
		public MQVuserKeyingMaterial(global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey ephemeralPublicKey, global::Org.BouncyCastle.Asn1.Asn1OctetString addedukm)
		{
			this.ephemeralPublicKey = ephemeralPublicKey;
			this.addedukm = addedukm;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x0012F0C8 File Offset: 0x0012D2C8
		private MQVuserKeyingMaterial(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.ephemeralPublicKey = global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.addedukm = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1], true);
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x0012F103 File Offset: 0x0012D303
		public static global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x0012F111 File Offset: 0x0012D311
		public static global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.Ecc.MQVuserKeyingMaterial((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid MQVuserKeyingMaterial: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060043CC RID: 17356 RVA: 0x0012F14E File Offset: 0x0012D34E
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey EphemeralPublicKey
		{
			get
			{
				return this.ephemeralPublicKey;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x0012F156 File Offset: 0x0012D356
		public global::Org.BouncyCastle.Asn1.Asn1OctetString AddedUkm
		{
			get
			{
				return this.addedukm;
			}
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x0012F15E File Offset: 0x0012D35E
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.ephemeralPublicKey
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.addedukm);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04002096 RID: 8342
		private global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey ephemeralPublicKey;

		// Token: 0x04002097 RID: 8343
		private global::Org.BouncyCastle.Asn1.Asn1OctetString addedukm;
	}
}
