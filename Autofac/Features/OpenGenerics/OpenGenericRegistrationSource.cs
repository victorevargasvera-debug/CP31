using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;

namespace Autofac.Features.OpenGenerics
{
	// Token: 0x02000036 RID: 54
	internal class OpenGenericRegistrationSource : global::Autofac.Core.IRegistrationSource
	{
		// Token: 0x06000188 RID: 392 RVA: 0x000062B4 File Offset: 0x000044B4
		public OpenGenericRegistrationSource(global::Autofac.Builder.RegistrationData registrationData, global::Autofac.Builder.ReflectionActivatorData activatorData)
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
			this._registrationData = registrationData;
			this._activatorData = activatorData;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006302 File Offset: 0x00004502
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
			global::System.Type implementationType;
			global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services;
			if (global::Autofac.Features.OpenGenerics.OpenGenericServiceBinder.TryBindServiceType(service, this._registrationData.Services, this._activatorData.ImplementationType, out implementationType, out services))
			{
				yield return global::Autofac.Builder.RegistrationBuilder.CreateRegistration(global::System.Guid.NewGuid(), this._registrationData, new global::Autofac.Core.Activators.Reflection.ReflectionActivator(implementationType, this._activatorData.ConstructorFinder, this._activatorData.ConstructorSelector, this._activatorData.ConfiguredParameters, this._activatorData.ConfiguredProperties), services);
			}
			yield break;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00006320 File Offset: 0x00004520
		public bool IsAdapterForIndividualComponents
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006324 File Offset: 0x00004524
		public override string ToString()
		{
			global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			string openGenericRegistrationSourceDescription = global::Autofac.Features.OpenGenerics.OpenGenericRegistrationSourceResources.OpenGenericRegistrationSourceDescription;
			object[] array = new object[2];
			array[0] = this._activatorData.ImplementationType.FullName;
			array[1] = string.Join(", ", (from s in this._registrationData.Services
			select s.Description).ToArray<string>());
			return string.Format(currentCulture, openGenericRegistrationSourceDescription, array);
		}

		// Token: 0x04000041 RID: 65
		private readonly global::Autofac.Builder.RegistrationData _registrationData;

		// Token: 0x04000042 RID: 66
		private readonly global::Autofac.Builder.ReflectionActivatorData _activatorData;
	}
}
