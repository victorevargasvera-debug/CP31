using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x0200001B RID: 27
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory))]
	public class MefRegionBehaviorFactory : global::Microsoft.Practices.Prism.Regions.RegionBehaviorFactory
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00003085 File Offset: 0x00001285
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefRegionBehaviorFactory(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator) : base(serviceLocator)
		{
		}
	}
}
