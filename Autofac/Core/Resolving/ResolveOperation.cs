using System;
using System.Collections.Generic;

namespace Autofac.Core.Resolving
{
	// Token: 0x02000086 RID: 134
	internal class ResolveOperation : global::Autofac.IComponentContext, global::Autofac.Core.Resolving.IResolveOperation
	{
		// Token: 0x06000301 RID: 769 RVA: 0x000095BE File Offset: 0x000077BE
		public ResolveOperation(global::Autofac.Core.ISharingLifetimeScope mostNestedLifetimeScope)
		{
			this._mostNestedLifetimeScope = mostNestedLifetimeScope;
			this.ResetSuccessfulActivations();
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000095DE File Offset: 0x000077DE
		public object ResolveComponent(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return this.GetOrCreateInstance(this._mostNestedLifetimeScope, registration, parameters);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000095F0 File Offset: 0x000077F0
		public object Execute(global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			object result;
			try
			{
				result = this.ResolveComponent(registration, parameters);
			}
			catch (global::Autofac.Core.DependencyResolutionException exception)
			{
				this.End(exception);
				throw;
			}
			catch (global::System.Exception ex)
			{
				this.End(ex);
				throw new global::Autofac.Core.DependencyResolutionException(global::Autofac.Core.Resolving.ResolveOperationResources.ExceptionDuringResolve, ex);
			}
			this.End(null);
			return result;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000964C File Offset: 0x0000784C
		public object GetOrCreateInstance(global::Autofac.Core.ISharingLifetimeScope currentOperationScope, global::Autofac.Core.IComponentRegistration registration, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (this._ended)
			{
				throw new global::System.ObjectDisposedException(global::Autofac.Core.Resolving.ResolveOperationResources.TemporaryContextDisposed, null);
			}
			this._callDepth++;
			if (this._activationStack.Count > 0)
			{
				global::Autofac.Core.Resolving.CircularDependencyDetector.CheckForCircularDependency(registration, this._activationStack, this._callDepth);
			}
			global::Autofac.Core.Resolving.InstanceLookup instanceLookup = new global::Autofac.Core.Resolving.InstanceLookup(registration, this, currentOperationScope, parameters);
			this._activationStack.Push(instanceLookup);
			global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupBeginningEventArgs> instanceLookupBeginning = this.InstanceLookupBeginning;
			if (instanceLookupBeginning != null)
			{
				instanceLookupBeginning(this, new global::Autofac.Core.Resolving.InstanceLookupBeginningEventArgs(instanceLookup));
			}
			object result = instanceLookup.Execute();
			this._successfulActivations.Add(instanceLookup);
			this._activationStack.Pop();
			if (this._activationStack.Count == 0)
			{
				this.CompleteActivations();
			}
			this._callDepth--;
			return result;
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000305 RID: 773 RVA: 0x00009708 File Offset: 0x00007908
		// (remove) Token: 0x06000306 RID: 774 RVA: 0x00009740 File Offset: 0x00007940
		public event global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationEndingEventArgs> CurrentOperationEnding;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000307 RID: 775 RVA: 0x00009778 File Offset: 0x00007978
		// (remove) Token: 0x06000308 RID: 776 RVA: 0x000097B0 File Offset: 0x000079B0
		public event global::System.EventHandler<global::Autofac.Core.Resolving.InstanceLookupBeginningEventArgs> InstanceLookupBeginning;

		// Token: 0x06000309 RID: 777 RVA: 0x000097E8 File Offset: 0x000079E8
		private void CompleteActivations()
		{
			global::System.Collections.Generic.List<global::Autofac.Core.Resolving.InstanceLookup> successfulActivations = this._successfulActivations;
			int count = successfulActivations.Count;
			this.ResetSuccessfulActivations();
			for (int i = 0; i < count; i++)
			{
				successfulActivations[i].Complete();
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00009821 File Offset: 0x00007A21
		private void ResetSuccessfulActivations()
		{
			this._successfulActivations = new global::System.Collections.Generic.List<global::Autofac.Core.Resolving.InstanceLookup>();
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000982E File Offset: 0x00007A2E
		public global::Autofac.Core.IComponentRegistry ComponentRegistry
		{
			get
			{
				return this._mostNestedLifetimeScope.ComponentRegistry;
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000983B File Offset: 0x00007A3B
		private void End(global::System.Exception exception = null)
		{
			if (this._ended)
			{
				return;
			}
			this._ended = true;
			global::System.EventHandler<global::Autofac.Core.Resolving.ResolveOperationEndingEventArgs> currentOperationEnding = this.CurrentOperationEnding;
			if (currentOperationEnding == null)
			{
				return;
			}
			currentOperationEnding(this, new global::Autofac.Core.Resolving.ResolveOperationEndingEventArgs(this, exception));
		}

		// Token: 0x040000B0 RID: 176
		private readonly global::System.Collections.Generic.Stack<global::Autofac.Core.Resolving.InstanceLookup> _activationStack = new global::System.Collections.Generic.Stack<global::Autofac.Core.Resolving.InstanceLookup>();

		// Token: 0x040000B1 RID: 177
		private global::System.Collections.Generic.List<global::Autofac.Core.Resolving.InstanceLookup> _successfulActivations;

		// Token: 0x040000B2 RID: 178
		private readonly global::Autofac.Core.ISharingLifetimeScope _mostNestedLifetimeScope;

		// Token: 0x040000B3 RID: 179
		private int _callDepth;

		// Token: 0x040000B4 RID: 180
		private bool _ended;
	}
}
