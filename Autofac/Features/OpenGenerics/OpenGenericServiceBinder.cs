using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Autofac.Core;
using Autofac.Util;

namespace Autofac.Features.OpenGenerics
{
	// Token: 0x02000038 RID: 56
	internal static class OpenGenericServiceBinder
	{
		// Token: 0x06000191 RID: 401 RVA: 0x000063F8 File Offset: 0x000045F8
		public static bool TryBindServiceType(global::Autofac.Core.Service service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> configuredOpenGenericServices, global::System.Type openGenericImplementationType, out global::System.Type constructedImplementationType, out global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> constructedServices)
		{
			global::Autofac.Core.IServiceWithType serviceWithType = service as global::Autofac.Core.IServiceWithType;
			if (serviceWithType != null && serviceWithType.ServiceType.GetTypeInfo().IsGenericType)
			{
				global::Autofac.Core.IServiceWithType definitionService = (global::Autofac.Core.IServiceWithType)serviceWithType.ChangeType(serviceWithType.ServiceType.GetGenericTypeDefinition());
				global::System.Type[] serviceGenericArguments = serviceWithType.ServiceType.GetTypeInfo().GenericTypeArguments;
				if (configuredOpenGenericServices.Cast<global::Autofac.Core.IServiceWithType>().Any((global::Autofac.Core.IServiceWithType s) => s.Equals(definitionService)))
				{
					global::System.Type[] array = global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.TryMapImplementationGenericArguments(openGenericImplementationType, serviceWithType.ServiceType, definitionService.ServiceType, serviceGenericArguments);
					if (array.All((global::System.Type a) => a != null) && openGenericImplementationType.IsCompatibleWithGenericParameterConstraints(array))
					{
						global::System.Type type = openGenericImplementationType.MakeGenericType(array);
						global::System.Reflection.TypeInfo constructedImplementationTypeTmpInfo = type.GetTypeInfo();
						global::Autofac.Core.Service[] array2 = (from global::Autofac.Core.IServiceWithType s in configuredOpenGenericServices
						where s.ServiceType.GetTypeInfo().GenericTypeParameters.Length == serviceGenericArguments.Length
						select new
						{
							ServiceWithType = s,
							GenericService = s.ServiceType.MakeGenericType(serviceGenericArguments)
						} into p
						where p.GenericService.GetTypeInfo().IsAssignableFrom(constructedImplementationTypeTmpInfo)
						select p.ServiceWithType.ChangeType(p.GenericService)).ToArray<global::Autofac.Core.Service>();
						if (array2.Length != 0)
						{
							constructedImplementationType = type;
							constructedServices = array2;
							return true;
						}
					}
				}
			}
			constructedImplementationType = null;
			constructedServices = null;
			return false;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006568 File Offset: 0x00004768
		private static global::System.Type[] TryMapImplementationGenericArguments(global::System.Type implementationType, global::System.Type serviceType, global::System.Type serviceTypeDefinition, global::System.Type[] serviceGenericArguments)
		{
			if (serviceTypeDefinition == implementationType)
			{
				return serviceGenericArguments;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Type> genericTypeParameters = implementationType.GetTypeInfo().GenericTypeParameters;
			global::System.Type[] first = serviceType.GetTypeInfo().IsInterface ? global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.GetInterface(implementationType, serviceType).GetTypeInfo().GenericTypeArguments : serviceTypeDefinition.GetTypeInfo().GenericTypeParameters;
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>> serviceArgumentDefinitionToArgumentMapping = first.Zip(serviceGenericArguments, (global::System.Type a, global::System.Type b) => new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>(a, b));
			return (from implementationGenericArgumentDefinition in genericTypeParameters
			select global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.TryFindServiceArgumentForImplementationArgumentDefinition(implementationGenericArgumentDefinition, serviceArgumentDefinitionToArgumentMapping)).ToArray<global::System.Type>();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006600 File Offset: 0x00004800
		private static global::System.Type GetInterface(global::System.Type implementationType, global::System.Type serviceType)
		{
			global::System.Type result;
			try
			{
				result = implementationType.GetTypeInfo().ImplementedInterfaces.First((global::System.Type i) => i.Name == serviceType.Name && i.Namespace == serviceType.Namespace);
			}
			catch (global::System.InvalidOperationException)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ImplementorDoesntImplementService, new object[]
				{
					implementationType.FullName,
					serviceType.FullName
				}));
			}
			return result;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006680 File Offset: 0x00004880
		private static global::System.Type TryFindServiceArgumentForImplementationArgumentDefinition(global::System.Type implementationGenericArgumentDefinition, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>> serviceArgumentDefinitionToArgument)
		{
			global::System.Type type = (from argdef in serviceArgumentDefinitionToArgument
			where !argdef.Key.GetTypeInfo().IsGenericType && implementationGenericArgumentDefinition.Name == argdef.Key.Name
			select argdef.Value).FirstOrDefault<global::System.Type>();
			if (type != null)
			{
				return type;
			}
			return (from argdef in serviceArgumentDefinitionToArgument
			where argdef.Key.GetTypeInfo().IsGenericType && argdef.Value.GetTypeInfo().GenericTypeArguments.Any<global::System.Type>()
			select global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.TryFindServiceArgumentForImplementationArgumentDefinition(implementationGenericArgumentDefinition, argdef.Key.GetTypeInfo().GenericTypeArguments.Zip(argdef.Value.GetTypeInfo().GenericTypeArguments, (global::System.Type a, global::System.Type b) => new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Type>(a, b)))).FirstOrDefault((global::System.Type x) => x != null);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000673C File Offset: 0x0000493C
		public static void EnforceBindable(global::System.Type implementationType, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services)
		{
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (!implementationType.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ImplementorMustBeOpenGenericTypeDefinition, new object[]
				{
					implementationType
				}));
			}
			using (global::System.Collections.Generic.IEnumerator<global::Autofac.Core.IServiceWithType> enumerator = services.OfType<global::Autofac.Core.IServiceWithType>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Autofac.Core.IServiceWithType service = enumerator.Current;
					if (!service.ServiceType.GetTypeInfo().IsGenericTypeDefinition)
					{
						throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.ServiceTypeMustBeOpenGenericTypeDefinition, new object[]
						{
							service
						}));
					}
					if (service.ServiceType.GetTypeInfo().IsInterface)
					{
						if (global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.GetInterface(implementationType, service.ServiceType) == null)
						{
							throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.InterfaceIsNotImplemented, new object[]
							{
								implementationType,
								service
							}));
						}
					}
					else if (!global::Autofac.Util.Traverse.Across<global::System.Type>(implementationType, (global::System.Type t) => t.GetTypeInfo().BaseType).Any((global::System.Type t) => global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.IsCompatibleGenericClassDefinition(t, service.ServiceType)))
					{
						throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericServiceBinderResources.TypesAreNotConvertible, new object[]
						{
							implementationType,
							service
						}));
					}
				}
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000068E4 File Offset: 0x00004AE4
		private static bool IsCompatibleGenericClassDefinition(global::System.Type implementor, global::System.Type serviceType)
		{
			return implementor == serviceType || (implementor.GetTypeInfo().IsGenericType && implementor.GetGenericTypeDefinition() == serviceType);
		}
	}
}
