using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Autofac.Util
{
	// Token: 0x02000025 RID: 37
	internal static class TypeExtensions
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00004E4A File Offset: 0x0000304A
		public static global::System.Type FunctionReturnType(this global::System.Type type)
		{
			global::System.Reflection.MethodInfo declaredMethod = type.GetTypeInfo().GetDeclaredMethod("Invoke");
			global::Autofac.Util.Enforce.NotNull<global::System.Reflection.MethodInfo>(declaredMethod);
			return declaredMethod.ReturnType;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004E68 File Offset: 0x00003068
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetTypesThatClose(this global::System.Type @this, global::System.Type openGeneric)
		{
			return global::Autofac.Util.TypeExtensions.FindAssignableTypesThatClose(@this, openGeneric);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004E74 File Offset: 0x00003074
		public static bool IsClosedTypeOf(this global::System.Type @this, global::System.Type openGeneric)
		{
			return global::Autofac.Util.TypeExtensions.TypesAssignableFrom(@this).Any((global::System.Type t) => t.GetTypeInfo().IsGenericType && !@this.GetTypeInfo().ContainsGenericParameters && t.GetGenericTypeDefinition() == openGeneric);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004EB4 File Offset: 0x000030B4
		public static bool IsCompatibleWithGenericParameterConstraints(this global::System.Type genericTypeDefinition, global::System.Type[] parameters)
		{
			global::System.Type[] genericTypeParameters = genericTypeDefinition.GetTypeInfo().GenericTypeParameters;
			global::System.Func<global::System.Type, global::System.Type> <>9__0;
			for (int i = 0; i < genericTypeParameters.Length; i++)
			{
				global::System.Reflection.TypeInfo typeInfo = genericTypeParameters[i].GetTypeInfo();
				global::System.Type parameter = parameters[i];
				global::System.Reflection.TypeInfo typeInfo2 = parameter.GetTypeInfo();
				global::System.Collections.Generic.IEnumerable<global::System.Type> genericParameterConstraints = typeInfo.GetGenericParameterConstraints();
				global::System.Func<global::System.Type, global::System.Type> selector;
				if ((selector = <>9__0) == null)
				{
					selector = (<>9__0 = ((global::System.Type constraint) => global::Autofac.Util.TypeExtensions.SubstituteGenericParameterConstraint(parameters, constraint)));
				}
				if (genericParameterConstraints.Select(selector).Any((global::System.Type constraint) => !global::Autofac.Util.TypeExtensions.ParameterCompatibleWithTypeConstraint(parameter, constraint)))
				{
					return false;
				}
				global::System.Reflection.GenericParameterAttributes genericParameterAttributes = typeInfo.GenericParameterAttributes;
				if ((genericParameterAttributes & global::System.Reflection.GenericParameterAttributes.DefaultConstructorConstraint) != global::System.Reflection.GenericParameterAttributes.None && !typeInfo2.IsValueType)
				{
					if (typeInfo2.DeclaredConstructors.All((global::System.Reflection.ConstructorInfo c) => c.GetParameters().Count<global::System.Reflection.ParameterInfo>() != 0))
					{
						return false;
					}
				}
				if ((genericParameterAttributes & global::System.Reflection.GenericParameterAttributes.ReferenceTypeConstraint) != global::System.Reflection.GenericParameterAttributes.None && typeInfo2.IsValueType)
				{
					return false;
				}
				if ((genericParameterAttributes & global::System.Reflection.GenericParameterAttributes.NotNullableValueTypeConstraint) != global::System.Reflection.GenericParameterAttributes.None && (!typeInfo2.IsValueType || (typeInfo2.IsGenericType && parameter.IsGenericTypeDefinedBy(typeof(global::System.Nullable<>)))))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004FE6 File Offset: 0x000031E6
		public static bool IsCompilerGenerated(this global::System.Type type)
		{
			return type.GetTypeInfo().GetCustomAttributes<global::System.Runtime.CompilerServices.CompilerGeneratedAttribute>().Any<global::System.Runtime.CompilerServices.CompilerGeneratedAttribute>();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004FF8 File Offset: 0x000031F8
		public static bool IsDelegate(this global::System.Type type)
		{
			return type.GetTypeInfo().IsSubclassOf(typeof(global::System.Delegate));
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005010 File Offset: 0x00003210
		public static bool IsGenericEnumerableInterfaceType(this global::System.Type type)
		{
			return global::Autofac.Util.TypeExtensions.IsGenericEnumerableInterfaceCache.GetOrAdd(type, (global::System.Type t) => type.IsGenericTypeDefinedBy(typeof(global::System.Collections.Generic.IEnumerable<>)) || type.IsGenericListOrCollectionInterfaceType());
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005046 File Offset: 0x00003246
		public static bool IsGenericListOrCollectionInterfaceType(this global::System.Type type)
		{
			return global::Autofac.Util.TypeExtensions.IsGenericListOrCollectionInterfaceTypeCache.GetOrAdd(type, (global::System.Type t) => t.IsGenericTypeDefinedBy(typeof(global::System.Collections.Generic.IList<>)) || t.IsGenericTypeDefinedBy(typeof(global::System.Collections.Generic.ICollection<>)) || t.IsGenericTypeDefinedBy(typeof(global::System.Collections.Generic.IReadOnlyCollection<>)) || t.IsGenericTypeDefinedBy(typeof(global::System.Collections.Generic.IReadOnlyList<>)));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005072 File Offset: 0x00003272
		public static bool IsGenericTypeDefinedBy(this global::System.Type @this, global::System.Type openGeneric)
		{
			return global::Autofac.Util.TypeExtensions.IsGenericTypeDefinedByCache.GetOrAdd(global::System.Tuple.Create<global::System.Type, global::System.Type>(@this, openGeneric), (global::System.Tuple<global::System.Type, global::System.Type> key) => !key.Item1.GetTypeInfo().ContainsGenericParameters && key.Item1.GetTypeInfo().IsGenericType && key.Item1.GetGenericTypeDefinition() == key.Item2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000050A4 File Offset: 0x000032A4
		private static global::System.Collections.Generic.IEnumerable<global::System.Type> FindAssignableTypesThatClose(global::System.Type candidateType, global::System.Type openGenericServiceType)
		{
			return from t in global::Autofac.Util.TypeExtensions.TypesAssignableFrom(candidateType)
			where t.IsClosedTypeOf(openGenericServiceType)
			select t;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000050D5 File Offset: 0x000032D5
		private static global::System.Type SubstituteGenericParameterConstraint(global::System.Type[] parameters, global::System.Type constraint)
		{
			if (!constraint.IsGenericParameter)
			{
				return constraint;
			}
			return parameters[constraint.GenericParameterPosition];
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000050EC File Offset: 0x000032EC
		private static bool ParameterCompatibleWithTypeConstraint(global::System.Type parameter, global::System.Type constraint)
		{
			if (!constraint.GetTypeInfo().IsAssignableFrom(parameter.GetTypeInfo()))
			{
				return global::Autofac.Util.Traverse.Across<global::System.Type>(parameter, (global::System.Type p) => p.GetTypeInfo().BaseType).Concat(parameter.GetTypeInfo().ImplementedInterfaces).Any((global::System.Type p) => global::Autofac.Util.TypeExtensions.ParameterEqualsConstraint(p, constraint));
			}
			return true;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005168 File Offset: 0x00003368
		private static bool ParameterEqualsConstraint(global::System.Type parameter, global::System.Type constraint)
		{
			global::System.Type[] genericTypeArguments = parameter.GetTypeInfo().GenericTypeArguments;
			if (genericTypeArguments.Length != 0 && constraint.GetTypeInfo().IsGenericType)
			{
				global::System.Type genericTypeDefinition = constraint.GetGenericTypeDefinition();
				if (genericTypeDefinition.GetTypeInfo().GenericTypeParameters.Length == genericTypeArguments.Length)
				{
					try
					{
						global::System.Type left = genericTypeDefinition.MakeGenericType(genericTypeArguments);
						global::System.Type[] genericTypeArguments2 = constraint.GetTypeInfo().GenericTypeArguments;
						for (int i = 0; i < genericTypeArguments2.Length; i++)
						{
							global::System.Reflection.TypeInfo typeInfo = genericTypeArguments2[i].GetTypeInfo();
							if (!typeInfo.IsGenericParameter && !typeInfo.IsAssignableFrom(genericTypeArguments[i].GetTypeInfo()))
							{
								return false;
							}
						}
						return left == parameter;
					}
					catch (global::System.Exception)
					{
						return false;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005224 File Offset: 0x00003424
		private static global::System.Collections.Generic.IEnumerable<global::System.Type> TypesAssignableFrom(global::System.Type candidateType)
		{
			return candidateType.GetTypeInfo().ImplementedInterfaces.Concat(global::Autofac.Util.Traverse.Across<global::System.Type>(candidateType, (global::System.Type t) => t.GetTypeInfo().BaseType));
		}

		// Token: 0x04000029 RID: 41
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, bool> IsGenericEnumerableInterfaceCache = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, bool>();

		// Token: 0x0400002A RID: 42
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, bool> IsGenericListOrCollectionInterfaceTypeCache = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, bool>();

		// Token: 0x0400002B RID: 43
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, global::System.Type>, bool> IsGenericTypeDefinedByCache = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, global::System.Type>, bool>();
	}
}
