using System;

namespace Infragistics.Windows.Themes.Internal
{
	// Token: 0x020000AC RID: 172
	public class DockManagerAssemblyResourceSetLoader : global::Infragistics.Windows.Themes.AssemblyResourceSetLoader
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0001DB60 File Offset: 0x0001BD60
		protected override void OnRegisterResourceSets(string groupingName)
		{
			if (groupingName == "DockManager" || groupingName == null)
			{
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerGeneric.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerAero.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerLunaNormal.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerLunaOlive.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerLunaSilver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2k7Black.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerRoyale.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2010Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2013.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerIGTheme.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerMetro.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerMetroDark.Locator>.Location);
			}
		}
	}
}
