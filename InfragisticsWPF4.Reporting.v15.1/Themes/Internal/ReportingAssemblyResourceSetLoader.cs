using System;

namespace Infragistics.Windows.Themes.Internal
{
	// Token: 0x0200001A RID: 26
	public class ReportingAssemblyResourceSetLoader : global::Infragistics.Windows.Themes.AssemblyResourceSetLoader
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0000634E File Offset: 0x0000454E
		protected override void OnRegisterResourceSets(string groupingName)
		{
			if (groupingName == "Reporting" || groupingName == null)
			{
				global::Infragistics.Windows.Themes.AssemblyResourceSetLoader.RegisterResourceSet(global::Infragistics.Windows.Themes.ReportingResourceSet<global::Infragistics.Windows.Themes.ReportingGeneric.Locator>.Location);
			}
		}
	}
}
