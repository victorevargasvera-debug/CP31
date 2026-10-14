using System;
using System.Collections.Generic;
using Autofac.Core;

namespace Autofac.Features.LightweightAdapters
{
	// Token: 0x02000041 RID: 65
	public class LightweightAdapterActivatorData
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x000070E2 File Offset: 0x000052E2
		public LightweightAdapterActivatorData(global::Autofac.Core.Service fromService, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, object, object> adapter)
		{
			this.FromService = fromService;
			this.Adapter = adapter;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000070F8 File Offset: 0x000052F8
		public global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, object, object> Adapter { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00007100 File Offset: 0x00005300
		public global::Autofac.Core.Service FromService { get; }
	}
}
