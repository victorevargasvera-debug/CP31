using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000080 RID: 128
	internal class InstanceLookup : global::Autofac.IComponentContext, global::Autofac.Core.Resolving.IInstanceLookup
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x00009050 File Offset: 0x00007250
		public InstanceLookup(global::Autofac.Core.IComponentRegistration registration, global::Autofac.Core.Resolving.IResolveOperation context, global::Autofac.Core.ISharingLifetimeScope mostNestedVisibleScope, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			this.Parameters = parameters;
			this.ComponentRegistration = registration;
			this._context = context;
			try
			{
				this._activationScope = this.ComponentRegistration.Lifetime.FindScope(mostNestedVisibleScope);
			}
			catch (global::Autofac.Core.DependencyResolutionException innerException)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (global::Autofac.Core.Service service in registration.Services)
				{
					stringBuilder.Append("- ");
					stringBuilder.AppendLine(service.Description);
				}
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Resolving.ComponentActivationResources.UnableToLocateLifetimeScope, new object[]
				{
					registration.Activator.LimitType,
					stringBuilder
				}), innerException);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00009128 File Offset: 0x00007328
		public object Execute()
		{
			if (this._executed)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Resolving.ComponentActivationResources.ActivationAlreadyExecuted, new object[]
				{
					this.ComponentRegistration
				}));
			}
			this._executed = true;
			object obj = (this.ComponentRegistration.Sharing == global::Autofac.Core.InstanceSharing.None) ? this.Activate(this.Parameters) : this._activationScope.GetOrCreateAndShare(this.ComponentRegistration.Id, () => this.Activate(this.Parameters));
			global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupEndingEventArgs> instanceLookupEnding = this.InstanceLookupEnding;
			if (instanceLookupEnding != null)
			{
				instanceLookupEnding(this, new global::Autofac.Core.Resolving.InstanceLookupEndingEventArgs(this, this.NewInstanceActivated));
			}
			this.StartStartableComponent(obj);
			return obj;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000091CC File Offset: 0x000073CC
		private void StartStartableComponent(object instance)
		{
			global::Autofac.IStartable startable;
			if ((startable = (instance as global::Autofac.IStartable)) != null)
			{
				if (this.ComponentRegistration.Services.Any(delegate(global::Autofac.Core.Service s)
				{
					global::Autofac.Core.TypedService typedService;
					return (typedService = (s as global::Autofac.Core.TypedService)) != null && typedService.ServiceType == typeof(global::Autofac.IStartable);
				}) && !this.ComponentRegistration.Metadata.ContainsKey("__AutoActivated") && this.ComponentRegistry.Properties.ContainsKey("__StartOnActivate"))
				{
					this.ComponentRegistration.Metadata["__AutoActivated"] = true;
					startable.Start();
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00009266 File Offset: 0x00007466
		private bool NewInstanceActivated
		{
			get
			{
				return this._newInstance != null;
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00009274 File Offset: 0x00007474
		private object Activate(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			this.ComponentRegistration.RaisePreparing(this, ref parameters);
			try
			{
				this._newInstance = this.ComponentRegistration.Activator.ActivateInstance(this, parameters);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Resolving.ComponentActivationResources.ErrorDuringActivation, new object[]
				{
					this.ComponentRegistration
				}), innerException);
			}
			if (this.ComponentRegistration.Ownership == global::Autofac.Core.InstanceOwnership.OwnedByLifetimeScope)
			{
				global::System.IDisposable disposable = this._newInstance as global::System.IDisposable;
				if (disposable != null)
				{
					this._activationScope.Disposer.AddInstanceForDisposal(disposable);
				}
			}
			this.ComponentRegistration.RaiseActivating(this, parameters, ref this._newInstance);
			return this._newInstance;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00009328 File Offset: 0x00007528
		public void Complete()
		{
			if (!this.NewInstanceActivated)
			{
				return;
			}
			global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupCompletionBeginningEventArgs> completionBeginning = this.CompletionBeginning;
			if (completionBeginning != null)
			{
				completionBeginning(this, new global::Autofac.Core.Resolving.InstanceLookupCompletionBeginningEventArgs(this));
			}
			this.ComponentRegistration.RaiseActivated(this, this.Parameters, this._newInstance);
			global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupCompletionEndingEventArgs> completionEnding = this.CompletionEnding;
			if (completionEnding == null)
			{
				return;
			}
			completionEnding(this, new global::Autofac.Core.Resolving.InstanceLookupCompletionEndingEventArgs(this));
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00009385 File Offset: 0x00007585
		public global::Autofac.Core.IComponentRegistry ComponentRegistry
		{
			get
			{
				return this._activationScope.ComponentRegistry;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00009392 File Offset: 0x00007592
		public object ResolveComponent(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return this._context.GetOrCreateInstance(this._activationScope, registration, parameters);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000093A7 File Offset: 0x000075A7
		public global::Autofac.Core.IComponentRegistration ComponentRegistration { get; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000093AF File Offset: 0x000075AF
		public global::Autofac.ILifetimeScope ActivationScope
		{
			get
			{
				return this._activationScope;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000093B7 File Offset: 0x000075B7
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> Parameters { get; }

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060002EC RID: 748 RVA: 0x000093C0 File Offset: 0x000075C0
		// (remove) Token: 0x060002ED RID: 749 RVA: 0x000093F8 File Offset: 0x000075F8
		public event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupEndingEventArgs> InstanceLookupEnding;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060002EE RID: 750 RVA: 0x00009430 File Offset: 0x00007630
		// (remove) Token: 0x060002EF RID: 751 RVA: 0x00009468 File Offset: 0x00007668
		public event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupCompletionBeginningEventArgs> CompletionBeginning;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060002F0 RID: 752 RVA: 0x000094A0 File Offset: 0x000076A0
		// (remove) Token: 0x060002F1 RID: 753 RVA: 0x000094D8 File Offset: 0x000076D8
		public event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupCompletionEndingEventArgs> CompletionEnding;

		// Token: 0x040000A2 RID: 162
		private readonly global::Autofac.Core.Resolving.IResolveOperation _context;

		// Token: 0x040000A3 RID: 163
		private readonly global::Autofac.Core.ISharingLifetimeScope _activationScope;

		// Token: 0x040000A4 RID: 164
		private object _newInstance;

		// Token: 0x040000A5 RID: 165
		private bool _executed;
	}
}
