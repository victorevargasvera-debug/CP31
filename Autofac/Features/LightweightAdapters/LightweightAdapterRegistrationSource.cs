using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Autofac.Builder;
using Autofac.Core;

namespace Autofac.Features.LightweightAdapters
{
	// Token: 0x02000043 RID: 67
	internal class LightweightAdapterRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x000071D4 File Offset: 0x000053D4
		public LightweightAdapterRegistrationSource(global::Autofac.Builder.RegistrationData registrationData, global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData activatorData)
		{
			if (registrationData == null)
			{
				throw new global::System.ArgumentNullException("registrationData");
			}
			if (activatorData == null)
			{
				throw new global::System.ArgumentNullException("activatorData");
			}
			this._registrationData = registrationData;
			this._activatorData = activatorData;
			if (registrationData.Services.Contains(activatorData.FromService))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.FromAndToMustDiffer, new object[]
				{
					activatorData.FromService
				}));
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00007248 File Offset: 0x00005448
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
			if (this._registrationData.Services.Contains(service))
			{
				return registrationAccessor(this._activatorData.FromService).Select(delegate(global::Autofac.Core.IComponentRegistration r)
				{
					global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registrationBuilder = global::Autofac.Builder.RegistrationBuilder.ForDelegate<object>((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => this._activatorData.Adapter(c, global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>(), c.ResolveComponent(r, p))).Targeting(r).InheritRegistrationOrderFrom(r);
					registrationBuilder.RegistrationData.CopyFrom(this._registrationData, true);
					return registrationBuilder.CreateRegistration<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
				});
			}
			global::Autofac.Core.IServiceWithType requestedServiceWithType = service as global::Autofac.Core.IServiceWithType;
			global::Autofac.Core.IServiceWithType serviceWithType = this._activatorData.FromService as global::Autofac.Core.IServiceWithType;
			if (requestedServiceWithType != null && serviceWithType != null && requestedServiceWithType.ServiceType != serviceWithType.ServiceType && this._registrationData.Services.OfType<global::Autofac.Core.IServiceWithType>().Any((global::Autofac.Core.IServiceWithType s) => s.ServiceType == requestedServiceWithType.ServiceType))
			{
				global::Autofac.Core.Service arg = requestedServiceWithType.ChangeType(serviceWithType.ServiceType);
				return registrationAccessor(arg).Select(delegate(global::Autofac.Core.IComponentRegistration r)
				{
					global::Autofac.Builder.IRegistrationBuilder<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle> registrationBuilder = global::Autofac.Builder.RegistrationBuilder.ForDelegate<object>((global::Autofac.IComponentContext c, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> p) => this._activatorData.Adapter(c, p, c.ResolveComponent(r, global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>()))).Targeting(r);
					registrationBuilder.RegistrationData.CopyFrom(this._registrationData, true);
					registrationBuilder.RegistrationData.AddService(service);
					return registrationBuilder.CreateRegistration<object, global::Autofac.Builder.SimpleActivatorData, global::Autofac.Builder.SingleRegistrationStyle>();
				});
			}
			return new global::Autofac.Core.IComponentRegistration[0];
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00007364 File Offset: 0x00005564
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00007368 File Offset: 0x00005568
		public override string ToString()
		{
			global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			string adapterFromToDescription = global::Autofac.Features.LightweightAdapters.LightweightAdapterRegistrationSourceResources.AdapterFromToDescription;
			object[] array = new object[2];
			array[0] = this._activatorData.FromService.Description;
			array[1] = string.Join(", ", (from s in this._registrationData.Services
			select s.Description).ToArray<string>());
			return string.Format(currentCulture, adapterFromToDescription, array);
		}

		// Token: 0x04000054 RID: 84
		private readonly global::Autofac.Builder.RegistrationData _registrationData;

		// Token: 0x04000055 RID: 85
		private readonly global::Autofac.Features.LightweightAdapters.LightweightAdapterActivatorData _activatorData;
	}
}
