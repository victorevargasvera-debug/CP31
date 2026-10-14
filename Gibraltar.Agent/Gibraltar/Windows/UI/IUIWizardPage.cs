using System;

namespace Gibraltar.Windows.UI
{
	// Token: 0x0200016F RID: 367
	internal interface IUIWizardPage
	{
		// Token: 0x06000F03 RID: 3843
		void Initialize(object requestData);

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000F04 RID: 3844
		string Name { get; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000F05 RID: 3845
		string Title { get; }

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000F06 RID: 3846
		string Instructions { get; }

		// Token: 0x06000F07 RID: 3847
		void OnEnter();

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000F08 RID: 3848
		// (remove) Token: 0x06000F09 RID: 3849
		event global::System.EventHandler IsValidChanged;

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000F0A RID: 3850
		bool IsValid { get; }
	}
}
