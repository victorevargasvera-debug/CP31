using System;
using System.Collections.Generic;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;

namespace Autofac.Features.GeneratedFactories
{
	// Token: 0x0200004C RID: 76
	public class GeneratedFactoryActivatorData : global::Autofac.Builder.IConcreteActivatorData
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00007BC1 File Offset: 0x00005DC1
		public GeneratedFactoryActivatorData(global::System.Type delegateType, global::Autofac.Core.Service productService)
		{
			if (delegateType == null)
			{
				throw new global::System.ArgumentNullException("delegateType");
			}
			if (productService == null)
			{
				throw new global::System.ArgumentNullException("productService");
			}
			this._delegateType = delegateType;
			this._productService = productService;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00007BFF File Offset: 0x00005DFF
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00007C07 File Offset: 0x00005E07
		public global::Autofac.Features.GeneratedFactories.ParameterMapping ParameterMapping { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00007C10 File Offset: 0x00005E10
		public global::Autofac.Core.IInstanceActivator Activator
		{
			get
			{
				global::Autofac.Features.GeneratedFactories.FactoryGenerator factory = new global::Autofac.Features.GeneratedFactories.FactoryGenerator(this._delegateType, this._productService, this.ParameterMapping);
				return new global::Autofac.Core.Activators.Delegate.DelegateActivator(this._delegateType, (global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => factory.GenerateFactory(c, p));
			}
		}

		// Token: 0x04000060 RID: 96
		private readonly global::System.Type _delegateType;

		// Token: 0x04000061 RID: 97
		private readonly global::Autofac.Core.Service _productService;
	}
}
