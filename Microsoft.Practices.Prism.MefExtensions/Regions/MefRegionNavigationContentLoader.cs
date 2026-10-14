using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x02000019 RID: 25
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.IRegionNavigationContentLoader))]
	public class MefRegionNavigationContentLoader : global::Microsoft.Practices.Prism.Regions.RegionNavigationContentLoader
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00003074 File Offset: 0x00001274
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefRegionNavigationContentLoader(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator) : base(serviceLocator)
		{
		}
	}
}
