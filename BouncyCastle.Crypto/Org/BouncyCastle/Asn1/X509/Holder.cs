using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000658 RID: 1624
	public class Holder : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C18 RID: 15384 RVA: 0x00113900 File Offset: 0x00111B00
		public static global::Org.BouncyCastle.Asn1.X509.Holder GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.Holder)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Holder)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Holder((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Holder((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00113960 File Offset: 0x00111B60
		public Holder(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj)
		{
			int tagNo = tagObj.TagNo;
			if (tagNo != 0)
			{
				if (tagNo != 1)
				{
					throw new global::System.ArgumentException("unknown tag in Holder");
				}
				this.entityName = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(tagObj, true);
			}
			else
			{
				this.baseCertificateID = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(tagObj, true);
			}
			this.version = 0;
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x001139B4 File Offset: 0x00111BB4
		private Holder(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			for (int i = 0; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[i]);
				switch (tObj.TagNo)
				{
				case 0:
					this.baseCertificateID = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(tObj, false);
					break;
				case 1:
					this.entityName = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(tObj, false);
					break;
				case 2:
					this.objectDigestInfo = global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo.GetInstance(tObj, false);
					break;
				default:
					throw new global::System.ArgumentException("unknown tag in Holder");
				}
			}
			this.version = 1;
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x00113A66 File Offset: 0x00111C66
		public Holder(global::Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID) : this(baseCertificateID, 1)
		{
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00113A70 File Offset: 0x00111C70
		public Holder(global::Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID, int version)
		{
			this.baseCertificateID = baseCertificateID;
			this.version = version;
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x00113A86 File Offset: 0x00111C86
		public int Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x00113A8E File Offset: 0x00111C8E
		public Holder(global::Org.BouncyCastle.Asn1.X509.GeneralNames entityName) : this(entityName, 1)
		{
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x00113A98 File Offset: 0x00111C98
		public Holder(global::Org.BouncyCastle.Asn1.X509.GeneralNames entityName, int version)
		{
			this.entityName = entityName;
			this.version = version;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x00113AAE File Offset: 0x00111CAE
		public Holder(global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo)
		{
			this.objectDigestInfo = objectDigestInfo;
			this.version = 1;
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00113AC4 File Offset: 0x00111CC4
		public global::Org.BouncyCastle.Asn1.X509.IssuerSerial BaseCertificateID
		{
			get
			{
				return this.baseCertificateID;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003C22 RID: 15394 RVA: 0x00113ACC File Offset: 0x00111CCC
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames EntityName
		{
			get
			{
				return this.entityName;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x00113AD4 File Offset: 0x00111CD4
		public global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo ObjectDigestInfo
		{
			get
			{
				return this.objectDigestInfo;
			}
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00113ADC File Offset: 0x00111CDC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.version == 1)
			{
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(3);
				asn1EncodableVector.AddOptionalTagged(false, 0, this.baseCertificateID);
				asn1EncodableVector.AddOptionalTagged(false, 1, this.entityName);
				asn1EncodableVector.AddOptionalTagged(false, 2, this.objectDigestInfo);
				return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
			}
			if (this.entityName != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.entityName);
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.baseCertificateID);
		}

		// Token: 0x04001A73 RID: 6771
		internal readonly global::Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID;

		// Token: 0x04001A74 RID: 6772
		internal readonly global::Org.BouncyCastle.Asn1.X509.GeneralNames entityName;

		// Token: 0x04001A75 RID: 6773
		internal readonly global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo;

		// Token: 0x04001A76 RID: 6774
		private readonly int version;
	}
}
