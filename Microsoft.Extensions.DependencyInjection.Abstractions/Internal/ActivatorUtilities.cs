using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace Microsoft.Extensions.Internal
{
	// Token: 0x02000010 RID: 16
	internal static class ActivatorUtilities
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000031A4 File Offset: 0x000013A4
		internal static object CreateInstance(global::System.IServiceProvider provider, global::System.Type instanceType, params object[] parameters)
		{
			int num = -1;
			global::Microsoft.Extensions.Internal.ActivatorUtilities.ConstructorMatcher constructorMatcher = null;
			foreach (global::Microsoft.Extensions.Internal.ActivatorUtilities.ConstructorMatcher constructorMatcher2 in from c in instanceType.GetTypeInfo().DeclaredConstructors
			where !c.IsStatic && c.IsPublic
			select c into constructor
			select new global::Microsoft.Extensions.Internal.ActivatorUtilities.ConstructorMatcher(constructor))
			{
				int num2 = constructorMatcher2.Match(parameters);
				if (num2 != -1 && num < num2)
				{
					num = num2;
					constructorMatcher = constructorMatcher2;
				}
			}
			if (constructorMatcher == null)
			{
				throw new global::System.InvalidOperationException(string.Format("A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.", new object[]
				{
					instanceType
				}));
			}
			return constructorMatcher.CreateInstance(provider);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003278 File Offset: 0x00001478
		internal static global::Microsoft.Extensions.Internal.ObjectFactory CreateFactory(global::System.Type instanceType, global::System.Type[] argumentTypes)
		{
			global::System.Reflection.ConstructorInfo constructor;
			int?[] parameterMap;
			global::Microsoft.Extensions.Internal.ActivatorUtilities.FindApplicableConstructor(instanceType, argumentTypes, out constructor, out parameterMap);
			global::System.Linq.Expressions.ParameterExpression parameterExpression;
			global::System.Linq.Expressions.ParameterExpression parameterExpression2;
			return new global::Microsoft.Extensions.Internal.ObjectFactory(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.IServiceProvider, object[], object>>(global::Microsoft.Extensions.Internal.ActivatorUtilities.BuildFactoryExpression(constructor, parameterMap, parameterExpression, parameterExpression2), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile().Invoke);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000032E6 File Offset: 0x000014E6
		public static T CreateInstance<T>(global::System.IServiceProvider provider, params object[] parameters)
		{
			return (T)((object)global::Microsoft.Extensions.Internal.ActivatorUtilities.CreateInstance(provider, typeof(T), parameters));
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000032FE File Offset: 0x000014FE
		public static T GetServiceOrCreateInstance<T>(global::System.IServiceProvider provider)
		{
			return (T)((object)global::Microsoft.Extensions.Internal.ActivatorUtilities.GetServiceOrCreateInstance(provider, typeof(T)));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003315 File Offset: 0x00001515
		public static object GetServiceOrCreateInstance(global::System.IServiceProvider provider, global::System.Type type)
		{
			return provider.GetService(type) ?? global::Microsoft.Extensions.Internal.ActivatorUtilities.CreateInstance(provider, type, new object[0]);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000332F File Offset: 0x0000152F
		private static global::System.Reflection.MethodInfo GetMethodInfo<T>(global::System.Linq.Expressions.Expression<T> expr)
		{
			return ((global::System.Linq.Expressions.MethodCallExpression)expr.Body).Method;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003344 File Offset: 0x00001544
		private static object GetService(global::System.IServiceProvider sp, global::System.Type type, global::System.Type requiredBy, bool isDefaultParameterRequired)
		{
			object service = sp.GetService(type);
			if (service == null && !isDefaultParameterRequired)
			{
				throw new global::System.InvalidOperationException(string.Format("Unable to resolve service for type '{0}' while attempting to activate '{1}'.", new object[]
				{
					type,
					requiredBy
				}));
			}
			return service;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003380 File Offset: 0x00001580
		private static global::System.Linq.Expressions.Expression BuildFactoryExpression(global::System.Reflection.ConstructorInfo constructor, int?[] parameterMap, global::System.Linq.Expressions.Expression serviceProvider, global::System.Linq.Expressions.Expression factoryArgumentArray)
		{
			global::System.Reflection.ParameterInfo[] parameters = constructor.GetParameters();
			global::System.Linq.Expressions.Expression[] array = new global::System.Linq.Expressions.Expression[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				global::System.Type parameterType = parameters[i].ParameterType;
				if (parameterMap[i] != null)
				{
					array[i] = global::System.Linq.Expressions.Expression.ArrayAccess(factoryArgumentArray, new global::System.Linq.Expressions.Expression[]
					{
						global::System.Linq.Expressions.Expression.Constant(parameterMap[i])
					});
				}
				else
				{
					bool hasDefaultValue = parameters[i].HasDefaultValue;
					global::System.Linq.Expressions.Expression[] arguments = new global::System.Linq.Expressions.Expression[]
					{
						serviceProvider,
						global::System.Linq.Expressions.Expression.Constant(parameterType, typeof(global::System.Type)),
						global::System.Linq.Expressions.Expression.Constant(constructor.DeclaringType, typeof(global::System.Type)),
						global::System.Linq.Expressions.Expression.Constant(hasDefaultValue)
					};
					array[i] = global::System.Linq.Expressions.Expression.Call(global::Microsoft.Extensions.Internal.ActivatorUtilities.GetServiceInfo, arguments);
				}
				if (parameters[i].HasDefaultValue)
				{
					global::System.Linq.Expressions.ConstantExpression right = global::System.Linq.Expressions.Expression.Constant(parameters[i].DefaultValue);
					array[i] = global::System.Linq.Expressions.Expression.Coalesce(array[i], right);
				}
				array[i] = global::System.Linq.Expressions.Expression.Convert(array[i], parameterType);
			}
			return global::System.Linq.Expressions.Expression.New(constructor, array);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003488 File Offset: 0x00001688
		private static void FindApplicableConstructor(global::System.Type instanceType, global::System.Type[] argumentTypes, out global::System.Reflection.ConstructorInfo matchingConstructor, out int?[] parameterMap)
		{
			matchingConstructor = null;
			parameterMap = null;
			foreach (global::System.Reflection.ConstructorInfo constructorInfo in instanceType.GetTypeInfo().DeclaredConstructors)
			{
				int?[] array;
				if (!constructorInfo.IsStatic && constructorInfo.IsPublic && global::Microsoft.Extensions.Internal.ActivatorUtilities.TryCreateParameterMap(constructorInfo.GetParameters(), argumentTypes, out array))
				{
					if (matchingConstructor != null)
					{
						throw new global::System.InvalidOperationException(string.Format("Multiple constructors accepting all given argument types have been found in type '{0}'. There should only be one applicable constructor.", new object[]
						{
							instanceType
						}));
					}
					matchingConstructor = constructorInfo;
					parameterMap = array;
				}
			}
			if (matchingConstructor == null)
			{
				throw new global::System.InvalidOperationException(string.Format("A suitable constructor for type '{0}' could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor.", new object[]
				{
					instanceType
				}));
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000353C File Offset: 0x0000173C
		private static bool TryCreateParameterMap(global::System.Reflection.ParameterInfo[] constructorParameters, global::System.Type[] argumentTypes, out int?[] parameterMap)
		{
			parameterMap = new int?[constructorParameters.Length];
			for (int i = 0; i < argumentTypes.Length; i++)
			{
				bool flag = false;
				global::System.Reflection.TypeInfo typeInfo = argumentTypes[i].GetTypeInfo();
				for (int j = 0; j < constructorParameters.Length; j++)
				{
					if (parameterMap[j] == null && constructorParameters[j].ParameterType.GetTypeInfo().IsAssignableFrom(typeInfo))
					{
						flag = true;
						parameterMap[j] = new int?(i);
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400000B RID: 11
		private static readonly global::System.Reflection.MethodInfo GetServiceInfo = global::Microsoft.Extensions.Internal.ActivatorUtilities.GetMethodInfo<global::System.Func<global::System.IServiceProvider, global::System.Type, global::System.Type, bool, object>>((global::System.IServiceProvider sp, global::System.Type t, global::System.Type r, bool c) => global::Microsoft.Extensions.Internal.ActivatorUtilities.GetService(sp, t, r, c));

		// Token: 0x02000014 RID: 20
		private class ConstructorMatcher
		{
			// Token: 0x06000089 RID: 137 RVA: 0x000036C0 File Offset: 0x000018C0
			public ConstructorMatcher(global::System.Reflection.ConstructorInfo constructor)
			{
				this._constructor = constructor;
				this._parameters = this._constructor.GetParameters();
				this._parameterValuesSet = new bool[this._parameters.Length];
				this._parameterValues = new object[this._parameters.Length];
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00003714 File Offset: 0x00001914
			public int Match(object[] givenParameters)
			{
				int num = 0;
				int result = 0;
				for (int num2 = 0; num2 != givenParameters.Length; num2++)
				{
					global::System.Reflection.TypeInfo typeInfo = (givenParameters[num2] == null) ? null : givenParameters[num2].GetType().GetTypeInfo();
					bool flag = false;
					int num3 = num;
					while (!flag && num3 != this._parameters.Length)
					{
						if (!this._parameterValuesSet[num3] && this._parameters[num3].ParameterType.GetTypeInfo().IsAssignableFrom(typeInfo))
						{
							flag = true;
							this._parameterValuesSet[num3] = true;
							this._parameterValues[num3] = givenParameters[num2];
							if (num == num3)
							{
								num++;
								if (num3 == num2)
								{
									result = num3;
								}
							}
						}
						num3++;
					}
					if (!flag)
					{
						return -1;
					}
				}
				return result;
			}

			// Token: 0x0600008B RID: 139 RVA: 0x000037C4 File Offset: 0x000019C4
			public object CreateInstance(global::System.IServiceProvider provider)
			{
				for (int num = 0; num != this._parameters.Length; num++)
				{
					if (!this._parameterValuesSet[num])
					{
						object service = provider.GetService(this._parameters[num].ParameterType);
						if (service == null)
						{
							if (!this._parameters[num].HasDefaultValue)
							{
								throw new global::System.InvalidOperationException(string.Format("Unable to resolve service for type '{0}' while attempting to activate '{1}'.", new object[]
								{
									this._parameters[num].ParameterType,
									this._constructor.DeclaringType
								}));
							}
							this._parameterValues[num] = this._parameters[num].DefaultValue;
						}
						else
						{
							this._parameterValues[num] = service;
						}
					}
				}
				object result;
				try
				{
					result = this._constructor.Invoke(this._parameterValues);
				}
				catch (global::System.Exception ex)
				{
					global::System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
					throw;
				}
				return result;
			}

			// Token: 0x04000010 RID: 16
			private readonly global::System.Reflection.ConstructorInfo _constructor;

			// Token: 0x04000011 RID: 17
			private readonly global::System.Reflection.ParameterInfo[] _parameters;

			// Token: 0x04000012 RID: 18
			private readonly object[] _parameterValues;

			// Token: 0x04000013 RID: 19
			private readonly bool[] _parameterValuesSet;
		}
	}
}
