using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000060 RID: 96
	public interface INavigationAware
	{
		// Token: 0x060002CD RID: 717
		void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext);

		// Token: 0x060002CE RID: 718
		bool IsNavigationTarget(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext);

		// Token: 0x060002CF RID: 719
		void OnNavigatedFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext);
	}
}
