using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.GeneratedFactories
{
	// Token: 0x0200004B RID: 75
	public class FactoryGenerator
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00007894 File Offset: 0x00005A94
		public FactoryGenerator(global::System.Type delegateType, global::Autofac.Core.Service service, global::Autofac.Features.GeneratedFactories.ParameterMapping parameterMapping)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			global::Autofac.Util.Enforce.ArgumentTypeIsFunction(delegateType);
			this._generator = global::Autofac.Features.GeneratedFactories.FactoryGenerator.CreateGenerator(delegate(global::System.Linq.Expressions.Expression activatorContextParam, global::System.Linq.Expressions.Expression[] resolveParameterArray)
			{
				global::System.Linq.Expressions.Expression[] arguments = new global::System.Linq.Expressions.Expression[]
				{
					activatorContextParam,
					global::System.Linq.Expressions.Expression.Constant(service, typeof(global::Autofac.Core.Service)),
					global::System.Linq.Expressions.Expression.NewArrayInit(typeof(global::Autofac.Core.Parameter), resolveParameterArray)
				};
				return global::System.Linq.Expressions.Expression.Call(global::Autofac.Util.ReflectionExtensions.GetMethod<global::Autofac.IComponentContext>((global::Autofac.IComponentContext cc) => cc.ResolveService(null, null)), arguments);
			}, delegateType, global::Autofac.Features.GeneratedFactories.FactoryGenerator.GetParameterMapping(delegateType, parameterMapping));
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000078F4 File Offset: 0x00005AF4
		public FactoryGenerator(global::System.Type delegateType, global::Autofac.Core.IComponentRegistration productRegistration, global::Autofac.Features.GeneratedFactories.ParameterMapping parameterMapping)
		{
			if (productRegistration == null)
			{
				throw new global::System.ArgumentNullException("productRegistration");
			}
			global::Autofac.Util.Enforce.ArgumentTypeIsFunction(delegateType);
			this._generator = global::Autofac.Features.GeneratedFactories.FactoryGenerator.CreateGenerator(delegate(global::System.Linq.Expressions.Expression activatorContextParam, global::System.Linq.Expressions.Expression[] resolveParameterArray)
			{
				global::System.Linq.Expressions.Expression[] arguments = new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(productRegistration, typeof(global::Autofac.Core.IComponentRegistration)),
					global::System.Linq.Expressions.Expression.NewArrayInit(typeof(global::Autofac.Core.Parameter), resolveParameterArray)
				};
				return global::System.Linq.Expressions.Expression.Call(activatorContextParam, global::Autofac.Util.ReflectionExtensions.GetMethod<global::Autofac.IComponentContext>((global::Autofac.IComponentContext cc) => cc.ResolveComponent(null, null)), arguments);
			}, delegateType, global::Autofac.Features.GeneratedFactories.FactoryGenerator.GetParameterMapping(delegateType, parameterMapping));
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000794C File Offset: 0x00005B4C
		private static global::Autofac.Features.GeneratedFactories.ParameterMapping GetParameterMapping(global::System.Type delegateType, global::Autofac.Features.GeneratedFactories.ParameterMapping configuredParameterMapping)
		{
			if (configuredParameterMapping != global::Autofac.Features.GeneratedFactories.ParameterMapping.Adaptive)
			{
				return configuredParameterMapping;
			}
			if (!global::Autofac.Features.GeneratedFactories.FactoryGenerator.DelegateTypeIsFunc(delegateType))
			{
				return global::Autofac.Features.GeneratedFactories.ParameterMapping.ByName;
			}
			return global::Autofac.Features.GeneratedFactories.ParameterMapping.ByType;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000795E File Offset: 0x00005B5E
		private static bool DelegateTypeIsFunc(global::System.Type delegateType)
		{
			return delegateType.Name.StartsWith("Func`", global::System.StringComparison.Ordinal);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007974 File Offset: 0x00005B74
		private static global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, global::System.Delegate> CreateGenerator(global::System.Func<global::System.Linq.Expressions.Expression, global::System.Linq.Expressions.Expression[], global::System.Linq.Expressions.Expression> makeResolveCall, global::System.Type delegateType, global::Autofac.Features.GeneratedFactories.ParameterMapping pm)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(global::Autofac.IComponentContext), "c");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>), "p");
			global::System.Linq.Expressions.ParameterExpression[] parameters = new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			};
			global::System.Reflection.MethodInfo declaredMethod = delegateType.GetTypeInfo().GetDeclaredMethod("Invoke");
			global::System.Collections.Generic.List<global::System.Linq.Expressions.ParameterExpression> list = (from pi in declaredMethod.GetParameters()
			select global::System.Linq.Expressions.Expression.Parameter(pi.ParameterType, pi.Name)).ToList<global::System.Linq.Expressions.ParameterExpression>();
			global::System.Linq.Expressions.Expression expression = null;
			if (global::Autofac.Features.GeneratedFactories.FactoryGenerator.DelegateTypeIsFunc(delegateType) && pm == global::Autofac.Features.GeneratedFactories.ParameterMapping.ByType)
			{
				global::System.Type[] genericTypeArguments = delegateType.GetTypeInfo().GenericTypeArguments;
				global::System.Type type = genericTypeArguments.Last<global::System.Type>();
				global::System.Array.Resize<global::System.Type>(ref genericTypeArguments, genericTypeArguments.Length - 1);
				if (genericTypeArguments.Distinct<global::System.Type>().Count<global::System.Type>() != genericTypeArguments.Length)
				{
					expression = global::System.Linq.Expressions.Expression.Throw(global::System.Linq.Expressions.Expression.Constant(new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.GeneratedFactories.GeneratedFactoryRegistrationSourceResources.DuplicateTypesInTypeMappedFuncParameterList, new object[]
					{
						type.AssemblyQualifiedName,
						string.Join(", ", genericTypeArguments.Cast<object>().ToArray<object>())
					}))), declaredMethod.ReturnType);
				}
			}
			if (expression == null)
			{
				global::System.Linq.Expressions.Expression[] arg = global::Autofac.Features.GeneratedFactories.FactoryGenerator.MapParameters(list, pm);
				expression = global::System.Linq.Expressions.Expression.Convert(makeResolveCall(parameterExpression, arg), declaredMethod.ReturnType);
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, global::System.Delegate>>(global::System.Linq.Expressions.Expression.Lambda(delegateType, expression, list), parameters).Compile();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007AD0 File Offset: 0x00005CD0
		private static global::System.Linq.Expressions.Expression[] MapParameters(global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.ParameterExpression> creatorParams, global::Autofac.Features.GeneratedFactories.ParameterMapping pm)
		{
			switch (pm)
			{
			case global::Autofac.Features.GeneratedFactories.ParameterMapping.ByType:
				return (from p in creatorParams
				select global::System.Linq.Expressions.Expression.New(typeof(global::Autofac.TypedParameter).GetMatchingConstructor(new global::System.Type[]
				{
					typeof(global::System.Type),
					typeof(object)
				}), new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(p.Type, typeof(global::System.Type)),
					global::System.Linq.Expressions.Expression.Convert(p, typeof(object))
				})).OfType<global::System.Linq.Expressions.Expression>().ToArray<global::System.Linq.Expressions.Expression>();
			case global::Autofac.Features.GeneratedFactories.ParameterMapping.ByPosition:
				return creatorParams.Select((global::System.Linq.Expressions.ParameterExpression p, int i) => global::System.Linq.Expressions.Expression.New(typeof(global::Autofac.PositionalParameter).GetMatchingConstructor(new global::System.Type[]
				{
					typeof(int),
					typeof(object)
				}), new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(i, typeof(int)),
					global::System.Linq.Expressions.Expression.Convert(p, typeof(object))
				})).OfType<global::System.Linq.Expressions.Expression>().ToArray<global::System.Linq.Expressions.Expression>();
			}
			return (from p in creatorParams
			select global::System.Linq.Expressions.Expression.New(typeof(global::Autofac.NamedParameter).GetMatchingConstructor(new global::System.Type[]
			{
				typeof(string),
				typeof(object)
			}), new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(p.Name, typeof(string)),
				global::System.Linq.Expressions.Expression.Convert(p, typeof(object))
			})).OfType<global::System.Linq.Expressions.Expression>().ToArray<global::System.Linq.Expressions.Expression>();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00007B82 File Offset: 0x00005D82
		public global::System.Delegate GenerateFactory(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			return this._generator(context.Resolve<global::Autofac.ILifetimeScope>(), parameters);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007BB2 File Offset: 0x00005DB2
		public TDelegate GenerateFactory<TDelegate>(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters) where TDelegate : class
		{
			return (TDelegate)((object)this.GenerateFactory(context, parameters));
		}

		// Token: 0x0400005F RID: 95
		private readonly global::System.Func<global::Autofac.IComponentContext, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter>, global::System.Delegate> _generator;
	}
}
