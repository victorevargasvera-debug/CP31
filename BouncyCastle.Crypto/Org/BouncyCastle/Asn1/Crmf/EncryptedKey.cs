using System;
using Org.BouncyCastle.Asn1.Cms;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200072F RID: 1839
	public class EncryptedKey : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004203 RID: 16899 RVA: 0x0012A2D0 File Offset: 0x001284D0
		public static global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey GetInstance(object o)
		{
			if (o is global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey(global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o, false));
			}
			if (o is global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey((global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue)o);
			}
			return new global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey(global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue.GetInstance(o));
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x0012A325 File Offset: 0x00128525
		public EncryptedKey(global::Org.BouncyCastle.Asn1.Cms.EnvelopedData envelopedData)
		{
			this.envelopedData = envelopedData;
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x0012A334 File Offset: 0x00128534
		public EncryptedKey(global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue encryptedValue)
		{
			this.encryptedValue = encryptedValue;
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x0012A343 File Offset: 0x00128543
		public virtual bool IsEncryptedValue
		{
			get
			{
				return this.encryptedValue != null;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06004207 RID: 16903 RVA: 0x0012A34E File Offset: 0x0012854E
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				if (this.encryptedValue != null)
				{
					return this.encryptedValue;
				}
				return this.envelopedData;
			}
		}

		// Token: 0x06004208 RID: 16904 RVA: 0x0012A365 File Offset: 0x00128565
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.encryptedValue != null)
			{
				return this.encryptedValue.ToAsn1Object();
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.envelopedData);
		}

		// Token: 0x04001FC8 RID: 8136
		private readonly global::Org.BouncyCastle.Asn1.Cms.EnvelopedData envelopedData;

		// Token: 0x04001FC9 RID: 8137
		private readonly global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue encryptedValue;
	}
}
