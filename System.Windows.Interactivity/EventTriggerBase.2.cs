using System;

namespace System.Windows.Interactivity
{
	// Token: 0x0200000E RID: 14
	public abstract class EventTriggerBase<T> : global::System.Windows.Interactivity.EventTriggerBase where T : class
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00003405 File Offset: 0x00001605
		protected EventTriggerBase() : base(typeof(T))
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00003417 File Offset: 0x00001617
		public new T Source
		{
			get
			{
				return (T)((object)base.Source);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003424 File Offset: 0x00001624
		internal sealed override void OnSourceChangedImpl(object oldSource, object newSource)
		{
			base.OnSourceChangedImpl(oldSource, newSource);
			this.OnSourceChanged(oldSource as T, newSource as T);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000344A File Offset: 0x0000164A
		protected virtual void OnSourceChanged(T oldSource, T newSource)
		{
		}
	}
}
