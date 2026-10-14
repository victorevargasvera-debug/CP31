using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;

namespace Autofac.Features.OpenGenerics
{
	// Token: 0x02000032 RID: 50
	internal class OpenGenericDecoratorRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00005E60 File Offset: 0x00004060
		public OpenGenericDecoratorRegistrationSource(global::Autofac.Builder.RegistrationData registrationData, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData activatorData)
		{
			if (registrationData == null)
			{
				throw new global::System.ArgumentNullException("registrationData");
			}
			if (activatorData == null)
			{
				throw new global::System.ArgumentNullException("activatorData");
			}
			global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.EnforceBindable(activatorData.ImplementationType, registrationData.Services);
			if (registrationData.Services.Contains((global::Autofac.Core.Service)activatorData.FromService))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorRegistrationSourceResources.FromAndToMustDiffer, new object[]
				{
					activatorData.FromService
				}));
			}
			this._registrationData = registrationData;
			this._activatorData = activatorData;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005EEC File Offset: 0x000040EC
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
			global::System.Type constructedImplementationType;
			global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services;
			if (global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.TryBindServiceType(service, this._registrationData.Services, this._activatorData.ImplementationType, out constructedImplementationType, out services))
			{
				global::Autofac.Core.IServiceWithType swt = (global::Autofac.Core.IServiceWithType)service;
				global::Autofac.Core.Service arg = this._activatorData.FromService.ChangeType(swt.ServiceType);
				return from cr in registrationAccessor(arg)
				select global::Autofac.Builder.RegistrationBuilder.CreateRegistration(global::System.Guid.NewGuid(), this._registrationData, new global::Autofac.Core.Activators.Reflection.ReflectionActivator(constructedImplementationType, this._activatorData.ConstructorFinder, this._activatorData.ConstructorSelector, global::Autofac.Features.OpenGenerics.OpenGenericDecoratorRegistrationSource.AddDecoratedComponentParameter(swt.ServiceType, cr, this._activatorData.ConfiguredParameters), this._activatorData.ConfiguredProperties), services);
			}
			return global::System.Linq.Enumerable.Empty<global::Autofac.Core.IComponentRegistration>();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005FA8 File Offset: 0x000041A8
		private static global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> AddDecoratedComponentParameter(global::System.Type decoratedParameterType, global::Autofac.Core.IComponentRegistration decoratedComponent, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> configuredParameters)
		{
			global::Autofac.Core.ResolvedParameter resolvedParameter = new global::Autofac.Core.ResolvedParameter((global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext c) => pi.ParameterType == decoratedParameterType, (global::System.Reflection.ParameterInfo pi, global::Autofac.IComponentContext c) => c.ResolveComponent(decoratedComponent, global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>()));
			return new global::Autofac.Core.ResolvedParameter[]
			{
				resolvedParameter
			}.Concat(configuredParameters);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00005FF7 File Offset: 0x000041F7
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005FFC File Offset: 0x000041FC
		public override string ToString()
		{
			global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			string openGenericDecoratorRegistrationSourceImplFromTo = global::Autofac.Features.OpenGenerics.OpenGenericDecoratorRegistrationSourceResources.OpenGenericDecoratorRegistrationSourceImplFromTo;
			object[] array = new object[3];
			array[0] = this._activatorData.ImplementationType.FullName;
			array[1] = ((global::Autofac.Core.Service)this._activatorData.FromService).Description;
			array[2] = string.Join(", ", (from s in this._registrationData.Services
			select s.Description).ToArray<string>());
			return string.Format(currentCulture, openGenericDecoratorRegistrationSourceImplFromTo, array);
		}

		// Token: 0x0400003B RID: 59
		private readonly global::Autofac.Builder.RegistrationData _registrationData;

		// Token: 0x0400003C RID: 60
		private readonly global::Autofac.Features.OpenGenerics.OpenGenericDecoratorActivatorData _activatorData;
	}
}
