using System;

namespace Infragistics.Windows.Themes.Internal
{
	// Token: 0x020002C0 RID: 704
	public class WindowsAssemblyResourceSetLoader : global::Infragistics.Windows.Themes.AssemblyResourceSetLoader
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x000687EC File Offset: 0x000669EC
		protected override void OnRegisterResourceSets(string groupingName)
		{
			if (groupingName == "Primitives" || groupingName == null)
			{
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOnyx.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesAero.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesRoyale.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaNormal.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaOlive.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaSilver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesMetro.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesMetroDark.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2013.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesIGTheme.Locator>.Location);
			}
		}
	}
}
