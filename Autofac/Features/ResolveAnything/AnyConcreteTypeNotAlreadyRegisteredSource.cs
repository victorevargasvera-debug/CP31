using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.ResolveAnything
{
	// Token: 0x0200002A RID: 42
	public class AnyConcreteTypeNotAlreadyRegisteredSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x06000154 RID: 340 RVA: 0x000059FC File Offset: 0x00003BFC
		public AnyConcreteTypeNotAlreadyRegisteredSource() : this((global::System.Type t) => true)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005A23 File Offset: 0x00003C23
		public AnyConcreteTypeNotAlreadyRegisteredSource(global::System.Func<global::System.Type, bool> predicate)
		{
			if (predicate == null)
			{
				throw new global::System.ArgumentNullException("predicate");
			}
			this._predicate = predicate;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00005A44 File Offset: 0x00003C44
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service, global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>> registrationAccessor)
		{
			if (registrationAccessor == null)
			{
				throw new global::System.ArgumentNullException("registrationAccessor");
			}
			global::Autofac.Core.TypedService typedService = service as global::Autofac.Core.TypedService;
			if (typedService == null || typedService.ServiceType == typeof(string))
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			global::System.Reflection.TypeInfo typeInfo = typedService.ServiceType.GetTypeInfo();
			if (!typeInfo.IsClass || typeInfo.IsSubclassOf(typeof(global::System.Delegate)) || typeInfo.IsAbstract || typeInfo.IsGenericTypeDefinition || !this._predicate(typedService.ServiceType) || registrationAccessor(service).Any<global::Autofac.Core.IComponentRegistration>())
			{
				return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
			}
			if (typeInfo.IsGenericType)
			{
				foreach (global::System.Type type in typeInfo.GenericTypeArguments)
				{
					if (this._predicate(type) && !registrationAccessor(new global::Autofac.Core.TypedService(type)).Any<global::Autofac.Core.IComponentRegistration>())
					{
						return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
					}
				}
			}
			global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registrationBuilder = global::Autofac.Builder.RegistrationBuilder.ForType(typedService.ServiceType);
			global::System.Action<global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>> registrationConfiguration = this.RegistrationConfiguration;
			if (registrationConfiguration != null)
			{
				registrationConfiguration(registrationBuilder);
			}
			return new global::Autofac.Core.IComponentRegistration[]
			{
				registrationBuilder.CreateRegistration<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>()
			};
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00005B66 File Offset: 0x00003D66
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00005B69 File Offset: 0x00003D69
		// (set) Token: 0x06000159 RID: 345 RVA: 0x00005B71 File Offset: 0x00003D71
		public global::System.Action<global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.ConcreteReflectionActivatorData, global::Autofac.Builder.SingleRegistrationStyle>> RegistrationConfiguration { get; set; }

		// Token: 0x0600015A RID: 346 RVA: 0x00005B7A File Offset: 0x00003D7A
		public override string ToString()
		{
			return global::Autofac.Features.ResolveAnything.AnyConcreteTypeNotAlreadyRegisteredSourceResources.AnyConcreteTypeNotAlreadyRegisteredSourceDescription;
		}

		// Token: 0x04000030 RID: 48
		private readonly global::System.Func<global::System.Type, bool> _predicate;
	}
}
