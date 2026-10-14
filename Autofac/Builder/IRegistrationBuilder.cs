using System;
using System.Collections.Generic;
using System.ComponentModel;
using Autofac.Core;

namespace Autofac.Builder
{
	// Token: 0x020000BE RID: 190
	public interface IRegistrationBuilder<out TLimit, out TActivatorData, out TRegistrationStyle>
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600043C RID: 1084
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		TActivatorData ActivatorData { get; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600043D RID: 1085
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		TRegistrationStyle RegistrationStyle { get; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600043E RID: 1086
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::Autofac.Builder.RegistrationData RegistrationData { get; }

		// Token: 0x0600043F RID: 1087
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> ExternallyOwned();

		// Token: 0x06000440 RID: 1088
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OwnedByLifetimeScope();

		// Token: 0x06000441 RID: 1089
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerDependency();

		// Token: 0x06000442 RID: 1090
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> SingleInstance();

		// Token: 0x06000443 RID: 1091
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerLifetimeScope();

		// Token: 0x06000444 RID: 1092
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerMatchingLifetimeScope(params object[] lifetimeScopeTag);

		// Token: 0x06000445 RID: 1093
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned<TService>();

		// Token: 0x06000446 RID: 1094
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned(global::System.Type serviceType);

		// Token: 0x06000447 RID: 1095
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned<TService>(object serviceKey);

		// Token: 0x06000448 RID: 1096
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned(object serviceKey, global::System.Type serviceType);

		// Token: 0x06000449 RID: 1097
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As<TService>();

		// Token: 0x0600044A RID: 1098
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As<TService1, TService2>();

		// Token: 0x0600044B RID: 1099
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As<TService1, TService2, TService3>();

		// Token: 0x0600044C RID: 1100
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As(params global::System.Type[] services);

		// Token: 0x0600044D RID: 1101
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As(params global::Autofac.Core.Service[] services);

		// Token: 0x0600044E RID: 1102
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Named(string serviceName, global::System.Type serviceType);

		// Token: 0x0600044F RID: 1103
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Named<TService>(string serviceName);

		// Token: 0x06000450 RID: 1104
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Keyed(object serviceKey, global::System.Type serviceType);

		// Token: 0x06000451 RID: 1105
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Keyed<TService>(object serviceKey);

		// Token: 0x06000452 RID: 1106
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnPreparing(global::System.Action<global::Autofac.Core.PreparingEventArgs> handler);

		// Token: 0x06000453 RID: 1107
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnActivating(global::System.Action<global::Autofac.Core.IActivatingEventArgs<TLimit>> handler);

		// Token: 0x06000454 RID: 1108
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnActivated(global::System.Action<global::Autofac.Core.IActivatedEventArgs<TLimit>> handler);

		// Token: 0x06000455 RID: 1109
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> PropertiesAutowired(global::Autofac.Core.IPropertySelector propertySelector, bool allowCircularDependencies = false);

		// Token: 0x06000456 RID: 1110
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> WithMetadata(string key, object value);

		// Token: 0x06000457 RID: 1111
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> WithMetadata(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> properties);

		// Token: 0x06000458 RID: 1112
		global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> WithMetadata<TMetadata>(global::System.Action<global::Autofac.Builder.MetadataConfiguration<TMetadata>> configurationAction);
	}
}
