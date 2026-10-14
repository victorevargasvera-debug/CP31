using System;
using System.Collections.Generic;
using System.Globalization;

namespace Autofac.Core.Activators.Delegate
{
	// Token: 0x020000B6 RID: 182
	public class DelegateActivator : global::Autofac.Core.Activators.InstanceActivator, global::Autofac.Core.IInstanceActivator, global::System.IDisposable
	{
		// Token: 0x06000429 RID: 1065 RVA: 0x0000C83D File Offset: 0x0000AA3D
		public DelegateActivator(global::System.Type limitType, global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, object> activationFunction) : base(limitType)
		{
			if (activationFunction == null)
			{
				throw new global::System.ArgumentNullException("activationFunction");
			}
			this._activationFunction = activationFunction;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000C85C File Offset: 0x0000AA5C
		public object ActivateInstance(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			object obj = this._activationFunction(context, parameters);
			if (obj == null)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Delegate.DelegateActivatorResources.NullFromActivationDelegateFor, new object[]
				{
					base.LimitType
				}));
			}
			return obj;
		}

		// Token: 0x0400011F RID: 287
		private readonly global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, object> _activationFunction;
	}
}
