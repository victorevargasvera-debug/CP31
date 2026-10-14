using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Autofac.Core.Registration;

namespace Autofac
{
	// Token: 0x02000014 RID: 20
	public static class ResolutionExtensions
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00003DE1 File Offset: 0x00001FE1
		public static TService InjectProperties<TService>(this global::Autofac.IComponentContext context, TService instance)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, global::Autofac.Core.DefaultPropertySelector.OverwriteSetValueInstance, global::Autofac.ResolutionExtensions.NoParameters);
			return instance;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003DFA File Offset: 0x00001FFA
		public static TService InjectProperties<TService>(this global::Autofac.IComponentContext context, TService instance, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, global::Autofac.Core.DefaultPropertySelector.OverwriteSetValueInstance, parameters);
			return instance;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003E0F File Offset: 0x0000200F
		public static TService InjectProperties<TService>(this global::Autofac.IComponentContext context, TService instance, params global::Autofac.Core.Parameter[] parameters)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, global::Autofac.Core.DefaultPropertySelector.OverwriteSetValueInstance, parameters);
			return instance;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003E24 File Offset: 0x00002024
		public static TService InjectProperties<TService>(this global::Autofac.IComponentContext context, TService instance, global::Autofac.Core.IPropertySelector propertySelector)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, propertySelector, global::Autofac.ResolutionExtensions.NoParameters);
			return instance;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003E39 File Offset: 0x00002039
		public static TService InjectProperties<TService>(this global::Autofac.IComponentContext context, TService instance, global::Autofac.Core.IPropertySelector propertySelector, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, propertySelector, parameters);
			return instance;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003E4A File Offset: 0x0000204A
		public static TService InjectProperties<TService>(this global::Autofac.IComponentContext context, TService instance, global::Autofac.Core.IPropertySelector propertySelector, params global::Autofac.Core.Parameter[] parameters)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, propertySelector, parameters);
			return instance;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003E5B File Offset: 0x0000205B
		public static TService InjectUnsetProperties<TService>(this global::Autofac.IComponentContext context, TService instance)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, global::Autofac.Core.DefaultPropertySelector.PreserveSetValueInstance, global::Autofac.ResolutionExtensions.NoParameters);
			return instance;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003E74 File Offset: 0x00002074
		public static TService InjectUnsetProperties<TService>(this global::Autofac.IComponentContext context, TService instance, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, global::Autofac.Core.DefaultPropertySelector.PreserveSetValueInstance, parameters);
			return instance;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00003E89 File Offset: 0x00002089
		public static TService InjectUnsetProperties<TService>(this global::Autofac.IComponentContext context, TService instance, params global::Autofac.Core.Parameter[] parameters)
		{
			global::Autofac.Core.Activators.Reflection.AutowiringPropertyInjector.InjectProperties(context, instance, global::Autofac.Core.DefaultPropertySelector.PreserveSetValueInstance, parameters);
			return instance;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003E9E File Offset: 0x0000209E
		public static bool IsRegistered<TService>(this global::Autofac.IComponentContext context)
		{
			return context.IsRegistered(typeof(TService));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003EB0 File Offset: 0x000020B0
		public static bool IsRegistered(this global::Autofac.IComponentContext context, global::System.Type serviceType)
		{
			return context.IsRegisteredService(new global::Autofac.Core.TypedService(serviceType));
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003EBE File Offset: 0x000020BE
		public static bool IsRegisteredService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			return context.ComponentRegistry.IsRegistered(service);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003EEE File Offset: 0x000020EE
		public static bool IsRegisteredWithKey<TService>(this global::Autofac.IComponentContext context, object serviceKey)
		{
			return context.IsRegisteredWithKey(serviceKey, typeof(TService));
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003F01 File Offset: 0x00002101
		public static bool IsRegisteredWithKey(this global::Autofac.IComponentContext context, object serviceKey, global::System.Type serviceType)
		{
			return context.IsRegisteredService(new global::Autofac.Core.KeyedService(serviceKey, serviceType));
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003F10 File Offset: 0x00002110
		public static bool IsRegisteredWithName<TService>(this global::Autofac.IComponentContext context, string serviceName)
		{
			return context.IsRegisteredWithKey(serviceName);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003F19 File Offset: 0x00002119
		public static bool IsRegisteredWithName(this global::Autofac.IComponentContext context, string serviceName, global::System.Type serviceType)
		{
			return context.IsRegisteredWithKey(serviceName, serviceType);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003F23 File Offset: 0x00002123
		public static TService Resolve<TService>(this global::Autofac.IComponentContext context)
		{
			return context.Resolve(global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003F30 File Offset: 0x00002130
		public static TService Resolve<TService>(this global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return (TService)((object)context.Resolve(typeof(TService), parameters));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003F48 File Offset: 0x00002148
		public static TService Resolve<TService>(this global::Autofac.IComponentContext context, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.Resolve(parameters);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00003F51 File Offset: 0x00002151
		public static object Resolve(this global::Autofac.IComponentContext context, global::System.Type serviceType)
		{
			return context.Resolve(serviceType, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003F5F File Offset: 0x0000215F
		public static object Resolve(this global::Autofac.IComponentContext context, global::System.Type serviceType, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return context.ResolveService(new global::Autofac.Core.TypedService(serviceType), parameters);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003F6E File Offset: 0x0000216E
		public static object Resolve(this global::Autofac.IComponentContext context, global::System.Type serviceType, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.Resolve(serviceType, parameters);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003F78 File Offset: 0x00002178
		public static TService ResolveKeyed<TService>(this global::Autofac.IComponentContext context, object serviceKey)
		{
			return context.ResolveKeyed(serviceKey, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003F86 File Offset: 0x00002186
		public static TService ResolveKeyed<TService>(this global::Autofac.IComponentContext context, object serviceKey, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return (TService)((object)context.ResolveService(new global::Autofac.Core.KeyedService(serviceKey, typeof(TService)), parameters));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003FA4 File Offset: 0x000021A4
		public static TService ResolveKeyed<TService>(this global::Autofac.IComponentContext context, object serviceKey, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveKeyed(serviceKey, parameters);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003FAE File Offset: 0x000021AE
		public static object ResolveKeyed(this global::Autofac.IComponentContext context, object serviceKey, global::System.Type serviceType)
		{
			return context.ResolveKeyed(serviceKey, serviceType, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003FBD File Offset: 0x000021BD
		public static object ResolveKeyed(this global::Autofac.IComponentContext context, object serviceKey, global::System.Type serviceType, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return context.ResolveService(new global::Autofac.Core.KeyedService(serviceKey, serviceType), parameters);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003FCD File Offset: 0x000021CD
		public static object ResolveKeyed(this global::Autofac.IComponentContext context, object serviceKey, global::System.Type serviceType, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveKeyed(serviceKey, serviceType, parameters);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003FD8 File Offset: 0x000021D8
		public static TService ResolveNamed<TService>(this global::Autofac.IComponentContext context, string serviceName)
		{
			return context.ResolveNamed(serviceName, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003FE6 File Offset: 0x000021E6
		public static TService ResolveNamed<TService>(this global::Autofac.IComponentContext context, string serviceName, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return (TService)((object)context.ResolveService(new global::Autofac.Core.KeyedService(serviceName, typeof(TService)), parameters));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004004 File Offset: 0x00002204
		public static TService ResolveNamed<TService>(this global::Autofac.IComponentContext context, string serviceName, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveNamed(serviceName, parameters);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000400E File Offset: 0x0000220E
		public static object ResolveNamed(this global::Autofac.IComponentContext context, string serviceName, global::System.Type serviceType)
		{
			return context.ResolveNamed(serviceName, serviceType, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000401D File Offset: 0x0000221D
		public static object ResolveNamed(this global::Autofac.IComponentContext context, string serviceName, global::System.Type serviceType, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return context.ResolveService(new global::Autofac.Core.KeyedService(serviceName, serviceType), parameters);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000402D File Offset: 0x0000222D
		public static object ResolveNamed(this global::Autofac.IComponentContext context, string serviceName, global::System.Type serviceType, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveNamed(serviceName, serviceType, parameters);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004038 File Offset: 0x00002238
		public static TService ResolveOptional<TService>(this global::Autofac.IComponentContext context) where TService : class
		{
			return context.ResolveOptional(global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004045 File Offset: 0x00002245
		public static TService ResolveOptional<TService>(this global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters) where TService : class
		{
			return (TService)((object)context.ResolveOptionalService(new global::Autofac.Core.TypedService(typeof(TService)), parameters));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004062 File Offset: 0x00002262
		public static TService ResolveOptional<TService>(this global::Autofac.IComponentContext context, params global::Autofac.Core.Parameter[] parameters) where TService : class
		{
			return context.ResolveOptional(parameters);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000406B File Offset: 0x0000226B
		public static object ResolveOptional(this global::Autofac.IComponentContext context, global::System.Type serviceType)
		{
			return context.ResolveOptional(serviceType, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004079 File Offset: 0x00002279
		public static object ResolveOptional(this global::Autofac.IComponentContext context, global::System.Type serviceType, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			return context.ResolveOptionalService(new global::Autofac.Core.TypedService(serviceType), parameters);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004088 File Offset: 0x00002288
		public static object ResolveOptional(this global::Autofac.IComponentContext context, global::System.Type serviceType, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveOptional(serviceType, parameters);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004092 File Offset: 0x00002292
		public static TService ResolveOptionalKeyed<TService>(this global::Autofac.IComponentContext context, object serviceKey) where TService : class
		{
			return context.ResolveOptionalKeyed(serviceKey, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000040A0 File Offset: 0x000022A0
		public static TService ResolveOptionalKeyed<TService>(this global::Autofac.IComponentContext context, object serviceKey, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters) where TService : class
		{
			return (TService)((object)context.ResolveOptionalService(new global::Autofac.Core.KeyedService(serviceKey, typeof(TService)), parameters));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000040BE File Offset: 0x000022BE
		public static TService ResolveOptionalKeyed<TService>(this global::Autofac.IComponentContext context, object serviceKey, params global::Autofac.Core.Parameter[] parameters) where TService : class
		{
			return context.ResolveOptionalKeyed(serviceKey, parameters);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000040C8 File Offset: 0x000022C8
		public static TService ResolveOptionalNamed<TService>(this global::Autofac.IComponentContext context, string serviceName) where TService : class
		{
			return context.ResolveOptionalKeyed(serviceName);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000040D1 File Offset: 0x000022D1
		public static TService ResolveOptionalNamed<TService>(this global::Autofac.IComponentContext context, string serviceName, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters) where TService : class
		{
			return context.ResolveOptionalKeyed(serviceName, parameters);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000040DB File Offset: 0x000022DB
		public static TService ResolveOptionalNamed<TService>(this global::Autofac.IComponentContext context, string serviceName, params global::Autofac.Core.Parameter[] parameters) where TService : class
		{
			return context.ResolveOptionalKeyed(serviceName, parameters);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000040E5 File Offset: 0x000022E5
		public static object ResolveOptionalService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service)
		{
			return context.ResolveOptionalService(service, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000040F4 File Offset: 0x000022F4
		public static object ResolveOptionalService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			object result;
			context.TryResolveService(service, parameters, out result);
			return result;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000413D File Offset: 0x0000233D
		public static object ResolveOptionalService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveOptionalService(service, parameters);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004147 File Offset: 0x00002347
		public static object ResolveService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service)
		{
			return context.ResolveService(service, global::Autofac.ResolutionExtensions.NoParameters);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004158 File Offset: 0x00002358
		public static object ResolveService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			object result;
			if (!context.TryResolveService(service, parameters, out result))
			{
				throw new global::Autofac.Core.Registration.ComponentNotRegisteredException(service);
			}
			return result;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000041A9 File Offset: 0x000023A9
		public static object ResolveService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service, params global::Autofac.Core.Parameter[] parameters)
		{
			return context.ResolveService(service, parameters);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000041B4 File Offset: 0x000023B4
		public static bool TryResolve<T>(this global::Autofac.IComponentContext context, out T instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			object obj;
			bool flag = context.TryResolve(typeof(T), out obj);
			instance = (flag ? ((T)((object)obj)) : default(T));
			return flag;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000041FD File Offset: 0x000023FD
		public static bool TryResolve(this global::Autofac.IComponentContext context, global::System.Type serviceType, out object instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			return context.TryResolveService(new global::Autofac.Core.TypedService(serviceType), global::Autofac.ResolutionExtensions.NoParameters, out instance);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000421F File Offset: 0x0000241F
		public static bool TryResolveKeyed(this global::Autofac.IComponentContext context, object serviceKey, global::System.Type serviceType, out object instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			return context.TryResolveService(new global::Autofac.Core.KeyedService(serviceKey, serviceType), global::Autofac.ResolutionExtensions.NoParameters, out instance);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004242 File Offset: 0x00002442
		public static bool TryResolveNamed(this global::Autofac.IComponentContext context, string serviceName, global::System.Type serviceType, out object instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			return context.TryResolveService(new global::Autofac.Core.KeyedService(serviceName, serviceType), global::Autofac.ResolutionExtensions.NoParameters, out instance);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004265 File Offset: 0x00002465
		public static bool TryResolveService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service, out object instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			return context.TryResolveService(service, global::Autofac.ResolutionExtensions.NoParameters, out instance);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00004284 File Offset: 0x00002484
		public static bool TryResolveService(this global::Autofac.IComponentContext context, global::Autofac.Core.Service service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, out object instance)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			global::Autofac.Core.IComponentRegistration registration;
			if (!context.ComponentRegistry.TryGetRegistration(service, out registration))
			{
				instance = null;
				return false;
			}
			instance = context.ResolveComponent(registration, parameters);
			return true;
		}

		// Token: 0x04000017 RID: 23
		public const string PropertyInjectedInstanceTypeNamedParameter = "Autofac.AutowiringPropertyInjector.InstanceType";

		// Token: 0x04000018 RID: 24
		private static readonly global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> NoParameters = global::System.Linq.Enumerable.Empty<global::Autofac.Core.Parameter>();
	}
}
