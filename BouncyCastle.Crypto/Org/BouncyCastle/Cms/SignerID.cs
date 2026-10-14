using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000557 RID: 1367
	public class SignerID : global::Org.BouncyCastle.X509.Store.X509CertStoreSelector
	{
		// Token: 0x06003468 RID: 13416 RVA: 0x000FA68C File Offset: 0x000F888C
		public override int GetHashCode()
		{
			int code = global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(base.SubjectKeyIdentifier);
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

		// Token: 0x06003469 RID: 13417 RVA: 0x000FA6CC File Offset: 0x000F88CC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return false;
			}
			global::Org.BouncyCastle.Cms.SignerID id = obj as global::Org.BouncyCastle.Cms.SignerID;
			return id != null && (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(base.SubjectKeyIdentifier, id.SubjectKeyIdentifier) && object.Equals(base.SerialNumber, id.SerialNumber)) && global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.IssuersMatch(base.Issuer, id.Issuer);
		}
	}
}
