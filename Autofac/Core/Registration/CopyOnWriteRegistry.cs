using System;
using System.Collections.Generic;
using Autofac.Util;

namespace Autofac.Core.Registration
{
	// Token: 0x02000092 RID: 146
	internal class CopyOnWriteRegistry : global::Autofac.Core.IComponentRegistry, global::System.IDisposable
	{
		// Token: 0x06000369 RID: 873 RVA: 0x0000A7C4 File Offset: 0x000089C4
		public CopyOnWriteRegistry(global::Autofac.Core.IComponentRegistry readRegistry, global::System.Func<global::Autofac.Core.IComponentRegistry> createWriteRegistry)
		{
			if (readRegistry == null)
			{
				throw new global::System.ArgumentNullException("readRegistry");
			}
			this._readRegistry = readRegistry;
			if (createWriteRegistry == null)
			{
				throw new global::System.ArgumentNullException("createWriteRegistry");
			}
			this._createWriteRegistry = createWriteRegistry;
			this.Properties = new global::Autofac.Util.FallbackDictionary<string, object>(readRegistry.Properties);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000A814 File Offset: 0x00008A14
		private global::Autofac.Core.IComponentRegistry Registry
		{
			get
			{
				return this._writeRegistry ?? this._readRegistry;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000A828 File Offset: 0x00008A28
		private global::Autofac.Core.IComponentRegistry WriteRegistry
		{
			get
			{
				global::Autofac.Core.IComponentRegistry result;
				if ((result = this._writeRegistry) == null)
				{
					result = (this._writeRegistry = this._createWriteRegistry());
				}
				return result;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000A853 File Offset: 0x00008A53
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0000A85B File Offset: 0x00008A5B
		public global::System.Collections.Generic.IDictionary<string, object> Properties { get; set; }

		// Token: 0x0600036E RID: 878 RVA: 0x0000A864 File Offset: 0x00008A64
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000A873 File Offset: 0x00008A73
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				global::Autofac.Core.IComponentRegistry writeRegistry = this._writeRegistry;
				if (writeRegistry == null)
				{
					return;
				}
				writeRegistry.Dispose();
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000A888 File Offset: 0x00008A88
		public bool TryGetRegistration(global::Autofac.Core.Service service, out global::Autofac.Core.IComponentRegistration registration)
		{
			return this.Registry.TryGetRegistration(service, out registration);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000A897 File Offset: 0x00008A97
		public bool IsRegistered(global::Autofac.Core.Service service)
		{
			return this.Registry.IsRegistered(service);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000A8A5 File Offset: 0x00008AA5
		public void Register(global::Autofac.Core.IComponentRegistration registration)
		{
			this.WriteRegistry.Register(registration);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000A8B3 File Offset: 0x00008AB3
		public void Register(global::Autofac.Core.IComponentRegistration registration, bool preserveDefaults)
		{
			this.WriteRegistry.Register(registration, preserveDefaults);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0000A8C2 File Offset: 0x00008AC2
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> Registrations
		{
			get
			{
				return this.Registry.Registrations;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000A8CF File Offset: 0x00008ACF
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> RegistrationsFor(global::Autofac.Core.Service service)
		{
			return this.Registry.RegistrationsFor(service);
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000376 RID: 886 RVA: 0x0000A8DD File Offset: 0x00008ADD
		// (remove) Token: 0x06000377 RID: 887 RVA: 0x0000A8EB File Offset: 0x00008AEB
		public event global::System.EventHandler<global::Autofac.Core.ComponentRegisteredEventArgs> Registered
		{
			add
			{
				this.WriteRegistry.Registered += value;
			}
			remove
			{
				this.WriteRegistry.Registered -= value;
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000A8F9 File Offset: 0x00008AF9
		public void AddRegistrationSource(global::Autofac.Core.IRegistrationSource source)
		{
			this.WriteRegistry.AddRegistrationSource(source);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000A907 File Offset: 0x00008B07
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> Sources
		{
			get
			{
				return this.Registry.Sources;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000A914 File Offset: 0x00008B14
		public bool HasLocalComponents
		{
			get
			{
				return this._writeRegistry != null;
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600037B RID: 891 RVA: 0x0000A91F File Offset: 0x00008B1F
		// (remove) Token: 0x0600037C RID: 892 RVA: 0x0000A92D File Offset: 0x00008B2D
		public event global::System.EventHandler<global::Autofac.Core.RegistrationSourceAddedEventArgs> RegistrationSourceAdded
		{
			add
			{
				this.WriteRegistry.RegistrationSourceAdded += value;
			}
			remove
			{
				this.WriteRegistry.RegistrationSourceAdded -= value;
			}
		}

		// Token: 0x040000D9 RID: 217
		private readonly global::Autofac.Core.IComponentRegistry _readRegistry;

		// Token: 0x040000DA RID: 218
		private readonly global::System.Func<global::Autofac.Core.IComponentRegistry> _createWriteRegistry;

		// Token: 0x040000DB RID: 219
		private global::Autofac.Core.IComponentRegistry _writeRegistry;
	}
}
