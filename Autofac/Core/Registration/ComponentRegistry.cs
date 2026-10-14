using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Util;

namespace Autofac.Core.Registration
{
	// Token: 0x02000091 RID: 145
	public class ComponentRegistry : global::Autofac.Util.Disposable, global::Autofac.Core.IComponentRegistry, global::System.IDisposable
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0000A097 File Offset: 0x00008297
		public ComponentRegistry() : this(new global::System.Collections.Generic.Dictionary<string, object>())
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000A0A4 File Offset: 0x000082A4
		internal ComponentRegistry(global::System.Collections.Generic.IDictionary<string, object> properties)
		{
			this.Properties = properties;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000A0DF File Offset: 0x000082DF
		public global::System.Collections.Generic.IDictionary<string, object> Properties { get; }

		// Token: 0x06000357 RID: 855 RVA: 0x0000A0E8 File Offset: 0x000082E8
		protected override void Dispose(bool disposing)
		{
			foreach (global::Autofac.Core.IComponentRegistration componentRegistration in this._registrations)
			{
				componentRegistration.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000A13C File Offset: 0x0000833C
		public bool TryGetRegistration(global::Autofac.Core.Service service, out global::Autofac.Core.IComponentRegistration registration)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			object synchRoot = this._synchRoot;
			bool result;
			lock (synchRoot)
			{
				result = this.GetInitializedServiceInfo(service).TryGetRegistration(out registration);
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000A19C File Offset: 0x0000839C
		public bool IsRegistered(global::Autofac.Core.Service service)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			object synchRoot = this._synchRoot;
			bool isRegistered;
			lock (synchRoot)
			{
				isRegistered = this.GetInitializedServiceInfo(service).IsRegistered;
			}
			return isRegistered;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public void Register(global::Autofac.Core.IComponentRegistration registration)
		{
			this.Register(registration, false);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000A204 File Offset: 0x00008404
		public void Register(global::Autofac.Core.IComponentRegistration registration, bool preserveDefaults)
		{
			if (registration == null)
			{
				throw new global::System.ArgumentNullException("registration");
			}
			object synchRoot = this._synchRoot;
			lock (synchRoot)
			{
				this.AddRegistration(registration, preserveDefaults, false);
				this.UpdateInitialisedAdapters(registration);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000A25C File Offset: 0x0000845C
		private void UpdateInitialisedAdapters(global::Autofac.Core.IComponentRegistration registration)
		{
			global::Autofac.Core.Service[] array = (from si in this._serviceInfo
			where si.Value.ShouldRecalculateAdaptersOn(registration)
			select si.Key).ToArray<global::Autofac.Core.Service>();
			if (array.Length == 0)
			{
				return;
			}
			foreach (global::Autofac.Core.IComponentRegistration registration2 in new global::Autofac.Core.Registration.AdaptationSandbox(from rs in this._dynamicRegistrationSources
			where rs.IsAdapterForIndividualComponents
			select rs, registration, array).GetAdapters())
			{
				this.AddRegistration(registration2, true, true);
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000A334 File Offset: 0x00008534
		protected virtual void AddRegistration(global::Autofac.Core.IComponentRegistration registration, bool preserveDefaults, bool originatedFromSource = false)
		{
			foreach (global::Autofac.Core.Service service in registration.Services)
			{
				this.GetServiceInfo(service).AddImplementation(registration, preserveDefaults, originatedFromSource);
			}
			this._registrations.Add(registration);
			global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs> registered = this.Registered;
			if (registered == null)
			{
				return;
			}
			registered(this, new global::Autofac.Core.ComponentRegisteredEventArgs(this, registration));
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000A3B0 File Offset: 0x000085B0
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> Registrations
		{
			get
			{
				object synchRoot = this._synchRoot;
				global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> result;
				lock (synchRoot)
				{
					result = this._registrations.ToArray<global::Autofac.Core.IComponentRegistration>();
				}
				return result;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000A3F8 File Offset: 0x000085F8
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			object synchRoot = this._synchRoot;
			global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> result;
			lock (synchRoot)
			{
				result = this.GetInitializedServiceInfo(service).Implementations.ToArray<global::Autofac.Core.IComponentRegistration>();
			}
			return result;
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000360 RID: 864 RVA: 0x0000A45C File Offset: 0x0000865C
		// (remove) Token: 0x06000361 RID: 865 RVA: 0x0000A494 File Offset: 0x00008694
		public event global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs> Registered;

		// Token: 0x06000362 RID: 866 RVA: 0x0000A4CC File Offset: 0x000086CC
		public void AddRegistrationSource(global::Autofac.Core.IRegistrationSource source)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			object synchRoot = this._synchRoot;
			lock (synchRoot)
			{
				this._dynamicRegistrationSources.Insert(0, source);
				foreach (global::System.Collections.Generic.KeyValuePair<global::Autofac.Core.Service, global::Autofac.Core.Registration.ServiceRegistrationInfo> keyValuePair in this._serviceInfo)
				{
					keyValuePair.Value.Include(source);
				}
				global::System.EventHandler<global::Autofac.Core.RegistrationSourceAddedEventArgs> registrationSourceAdded = this.RegistrationSourceAdded;
				if (registrationSourceAdded != null)
				{
					registrationSourceAdded(this, new global::Autofac.Core.RegistrationSourceAddedEventArgs(this, source));
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000A57C File Offset: 0x0000877C
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> Sources
		{
			get
			{
				object synchRoot = this._synchRoot;
				global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> result;
				lock (synchRoot)
				{
					result = this._dynamicRegistrationSources.ToArray<global::Autofac.Core.IRegistrationSource>();
				}
				return result;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000A5C4 File Offset: 0x000087C4
		public bool HasLocalComponents
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000365 RID: 869 RVA: 0x0000A5C8 File Offset: 0x000087C8
		// (remove) Token: 0x06000366 RID: 870 RVA: 0x0000A600 File Offset: 0x00008800
		public event global::System.EventHandler<global::Autofac.Core.RegistrationSourceAddedEventArgs> RegistrationSourceAdded;

		// Token: 0x06000367 RID: 871 RVA: 0x0000A638 File Offset: 0x00008838
		private global::Autofac.Core.Registration.ServiceRegistrationInfo GetInitializedServiceInfo(global::Autofac.Core.Service service)
		{
			global::Autofac.Core.Registration.ServiceRegistrationInfo serviceInfo = this.GetServiceInfo(service);
			if (serviceInfo.IsInitialized)
			{
				return serviceInfo;
			}
			if (!serviceInfo.IsInitializing)
			{
				serviceInfo.BeginInitialization(this._dynamicRegistrationSources);
			}
			while (serviceInfo.HasSourcesToQuery)
			{
				global::Autofac.Core.IRegistrationSource next = serviceInfo.DequeueNextSource();
				global::System.Func<global::Autofac.Core.IRegistrationSource, bool> <>9__0;
				foreach (global::Autofac.Core.IComponentRegistration componentRegistration in next.RegistrationsFor(service, new global::System.Func<global::Autofac.Core.Service, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration>>(this.RegistrationsFor)))
				{
					foreach (global::Autofac.Core.Service service2 in componentRegistration.Services)
					{
						global::Autofac.Core.Registration.ServiceRegistrationInfo serviceInfo2 = this.GetServiceInfo(service2);
						if (!serviceInfo2.IsInitialized && serviceInfo2 != serviceInfo)
						{
							if (!serviceInfo2.IsInitializing)
							{
								global::Autofac.Core.Registration.ServiceRegistrationInfo serviceRegistrationInfo = serviceInfo2;
								global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> dynamicRegistrationSources = this._dynamicRegistrationSources;
								global::System.Func<global::Autofac.Core.IRegistrationSource, bool> predicate;
								if ((predicate = <>9__0) == null)
								{
									predicate = (<>9__0 = ((global::Autofac.Core.IRegistrationSource src) => src != next));
								}
								serviceRegistrationInfo.BeginInitialization(dynamicRegistrationSources.Where(predicate));
							}
							else
							{
								serviceInfo2.SkipSource(next);
							}
						}
					}
					this.AddRegistration(componentRegistration, true, true);
				}
			}
			serviceInfo.CompleteInitialization();
			return serviceInfo;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000A790 File Offset: 0x00008990
		private global::Autofac.Core.Registration.ServiceRegistrationInfo GetServiceInfo(global::Autofac.Core.Service service)
		{
			global::Autofac.Core.Registration.ServiceRegistrationInfo result;
			if (this._serviceInfo.TryGetValue(service, out result))
			{
				return result;
			}
			global::Autofac.Core.Registration.ServiceRegistrationInfo serviceRegistrationInfo = new global::Autofac.Core.Registration.ServiceRegistrationInfo(service);
			this._serviceInfo.Add(service, serviceRegistrationInfo);
			return serviceRegistrationInfo;
		}

		// Token: 0x040000D2 RID: 210
		private readonly object _synchRoot = new object();

		// Token: 0x040000D3 RID: 211
		private readonly global::System.Collections.Generic.IList<global::Autofac.Core.IRegistrationSource> _dynamicRegistrationSources = new global::System.Collections.Generic.List<global::Autofac.Core.IRegistrationSource>();

		// Token: 0x040000D4 RID: 212
		private readonly global::System.Collections.Generic.ICollection<global::Autofac.Core.IComponentRegistration> _registrations = new global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration>();

		// Token: 0x040000D5 RID: 213
		private readonly global::System.Collections.Generic.IDictionary<global::Autofac.Core.Service, global::Autofac.Core.Registration.ServiceRegistrationInfo> _serviceInfo = new global::System.Collections.Generic.Dictionary<global::Autofac.Core.Service, global::Autofac.Core.Registration.ServiceRegistrationInfo>();
	}
}
