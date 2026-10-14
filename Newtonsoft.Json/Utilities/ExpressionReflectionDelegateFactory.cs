using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000058 RID: 88
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class ExpressionReflectionDelegateFactory : global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001599C File Offset: 0x00013B9C
		internal static global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory Instance
		{
			get
			{
				return global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory._instance;
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000159A4 File Offset: 0x00013BA4
		public override global::Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(global::System.Reflection.MethodBase method)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(method, "method");
			global::System.Type typeFromHandle = typeof(object);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object[]), "args");
			global::System.Linq.Expressions.Expression body = this.BuildMethodCall(method, typeFromHandle, null, parameterExpression);
			return (global::Newtonsoft.Json.Serialization.ObjectConstructor<object>)global::System.Linq.Expressions.Expression.Lambda(typeof(global::Newtonsoft.Json.Serialization.ObjectConstructor<object>), body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00015A0C File Offset: 0x00013C0C
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.MethodBase method)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(method, "method");
			global::System.Type typeFromHandle = typeof(object);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeFromHandle, "target");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object[]), "args");
			global::System.Linq.Expressions.Expression body = this.BuildMethodCall(method, typeFromHandle, parameterExpression, parameterExpression2);
			return (global::Newtonsoft.Json.Utilities.MethodCall<T, object>)global::System.Linq.Expressions.Expression.Lambda(typeof(global::Newtonsoft.Json.Utilities.MethodCall<T, object>), body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00015A84 File Offset: 0x00013C84
		private global::System.Linq.Expressions.Expression BuildMethodCall(global::System.Reflection.MethodBase method, global::System.Type type, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Linq.Expressions.ParameterExpression targetParameterExpression, global::System.Linq.Expressions.ParameterExpression argsParameterExpression)
		{
			global::System.Reflection.ParameterInfo[] parameters = method.GetParameters();
			global::System.Linq.Expressions.Expression[] array;
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.ByRefParameter> list;
			if (parameters.Length == 0)
			{
				array = global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<global::System.Linq.Expressions.Expression>();
				list = global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.ByRefParameter>();
			}
			else
			{
				array = new global::System.Linq.Expressions.Expression[parameters.Length];
				list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.ByRefParameter>();
				for (int i = 0; i < parameters.Length; i++)
				{
					global::System.Reflection.ParameterInfo parameterInfo = parameters[i];
					global::System.Type type2 = parameterInfo.ParameterType;
					bool flag = false;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
						flag = true;
					}
					global::System.Linq.Expressions.Expression index = global::System.Linq.Expressions.Expression.Constant(i);
					global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.ArrayIndex(argsParameterExpression, index);
					global::System.Linq.Expressions.Expression expression2 = this.EnsureCastExpression(expression, type2, !flag);
					if (flag)
					{
						global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Variable(type2);
						list.Add(new global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.ByRefParameter(expression2, parameterExpression, parameterInfo.IsOut));
						expression2 = parameterExpression;
					}
					array[i] = expression2;
				}
			}
			global::System.Linq.Expressions.Expression expression3;
			if (method.IsConstructor)
			{
				expression3 = global::System.Linq.Expressions.Expression.New((global::System.Reflection.ConstructorInfo)method, array);
			}
			else if (method.IsStatic)
			{
				expression3 = global::System.Linq.Expressions.Expression.Call((global::System.Reflection.MethodInfo)method, array);
			}
			else
			{
				expression3 = global::System.Linq.Expressions.Expression.Call(this.EnsureCastExpression(targetParameterExpression, method.DeclaringType, false), (global::System.Reflection.MethodInfo)method, array);
			}
			global::System.Reflection.MethodInfo methodInfo = method as global::System.Reflection.MethodInfo;
			if (methodInfo != null)
			{
				if (methodInfo.ReturnType != typeof(void))
				{
					expression3 = this.EnsureCastExpression(expression3, type, false);
				}
				else
				{
					expression3 = global::System.Linq.Expressions.Expression.Block(expression3, global::System.Linq.Expressions.Expression.Constant(null));
				}
			}
			else
			{
				expression3 = this.EnsureCastExpression(expression3, type, false);
			}
			if (list.Count > 0)
			{
				global::System.Collections.Generic.IList<global::System.Linq.Expressions.ParameterExpression> list2 = new global::System.Collections.Generic.List<global::System.Linq.Expressions.ParameterExpression>();
				global::System.Collections.Generic.IList<global::System.Linq.Expressions.Expression> list3 = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
				foreach (global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory.ByRefParameter byRefParameter in list)
				{
					if (!byRefParameter.IsOut)
					{
						list3.Add(global::System.Linq.Expressions.Expression.Assign(byRefParameter.Variable, byRefParameter.Value));
					}
					list2.Add(byRefParameter.Variable);
				}
				list3.Add(expression3);
				expression3 = global::System.Linq.Expressions.Expression.Block(list2, list3);
			}
			return expression3;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00015C7C File Offset: 0x00013E7C
		public override global::System.Func<T> CreateDefaultConstructor<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Type type)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			if (type.IsAbstract())
			{
				return () => (T)((object)global::System.Activator.CreateInstance(type));
			}
			global::System.Func<T> result;
			try
			{
				global::System.Type typeFromHandle = typeof(T);
				global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.New(type);
				expression = this.EnsureCastExpression(expression, typeFromHandle, false);
				result = (global::System.Func<T>)global::System.Linq.Expressions.Expression.Lambda(typeof(global::System.Func<T>), expression, new global::System.Linq.Expressions.ParameterExpression[0]).Compile();
			}
			catch
			{
				result = (() => (T)((object)global::System.Activator.CreateInstance(type)));
			}
			return result;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00015D28 File Offset: 0x00013F28
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			global::System.Type typeFromHandle = typeof(T);
			global::System.Type typeFromHandle2 = typeof(object);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeFromHandle, "instance");
			global::System.Reflection.MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new global::System.ArgumentException("Property does not have a getter.");
			}
			global::System.Linq.Expressions.Expression expression;
			if (getMethod.IsStatic)
			{
				expression = global::System.Linq.Expressions.Expression.MakeMemberAccess(null, propertyInfo);
			}
			else
			{
				expression = global::System.Linq.Expressions.Expression.MakeMemberAccess(this.EnsureCastExpression(parameterExpression, propertyInfo.DeclaringType, false), propertyInfo);
			}
			expression = this.EnsureCastExpression(expression, typeFromHandle2, false);
			return (global::System.Func<T, object>)global::System.Linq.Expressions.Expression.Lambda(typeof(global::System.Func<T, object>), expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00015DD0 File Offset: 0x00013FD0
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(fieldInfo, "fieldInfo");
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "source");
			global::System.Linq.Expressions.Expression expression;
			if (fieldInfo.IsStatic)
			{
				expression = global::System.Linq.Expressions.Expression.Field(null, fieldInfo);
			}
			else
			{
				expression = global::System.Linq.Expressions.Expression.Field(this.EnsureCastExpression(parameterExpression, fieldInfo.DeclaringType, false), fieldInfo);
			}
			expression = this.EnsureCastExpression(expression, typeof(object), false);
			return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<T, object>>(expression, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00015E4C File Offset: 0x0001404C
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(fieldInfo, "fieldInfo");
			if (fieldInfo.DeclaringType.IsValueType() || fieldInfo.IsInitOnly)
			{
				return global::Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.Instance.CreateSet<T>(fieldInfo);
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(T), "source");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "value");
			global::System.Linq.Expressions.Expression expression;
			if (fieldInfo.IsStatic)
			{
				expression = global::System.Linq.Expressions.Expression.Field(null, fieldInfo);
			}
			else
			{
				expression = global::System.Linq.Expressions.Expression.Field(this.EnsureCastExpression(parameterExpression, fieldInfo.DeclaringType, false), fieldInfo);
			}
			global::System.Linq.Expressions.Expression right = this.EnsureCastExpression(parameterExpression2, expression.Type, false);
			global::System.Linq.Expressions.BinaryExpression body = global::System.Linq.Expressions.Expression.Assign(expression, right);
			return (global::System.Action<T, object>)global::System.Linq.Expressions.Expression.Lambda(typeof(global::System.Action<T, object>), body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00015F18 File Offset: 0x00014118
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyInfo, "propertyInfo");
			if (propertyInfo.DeclaringType.IsValueType())
			{
				return global::Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.Instance.CreateSet<T>(propertyInfo);
			}
			global::System.Type typeFromHandle = typeof(T);
			global::System.Type typeFromHandle2 = typeof(object);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeFromHandle, "instance");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeFromHandle2, "value");
			global::System.Linq.Expressions.Expression expression = this.EnsureCastExpression(parameterExpression2, propertyInfo.PropertyType, false);
			global::System.Reflection.MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			if (setMethod == null)
			{
				throw new global::System.ArgumentException("Property does not have a setter.");
			}
			global::System.Linq.Expressions.Expression body;
			if (setMethod.IsStatic)
			{
				body = global::System.Linq.Expressions.Expression.Call(setMethod, expression);
			}
			else
			{
				body = global::System.Linq.Expressions.Expression.Call(this.EnsureCastExpression(parameterExpression, propertyInfo.DeclaringType, false), setMethod, new global::System.Linq.Expressions.Expression[]
				{
					expression
				});
			}
			return (global::System.Action<T, object>)global::System.Linq.Expressions.Expression.Lambda(typeof(global::System.Action<T, object>), body, new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00016004 File Offset: 0x00014204
		private global::System.Linq.Expressions.Expression EnsureCastExpression(global::System.Linq.Expressions.Expression expression, global::System.Type targetType, bool allowWidening = false)
		{
			global::System.Type type = expression.Type;
			if (type == targetType || (!type.IsValueType() && targetType.IsAssignableFrom(type)))
			{
				return expression;
			}
			if (targetType.IsValueType())
			{
				global::System.Linq.Expressions.Expression expression2 = global::System.Linq.Expressions.Expression.Unbox(expression, targetType);
				if (allowWidening && targetType.IsPrimitive())
				{
					global::System.Reflection.MethodInfo method = typeof(global::System.Convert).GetMethod("To" + targetType.Name, new global::System.Type[]
					{
						typeof(object)
					});
					if (method != null)
					{
						expression2 = global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.TypeIs(expression, targetType), expression2, global::System.Linq.Expressions.Expression.Call(method, expression));
					}
				}
				return global::System.Linq.Expressions.Expression.Condition(global::System.Linq.Expressions.Expression.Equal(expression, global::System.Linq.Expressions.Expression.Constant(null, typeof(object))), global::System.Linq.Expressions.Expression.Default(targetType), expression2);
			}
			return global::System.Linq.Expressions.Expression.Convert(expression, targetType);
		}

		// Token: 0x040001CA RID: 458
		private static readonly global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory _instance = new global::Newtonsoft.Json.Utilities.ExpressionReflectionDelegateFactory();

		// Token: 0x0200017C RID: 380
		[global::System.Runtime.CompilerServices.Nullable(0)]
		private class ByRefParameter
		{
			// Token: 0x06000EC4 RID: 3780 RVA: 0x00041A7E File Offset: 0x0003FC7E
			public ByRefParameter(global::System.Linq.Expressions.Expression value, global::System.Linq.Expressions.ParameterExpression variable, bool isOut)
			{
				this.Value = value;
				this.Variable = variable;
				this.IsOut = isOut;
			}

			// Token: 0x040006B2 RID: 1714
			public global::System.Linq.Expressions.Expression Value;

			// Token: 0x040006B3 RID: 1715
			public global::System.Linq.Expressions.ParameterExpression Variable;

			// Token: 0x040006B4 RID: 1716
			public bool IsOut;
		}
	}
}
