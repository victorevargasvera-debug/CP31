using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200006A RID: 106
	public static class NavigationAsyncExtensions
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x00008B0D File Offset: 0x00006D0D
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.INavigateAsync navigation, string target)
		{
			navigation.RequestNavigate(target, delegate(global::Microsoft.Practices.Prism.Regions.NavigationResult nr)
			{
			});
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00008B34 File Offset: 0x00006D34
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.INavigateAsync navigation, string target, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			if (navigation == null)
			{
				throw new global::System.ArgumentNullException("navigation");
			}
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			global::System.Uri target2 = new global::System.Uri(target, global::System.UriKind.RelativeOrAbsolute);
			navigation.RequestNavigate(target2, navigationCallback);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00008B6F File Offset: 0x00006D6F
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.INavigateAsync navigation, global::System.Uri target)
		{
			if (navigation == null)
			{
				throw new global::System.ArgumentNullException("navigation");
			}
			navigation.RequestNavigate(target, delegate(global::Microsoft.Practices.Prism.Regions.NavigationResult nr)
			{
			});
		}
	}
}
