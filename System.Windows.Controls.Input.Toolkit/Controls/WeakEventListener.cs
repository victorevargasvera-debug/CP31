using System;

namespace System.Windows.Controls
{
	// Token: 0x02000020 RID: 32
	internal class WeakEventListener<TInstance, TSource, TEventArgs> where TInstance : class
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00007333 File Offset: 0x00005533
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000733B File Offset: 0x0000553B
		public global::System.Action<TInstance, TSource, TEventArgs> OnEventAction { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00007344 File Offset: 0x00005544
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000734C File Offset: 0x0000554C
		public global::System.Action<global::System.Windows.Controls.WeakEventListener<TInstance, TSource, TEventArgs>> OnDetachAction { get; set; }

		// Token: 0x060001C3 RID: 451 RVA: 0x00007355 File Offset: 0x00005555
		public WeakEventListener(TInstance instance)
		{
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			this._weakInstance = new global::System.WeakReference(instance);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00007384 File Offset: 0x00005584
		public void OnEvent(TSource source, TEventArgs eventArgs)
		{
			TInstance tinstance = (TInstance)((object)this._weakInstance.Target);
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

		// Token: 0x060001C5 RID: 453 RVA: 0x000073C7 File Offset: 0x000055C7
		public void Detach()
		{
			if (this.OnDetachAction != null)
			{
				this.OnDetachAction(this);
				this.OnDetachAction = null;
			}
		}

		// Token: 0x040000C1 RID: 193
		private global::System.WeakReference _weakInstance;
	}
}
