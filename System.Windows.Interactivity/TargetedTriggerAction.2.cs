using System;

namespace System.Windows.Interactivity
{
	// Token: 0x02000017 RID: 23
	public abstract class TargetedTriggerAction<T> : global::System.Windows.Interactivity.TargetedTriggerAction where T : class
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00004081 File Offset: 0x00002281
		protected TargetedTriggerAction() : base(typeof(T))
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004093 File Offset: 0x00002293
		protected new T Target
		{
			get
			{
				return (T)((object)base.Target);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000040A0 File Offset: 0x000022A0
		internal sealed override void OnTargetChangedImpl(object oldTarget, object newTarget)
		{
			base.OnTargetChangedImpl(oldTarget, newTarget);
			this.OnTargetChanged(oldTarget as T, newTarget as T);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000040C6 File Offset: 0x000022C6
		protected virtual void OnTargetChanged(T oldTarget, T newTarget)
		{
		}
	}
}
