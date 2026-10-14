using System;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200072E RID: 1838
	public class EncKeyWithID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041F9 RID: 16889 RVA: 0x0012A19B File Offset: 0x0012839B
		public static global::Org.BouncyCastle.Asn1.Crmf.EncKeyWithID GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.EncKeyWithID)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.EncKeyWithID)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.EncKeyWithID(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x0012A1BC File Offset: 0x001283BC
		private EncKeyWithID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.privKeyInfo = global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo.GetInstance(seq[0]);
			if (seq.Count <= 1)
			{
				this.identifier = null;
				return;
			}
			if (!(seq[1] is global::Org.BouncyCastle.Asn1.DerUtf8String))
			{
				this.identifier = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[1]);
				return;
			}
			this.identifier = seq[1];
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x0012A220 File Offset: 0x00128420
		public EncKeyWithID(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privKeyInfo)
		{
			this.privKeyInfo = privKeyInfo;
			this.identifier = null;
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x0012A236 File Offset: 0x00128436
		public EncKeyWithID(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privKeyInfo, global::Org.BouncyCastle.Asn1.DerUtf8String str)
		{
			this.privKeyInfo = privKeyInfo;
			this.identifier = str;
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x0012A24C File Offset: 0x0012844C
		public EncKeyWithID(global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privKeyInfo, global::Org.BouncyCastle.Asn1.X509.GeneralName generalName)
		{
			this.privKeyInfo = privKeyInfo;
			this.identifier = generalName;
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x0012A262 File Offset: 0x00128462
		public virtual global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo PrivateKey
		{
			get
			{
				return this.privKeyInfo;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x0012A26A File Offset: 0x0012846A
		public virtual bool HasIdentifier
		{
			get
			{
				return this.identifier != null;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06004200 RID: 16896 RVA: 0x0012A275 File Offset: 0x00128475
		public virtual bool IsIdentifierUtf8String
		{
			get
			{
				return this.identifier is global::Org.BouncyCastle.Asn1.DerUtf8String;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06004201 RID: 16897 RVA: 0x0012A285 File Offset: 0x00128485
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Identifier
		{
			get
			{
				return this.identifier;
			}
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x0012A290 File Offset: 0x00128490
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.privKeyInfo
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.identifier
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001FC6 RID: 8134
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.PrivateKeyInfo privKeyInfo;

		// Token: 0x04001FC7 RID: 8135
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable identifier;
	}
}
