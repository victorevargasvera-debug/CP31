using System;
using System.Collections.Generic;

namespace Autofac.Core
{
	// Token: 0x02000068 RID: 104
	public interface IComponentRegistration : global::System.IDisposable
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600026B RID: 619
		global::System.Guid Id { get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600026C RID: 620
		global::Autofac.Core.IInstanceActivator Activator { get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600026D RID: 621
		global::Autofac.Core.IComponentLifetime Lifetime { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600026E RID: 622
		global::Autofac.Core.InstanceSharing Sharing { get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600026F RID: 623
		global::Autofac.Core.InstanceOwnership Ownership { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000270 RID: 624
		global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> Services { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000271 RID: 625
		global::System.Collections.Generic.IDictionary<string, object> Metadata { get; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000272 RID: 626
		global::Autofac.Core.IComponentRegistration Target { get; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000273 RID: 627
		// (remove) Token: 0x06000274 RID: 628
		event global::System.EventHandler<global::Autofac.Core.PreparingEventArgs> Preparing;

		// Token: 0x06000275 RID: 629
		void RaisePreparing(global::Autofac.IComponentContext context, ref global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters);

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000276 RID: 630
		// (remove) Token: 0x06000277 RID: 631
		event global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>> Activating;

		// Token: 0x06000278 RID: 632
		void RaiseActivating(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, ref object instance);

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000279 RID: 633
		// (remove) Token: 0x0600027A RID: 634
		event global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>> Activated;

		// Token: 0x0600027B RID: 635
		void RaiseActivated(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, object instance);
	}
}
