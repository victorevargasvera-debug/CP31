using System;
using System.Globalization;
using System.Reflection;
using Autofac.Core;

namespace Autofac
{
	// Token: 0x0200000B RID: 11
	public abstract class Module : global::Autofac.Core.IModule
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000272C File Offset: 0x0000092C
		public void Configure(global::Autofac.Core.IComponentRegistry componentRegistry)
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			global::Autofac.ContainerBuilder containerBuilder = new global::Autofac.ContainerBuilder(componentRegistry.Properties);
			this.Load(containerBuilder);
			containerBuilder.UpdateRegistry(componentRegistry);
			this.AttachToRegistrations(componentRegistry);
			this.AttachToSources(componentRegistry);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000276F File Offset: 0x0000096F
		protected virtual void Load(global::Autofac.ContainerBuilder builder)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002771 File Offset: 0x00000971
		protected virtual void AttachToComponentRegistration(global::Autofac.Core.IComponentRegistry componentRegistry, global::Autofac.Core.IComponentRegistration registration)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002773 File Offset: 0x00000973
		protected virtual void AttachToRegistrationSource(global::Autofac.Core.IComponentRegistry componentRegistry, global::Autofac.Core.IRegistrationSource registrationSource)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002778 File Offset: 0x00000978
		private void AttachToRegistrations(global::Autofac.Core.IComponentRegistry componentRegistry)
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			foreach (global::Autofac.Core.IComponentRegistration registration in componentRegistry.Registrations)
			{
				this.AttachToComponentRegistration(componentRegistry, registration);
			}
			componentRegistry.Registered += delegate(object sender, global::Autofac.Core.ComponentRegisteredEventArgs e)
			{
				this.AttachToComponentRegistration(e.ComponentRegistry, e.ComponentRegistration);
			};
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000027E8 File Offset: 0x000009E8
		private void AttachToSources(global::Autofac.Core.IComponentRegistry componentRegistry)
		{
			if (componentRegistry == null)
			{
				throw new global::System.ArgumentNullException("componentRegistry");
			}
			foreach (global::Autofac.Core.IRegistrationSource registrationSource in componentRegistry.Sources)
			{
				this.AttachToRegistrationSource(componentRegistry, registrationSource);
			}
			componentRegistry.RegistrationSourceAdded += delegate(object sender, global::Autofac.Core.RegistrationSourceAddedEventArgs e)
			{
				this.AttachToRegistrationSource(e.ComponentRegistry, e.RegistrationSource);
			};
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002858 File Offset: 0x00000A58
		protected virtual global::System.Reflection.Assembly ThisAssembly
		{
			get
			{
				global::System.Type type = base.GetType();
				global::System.Type baseType = type.GetTypeInfo().BaseType;
				if (baseType != typeof(global::Autofac.Module))
				{
					throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.ModuleResources.ThisAssemblyUnavailable, new object[]
					{
						type,
						baseType
					}));
				}
				return type.GetTypeInfo().Assembly;
			}
		}
	}
}
