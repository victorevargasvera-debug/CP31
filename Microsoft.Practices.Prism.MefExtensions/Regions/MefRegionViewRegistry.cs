using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x02000020 RID: 32
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry))]
	public class MefRegionViewRegistry : global::Microsoft.Practices.Prism.Regions.RegionViewRegistry
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000030B1 File Offset: 0x000012B1
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefRegionViewRegistry(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator) : base(serviceLocator)
		{
		}
	}
}
