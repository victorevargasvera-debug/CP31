using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200004A RID: 74
	public interface INavigateAsync
	{
		// Token: 0x06000214 RID: 532
		void RequestNavigate(global::System.Uri target, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback);
	}
}
