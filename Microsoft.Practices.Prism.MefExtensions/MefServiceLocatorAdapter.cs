using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.MefExtensions
{
	// Token: 0x0200000A RID: 10
	public class MefServiceLocatorAdapter : global::Microsoft.Practices.ServiceLocation.ServiceLocatorImplBase
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002C79 File Offset: 0x00000E79
		public MefServiceLocatorAdapter(global::System.ComponentModel.Composition.Hosting.CompositionContainer compositionContainer)
		{
			this.compositionContainer = compositionContainer;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002C90 File Offset: 0x00000E90
		protected override global::System.Collections.Generic.IEnumerable<object> DoGetAllInstances(global::System.Type serviceType)
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			global::System.Collections.Generic.IEnumerable<global::System.Lazy<object, object>> exports = this.compositionContainer.GetExports(serviceType, null, null);
			if (exports != null)
			{
				list.AddRange(from export in exports
				select export.Value);
			}
			return list;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002CE0 File Offset: 0x00000EE0
		protected override object DoGetInstance(global::System.Type serviceType, string key)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Lazy<object, object>> exports = this.compositionContainer.GetExports(serviceType, null, key);
			if (exports != null && exports.Count<global::System.Lazy<object, object>>() > 0)
			{
				return exports.Single<global::System.Lazy<object, object>>().Value;
			}
			throw new global::Microsoft.Practices.ServiceLocation.ActivationException(this.FormatActivationExceptionMessage(new global::System.ComponentModel.Composition.CompositionException("Export not found"), serviceType, key));
		}

		// Token: 0x04000010 RID: 16
		private readonly global::System.ComponentModel.Composition.Hosting.CompositionContainer compositionContainer;
	}
}
