using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;
using Autofac.Util;

namespace Autofac.Features.Collections
{
	// Token: 0x02000051 RID: 81
	internal class CollectionRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x06000206 RID: 518 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.IServiceWithType serviceWithType = service as global::Autofac.Core.IServiceWithType;
			if (serviceWithType == null)
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Type serviceType = serviceWithType.ServiceType;
			global::System.Type elementType = null;
			if (serviceType.IsGenericEnumerableInterfaceType())
			{
				elementType = serviceType.GetTypeInfo().GenericTypeArguments.First<global::System.Type>();
			}
			else if (serviceType.IsArray)
			{
				elementType = serviceType.GetElementType();
			}
			if (elementType == null)
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::Autofac.Core.Service elementTypeService = serviceWithType.ChangeType(elementType);
			global::System.Type limitType = elementType.MakeArrayType();
			global::System.Type listType = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
			{
				elementType
			});
			bool serviceTypeIsList = serviceType.IsGenericListOrCollectionInterfaceType();
			global::Autofac.Core.Activators.Delegate.DelegateActivator activator = new global::Autofac.Core.Activators.Delegate.DelegateActivator(limitType, delegate(global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p)
			{
				object[] array = (from cr in c.ComponentRegistry.RegistrationsFor(elementTypeService)
				orderby cr.GetRegistrationOrder()
				select c.ResolveComponent(cr, p)).ToArray<object>();
				global::System.Array array2 = global::System.Array.CreateInstance(elementType, array.Length);
				array.CopyTo(array2, 0);
				if (!serviceTypeIsList)
				{
					return array2;
				}
				return global::System.Activator.CreateInstance(listType, new object[]
				{
					array2
				});
			});
			global::Autofac.Core.Registration.ComponentRegistration componentRegistration = new global::Autofac.Core.Registration.ComponentRegistration(global::System.Guid.NewGuid(), activator, new global::Autofac.Core.Lifetime.CurrentScopeLifetime(), global::Autofac.Core.InstanceSharing.None, global::Autofac.Core.InstanceOwnership.ExternallyOwned, new global::Autofac.Core.Service[]
			{
				service
			}, new global::System.Collections.Generic.Dictionary<string, object>());
			return new global::Autofac.Core.IComponentRegistration[]
			{
				componentRegistration
			};
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00007F14 File Offset: 0x00006114
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007F17 File Offset: 0x00006117
		public override string ToString()
		{
			return global::Autofac.Features.Collections.CollectionRegistrationSourceResources.CollectionRegistrationSourceDescription;
		}
	}
}
