using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001EE RID: 494
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public enum LicenseStatus
	{
		// Token: 0x0400097F RID: 2431
		Unchecked,
		// Token: 0x04000980 RID: 2432
		UnableToLocateLicenseAssembly,
		// Token: 0x04000981 RID: 2433
		InsufficientSecurityPermissions,
		// Token: 0x04000982 RID: 2434
		RegKeyNotFound,
		// Token: 0x04000983 RID: 2435
		CDKeyInvalid,
		// Token: 0x04000984 RID: 2436
		BetaExpired,
		// Token: 0x04000985 RID: 2437
		BetaValid,
		// Token: 0x04000986 RID: 2438
		TrialExpired,
		// Token: 0x04000987 RID: 2439
		ActivationGracePeriodExpired,
		// Token: 0x04000988 RID: 2440
		CDKeyValid,
		// Token: 0x04000989 RID: 2441
		TrialValid,
		// Token: 0x0400098A RID: 2442
		ActivationGracePeriodValid,
		// Token: 0x0400098B RID: 2443
		Licensed
	}
}
