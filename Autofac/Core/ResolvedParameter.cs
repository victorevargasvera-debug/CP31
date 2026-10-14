using System;
using System.Reflection;

namespace Autofac.Core
{
	// Token: 0x02000077 RID: 119
	public class ResolvedParameter : global::Autofac.Core.Parameter
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00008B2B File Offset: 0x00006D2B
		public ResolvedParameter(global::System.Func<global::System.Reflection.ParameterInfo, global::Autofac.IComponentContext, bool> predicate, global::System.Func<global::System.Reflection.ParameterInfo, global::Autofac.IComponentContext, object> valueAccessor)
		{
			if (predicate == null)
			{
				throw new global::System.ArgumentNullException("predicate");
			}
			if (valueAccessor == null)
			{
				throw new global::System.ArgumentNullException("valueAccessor");
			}
			this._predicate = predicate;
			this._valueAccessor = valueAccessor;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00008B60 File Offset: 0x00006D60
		public override bool CanSupplyValue(global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext context, out global::System.Func<object> valueProvider)
		{
			if (pi == null)
			{
				throw new global::System.ArgumentNullException("pi");
			}
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (this._predicate(pi, context))
			{
				valueProvider = (() => this._valueAccessor(pi, context));
				return true;
			}
			valueProvider = null;
			return false;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00008BDB File Offset: 0x00006DDB
		public static global::Autofac.Core.ResolvedParameter ForNamed<TService>(string serviceName)
		{
			if (serviceName == null)
			{
				throw new global::System.ArgumentNullException("serviceName");
			}
			return global::Autofac.Core.ResolvedParameter.ForKeyed<TService>(serviceName);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00008BF4 File Offset: 0x00006DF4
		public static global::Autofac.Core.ResolvedParameter ForKeyed<TService>(object serviceKey)
		{
			if (serviceKey == null)
			{
				throw new global::System.ArgumentNullException("serviceKey");
			}
			global::Autofac.Core.KeyedService ks = new global::Autofac.Core.KeyedService(serviceKey, typeof(TService));
			return new global::Autofac.Core.ResolvedParameter((global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext c) => pi.ParameterType == typeof(TService) && c.IsRegisteredService(ks), (global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext c) => c.ResolveService(ks));
		}

		// Token: 0x04000097 RID: 151
		private readonly global::System.Func<global::System.Reflection.ParameterInfo, global::Autofac.IComponentContext, bool> _predicate;

		// Token: 0x04000098 RID: 152
		private readonly global::System.Func<global::System.Reflection.ParameterInfo, global::Autofac.IComponentContext, object> _valueAccessor;
	}
}
