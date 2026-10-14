using System;

namespace System.Windows.Controls
{
	// Token: 0x02000015 RID: 21
	internal class WeakEventListener<TInstance, TSource, TEventArgs> where TInstance : class
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000714F File Offset: 0x0000534F
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00007157 File Offset: 0x00005357
		public global::System.Action<TInstance, TSource, TEventArgs> OnEventAction { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00007160 File Offset: 0x00005360
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00007168 File Offset: 0x00005368
		public global::System.Action<global::System.Windows.Controls.WeakEventListener<TInstance, TSource, TEventArgs>> OnDetachAction { get; set; }

		// Token: 0x06000142 RID: 322 RVA: 0x00007171 File Offset: 0x00005371
		public WeakEventListener(TInstance instance)
		{
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			this._weakInstance = new global::System.WeakReference(instance);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000071A0 File Offset: 0x000053A0
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

		// Token: 0x06000144 RID: 324 RVA: 0x000071E3 File Offset: 0x000053E3
		public void Detach()
		{
			if (this.OnDetachAction != null)
			{
				this.OnDetachAction(this);
				this.OnDetachAction = null;
			}
		}

		// Token: 0x040000A0 RID: 160
		private global::System.WeakReference _weakInstance;
	}
}
