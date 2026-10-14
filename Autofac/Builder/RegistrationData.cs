using System;
using System.Collections.Generic;
using System.Linq;
using Autofac.Core;
using Autofac.Core.Lifetime;
using Autofac.Util;

namespace Autofac.Builder
{
	// Token: 0x020000C5 RID: 197
	public class RegistrationData
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		public RegistrationData(global::Autofac.Core.Service defaultService)
		{
			if (defaultService == null)
			{
				throw new global::System.ArgumentNullException("defaultService");
			}
			this._defaultService = defaultService;
			this.Metadata = new global::System.Collections.Generic.Dictionary<string, object>
			{
				{
					"__RegistrationOrder",
					global::Autofac.Util.SequenceGenerator.GetNextUniqueSequence()
				}
			};
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000D43C File Offset: 0x0000B63C
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> Services
		{
			get
			{
				if (this._defaultServiceOverridden)
				{
					return this._services;
				}
				return this._services.DefaultIfEmpty(this._defaultService);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000D460 File Offset: 0x0000B660
		public void AddServices(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			this._defaultServiceOverridden = true;
			foreach (global::Autofac.Core.Service service in services)
			{
				this.AddService(service);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		public void AddService(global::Autofac.Core.Service service)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			this._defaultServiceOverridden = true;
			this._services.Add(service);
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000D4E9 File Offset: 0x0000B6E9
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x0000D4F1 File Offset: 0x0000B6F1
		public global::Autofac.Core.InstanceOwnership Ownership { get; set; } = global::Autofac.Core.InstanceOwnership.OwnedByLifetimeScope;

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0000D4FA File Offset: 0x0000B6FA
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x0000D502 File Offset: 0x0000B702
		public global::Autofac.Core.IComponentLifetime Lifetime
		{
			get
			{
				return this._lifetime;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._lifetime = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0000D519 File Offset: 0x0000B719
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x0000D521 File Offset: 0x0000B721
		public global::Autofac.Core.InstanceSharing Sharing { get; set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0000D52A File Offset: 0x0000B72A
		public global::System.Collections.Generic.IDictionary<string, object> Metadata { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0000D532 File Offset: 0x0000B732
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0000D53A File Offset: 0x0000B73A
		public global::Autofac.Builder.DeferredCallback DeferredCallback { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000D543 File Offset: 0x0000B743
		public global::System.Collections.Generic.ICollection<global::System.EventHandler<global::Autofac.Core.PreparingEventArgs>> PreparingHandlers { get; } = new global::System.Collections.Generic.List<global::System.EventHandler<global::Autofac.Core.PreparingEventArgs>>();

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000D54B File Offset: 0x0000B74B
		public global::System.Collections.Generic.ICollection<global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>>> ActivatingHandlers { get; } = new global::System.Collections.Generic.List<global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>>>();

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000D553 File Offset: 0x0000B753
		public global::System.Collections.Generic.ICollection<global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>>> ActivatedHandlers { get; } = new global::System.Collections.Generic.List<global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>>>();

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000D55C File Offset: 0x0000B75C
		public void CopyFrom(global::Autofac.Builder.RegistrationData that, bool includeDefaultService)
		{
			if (that == null)
			{
				throw new global::System.ArgumentNullException("that");
			}
			this.Ownership = that.Ownership;
			this.Sharing = that.Sharing;
			this.Lifetime = that.Lifetime;
			this._defaultServiceOverridden |= that._defaultServiceOverridden;
			if (includeDefaultService)
			{
				this._defaultService = that._defaultService;
			}
			global::Autofac.Builder.RegistrationData.AddAll<global::Autofac.Core.Service>(this._services, that._services);
			global::Autofac.Builder.RegistrationData.AddAll<global::System.Collections.Generic.KeyValuePair<string, object>>(this.Metadata, from m in that.Metadata
			where m.Key != "__RegistrationOrder"
			select m);
			global::Autofac.Builder.RegistrationData.AddAll<global::System.EventHandler<global::Autofac.Core.PreparingEventArgs>>(this.PreparingHandlers, that.PreparingHandlers);
			global::Autofac.Builder.RegistrationData.AddAll<global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>>>(this.ActivatingHandlers, that.ActivatingHandlers);
			global::Autofac.Builder.RegistrationData.AddAll<global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>>>(this.ActivatedHandlers, that.ActivatedHandlers);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000D638 File Offset: 0x0000B838
		private static void AddAll<T>(global::System.Collections.Generic.ICollection<T> to, global::System.Collections.Generic.IEnumerable<T> from)
		{
			foreach (T item in from)
			{
				to.Add(item);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000D680 File Offset: 0x0000B880
		public void ClearServices()
		{
			this._services.Clear();
			this._defaultServiceOverridden = true;
		}

		// Token: 0x04000139 RID: 313
		private bool _defaultServiceOverridden;

		// Token: 0x0400013A RID: 314
		private global::Autofac.Core.Service _defaultService;

		// Token: 0x0400013B RID: 315
		private readonly global::System.Collections.Generic.ICollection<global::Autofac.Core.Service> _services = new global::System.Collections.Generic.HashSet<global::Autofac.Core.Service>();

		// Token: 0x0400013C RID: 316
		private global::Autofac.Core.IComponentLifetime _lifetime = new global::Autofac.Core.Lifetime.CurrentScopeLifetime();
	}
}
