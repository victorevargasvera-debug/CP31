using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000732 RID: 1842
	public class PkiArchiveOptions : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004219 RID: 16921 RVA: 0x0012A631 File Offset: 0x00128831
		public static global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.PkiArchiveOptions((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x0012A670 File Offset: 0x00128870
		private PkiArchiveOptions(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged)
		{
			switch (tagged.TagNo)
			{
			case 0:
				this.value = global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey.GetInstance(tagged.GetObject());
				return;
			case 1:
				this.value = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tagged, false);
				return;
			case 2:
				this.value = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(tagged, false);
				return;
			default:
				throw new global::System.ArgumentException("unknown tag number: " + tagged.TagNo.ToString(), "tagged");
			}
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x0012A6EE File Offset: 0x001288EE
		public PkiArchiveOptions(global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey encKey)
		{
			this.value = encKey;
		}

		// Token: 0x0600421C RID: 16924 RVA: 0x0012A6FD File Offset: 0x001288FD
		public PkiArchiveOptions(global::Org.BouncyCastle.Asn1.Asn1OctetString keyGenParameters)
		{
			this.value = keyGenParameters;
		}

		// Token: 0x0600421D RID: 16925 RVA: 0x0012A70C File Offset: 0x0012890C
		public PkiArchiveOptions(bool archiveRemGenPrivKey)
		{
			this.value = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(archiveRemGenPrivKey);
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x0012A720 File Offset: 0x00128920
		public virtual int Type
		{
			get
			{
				if (this.value is global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey)
				{
					return 0;
				}
				if (this.value is global::Org.BouncyCastle.Asn1.Asn1OctetString)
				{
					return 1;
				}
				return 2;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x0012A741 File Offset: 0x00128941
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x0012A74C File Offset: 0x0012894C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.value is global::Org.BouncyCastle.Asn1.Crmf.EncryptedKey)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.value);
			}
			if (this.value is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, this.value);
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, this.value);
		}

		// Token: 0x04001FD2 RID: 8146
		public const int encryptedPrivKey = 0;

		// Token: 0x04001FD3 RID: 8147
		public const int keyGenParameters = 1;

		// Token: 0x04001FD4 RID: 8148
		public const int archiveRemGenPrivKey = 2;

		// Token: 0x04001FD5 RID: 8149
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable value;
	}
}
