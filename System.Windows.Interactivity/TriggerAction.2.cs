using System;

namespace System.Windows.Interactivity
{
	// Token: 0x02000012 RID: 18
	public abstract class TriggerAction<T> : global::System.Windows.Interactivity.TriggerAction where T : global::System.Windows.DependencyObject
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00003839 File Offset: 0x00001A39
		protected TriggerAction() : base(typeof(T))
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000384B File Offset: 0x00001A4B
		protected new T AssociatedObject
		{
			get
			{
				return (T)((object)base.AssociatedObject);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003858 File Offset: 0x00001A58
		protected sealed override global::System.Type AssociatedObjectTypeConstraint
		{
			get
			{
				return base.AssociatedObjectTypeConstraint;
			}
		}
	}
}
