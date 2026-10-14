using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Autofac.Util;

namespace Autofac.Core.Registration
{
	// Token: 0x0200008D RID: 141
	public class ComponentRegistration : global::Autofac.Util.Disposable, global::Autofac.Core.IComponentRegistration, global::System.IDisposable
	{
		// Token: 0x06000325 RID: 805 RVA: 0x00009B70 File Offset: 0x00007D70
		public ComponentRegistration(global::System.Guid id, global::Autofac.Core.IInstanceActivator activator, global::Autofac.Core.IComponentLifetime lifetime, global::Autofac.Core.InstanceSharing sharing, global::Autofac.Core.InstanceOwnership ownership, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services, global::System.Collections.Generic.IDictionary<string, object> metadata)
		{
			if (activator == null)
			{
				throw new global::System.ArgumentNullException("activator");
			}
			if (lifetime == null)
			{
				throw new global::System.ArgumentNullException("lifetime");
			}
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (metadata == null)
			{
				throw new global::System.ArgumentNullException("metadata");
			}
			this.Id = id;
			this.Activator = activator;
			this.Lifetime = lifetime;
			this.Sharing = sharing;
			this.Ownership = ownership;
			this.Services = global::Autofac.Util.Enforce.ArgumentElementNotNull<global::Autofac.Core.Service>(services, "services");
			this.Metadata = metadata;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00009BFC File Offset: 0x00007DFC
		public ComponentRegistration(global::System.Guid id, global::Autofac.Core.IInstanceActivator activator, global::Autofac.Core.IComponentLifetime lifetime, global::Autofac.Core.InstanceSharing sharing, global::Autofac.Core.InstanceOwnership ownership, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> services, global::System.Collections.Generic.IDictionary<string, object> metadata, global::Autofac.Core.IComponentRegistration target) : this(id, activator, lifetime, sharing, ownership, services, metadata)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			this._target = target;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00009C26 File Offset: 0x00007E26
		public global::Autofac.Core.IComponentRegistration Target
		{
			get
			{
				return this._target ?? this;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00009C33 File Offset: 0x00007E33
		public global::System.Guid Id { get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00009C3B File Offset: 0x00007E3B
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00009C43 File Offset: 0x00007E43
		public global::Autofac.Core.IInstanceActivator Activator { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00009C4C File Offset: 0x00007E4C
		public global::Autofac.Core.IComponentLifetime Lifetime { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00009C54 File Offset: 0x00007E54
		public global::Autofac.Core.InstanceSharing Sharing { get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00009C5C File Offset: 0x00007E5C
		public global::Autofac.Core.InstanceOwnership Ownership { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00009C64 File Offset: 0x00007E64
		public global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Service> Services { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600032F RID: 815 RVA: 0x00009C6C File Offset: 0x00007E6C
		public global::System.Collections.Generic.IDictionary<string, object> Metadata { get; }

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000330 RID: 816 RVA: 0x00009C74 File Offset: 0x00007E74
		// (remove) Token: 0x06000331 RID: 817 RVA: 0x00009CAC File Offset: 0x00007EAC
		public event global::System.EventHandler<global::Autofac.Core.PreparingEventArgs> Preparing;

		// Token: 0x06000332 RID: 818 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public void RaisePreparing(global::Autofac.IComponentContext context, ref global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters)
		{
			global::System.EventHandler<global::Autofac.Core.PreparingEventArgs> preparing = this.Preparing;
			if (preparing == null)
			{
				return;
			}
			global::Autofac.Core.PreparingEventArgs preparingEventArgs = new global::Autofac.Core.PreparingEventArgs(context, this, parameters);
			preparing(this, preparingEventArgs);
			parameters = preparingEventArgs.Parameters;
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000333 RID: 819 RVA: 0x00009D18 File Offset: 0x00007F18
		// (remove) Token: 0x06000334 RID: 820 RVA: 0x00009D50 File Offset: 0x00007F50
		public event global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>> Activating;

		// Token: 0x06000335 RID: 821 RVA: 0x00009D88 File Offset: 0x00007F88
		public void RaiseActivating(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, ref object instance)
		{
			global::System.EventHandler<global::Autofac.Core.ActivatingEventArgs<object>> activating = this.Activating;
			if (activating == null)
			{
				return;
			}
			global::Autofac.Core.ActivatingEventArgs<object> activatingEventArgs = new global::Autofac.Core.ActivatingEventArgs<object>(context, this, parameters, instance);
			activating(this, activatingEventArgs);
			instance = activatingEventArgs.Instance;
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000336 RID: 822 RVA: 0x00009DBC File Offset: 0x00007FBC
		// (remove) Token: 0x06000337 RID: 823 RVA: 0x00009DF4 File Offset: 0x00007FF4
		public event global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>> Activated;

		// Token: 0x06000338 RID: 824 RVA: 0x00009E29 File Offset: 0x00008029
		public void RaiseActivated(global::Autofac.IComponentContext context, global::System.Collections.Generic.IEnumerable<global::Autofac.Core.Parameter> parameters, object instance)
		{
			global::System.EventHandler<global::Autofac.Core.ActivatedEventArgs<object>> activated = this.Activated;
			if (activated == null)
			{
				return;
			}
			activated(this, new global::Autofac.Core.ActivatedEventArgs<object>(context, this, parameters, instance));
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00009E48 File Offset: 0x00008048
		public override string ToString()
		{
			global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			string toStringFormat = global::Autofac.Core.Registration.ComponentRegistrationResources.ToStringFormat;
			object[] array = new object[5];
			array[0] = this.Activator;
			array[1] = (from s in this.Services
			select s.Description).JoinWith(", ");
			array[2] = this.Lifetime;
			array[3] = this.Sharing;
			array[4] = this.Ownership;
			return string.Format(currentCulture, toStringFormat, array);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00009ECF File Offset: 0x000080CF
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Activator.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x040000C3 RID: 195
		private readonly global::Autofac.Core.IComponentRegistration _target;
	}
}
