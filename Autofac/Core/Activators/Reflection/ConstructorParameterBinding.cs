using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace Autofac.Core.Activators.Reflection
{
	// Token: 0x020000A6 RID: 166
	public class ConstructorParameterBinding
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000B870 File Offset: 0x00009A70
		public global::System.Reflection.ConstructorInfo TargetConstructor
		{
			get
			{
				return this._ci;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0000B878 File Offset: 0x00009A78
		public bool CanInstantiate { get; }

		// Token: 0x060003DC RID: 988 RVA: 0x0000B880 File Offset: 0x00009A80
		public ConstructorParameterBinding(global::System.Reflection.ConstructorInfo ci, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> availableParameters, global::Autofac.IComponentContext context)
		{
			if (ci == null)
			{
				throw new global::System.ArgumentNullException("ci");
			}
			if (availableParameters == null)
			{
				throw new global::System.ArgumentNullException("availableParameters");
			}
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			this.CanInstantiate = 1;
			this._ci = ci;
			global::System.Reflection.ParameterInfo[] parameters = ci.GetParameters();
			this._valueRetrievers = new global::System.Func<object>[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				global::System.Reflection.ParameterInfo parameterInfo = parameters[i];
				bool flag = false;
				using (global::System.Collections.Generic.IEnumerator<global::Autofac.Core.Parameter> enumerator = availableParameters.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Func<object> func;
						if (enumerator.Current.CanSupplyValue(parameterInfo, context, out func))
						{
							this._valueRetrievers[i] = func;
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					this.CanInstantiate = 0;
					this._firstNonBindableParameter = parameterInfo;
					return;
				}
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000B960 File Offset: 0x00009B60
		public object Instantiate()
		{
			if (!this.CanInstantiate)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.CannotInstantitate, new object[]
				{
					this.Description
				}));
			}
			object[] array = new object[this._valueRetrievers.Length];
			for (int i = 0; i < this._valueRetrievers.Length; i++)
			{
				array[i] = this._valueRetrievers[i]();
			}
			global::System.Func<object[], object> constructorInvoker;
			if (!global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding.ConstructorInvokers.TryGetValue(this.TargetConstructor, out constructorInvoker))
			{
				constructorInvoker = global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding.GetConstructorInvoker(this.TargetConstructor);
				global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding.ConstructorInvokers[this.TargetConstructor] = constructorInvoker;
			}
			object result;
			try
			{
				result = constructorInvoker(array);
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.ExceptionDuringInstantiation, new object[]
				{
					this.TargetConstructor,
					this.TargetConstructor.DeclaringType.Name
				}), ex.InnerException);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.ExceptionDuringInstantiation, new object[]
				{
					this.TargetConstructor,
					this.TargetConstructor.DeclaringType.Name
				}), innerException);
			}
			return result;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000BAA0 File Offset: 0x00009CA0
		public string Description
		{
			get
			{
				if (!this.CanInstantiate)
				{
					return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.NonBindableConstructor, new object[]
					{
						this._ci,
						this._firstNonBindableParameter
					});
				}
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Core.Activators.Reflection.ConstructorParameterBindingResources.BoundConstructor, new object[]
				{
					this._ci
				});
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000BAFB File Offset: 0x00009CFB
		public override string ToString()
		{
			return this.Description;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000BB04 File Offset: 0x00009D04
		private static global::System.Func<object[], object> GetConstructorInvoker(global::System.Reflection.ConstructorInfo constructorInfo)
		{
			global::System.Reflection.ParameterInfo[] parameters = constructorInfo.GetParameters();
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object[]), "args");
			global::System.Linq.Expressions.Expression[] array = new global::System.Linq.Expressions.Expression[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				global::System.Linq.Expressions.ConstantExpression index = global::System.Linq.Expressions.Expression.Constant(i);
				global::System.Type parameterType = parameters[i].ParameterType;
				global::System.Linq.Expressions.BinaryExpression binaryExpression = global::System.Linq.Expressions.Expression.ArrayIndex(parameterExpression, index);
				global::System.Linq.Expressions.UnaryExpression unaryExpression = parameterType.GetTypeInfo().IsPrimitive ? global::System.Linq.Expressions.Expression.Convert(global::Autofac.Core.Activators.Reflection.ConstructorParameterBinding.ConvertPrimitiveType(binaryExpression, parameterType), parameterType) : global::System.Linq.Expressions.Expression.Convert(binaryExpression, parameterType);
				array[i] = unaryExpression;
				if (parameterType.GetTypeInfo().IsValueType)
				{
					global::System.Linq.Expressions.BinaryExpression test = global::System.Linq.Expressions.Expression.Equal(binaryExpression, global::System.Linq.Expressions.Expression.Constant(null));
					array[i] = global::System.Linq.Expressions.Expression.Condition(test, global::System.Linq.Expressions.Expression.Default(parameterType), unaryExpression);
				}
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object[], object>>(global::System.Linq.Expressions.Expression.New(constructorInfo, array), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000BBE8 File Offset: 0x00009DE8
		public static global::System.Linq.Expressions.MethodCallExpression ConvertPrimitiveType(global::System.Linq.Expressions.Expression valueExpression, global::System.Type conversionType)
		{
			return global::System.Linq.Expressions.Expression.Call(typeof(global::System.Convert).GetRuntimeMethod("ChangeType", new global::System.Type[]
			{
				typeof(object),
				typeof(global::System.Type)
			}), valueExpression, global::System.Linq.Expressions.Expression.Constant(conversionType));
		}

		// Token: 0x04000100 RID: 256
		private readonly global::System.Reflection.ConstructorInfo _ci;

		// Token: 0x04000101 RID: 257
		private readonly global::System.Func<object>[] _valueRetrievers;

		// Token: 0x04000102 RID: 258
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Reflection.ConstructorInfo, global::System.Func<object[], object>> ConstructorInvokers = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Reflection.ConstructorInfo, global::System.Func<object[], object>>();

		// Token: 0x04000103 RID: 259
		private readonly global::System.Reflection.ParameterInfo _firstNonBindableParameter;
	}
}
