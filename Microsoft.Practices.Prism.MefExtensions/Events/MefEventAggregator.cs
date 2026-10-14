using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Events;

namespace Microsoft.Practices.Prism.MefExtensions.Events
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Events.IEventAggregator))]
	public class MefEventAggregator : global::Microsoft.Practices.Prism.Events.EventAggregator
	{
	}
}
