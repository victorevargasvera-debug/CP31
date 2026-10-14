using System;

namespace Infragistics
{
	// Token: 0x02000094 RID: 148
	internal class WeakEventHandler<TInstance, TEventSource, TEventArgs> where TInstance : class
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x000157B9 File Offset: 0x000139B9
		public WeakEventHandler(TInstance instance, TEventSource eventSource, global::System.Action<TInstance, object, TEventArgs> onEventAction, global::System.Action<global::Infragistics.WeakEventHandler<TInstance, TEventSource, TEventArgs>, TEventSource> onDetachAction)
		{
			this._weakInstance = new global::System.WeakReference(instance);
			this._weakEventSource = new global::System.WeakReference(eventSource);
			this.OnEventAction = onEventAction;
			this.OnDetachAction = onDetachAction;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x000157F2 File Offset: 0x000139F2
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x000157FA File Offset: 0x000139FA
		private global::System.Action<TInstance, object, TEventArgs> OnEventAction { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00015803 File Offset: 0x00013A03
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x0001580B File Offset: 0x00013A0B
		private global::System.Action<global::Infragistics.WeakEventHandler<TInstance, TEventSource, TEventArgs>, TEventSource> OnDetachAction { get; set; }

		// Token: 0x060005BC RID: 1468 RVA: 0x00015814 File Offset: 0x00013A14
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

		// Token: 0x060005BD RID: 1469 RVA: 0x0001585C File Offset: 0x00013A5C
		public void Detach()
		{
			TEventSource arg = (TEventSource)((object)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._weakEventSource));
			if (this.OnDetachAction != null && this._weakEventSource.IsAlive)
			{
				this.OnDetachAction(this, arg);
			}
			this.OnDetachAction = null;
		}

		// Token: 0x040002AF RID: 687
		private readonly global::System.WeakReference _weakInstance;

		// Token: 0x040002B0 RID: 688
		private readonly global::System.WeakReference _weakEventSource;
	}
}
