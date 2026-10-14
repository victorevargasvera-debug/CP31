using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000069 RID: 105
	public interface IConfirmNavigationRequest : global::Microsoft.Practices.Prism.Regions.INavigationAware
	{
		// Token: 0x060002F8 RID: 760
		void ConfirmNavigationRequest(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, global::System.Action<bool> continuationCallback);
	}
}
