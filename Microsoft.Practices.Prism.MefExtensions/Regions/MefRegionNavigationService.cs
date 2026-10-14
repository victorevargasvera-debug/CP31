using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x0200001F RID: 31
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.IRegionNavigationService))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	public class MefRegionNavigationService : global::Microsoft.Practices.Prism.Regions.RegionNavigationService
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000030A6 File Offset: 0x000012A6
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefRegionNavigationService(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator, global::Microsoft.Practices.Prism.Regions.IRegionNavigationContentLoader navigationContentLoader, global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal journal) : base(serviceLocator, navigationContentLoader, journal)
		{
		}
	}
}
