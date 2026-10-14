using System;

namespace Infragistics.Windows.Themes.Internal
{
	// Token: 0x020000BC RID: 188
	public class EditorsAssemblyResourceSetLoader : global::Infragistics.Windows.Themes.AssemblyResourceSetLoader
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x0002D77C File Offset: 0x0002B97C
		protected override void OnRegisterResourceSets(string groupingName)
		{
			if (groupingName == "Editors" || groupingName == null)
			{
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsGeneric.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOnyx.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsAero.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsRoyale.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaNormal.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaOlive.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaSilver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Black.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Silver.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsPrintBasic.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2010Blue.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsIGTheme.Locator>.Location);
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsMetro.Locator>.Location);
			}
		}
	}
}
