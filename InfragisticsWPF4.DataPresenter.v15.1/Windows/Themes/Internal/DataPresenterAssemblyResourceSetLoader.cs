using System;

namespace Infragistics.Windows.Themes.Internal
{
	// Token: 0x02000370 RID: 880
	public class DataPresenterAssemblyResourceSetLoader : global::Infragistics.Windows.Themes.AssemblyResourceSetLoader
	{
		// Token: 0x06002B0F RID: 11023 RVA: 0x000BFA6C File Offset: 0x000BDC6C
		protected override void OnRegisterResourceSets(string groupingName)
		{
			if (groupingName == "DataPresenter" || groupingName == null)
			{
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOnyx.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterAero.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterRoyale.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaNormal.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaOlive.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaSilver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterPrintBasic.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2013.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterIGTheme.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterMetro.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterMetroDark.Locator>.Location);
			}
		}
	}
}
