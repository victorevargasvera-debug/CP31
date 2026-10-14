using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000553 RID: 1363
	public class RecipientID : global::Org.BouncyCastle.X509.Store.X509CertStoreSelector
	{
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x000FA320 File Offset: 0x000F8520
		// (set) Token: 0x06003453 RID: 13395 RVA: 0x000FA32D File Offset: 0x000F852D
		public byte[] KeyIdentifier
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.keyIdentifier);
			}
			set
			{
				this.keyIdentifier = global::Org.BouncyCastle.Utilities.Arrays.Clone(value);
			}
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x000FA33C File Offset: 0x000F853C
		public override int GetHashCode()
		{
			int code = global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.keyIdentifier) ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(base.SubjectKeyIdentifier);
			global::Org.BouncyCastle.Math.BigInteger serialNumber = base.SerialNumber;
			if (serialNumber != null)
			{
				code ^= serialNumber.GetHashCode();
			}
			global::Org.BouncyCastle.Asn1.X509.X509Name issuer = base.Issuer;
			if (issuer != null)
			{
				code ^= issuer.GetHashCode();
			}
			return code;
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x000FA388 File Offset: 0x000F8588
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Cms.RecipientID id = obj as global::Org.BouncyCastle.Cms.RecipientID;
			return id != null && (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.keyIdentifier, id.keyIdentifier) && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(base.SubjectKeyIdentifier, id.SubjectKeyIdentifier) && object.Equals(base.SerialNumber, id.SerialNumber)) && global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.IssuersMatch(base.Issuer, id.Issuer);
		}

		// Token: 0x04001766 RID: 5990
		private byte[] keyIdentifier;
	}
}
