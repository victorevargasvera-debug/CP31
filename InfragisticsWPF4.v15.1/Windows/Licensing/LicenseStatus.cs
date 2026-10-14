using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x0200021E RID: 542
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public enum LicenseStatus
	{
		// Token: 0x04000ACA RID: 2762
		Unchecked,
		// Token: 0x04000ACB RID: 2763
		UnableToLocateLicenseAssembly,
		// Token: 0x04000ACC RID: 2764
		InsufficientSecurityPermissions,
		// Token: 0x04000ACD RID: 2765
		RegKeyNotFound,
		// Token: 0x04000ACE RID: 2766
		CDKeyInvalid,
		// Token: 0x04000ACF RID: 2767
		BetaExpired,
		// Token: 0x04000AD0 RID: 2768
		BetaValid,
		// Token: 0x04000AD1 RID: 2769
		TrialExpired,
		// Token: 0x04000AD2 RID: 2770
		ActivationGracePeriodExpired,
		// Token: 0x04000AD3 RID: 2771
		CDKeyValid,
		// Token: 0x04000AD4 RID: 2772
		TrialValid,
		// Token: 0x04000AD5 RID: 2773
		ActivationGracePeriodValid,
		// Token: 0x04000AD6 RID: 2774
		Licensed
	}
}
