using System;

namespace Gibraltar.Windows.UI
{
	// Token: 0x0200016D RID: 365
	internal interface IUIWizardFinishPage : global::Gibraltar.Windows.UI.IUIWizardPage
	{
		// Token: 0x06000F00 RID: 3840
		global::Gibraltar.AsyncTaskResultEventArgs Finish();

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06000F01 RID: 3841
		bool AutoClose { get; }
	}
}
