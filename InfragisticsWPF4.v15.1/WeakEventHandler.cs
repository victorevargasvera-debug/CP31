using System;

namespace Infragistics
{
	// Token: 0x020000AD RID: 173
	internal class WeakEventHandler<TInstance, TEventSource, TEventArgs> where TInstance : class
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x00018E31 File Offset: 0x00017031
		public WeakEventHandler(TInstance instance, TEventSource eventSource, global::System.Action<TInstance, object, TEventArgs> onEventAction, global::System.Action<global::Infragistics.WeakEventHandler<TInstance, TEventSource, TEventArgs>, TEventSource> onDetachAction)
		{
			this._weakInstance = new global::System.WeakReference(instance);
			this._weakEventSource = new global::System.WeakReference(eventSource);
			this.OnEventAction = onEventAction;
			this.OnDetachAction = onDetachAction;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00018E6A File Offset: 0x0001706A
		public TEventSource EventSource
		{
			get
			{
				return (TEventSource)((object)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._weakEventSource));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00018E7C File Offset: 0x0001707C
		public TInstance Instance
		{
			get
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._weakInstance) as TInstance;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00018E93 File Offset: 0x00017093
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00018E9B File Offset: 0x0001709B
		private global::System.Action<TInstance, object, TEventArgs> OnEventAction { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00018EA4 File Offset: 0x000170A4
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00018EAC File Offset: 0x000170AC
		private global::System.Action<global::Infragistics.WeakEventHandler<TInstance, TEventSource, TEventArgs>, TEventSource> OnDetachAction { get; set; }

		// Token: 0x0600069B RID: 1691 RVA: 0x00018EB8 File Offset: 0x000170B8
		public void OnEvent(object source, TEventArgs eventArgs)
		{
			TInstance tinstance = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._weakInstance) as TInstance;
			if (tinstance != null)
			{
				if (this.OnEventAction != null)
				{
					this.OnEventAction(tinstance, source, eventArgs);
					return;
				}
			}
			else
			{
				this.Detach();
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00018F00 File Offset: 0x00017100
		public void Detach()
		{
			TEventSource arg = (TEventSource)((object)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._weakEventSource));
			if (this.OnDetachAction != null && this._weakEventSource.IsAlive)
			{
				this.OnDetachAction(this, arg);
			}
			this.OnDetachAction = null;
		}

		// Token: 0x04000332 RID: 818
		private readonly global::System.WeakReference _weakInstance;

		// Token: 0x04000333 RID: 819
		private readonly global::System.WeakReference _weakEventSource;
	}
}
