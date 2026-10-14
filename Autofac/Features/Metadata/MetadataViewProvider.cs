using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Autofac.Core;

namespace Autofac.Features.Metadata
{
	// Token: 0x0200003A RID: 58
	internal static class MetadataViewProvider
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x000069C4 File Offset: 0x00004BC4
		public static global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, TMetadata> GetMetadataViewProvider<TMetadata>()
		{
			if (typeof(TMetadata) == typeof(global::System.Collections.Generic.IDictionary<string, object>))
			{
				return (global::System.Collections.Generic.IDictionary<string, object> m) => (TMetadata)((object)m);
			}
			if (!typeof(TMetadata).GetTypeInfo().IsClass)
			{
				throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.Metadata.MetadataViewProviderResources.InvalidViewImplementation, new object[]
				{
					typeof(TMetadata).Name
				}));
			}
			global::System.Type typeFromHandle = typeof(TMetadata);
			global::System.Reflection.ConstructorInfo constructorInfo = typeFromHandle.GetTypeInfo().DeclaredConstructors.SingleOrDefault(delegate(global::System.Reflection.ConstructorInfo ci)
			{
				global::System.Reflection.ParameterInfo[] parameters = ci.GetParameters();
				return ci.IsPublic && parameters.Length == 1 && parameters[0].ParameterType == typeof(global::System.Collections.Generic.IDictionary<string, object>);
			});
			if (constructorInfo != null)
			{
				global::System.Linq.Expressions.ParameterExpression parameterExpression;
				return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, TMetadata>>(global::System.Linq.Expressions.Expression.New(constructorInfo, new global::System.Linq.Expressions.Expression[]
				{
					parameterExpression
				}), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression
				}).Compile();
			}
			global::System.Reflection.ConstructorInfo constructorInfo2 = typeFromHandle.GetTypeInfo().DeclaredConstructors.SingleOrDefault((global::System.Reflection.ConstructorInfo ci) => ci.IsPublic && ci.GetParameters().Length == 0);
			if (constructorInfo2 != null)
			{
				global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(global::System.Collections.Generic.IDictionary<string, object>), "metadata");
				global::System.Linq.Expressions.ParameterExpression parameterExpression3 = global::System.Linq.Expressions.Expression.Variable(typeof(TMetadata), "result");
				global::System.Linq.Expressions.BinaryExpression item = global::System.Linq.Expressions.Expression.Assign(parameterExpression3, global::System.Linq.Expressions.Expression.New(constructorInfo2));
				global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>
				{
					item
				};
				foreach (global::System.Reflection.PropertyInfo propertyInfo in from prop in typeof(TMetadata).GetRuntimeProperties()
				where prop.GetMethod != null && !prop.GetMethod.IsStatic && prop.SetMethod != null && !prop.SetMethod.IsStatic
				select prop)
				{
					global::System.Linq.Expressions.ConstantExpression arg = global::System.Linq.Expressions.Expression.Constant(propertyInfo.GetCustomAttribute(false), typeof(global::System.ComponentModel.DefaultValueAttribute));
					global::System.Linq.Expressions.ConstantExpression arg2 = global::System.Linq.Expressions.Expression.Constant(propertyInfo.Name, typeof(string));
					global::System.Reflection.MethodInfo method = global::Autofac.Features.Metadata.MetadataViewProvider.GetMetadataValueMethod.MakeGenericMethod(new global::System.Type[]
					{
						propertyInfo.PropertyType
					});
					global::System.Linq.Expressions.BinaryExpression item2 = global::System.Linq.Expressions.Expression.Assign(global::System.Linq.Expressions.Expression.Property(parameterExpression3, propertyInfo), global::System.Linq.Expressions.Expression.Call(null, method, parameterExpression2, arg2, arg));
					list.Add(item2);
				}
				list.Add(parameterExpression3);
				return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, TMetadata>>(global::System.Linq.Expressions.Expression.Block(new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression3
				}, list), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression2
				}).Compile();
			}
			throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.Metadata.MetadataViewProviderResources.InvalidViewImplementation, new object[]
			{
				typeof(TMetadata).Name
			}));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006C94 File Offset: 0x00004E94
		private static TValue GetMetadataValue<TValue>(global::System.Collections.Generic.IDictionary<string, object> metadata, string name, global::System.ComponentModel.DefaultValueAttribute defaultValue)
		{
			object obj;
			if (metadata.TryGetValue(name, out obj))
			{
				return (TValue)((object)obj);
			}
			if (defaultValue != null)
			{
				return (TValue)((object)defaultValue.Value);
			}
			throw new global::Autofac.Core.DependencyResolutionException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.Metadata.MetadataViewProviderResources.MissingMetadata, new object[]
			{
				name
			}));
		}

		// Token: 0x04000047 RID: 71
		private static readonly global::System.Reflection.MethodInfo GetMetadataValueMethod = typeof(global::Autofac.Features.Metadata.MetadataViewProvider).GetTypeInfo().GetDeclaredMethod("GetMetadataValue");
	}
}
