using System;
using System.Collections.Generic;
using System.Linq;

namespace Autofac.Core.Registration
{
	// Token: 0x02000097 RID: 151
	internal class ServiceRegistrationInfo
	{
		// Token: 0x06000385 RID: 901 RVA: 0x0000AA60 File Offset: 0x00008C60
		public ServiceRegistrationInfo(global::Autofac.Core.Service service)
		{
			this._service = service;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000AA90 File Offset: 0x00008C90
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000AA98 File Offset: 0x00008C98
		public bool IsInitialized { get; private set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IComponentRegistration> Implementations
		{
			get
			{
				this.RequiresInitialization();
				return this._defaultImplementations.Reverse<global::Autofac.Core.IComponentRegistration>().Concat(this._sourceImplementations).Concat(this._preserveDefaultImplementations);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000AACA File Offset: 0x00008CCA
		private void RequiresInitialization()
		{
			if (!this.IsInitialized)
			{
				throw new global::System.InvalidOperationException(global::Autofac.Core.Registration.ServiceRegistrationInfoResources.NotInitialized);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000AADF File Offset: 0x00008CDF
		public bool IsRegistered
		{
			get
			{
				this.RequiresInitialization();
				return this.Any;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0000AAED File Offset: 0x00008CED
		private bool Any
		{
			get
			{
				return this._defaultImplementations.Any<global::Autofac.Core.IComponentRegistration>() || this._sourceImplementations.Any<global::Autofac.Core.IComponentRegistration>() || this._preserveDefaultImplementations.Any<global::Autofac.Core.IComponentRegistration>();
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000AB18 File Offset: 0x00008D18
		public void AddImplementation(global::Autofac.Core.IComponentRegistration registration, bool preserveDefaults, bool originatedFromSource)
		{
			if (preserveDefaults)
			{
				if (originatedFromSource)
				{
					this._sourceImplementations.Add(registration);
				}
				else
				{
					this._preserveDefaultImplementations.Add(registration);
				}
			}
			else
			{
				if (originatedFromSource)
				{
					throw new global::System.ArgumentOutOfRangeException("originatedFromSource");
				}
				this._defaultImplementations.Add(registration);
			}
			this._defaultImplementation = null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000AB68 File Offset: 0x00008D68
		public bool TryGetRegistration(out global::Autofac.Core.IComponentRegistration registration)
		{
			this.RequiresInitialization();
			global::Autofac.Core.IComponentRegistration componentRegistration;
			if ((componentRegistration = this._defaultImplementation) == null)
			{
				global::Autofac.Core.IComponentRegistration defaultImplementation;
				if ((defaultImplementation = this._defaultImplementations.LastOrDefault<global::Autofac.Core.IComponentRegistration>()) == null)
				{
					defaultImplementation = (this._sourceImplementations.FirstOrDefault<global::Autofac.Core.IComponentRegistration>() ?? this._preserveDefaultImplementations.FirstOrDefault<global::Autofac.Core.IComponentRegistration>());
				}
				componentRegistration = (this._defaultImplementation = defaultImplementation);
			}
			registration = componentRegistration;
			return registration != null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000ABBE File Offset: 0x00008DBE
		public void Include(global::Autofac.Core.IRegistrationSource source)
		{
			if (this.IsInitialized)
			{
				this.BeginInitialization(new global::Autofac.Core.IRegistrationSource[]
				{
					source
				});
				return;
			}
			if (this.IsInitializing)
			{
				this._sourcesToQuery.Enqueue(source);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000ABED File Offset: 0x00008DED
		public bool IsInitializing
		{
			get
			{
				return !this.IsInitialized && this._sourcesToQuery != null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000AC02 File Offset: 0x00008E02
		public bool HasSourcesToQuery
		{
			get
			{
				return this.IsInitializing && this._sourcesToQuery.Count != 0;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000AC1C File Offset: 0x00008E1C
		public void BeginInitialization(global::System.Collections.Generic.IEnumerable<global::Autofac.Core.IRegistrationSource> sources)
		{
			this.IsInitialized = false;
			this._sourcesToQuery = new global::System.Collections.Generic.Queue<global::Autofac.Core.IRegistrationSource>(sources);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000AC34 File Offset: 0x00008E34
		public void SkipSource(global::Autofac.Core.IRegistrationSource source)
		{
			this.EnforceDuringInitialization();
			this._sourcesToQuery = new global::System.Collections.Generic.Queue<global::Autofac.Core.IRegistrationSource>(from rs in this._sourcesToQuery
			where rs != source
			select rs);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000AC76 File Offset: 0x00008E76
		private void EnforceDuringInitialization()
		{
			if (!this.IsInitializing)
			{
				throw new global::System.InvalidOperationException(global::Autofac.Core.Registration.ServiceRegistrationInfoResources.NotDuringInitialization);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000AC8B File Offset: 0x00008E8B
		public global::Autofac.Core.IRegistrationSource DequeueNextSource()
		{
			this.EnforceDuringInitialization();
			return this._sourcesToQuery.Dequeue();
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000AC9E File Offset: 0x00008E9E
		public void CompleteInitialization()
		{
			this.IsInitialized = true;
			this._sourcesToQuery = null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000ACAE File Offset: 0x00008EAE
		public bool ShouldRecalculateAdaptersOn(global::Autofac.Core.IComponentRegistration registration)
		{
			return this.IsInitialized && (this._sourceImplementations.Any<global::Autofac.Core.IComponentRegistration>() || !this.Any);
		}

		// Token: 0x040000E0 RID: 224
		private readonly global::Autofac.Core.Service _service;

		// Token: 0x040000E1 RID: 225
		private readonly global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration> _defaultImplementations = new global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration>();

		// Token: 0x040000E2 RID: 226
		private readonly global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration> _sourceImplementations = new global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration>();

		// Token: 0x040000E3 RID: 227
		private readonly global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration> _preserveDefaultImplementations = new global::System.Collections.Generic.List<global::Autofac.Core.IComponentRegistration>();

		// Token: 0x040000E4 RID: 228
		private global::Autofac.Core.IComponentRegistration _defaultImplementation;

		// Token: 0x040000E5 RID: 229
		private global::System.Collections.Generic.Queue<global::Autofac.Core.IRegistrationSource> _sourcesToQuery;
	}
}
