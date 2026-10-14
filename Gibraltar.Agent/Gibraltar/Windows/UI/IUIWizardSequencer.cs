using System;

namespace Gibraltar.Windows.UI
{
	// Token: 0x0200016C RID: 364
	internal interface IUIWizardSequencer
	{
		// Token: 0x06000EFD RID: 3837
		void Initialize(global::Gibraltar.Windows.UI.WizardEngine engine, object request);

		// Token: 0x06000EFE RID: 3838
		global::Gibraltar.Windows.UI.IUIWizardPage MoveNext();

		// Token: 0x06000EFF RID: 3839
		global::Gibraltar.Windows.UI.IUIWizardInputPage MovePrevious();
	}
}
