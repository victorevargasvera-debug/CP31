using System;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x0200019B RID: 411
	public abstract class PkixCertPathChecker
	{
		// Token: 0x06000F1B RID: 3867
		public abstract void Init(bool forward);

		// Token: 0x06000F1C RID: 3868
		public abstract bool IsForwardCheckingSupported();

		// Token: 0x06000F1D RID: 3869
		public abstract global::Org.BouncyCastle.Utilities.Collections.ISet GetSupportedExtensions();

		// Token: 0x06000F1E RID: 3870
		public abstract void Check(global::Org.BouncyCastle.X509.X509Certificate cert, global::Org.BouncyCastle.Utilities.Collections.ISet unresolvedCritExts);

		// Token: 0x06000F1F RID: 3871 RVA: 0x00038053 File Offset: 0x00036253
		public virtual object Clone()
		{
			return base.MemberwiseClone();
		}
	}
}
