using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Autofac.Core.Lifetime;

namespace Autofac.Builder
{
	// Token: 0x020000C4 RID: 196
	internal class RegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> : global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle>, global::Autofac.Builder.IHideObjectMembers
	{
		// Token: 0x06000473 RID: 1139 RVA: 0x0000CE9C File Offset: 0x0000B09C
		public RegistrationBuilder(global::Autofac.Core.Service defaultService, TActivatorData activatorData, TRegistrationStyle style)
		{
			if (defaultService == null)
			{
				throw new global::System.ArgumentNullException("defaultService");
			}
			if (activatorData == null)
			{
				throw new global::System.ArgumentNullException("activatorData");
			}
			if (style == null)
			{
				throw new global::System.ArgumentNullException("style");
			}
			this.ActivatorData = activatorData;
			this.RegistrationStyle = style;
			this.RegistrationData = new global::Autofac.Builder.RegistrationData(defaultService);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000CF03 File Offset: 0x0000B103
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public TActivatorData ActivatorData { get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000CF0B File Offset: 0x0000B10B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public TRegistrationStyle RegistrationStyle { get; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000CF13 File Offset: 0x0000B113
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Autofac.Builder.RegistrationData RegistrationData { get; }

		// Token: 0x06000477 RID: 1143 RVA: 0x0000CF1B File Offset: 0x0000B11B
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> ExternallyOwned()
		{
			this.RegistrationData.Ownership = global::Autofac.Core.InstanceOwnership.ExternallyOwned;
			return this;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000CF2A File Offset: 0x0000B12A
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OwnedByLifetimeScope()
		{
			this.RegistrationData.Ownership = global::Autofac.Core.InstanceOwnership.OwnedByLifetimeScope;
			return this;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000CF39 File Offset: 0x0000B139
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerDependency()
		{
			this.RegistrationData.Sharing = global::Autofac.Core.InstanceSharing.None;
			this.RegistrationData.Lifetime = new global::Autofac.Core.Lifetime.CurrentScopeLifetime();
			return this;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000CF58 File Offset: 0x0000B158
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> SingleInstance()
		{
			this.RegistrationData.Sharing = global::Autofac.Core.InstanceSharing.Shared;
			this.RegistrationData.Lifetime = new global::Autofac.Core.Lifetime.RootScopeLifetime();
			return this;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000CF77 File Offset: 0x0000B177
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerLifetimeScope()
		{
			this.RegistrationData.Sharing = global::Autofac.Core.InstanceSharing.Shared;
			this.RegistrationData.Lifetime = new global::Autofac.Core.Lifetime.CurrentScopeLifetime();
			return this;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000CF96 File Offset: 0x0000B196
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerMatchingLifetimeScope(params object[] lifetimeScopeTag)
		{
			if (lifetimeScopeTag == null)
			{
				throw new global::System.ArgumentNullException("lifetimeScopeTag");
			}
			this.RegistrationData.Sharing = global::Autofac.Core.InstanceSharing.Shared;
			this.RegistrationData.Lifetime = new global::Autofac.Core.Lifetime.MatchingScopeLifetime(lifetimeScopeTag);
			return this;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned<TService>()
		{
			return this.InstancePerOwned(typeof(TService));
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000CFD6 File Offset: 0x0000B1D6
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned(global::System.Type serviceType)
		{
			return this.InstancePerMatchingLifetimeScope(new object[]
			{
				new global::Autofac.Core.TypedService(serviceType)
			});
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000CFED File Offset: 0x0000B1ED
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned<TService>(object serviceKey)
		{
			return this.InstancePerOwned(serviceKey, typeof(TService));
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000D000 File Offset: 0x0000B200
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> InstancePerOwned(object serviceKey, global::System.Type serviceType)
		{
			return this.InstancePerMatchingLifetimeScope(new object[]
			{
				new global::Autofac.Core.KeyedService(serviceKey, serviceType)
			});
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000D018 File Offset: 0x0000B218
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As<TService>()
		{
			return this.As(new global::Autofac.Core.Service[]
			{
				new global::Autofac.Core.TypedService(typeof(TService))
			});
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000D038 File Offset: 0x0000B238
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As<TService1, TService2>()
		{
			return this.As(new global::Autofac.Core.Service[]
			{
				new global::Autofac.Core.TypedService(typeof(TService1)),
				new global::Autofac.Core.TypedService(typeof(TService2))
			});
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000D06C File Offset: 0x0000B26C
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As<TService1, TService2, TService3>()
		{
			return this.As(new global::Autofac.Core.Service[]
			{
				new global::Autofac.Core.TypedService(typeof(TService1)),
				new global::Autofac.Core.TypedService(typeof(TService2)),
				new global::Autofac.Core.TypedService(typeof(TService3))
			});
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000D0BB File Offset: 0x0000B2BB
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As(params global::System.Type[] services)
		{
			return this.As(services.Select(delegate(global::System.Type t)
			{
				if (t.FullName == null)
				{
					return new global::Autofac.Core.TypedService(t.GetGenericTypeDefinition());
				}
				return new global::Autofac.Core.TypedService(t);
			}).Cast<global::Autofac.Core.Service>().ToArray<global::Autofac.Core.Service>());
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000D0F2 File Offset: 0x0000B2F2
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> As(params global::Autofac.Core.Service[] services)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			this.RegistrationData.AddServices(services);
			return this;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000D10F File Offset: 0x0000B30F
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Named(string serviceName, global::System.Type serviceType)
		{
			if (serviceName == null)
			{
				throw new global::System.ArgumentNullException("serviceName");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return this.As(new global::Autofac.Core.Service[]
			{
				new global::Autofac.Core.KeyedService(serviceName, serviceType)
			});
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000D149 File Offset: 0x0000B349
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Named<TService>(string serviceName)
		{
			return this.Named(serviceName, typeof(TService));
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000D15C File Offset: 0x0000B35C
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Keyed(object serviceKey, global::System.Type serviceType)
		{
			if (serviceKey == null)
			{
				throw new global::System.ArgumentNullException("serviceKey");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return this.As(new global::Autofac.Core.Service[]
			{
				new global::Autofac.Core.KeyedService(serviceKey, serviceType)
			});
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000D196 File Offset: 0x0000B396
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> Keyed<TService>(object serviceKey)
		{
			return this.Keyed(serviceKey, typeof(TService));
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000D1AC File Offset: 0x0000B3AC
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnPreparing(global::System.Action<global::Autofac.Core.PreparingEventArgs> handler)
		{
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			this.RegistrationData.PreparingHandlers.Add(delegate(object s, global::Autofac.Core.PreparingEventArgs e)
			{
				handler(e);
			});
			return this;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnActivating(global::System.Action<global::Autofac.Core.IActivatingEventArgs<TLimit>> handler)
		{
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			this.RegistrationData.ActivatingHandlers.Add(delegate(object s, global::Autofac.Core.ActivatingEventArgs<object> e)
			{
				global::Autofac.Core.ActivatingEventArgs<TLimit> activatingEventArgs = new global::Autofac.Core.ActivatingEventArgs<TLimit>(e.Context, e.Component, e.Parameters, (TLimit)((object)e.Instance));
				handler(activatingEventArgs);
				e.Instance = activatingEventArgs.Instance;
			});
			return this;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000D244 File Offset: 0x0000B444
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> OnActivated(global::System.Action<global::Autofac.Core.IActivatedEventArgs<TLimit>> handler)
		{
			if (handler == null)
			{
				throw new global::System.ArgumentNullException("handler");
			}
			this.RegistrationData.ActivatedHandlers.Add(delegate(object s, global::Autofac.Core.ActivatedEventArgs<object> e)
			{
				handler(new global::Autofac.Core.ActivatedEventArgs<TLimit>(e.Context, e.Component, e.Parameters, (TLimit)((object)e.Instance)));
			});
			return this;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000D290 File Offset: 0x0000B490
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> PropertiesAutowired(global::Autofac.Core.IPropertySelector propertySelector, bool allowCircularDependencies)
		{
			if (allowCircularDependencies)
			{
				this.RegistrationData.ActivatedHandlers.Add(delegate(object s, global::Autofac.Core.ActivatedEventArgs<object> e)
				{
					global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(e.Context, e.Instance, propertySelector, e.Parameters);
				});
			}
			else
			{
				this.RegistrationData.ActivatingHandlers.Add(delegate(object s, global::Autofac.Core.ActivatingEventArgs<object> e)
				{
					global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(e.Context, e.Instance, propertySelector, e.Parameters);
				});
			}
			return this;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> WithMetadata(string key, object value)
		{
			if (key == null)
			{
				throw new global::System.ArgumentNullException("key");
			}
			this.RegistrationData.Metadata.Add(key, value);
			return this;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000D30C File Offset: 0x0000B50C
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> WithMetadata(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> properties)
		{
			if (properties == null)
			{
				throw new global::System.ArgumentNullException("properties");
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in properties)
			{
				this.WithMetadata(keyValuePair.Key, keyValuePair.Value);
			}
			return this;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000D374 File Offset: 0x0000B574
		public global::Autofac.Builder.IRegistrationBuilder<TLimit, TActivatorData, TRegistrationStyle> WithMetadata<TMetadata>(global::System.Action<global::Autofac.Builder.MetadataConfiguration<TMetadata>> configurationAction)
		{
			if (configurationAction == null)
			{
				throw new global::System.ArgumentNullException("configurationAction");
			}
			global::Autofac.Builder.MetadataConfiguration<TMetadata> metadataConfiguration = new global::Autofac.Builder.MetadataConfiguration<TMetadata>();
			configurationAction(metadataConfiguration);
			return this.WithMetadata(metadataConfiguration.Properties);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		global::System.Type global::Autofac.Builder.IHideObjectMembers.GetType()
		{
			return base.GetType();
		}
	}
}
