using System;
using System.Collections;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x02000193 RID: 403
	public abstract class PkixAttrCertChecker
	{
		// Token: 0x06000EF2 RID: 3826
		public abstract global::Org.BouncyCastle.Utilities.Collections.ISet GetSupportedExtensions();

		// Token: 0x06000EF3 RID: 3827
		public abstract void Check(global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert, global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.PkixCertPath holderCertPath, global::System.Collections.ICollection unresolvedCritExts);

		// Token: 0x06000EF4 RID: 3828
		public abstract global::Org.BouncyCastle.Pkix.PkixAttrCertChecker Clone();
	}
}
