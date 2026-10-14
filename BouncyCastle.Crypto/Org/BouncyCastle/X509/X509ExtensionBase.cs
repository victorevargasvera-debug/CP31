using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200001A RID: 26
	public abstract class X509ExtensionBase : global::Org.BouncyCastle.X509.IX509Extension
	{
		// Token: 0x06000129 RID: 297
		protected abstract global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions();

		// Token: 0x0600012A RID: 298 RVA: 0x00008714 File Offset: 0x00006914
		protected virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetExtensionOids(bool critical)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions = this.GetX509Extensions();
			if (extensions != null)
			{
				global::Org.BouncyCastle.Utilities.Collections.HashSet set = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in extensions.ExtensionOids)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
					if (extensions.GetExtension(oid).IsCritical == critical)
					{
						set.Add(oid.Id);
					}
				}
				return set;
			}
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008798 File Offset: 0x00006998
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetNonCriticalExtensionOids()
		{
			return this.GetExtensionOids(false);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000087A1 File Offset: 0x000069A1
		public virtual global::Org.BouncyCastle.Utilities.Collections.ISet GetCriticalExtensionOids()
		{
			return this.GetExtensionOids(true);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000087AA File Offset: 0x000069AA
		[global::System.Obsolete("Use version taking a DerObjectIdentifier instead")]
		public global::Org.BouncyCastle.Asn1.Asn1OctetString GetExtensionValue(string oid)
		{
			return this.GetExtensionValue(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid));
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000087B8 File Offset: 0x000069B8
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString GetExtensionValue(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extensions exts = this.GetX509Extensions();
			if (exts != null)
			{
				global::Org.BouncyCastle.Asn1.X509.X509Extension ext = exts.GetExtension(oid);
				if (ext != null)
				{
					return ext.Value;
				}
			}
			return null;
		}
	}
}
