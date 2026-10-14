using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200054C RID: 1356
	public class OriginatorID : global::Org.BouncyCastle.X509.Store.X509CertStoreSelector
	{
		// Token: 0x06003434 RID: 13364 RVA: 0x000F9D88 File Offset: 0x000F7F88
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

		// Token: 0x06003435 RID: 13365 RVA: 0x000F9DC8 File Offset: 0x000F7FC8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return false;
			}
			global::Org.BouncyCastle.Cms.OriginatorID id = obj as global::Org.BouncyCastle.Cms.OriginatorID;
			return id != null && (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(base.SubjectKeyIdentifier, id.SubjectKeyIdentifier) && object.Equals(base.SerialNumber, id.SerialNumber)) && global::Org.BouncyCastle.X509.Store.X509CertStoreSelector.IssuersMatch(base.Issuer, id.Issuer);
		}
	}
}
