using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Features.Metadata;
using Autofac.Util;

namespace Autofac.Features.AttributeFilters
{
	// Token: 0x02000054 RID: 84
	public sealed class MetadataFilterAttribute : global::Autofac.Features.AttributeFilters.ParameterFilterAttribute
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00007FDB File Offset: 0x000061DB
		public MetadataFilterAttribute(string key, object value)
		{
			this.Key = key;
			this.Value = value;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00007FF1 File Offset: 0x000061F1
		public string Key { get; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00007FF9 File Offset: 0x000061F9
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00008001 File Offset: 0x00006201
		public object Value { get; private set; }

		// Token: 0x06000216 RID: 534 RVA: 0x0000800C File Offset: 0x0000620C
		public override object ResolveParameter(global::System.Reflection.ParameterInfo parameter, global::Autofac.IComponentContext context)
		{
			if (parameter == null)
			{
				throw new global::System.ArgumentNullException("parameter");
			}
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			global::System.Type elementType = global::Autofac.Features.AttributeFilters.MetadataFilterAttribute.GetElementType(parameter.ParameterType);
			if (!(elementType != parameter.ParameterType))
			{
				return global::Autofac.Features.AttributeFilters.MetadataFilterAttribute.FilterOneMethod.MakeGenericMethod(new global::System.Type[]
				{
					elementType
				}).Invoke(null, new object[]
				{
					context,
					this.Key,
					this.Value
				});
			}
			return global::Autofac.Features.AttributeFilters.MetadataFilterAttribute.FilterAllMethod.MakeGenericMethod(new global::System.Type[]
			{
				elementType
			}).Invoke(null, new object[]
			{
				context,
				this.Key,
				this.Value
			});
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000080BC File Offset: 0x000062BC
		private static global::System.Type GetElementType(global::System.Type type)
		{
			if (!type.IsGenericEnumerableInterfaceType())
			{
				return type;
			}
			return type.GetTypeInfo().GenericTypeArguments[0];
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000080D8 File Offset: 0x000062D8
		private static T FilterOne<T>(global::Autofac.IComponentContext context, string metadataKey, object metadataValue)
		{
			return (from m in context.Resolve<global::System.Collections.Generic.IEnumerable<global::Autofac.Features.Metadata.Meta<global::System.Lazy<T>>>>()
			where m.Metadata.ContainsKey(metadataKey) && metadataValue.Equals(m.Metadata[metadataKey])
			select m.Value.Value).FirstOrDefault<T>();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000813C File Offset: 0x0000633C
		private static global::System.Collections.Generic.IEnumerable<T> FilterAll<T>(global::Autofac.IComponentContext context, string metadataKey, object metadataValue)
		{
			return (from m in context.Resolve<global::System.Collections.Generic.IEnumerable<global::Autofac.Features.Metadata.Meta<global::System.Lazy<T>>>>()
			where m.Metadata.ContainsKey(metadataKey) && metadataValue.Equals(m.Metadata[metadataKey])
			select m.Value.Value).ToArray<T>();
		}

		// Token: 0x0400006D RID: 109
		private static readonly global::System.Reflection.MethodInfo FilterOneMethod = typeof(global::Autofac.Features.AttributeFilters.MetadataFilterAttribute).GetTypeInfo().GetDeclaredMethod("FilterOne");

		// Token: 0x0400006E RID: 110
		private static readonly global::System.Reflection.MethodInfo FilterAllMethod = typeof(global::Autofac.Features.AttributeFilters.MetadataFilterAttribute).GetTypeInfo().GetDeclaredMethod("FilterAll");
	}
}
