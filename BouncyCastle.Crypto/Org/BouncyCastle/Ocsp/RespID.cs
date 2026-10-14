using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E8 RID: 488
	public class RespID
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x0004F379 File Offset: 0x0004D579
		public RespID(global::Org.BouncyCastle.Asn1.Ocsp.ResponderID id)
		{
			this.id = id;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0004F388 File Offset: 0x0004D588
		public RespID(global::Org.BouncyCastle.Asn1.X509.X509Name name)
		{
			this.id = new global::Org.BouncyCastle.Asn1.Ocsp.ResponderID(name);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0004F39C File Offset: 0x0004D59C
		public RespID(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			try
			{
				global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo info = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
				byte[] keyHash = global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest("SHA1", info.PublicKeyData.GetBytes());
				this.id = new global::Org.BouncyCastle.Asn1.Ocsp.ResponderID(new global::Org.BouncyCastle.Asn1.DerOctetString(keyHash));
			}
			catch (global::System.Exception e)
			{
				string str = "problem creating ID: ";
				global::System.Exception ex = e;
				throw new global::Org.BouncyCastle.Ocsp.OcspException(str + ((ex != null) ? ex.ToString() : null), e);
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0004F410 File Offset: 0x0004D610
		public global::Org.BouncyCastle.Asn1.Ocsp.ResponderID ToAsn1Object()
		{
			return this.id;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0004F418 File Offset: 0x0004D618
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Ocsp.RespID other = obj as global::Org.BouncyCastle.Ocsp.RespID;
			return other != null && this.id.Equals(other.id);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0004F448 File Offset: 0x0004D648
		public override int GetHashCode()
		{
			return this.id.GetHashCode();
		}

		// Token: 0x040008FE RID: 2302
		internal readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponderID id;
	}
}
